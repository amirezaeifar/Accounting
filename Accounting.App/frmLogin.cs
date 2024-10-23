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
using Accounting.DataLayer.Context;

namespace Accounting.App
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public bool IsEdit = false;

        private void Login_Load(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                this.Text = "ویرایش حساب کاربری";
                btnLogin.Text = "ذخیره";
                using (UnitOfWork db = new UnitOfWork())
                {
                    var login = db.LoginRepository.Get().First();
                    txtUsername.Text = login.UserName;
                    txtPassword.Text = login.Password;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

           
                using (UnitOfWork db = new UnitOfWork())
                {
                    if (IsEdit)
                    {
                        var login = db.LoginRepository.Get().First();
                        login.UserName = txtUsername.Text;
                        login.Password = txtPassword.Text;
                        db.LoginRepository.Update(login);
                        db.Save();
                        Application.Restart();
                    }
                    else
                    {

                        if (db.LoginRepository.Get(l => l.UserName == txtUsername.Text && l.Password == txtPassword.Text).Any())
                        {
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                        RtlMessageBox.Show("کاربر یافت نشد");
                        }
                    }
                
            }
        }
    }
}
