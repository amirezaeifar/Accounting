using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using Accounting.Utility.Conventor;
using Accounting.ViewModels.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.App.Accounting
{
    public partial class frmReport : Form
    {

        public int TypeID;

        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<ListCutomerViewModel> list = new List<ListCutomerViewModel>();
                list.Add(new ListCutomerViewModel()
                {
                    CustomerID = 0,
                    FullName = "انتخاب"
                });
                
                list.AddRange(db.customersRepository.GetNameCustomers());
                txtCustomer.DataSource = list;
                txtCustomer.DisplayMember = "FullName";
                txtCustomer.ValueMember = "CustomerID";
                dgReport.AutoGenerateColumns = false;

                if (TypeID == 1)
                {
                    this.Text = "گزارش دریافتی‌ها";
                }
                else
                {
                    this.Text = "گزارش پرداختی‌ها";
                }
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Filter();
        }

        public void Filter()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<DataLayer.Accounting> result = new List<DataLayer.Accounting>();

                DateTime? startDate;
                DateTime? endDate;

                if ((int)txtCustomer.SelectedValue != 0)
                {
                    int customerId = int.Parse(txtCustomer.SelectedValue.ToString());
                    result.AddRange(db.accountingRepository.Get(a => a.TypeID == TypeID && a.CustomerID == customerId));
                }
                else
                {
                    result.AddRange(db.accountingRepository.Get(a => a.TypeID == TypeID));
                }

                if (txtFromDate.Text != "    /  /")
                {
                    startDate = Convert.ToDateTime(txtFromDate.Text);
                    startDate = DateConvertor.ToMiladi(startDate.Value);
                    result = result.Where(r => r.DateTime >= startDate.Value).ToList();
                }

                if (txtToDate.Text != "    /  /")
                {
                    endDate = Convert.ToDateTime(txtToDate.Text);
                    endDate = DateConvertor.ToMiladi(endDate.Value);
                    result = result.Where(r => r.DateTime <= endDate.Value).ToList();
                }

                dgReport.Rows.Clear();
                foreach (var accounting in result)
                {
                    string customerName = db.customersRepository.GetCustomerNameById(accounting.CustomerID);
                    string customerType = db.customersRepository.GetCustomerTypeById(accounting.CustomerID);

                    dgReport.Rows.Add(accounting.ID, customerName, customerType, accounting.Amount, accounting.DateTime.ToShamsi(), accounting.Description);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgReport.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    string name = dgReport.CurrentRow.Cells[1].Value.ToString();
                    if (RtlMessageBox.Show("آیا از حذف این رکورد مطمین هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int Id = int.Parse(dgReport.CurrentRow.Cells[0].Value.ToString());
                        db.accountingRepository.Delete(Id);
                        db.Save();
                        Filter();
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgReport.CurrentRow != null)
            {

                int Id = int.Parse(dgReport.CurrentRow.Cells[0].Value.ToString());
                frmNewTransaction frmEdit = new frmNewTransaction();
                frmEdit.AccountID = Id;
                if (frmEdit.ShowDialog() == DialogResult.OK)
                {
                    Filter();
                }


            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dtPrint = new DataTable();
            dtPrint.Columns.Add("Customer");
            dtPrint.Columns.Add("Amount");
            dtPrint.Columns.Add("Date");
            dtPrint.Columns.Add("Description");
            foreach (DataGridViewRow item in dgReport.Rows)
            {
                dtPrint.Rows.Add(
                    item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[4].Value.ToString(),
                    item.Cells[3].Value.ToString()
                    );
            }
            stiPrint.Load(Application.StartupPath + "/Report.mrt");
            stiPrint.RegData("DT", dtPrint);
            stiPrint.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
