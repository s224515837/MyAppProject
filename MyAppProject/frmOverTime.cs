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
using System.Data.SqlClient;

namespace MyAppProject
{
    public partial class frmOverTime : Form
    {
        public frmOverTime()
        {
            InitializeComponent();
        }
        DataAccessLayer dll = new DataAccessLayer();
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btn_search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dll.GetOverTime(dateTimePicker1.ToString());
           
        }

        private void frmEnded_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = dll.GetEndedDate();
            //dataGridView1.DataSource = bll.GetEndedDate();

        }
    }
}
