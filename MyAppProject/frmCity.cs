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
    public partial class frmCity : Form
    {
        public frmCity()
        {
            InitializeComponent();
        }
        //BusinessLogicLayer bll = new BusinessLogicLayer();
        DataAccessLayer dll = new DataAccessLayer();
        private void btn_Add_Click(object sender, EventArgs e)
        {
            City c = new City();
            c.CityDescription = txt_CitySDesc.Text;
            c.ProvinceID = int.Parse(cmb_ProvinceID.SelectedValue.ToString());
            dll.AddCity(c);
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            dgv_City.DataSource = dll.GetCity();
        }

        private void dgv_City_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_City.SelectedRows.Count > 0)
            {
                txt_CityID.Text = dgv_City.SelectedRows[0].Cells["CityID"].Value.ToString();
                txt_CitySDesc.Text = dgv_City.SelectedRows[0].Cells["CityDescription"].Value.ToString();
                cmb_ProvinceID.Text = dgv_City.SelectedRows[0].Cells["ProvinceID"].Value.ToString();
            }
        }

        private void frmCity_Load(object sender, EventArgs e)
        {
            cmb_ProvinceID.DataSource = dll.GetProvince();
            cmb_ProvinceID.DisplayMember = "Description";
            cmb_ProvinceID.ValueMember = "ProvinceID";

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

        private void txt_CitySDesc_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_CitySDesc.Text))
            //{
            //    e.Cancel = true;
            //    txt_CitySDesc.Focus();
            //    errorDesc.SetError(txt_CitySDesc, "Please enter city description");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorDesc.SetError(txt_CitySDesc, null);
            //}
        }

        private void cmb_ProvinceID_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(cmb_ProvinceID.Text))
            //{
            //    e.Cancel = true;
            //    cmb_ProvinceID.Focus();
            //    errorID.SetError(cmb_ProvinceID, "Please select ID");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorID.SetError(cmb_ProvinceID, null);
            //}
        }
    }
}
