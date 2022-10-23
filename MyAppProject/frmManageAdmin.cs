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
    public partial class frmManageAdmin : Form
    {
        public frmManageAdmin()
        {
            InitializeComponent();
        }

        private void btn_Property_Click(object sender, EventArgs e)
        {
            frmProperty frmP = new frmProperty();
            frmP.Show();
            this.Hide();
        }

        private void btn_PropType_Click(object sender, EventArgs e)
        {
            frmPropertyType frmPt = new frmPropertyType();
            frmPt.Show();
            this.Hide();
        }

        private void btn_province_Click(object sender, EventArgs e)
        {
            frmProvince frmPr = new frmProvince();
            frmPr.Show();
            this.Hide();
        }

        private void btn_city_Click(object sender, EventArgs e)
        {
            frmCity frmC = new frmCity();
            frmC.Show();
            this.Hide();
        }

        private void btn_surbub_Click(object sender, EventArgs e)
        {
            frmSurbub frmS = new frmSurbub();
            frmS.Show();
            this.Hide();

        }

        private void btn_agency_Click(object sender, EventArgs e)
        {
            frmAgency frmAc = new frmAgency();
            frmAc.Show();
            this.Hide();
        }

        private void btn_Agent_Click(object sender, EventArgs e)
        {
            frmAgent frmA = new frmAgent();
            frmA.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPropertyAgent frm = new frmPropertyAgent();
            frm.Show();
            this.Hide();
        }
    }
}
