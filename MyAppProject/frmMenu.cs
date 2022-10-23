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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();
            frm.Show();
            this.Hide();
        }

        private void btn_Agent_Click(object sender, EventArgs e)
        {
            frmAgent fr = new frmAgent();
            fr.Show();
            this.Hide();

        }

        private void btn_Tenant_Click(object sender, EventArgs e)
        {
            frmTenant rm = new frmTenant();
            rm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmList frm = new frmList();
            frm.Show();
            this.Hide();
        }
    }
}
