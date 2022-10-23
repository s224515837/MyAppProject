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
    public partial class frmEndedDate : Form
    {
        public frmEndedDate()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        DataAccessLayer dll = new DataAccessLayer();
        private void btn_search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dll.GetEndedDate(startDate_1.ToString(),endDate_1.ToString());
           
        }

        private void frmEndedDate_Load(object sender, EventArgs e)
        {

        }

        private void btn_bCK_Click(object sender, EventArgs e)
        {
            frmManageAgent frm = new frmManageAgent();
            frm.Show();
            this.Hide();
        }
    }
}
