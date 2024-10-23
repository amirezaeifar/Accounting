using Accounting.App.Customer;
using Accounting.DataLayer.Context;
using Accounting.DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.App
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgCustomers.AutoGenerateColumns = false;
                dgCustomers.DataSource = db.customersRepository.ListOfCustomers();
            }
        }

        private void btnRefreshCustomer_Click(object sender, EventArgs e)
        {
            txtFilter.Text = "";
            BindGrid();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgCustomers.DataSource = db.customersRepository.GetCustomersByFilter(txtFilter.Text);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgCustomers.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    string name = dgCustomers.CurrentRow.Cells[1].Value.ToString();
                    if (MessageBox.Show($"آیا از حذف {name} مطمین هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int customerId = int.Parse(dgCustomers.CurrentRow.Cells[0].Value.ToString());
                        db.customersRepository.DeleteCustomer(customerId);
                        db.Save();
                        BindGrid();
                    }
                }
            }
            else
            {
                RtlMessageBox.Show("یک شخص را انتخاب کنید");
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            FrmAddOrEditCustomer frmAdd = new FrmAddOrEditCustomer();
            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgCustomers.CurrentRow != null)
            {
                int customerId = int.Parse(dgCustomers.CurrentRow.Cells[0].Value.ToString());
                FrmAddOrEditCustomer frmaddoredit = new FrmAddOrEditCustomer();
                frmaddoredit.customerId = customerId;
                if (frmaddoredit.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }

            }
        }
    }
}
