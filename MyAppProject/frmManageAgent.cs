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
    public partial class frmManageAgent : Form
    {
        public frmManageAgent()
        {
            InitializeComponent();
        }

        private void btn_Prop_Click(object sender, EventArgs e)
        {
            frmProperty frmP = new frmProperty();
            frmP.Show();
            this.Hide();
        }

        private void btn_Rental_Click(object sender, EventArgs e)
        {
            frmRental frmR = new frmRental();
            frmR.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEndedDate frm = new frmEndedDate();
            frm.Show();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAmount frm = new frmAmount();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmOverTime frm = new frmOverTime();
            frm.Show();
            this.Hide();
        }
    }
}
