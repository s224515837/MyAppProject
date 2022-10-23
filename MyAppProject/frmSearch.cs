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
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }
        DataAccessLayer dll = new DataAccessLayer();
        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void frmSearch_Load(object sender, EventArgs e)
        {
            


        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // dataGridView1.DataSource = dll.GetRequestReport();
            
        }

        private void txt_Price_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_Price_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void cmb_AgentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_searchDate_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource = dll.GetRequestReport(txt_desc.Text,txt_Name.Text,double.Parse( txt_Price.ToString()), dateTimePicker1.Text, dateTimePicker2.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            //dataGridView1.Refresh();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frmManageTenant frm = new frmManageTenant();
            frm.Show();
            this.Hide();
        }

        private void txt_desc_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
