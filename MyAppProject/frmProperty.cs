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
    public partial class frmProperty : Form
    {
        public frmProperty()
        {
            InitializeComponent();
        }
       BusinessLogicLayer bll = new BusinessLogicLayer();
        //DataAccessLayer dll = new DataAccessLayer();
        private void btn_add_Click(object sender, EventArgs e)
        {
            Prop p = new Prop();
            p.Description = txt_descr.Text;
            p.Price = int.Parse(txt_price.Text);
            p.PropertyTypeID = int.Parse(cmb_propTypeID.SelectedValue.ToString());
            p.Status = cmb_status.SelectedItem.ToString();
            p.SurbubID = int.Parse(cmb_surbubID.SelectedValue.ToString());
            p.Image = txt_Image.Text;
           
            bll.AddProperty(p);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Prop p = new Prop();
            p.PropertyID = int.Parse(txt_propertyID.Text);
            p.Price = int.Parse(txt_price.Text);
            p.PropertyTypeID = int.Parse(cmb_propTypeID.SelectedValue.ToString());
            p.Status = cmb_status.SelectedItem.ToString();
            bll.UpdateProperty(p);
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            dgv_property.DataSource = bll.GetProperty();

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                String picLoc = dlg.FileName.ToString();
                pct_Picture.ImageLocation = picLoc;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Prop p = new Prop();
            p.PropertyID = int.Parse(txt_propertyID.Text);
            bll.DeleteProperty(p);
        }

        private void dgv_property_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_property.SelectedRows.Count > 0)
            {
                txt_propertyID.Text = dgv_property.SelectedRows[0].Cells["PropertyID"].Value.ToString();
                txt_descr.Text = dgv_property.SelectedRows[0].Cells["Description"].Value.ToString();
                txt_price.Text = dgv_property.SelectedRows[0].Cells["Price"].Value.ToString();
                cmb_status.Text = dgv_property.SelectedRows[0].Cells["Status"].Value.ToString();
                cmb_propTypeID.Text = dgv_property.SelectedRows[0].Cells["PropertyTypeID"].Value.ToString();
                cmb_surbubID.Text = dgv_property.SelectedRows[0].Cells["SurbubID"].Value.ToString();
                txt_Image.Text = dgv_property.SelectedRows[0].Cells["Image"].Value.ToString();
            }
        }

        private void frmProperty_Load(object sender, EventArgs e)
        {
            cmb_propTypeID.DataSource = bll.GetPropertyType();
            cmb_propTypeID.DisplayMember = "Description";
            cmb_propTypeID.ValueMember = "PropertyTypeID";

            cmb_surbubID.DataSource = bll.GetSurbub();
            cmb_surbubID.DisplayMember = "Description";
            cmb_surbubID.ValueMember = "SurbubID";

            cmb_status.Items.Add("Available");
            cmb_status.Items.Add("Unavailable");
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            String Role=" ";
            if (Role == "Admin")
            {
            frmManageAdmin frmL = new frmManageAdmin();
            frmL.Show();
            this.Show();

            }
            else
            {
                frmLoginAgent frmLA = new frmLoginAgent();
                frmLA.Show();
                this.Hide();

            }



        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_descr_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_descr.Text))
            //{
            //    e.Cancel = true;
            //    txt_descr.Focus();
            //    errorDesc.SetError(txt_descr, "Please enter description");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorDesc.SetError(txt_descr, null);
            //}
        }

        private void txt_price_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_price.Text))
            //{
            //    e.Cancel = true;
            //    txt_price.Focus();
            //    errorPrice.SetError(txt_price, "Please enter price");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorPrice.SetError(txt_price, null);
            //}
        }

        private void cmb_propTypeID_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(cmb_propTypeID.Text))
            //{
            //    e.Cancel = true;
            //    cmb_propTypeID.Focus();
            //    errorPropID.SetError(cmb_propTypeID, "Please select ID");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorPropID.SetError(cmb_propTypeID, null);
            //}
        }

        private void cmb_status_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(cmb_status.Text))
            //{
            //    e.Cancel = true;
            //    cmb_status.Focus();
            //    errorStatus.SetError(cmb_status, "Please select status");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorStatus.SetError(cmb_status, null);
            //}
        }

        private void cmb_surbubID_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(cmb_surbubID.Text))
            //{
            //    e.Cancel = true;
            //    cmb_surbubID.Focus();
            //    errorSUrbubID.SetError(cmb_surbubID, "Please select ID");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorSUrbubID.SetError(cmb_surbubID, null);
            //}
        }

        private void pct_Picture_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(pct_Picture.Text))
            //{
            //    e.Cancel = true;
            //    pct_Picture.Focus();
            //    errorPicture.SetError(pct_Picture, "Please insert picture");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorPicture.SetError(pct_Picture, null);
            //}
        }
    }
}
