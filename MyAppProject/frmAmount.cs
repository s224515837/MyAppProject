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
    public partial class frmAmount : Form
    {
        public frmAmount()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        DataAccessLayer dll = new DataAccessLayer();
        private void btn_search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.GetAmount(double.Parse(txt_price.Text));
        }

        private void frmAmount_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = bll.GetAmount();
        }

        private void btn_bCK_Click(object sender, EventArgs e)
        {
            frmManageAgent frm = new frmManageAgent();
            frm.Show();
            this.Show();

        }
    }
}
