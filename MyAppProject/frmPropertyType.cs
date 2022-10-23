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
    public partial class frmPropertyType : Form
    {
        public frmPropertyType()
        {
            InitializeComponent();
        }
       // BusinessLogicLayer bll = new BusinessLogicLayer();
        DataAccessLayer dll = new DataAccessLayer();
        private void btn_add_Click(object sender, EventArgs e)
        {
            PropertyType pt = new PropertyType();
            pt.PropertyTypeDescription = txt_propTypeDesc.Text;
            //pt.PropertyTypeID = int.Parse(txt_propTypeID.Text);
            dll.AddPropertyType(pt);

        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            dgv_propType.DataSource = dll.GetPropertyType();
        }

        private void dgv_propType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_propType.SelectedRows.Count > 0)
            {
                txt_propTypeDesc.Text = dgv_propType.SelectedRows[0].Cells["PropertyDescitption"].Value.ToString();
                txt_propTypeID.Text = dgv_propType.SelectedRows[0].Cells["PropertyTypeID"].Value.ToString();

            }

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frmManageAdmin frmL = new frmManageAdmin();
            frmL.Show();
            this.Show();
        }

        private void frmPropertyType_Load(object sender, EventArgs e)
        {

        }

        private void txt_propTypeDesc_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_propTypeDesc.Text))
            //{
            //    e.Cancel = true;
            //    txt_propTypeDesc.Focus();
            //    errorProvider1.SetError(txt_propTypeDesc, "Please enter description");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(txt_propTypeDesc, null);
            //}
        }
    }
}
