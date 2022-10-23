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
using BLL;


namespace MyAppProject
{
    public partial class frmMost : Form
    {
        public frmMost()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        DataAccessLayer dll = new DataAccessLayer();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dll.GetMost();
        }

        private void btn_bCK_Click(object sender, EventArgs e)
        {
            frmMost frm = new frmMost();
            frm.Show();
            this.Hide();
        }
    }
}
