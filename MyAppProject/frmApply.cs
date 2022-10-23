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
    public partial class frmApply : Form
    {
        public frmApply()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        DataAccessLayer dll = new DataAccessLayer();

        private void btn_Display_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.GetRequestRent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frmManageTenant frm = new frmManageTenant();
            frm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
