using Accounting.App.Accounting;
using Accounting.Business;
using Accounting.DataLayer.Context;
using Accounting.Utility.Conventor;
using Accounting.ViewModels.Accounting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public int TypeID;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmCustomers frmCustomers = new frmCustomers();
            frmCustomers.ShowDialog();
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            frmNewTransaction frmNewTransaction = new frmNewTransaction();
            frmNewTransaction.ShowDialog();
            MainReport();

        }

        private void btnReportReceive_Click(object sender, EventArgs e)
        {
            frmReport frmReport = new frmReport();
            frmReport.TypeID = 1;
            frmReport.ShowDialog();
            MainReport();
        }

        private void btnReportPay_Click(object sender, EventArgs e)
        {

            frmReport frmReport = new frmReport();
            frmReport.TypeID = 2;
            frmReport.ShowDialog();
            MainReport();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();

            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                lblDate.Text = DateConvertor.ToShamsi(DateTime.Now);
                lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
                this.Show();
                MainReport();
            }
            else
            {
                Application.Exit();
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnEditAcount_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.IsEdit = true;
            frmLogin.ShowDialog();

        }

        public void MainReport()
        {
            ReportViewModel report = Account.ReportFromMain();
            lblReceive.Text = report.Receive.ToString("#,0");
            lblPay.Text = report.Pay.ToString("#,0");
            lblBalance.Text = report.Balance.ToString("#,0");
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            frmTest test = new frmTest();
            test.ShowDialog();
            

        }

    }
}
