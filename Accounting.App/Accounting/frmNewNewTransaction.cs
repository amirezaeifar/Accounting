using Accounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace Accounting.App
{
    public partial class frmNewTransaction : Form
    {
        public int AccountID = 0;
        public frmNewTransaction()
        {
            InitializeComponent();
        }

        private void frmNewTransaction_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork()) 
            { 
                dgCustomers.AutoGenerateColumns = false;
                dgCustomers.DataSource = db.customersRepository.GetNameCustomers();
                if (AccountID != 0)
                {
                    var account = db.accountingRepository.GetById(AccountID);
                    nudAmount.Value = account.Amount;
                    txtDiscription.Text = account.Description;
                    txtName.Text = db.customersRepository.GetCustomerNameById(account.CustomerID);
                    if (account.TypeID == 1)
                    {
                        rbReceive.Checked = true;
                    }
                    else
                    {
                        rbpay.Checked = true;
                    }

                    this.Text = "ویرایش تراکنش";
                    btnSave.Text = "ذخیره";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgCustomers.AutoGenerateColumns = false;
                dgCustomers.DataSource = db.customersRepository.GetNameCustomers(txtFilter.Text);
            }
        }

        private void dgCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgCustomers.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {

                if (rbpay.Checked || rbReceive.Checked)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        DataLayer.Accounting accounting = new DataLayer.Accounting()
                        {
                            Amount = int.Parse(nudAmount.Value.ToString()),
                            CustomerID = db.customersRepository.GetCustomerIdByName(txtName.Text),
                            TypeID = (rbpay.Checked) ? 2 : 1,
                            DateTime = DateTime.Now,
                            Description = txtDiscription.Text
                        };
                        if (AccountID == 0)
                        {
                            db.accountingRepository.Insert(accounting);
                            db.Save();
                        }
                        else
                        {
                            accounting.ID = AccountID;
                            db.accountingRepository.Update(accounting);
                            db.Save();
                        }
                    }
                    DialogResult = DialogResult.OK;

                }
                else 
                {
                    RtlMessageBox.Show("نوع تراکنش را انتخاب کنید");
                }
            }
        }

        private void dgCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
