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

namespace Accounting.App
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            test();
        }
        public void test()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgTest.AutoGenerateColumns = false;
                dgTest.DataSource = db.customersRepository.GetAllCustomers();
            }
        }
    }
}
