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
using System.Text.RegularExpressions;


namespace MyAppProject
{
    public partial class frmTenant : Form
    {
        public frmTenant()
        {
            InitializeComponent();
        }
        //DataAccessLayer dll = new DataAccessLayer();
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btn_next_Click(object sender, EventArgs e)
        {
            frmLoginTenant frmT = new frmLoginTenant();
            frmT.Show();
            this.Hide();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            DAL.Tenant t = new DAL.Tenant();
            t.Name = txt_name.Text;
            t.Surname = txt_surname.Text;
            t.Email = txt_email.Text;
            t.Password = txtx_password.Text;
            t.Phone = int.Parse(txt_phone.Text);
            t.Status = cmb_status.SelectedItem.ToString();
            bll.AddTenant(t);
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            Tenant t = new Tenant();
            t.TenantID = int.Parse(txt_tenantID.Text);
            t.Email = txt_email.Text;
            t.Phone = int.Parse(txt_phone.Text);
            t.Status = cmb_status.SelectedItem.ToString() ;
            bll.UpdateTenant(t);
        }

        private void DISPLAY_Click(object sender, EventArgs e)
        {
            dgv_tenant.DataSource = bll.GetTenant();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            DAL.Tenant t = new DAL.Tenant();
            t.TenantID = int.Parse(txt_tenantID.Text);
            bll.DeleteTenant(t);
        }

        private void frmTenant_Load(object sender, EventArgs e)
        {
            cmb_status.Items.Add("Available");
            cmb_status.Items.Add("Unavailable");


        }

        private void txt_name_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_name.Text))
            //{
            //    e.Cancel = true;
            //    txt_name.Focus();
            //    errorName.SetError(txt_name, "Please enter name");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorName.SetError(txt_name, null);
            //}
        }

        private void txt_surname_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_surname.Text))
            //{
            //    e.Cancel = true;
            //    txt_name.Focus();
            //    errorSurname.SetError(txt_surname, "Please enter surname");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorSurname.SetError(txt_surname, null);
            //}
        }

        private void txt_email_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_email.Text))
            //{
            //    e.Cancel = true;
            //    txt_email.Focus();
            //    errorEmail.SetError(txt_email, "Please enter email");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorEmail.SetError(txt_email, null);
            //}
        }

        private void txtx_password_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_name.Text))
            //{
            //    e.Cancel = true;
            //    txtx_password.Focus();
            //    errorPass.SetError(txtx_password, "Please enter password");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorPass.SetError(txtx_password, null);
            //}
        }

        private void txt_phone_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_phone.Text))
            //{
            //    e.Cancel = true;
            //    txt_phone.Focus();
            //    errorPhone.SetError(txt_phone, "Please enter phone number");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorPhone.SetError(txt_phone, null);
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

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_email.Text) || (!Regex.IsMatch(txt_email.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")))
            {

                errorEmail.SetError(txt_email, "Enter email in a correct format");
            }
        }

        private void dgv_tenant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_tenant.SelectedRows.Count > 0)
            {
                txt_tenantID.Text = dgv_tenant.SelectedRows[0].Cells["TenantID"].Value.ToString();
                txt_name.Text = dgv_tenant.SelectedRows[0].Cells["Name"].Value.ToString();
                txt_surname.Text = dgv_tenant.SelectedRows[0].Cells["Surname"].Value.ToString();
                txt_email.Text = dgv_tenant.SelectedRows[0].Cells["Email"].Value.ToString();
                txtx_password.Text = dgv_tenant.SelectedRows[0].Cells["Password"].Value.ToString();
                txt_phone.Text = dgv_tenant.SelectedRows[0].Cells["Phone"].Value.ToString();
                cmb_status.Text = dgv_tenant.SelectedRows[0].Cells["Status"].Value.ToString();

            }
        }

        private void cmb_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
