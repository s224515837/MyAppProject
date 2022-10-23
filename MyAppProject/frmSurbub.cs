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
    public partial class frmSurbub : Form
    {
        public frmSurbub()
        {
            InitializeComponent();
        }
        //BusinessLogicLayer bll = new BusinessLogicLayer();
       DataAccessLayer dll = new DataAccessLayer();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txt_SurbubDesc.Text = dataGridView1.SelectedRows[0].Cells["SurbubDescription"].Value.ToString();
                txt_postalCode.Text = dataGridView1.SelectedRows[0].Cells["PostalCode"].Value.ToString();
                cmb_cityID.Text = dataGridView1.SelectedRows[0].Cells["CityID"].Value.ToString();
                txt_SurbubID.Text = dataGridView1.SelectedRows[0].Cells["SurbubID"].Value.ToString();
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Surbub s = new Surbub();

            s.SuburbDescription = txt_SurbubDesc.Text;
            s.PostalCode = int.Parse(txt_postalCode.Text);
            s.CityID = int.Parse(cmb_cityID.SelectedValue.ToString());
            dll.AddSurbub(s);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dll.GetSurbub();
        }

        private void frmSurbub_Load(object sender, EventArgs e)
        {
            cmb_cityID.DataSource = dll.GetCity();
            cmb_cityID.DisplayMember = "CityDescription";
            cmb_cityID.ValueMember = "CityID";
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frmLoginAdmin frmL = new frmLoginAdmin();
            frmL.Show();
            this.Show();
        }

        private void txt_SurbubDesc_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_SurbubDesc.Text))
            //{
            //    e.Cancel = true;
            //    txt_SurbubDesc.Focus();
            //    errorProvider1.SetError(txt_SurbubDesc, "Please enter description");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(txt_SurbubDesc, null);
            //}
        }

        private void txt_postalCode_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_postalCode.Text))
            //{
            //    e.Cancel = true;
            //    txt_postalCode.Focus();
            //    errorProvider2.SetError(txt_postalCode, "Please enter postal code");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorProvider2.SetError(txt_postalCode, null);
            //}
        }

        private void cmb_cityID_Validating(object sender, CancelEventArgs e)
        {
        //    if (string.IsNullOrEmpty(cmb_cityID.Text))
        //    {
        //        e.Cancel = true;
        //       cmb_cityID.Focus();
        //        errorProvider1.SetError(cmb_cityID, "Please Select ID");
        //    }
        //    else
        //    {
        //        e.Cancel = true;
        //        errorProvider3.SetError(cmb_cityID, null);
        //    }
        }
    }
}
