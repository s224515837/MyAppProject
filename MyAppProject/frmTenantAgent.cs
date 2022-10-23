using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace MyAppProject
{
    public partial class frmTenantAgent : Form
    {
        public frmTenantAgent()
        {
            InitializeComponent();
        }
        DataAccessLayer dll = new DataAccessLayer();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dll.GetTenantAgent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmManageAgent frm = new frmManageAgent();
            frm.Show();
            this.Hide();
        }
    }
}
