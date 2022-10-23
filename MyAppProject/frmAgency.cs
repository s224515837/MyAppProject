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
    public partial class frmAgency : Form
    {
        public frmAgency()
        {
            InitializeComponent();
        }
        DataAccessLayer dll = new DataAccessLayer();
        //BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btn_Add_Click(object sender, EventArgs e)
        {
            Agency ac = new Agency();
            ac.AgencyName = txt_AgencyName.Text;
            ac.SuburbID = int.Parse(cmb_SurbubID.SelectedValue.ToString());
            int x = dll.AddAgencies(ac);
            if (x > 0)
            {
                MessageBox.Show(x + "Added.");

            }
            else
            {
                MessageBox.Show("Not Added!!!!");
            }
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {

            dgv_Agency.DataSource = dll.GetAgencies();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Agency ac = new Agency();
            ac.AgencyID = int.Parse(txt_AgencyID.Text);
            int x = dll.DeleteAgencies(ac);
            if (x < 0)
            {
                MessageBox.Show(x + "Deleted.");

            }
            else
            {
                MessageBox.Show("Not Deleted");
            }
        }

        private void dgv_Agency_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Agency.SelectedRows.Count > 0)
            {
                txt_AgencyID.Text = dgv_Agency.SelectedRows[0].Cells["AgencyID"].Value.ToString();
                txt_AgencyName.Text = dgv_Agency.SelectedRows[0].Cells["AgencyName"].Value.ToString();
                cmb_SurbubID.SelectedItem = dgv_Agency.SelectedRows[0].Cells["SurbubID"].Value.ToString();
            }
        }

        private void frmAgency_Load(object sender, EventArgs e)
        {
            cmb_SurbubID.DataSource = dll.GetSurbub();
            cmb_SurbubID.DisplayMember = "AgencyName";
            cmb_SurbubID.ValueMember = "SurbubID";
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frmManageAdmin frmL = new frmManageAdmin();
            frmL.Show();
            this.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_AgencyName_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_AgencyName.Text))
            //{
            //    e.Cancel = true;
            //    txt_AgencyName.Focus();
            //    errorName.SetError(txt_AgencyName, "Please enter name");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorName.SetError(txt_AgencyName, null);
            //}

        }

        private void cmb_SurbubID_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(cmb_SurbubID.Text))
            //{
            //    e.Cancel = true;
            //    cmb_SurbubID.Focus();
            //    errorID.SetError(cmb_SurbubID, "Please Select a surbub");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorID.SetError(cmb_SurbubID, null);
            //}
        }

        private void cmb_SurbubID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_AgencyName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMost frm = new frmMost();
            frm.Show();
            this.Hide();
        }
    }
}
