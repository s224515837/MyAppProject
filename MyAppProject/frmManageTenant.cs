using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAppProject
{
    public partial class frmManageTenant : Form
    {
        public frmManageTenant()
        {
            InitializeComponent();
        }

        private void btn_tenant_Click(object sender, EventArgs e)
        {
            frmApply frmA = new frmApply();
            frmA.Show();
            this.Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            frmSearch frmSe = new frmSearch();
            frmSe.Show();
            this.Hide();
        }
    }
}
