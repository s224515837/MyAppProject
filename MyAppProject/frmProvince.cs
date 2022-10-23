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
    public partial class frmProvince : Form
    {
        public frmProvince()
        {
            InitializeComponent();
        }
        //BusinessLogicLayer bll = new BusinessLogicLayer();
        DataAccessLayer dll = new DataAccessLayer();
        private void btn_add_Click(object sender, EventArgs e)
        {
            Province p = new Province();
            p.Description = txt_description.Text;
            dll.AddProvince(p);
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            dgv_province.DataSource = dll.GetProvince();

        }

        private void dgv_province_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_province.SelectedRows.Count > 0)
            {
                txt_provinceID.Text = dgv_province.SelectedRows[0].Cells["ProvinceID"].Value.ToString();
                txt_description.Text = dgv_province.SelectedRows[0].Cells["ProvinceDescription"].Value.ToString();
            }

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frmManageAdmin frmL = new frmManageAdmin();
            frmL.Show();
            this.Show();
        }

        private void frmProvince_Load(object sender, EventArgs e)
        {

        }

        private void txt_description_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_description.Text))
            //{
            //    e.Cancel = true;
            //    txt_description.Focus();
            //    errorProvider1.SetError(txt_description, "Please enter description");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(txt_description, null);
            //}
        }
    }
}
