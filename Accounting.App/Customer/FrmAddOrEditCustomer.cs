using Accounting.Business;
using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace Accounting.App.Customer
{
    public partial class FrmAddOrEditCustomer : Form
    {
        public int customerId = 0;
        public FrmAddOrEditCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (BaseValidator.IsFormValid(this.components))
                {
                    string imageName = Guid.NewGuid().ToString() + Path.GetExtension(pcCustomer.ImageLocation);
                    string path = Application.StartupPath + "/Images/";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    pcCustomer.Image.Save(path + imageName);
                    if (rbIndi.Checked || rbLeg.Checked)
                    {
                        Customers customers = new Customers()
                        {
                            Address = txtAddress.Text,
                            Email = txtEmail.Text,
                            Mobile = txtMoblie.Text,
                            FullName = txtName.Text,
                            CustomersImage = imageName,
                            EntityID = (rbIndi.Checked) ? 1 : 2

                        };

                        if (customerId == 0)
                        {
                            db.customersRepository.InsertCustomer(customers);
                        }

                        else
                        {
                            customers.CustomersID = customerId;
                            db.customersRepository.UpdateCustomer(customers);
                        }
                        db.Save();
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        RtlMessageBox.Show("نوع شخص را انتخاب کنید");
                    }
                
                }
            }
        }

        private void FrmAddOrEditCustomer_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork()) 
            { 
          
                if (customerId != 0)
                {
                    this.Text = "ویرایش طرف حساب";
                    btnSave.Text = "ذخیره";
                    var customer = db.customersRepository.GetCustomerById(customerId);
                    txtAddress.Text = customer.Address;
                    txtEmail.Text = customer.Email;
                    txtName.Text = customer.FullName;
                    txtMoblie.Text = customer.Mobile;
                    pcCustomer.ImageLocation = Application.StartupPath + "/Images/" + customer.CustomersImage;
                    if (customer.EntityID == 1)
                    {
                        rbIndi.Checked = true;
                    }
                    else
                    {
                        rbLeg.Checked = true;
                    }
                }
            }
        }

        private void btnSelectPic_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pcCustomer.ImageLocation = openFile.FileName;
            }
        }
    }
}
