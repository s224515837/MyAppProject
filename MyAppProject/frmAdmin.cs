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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        DataAccessLayer dll = new DataAccessLayer();
        // BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btn_next_Click(object sender, EventArgs e)
        {
            frmLoginAdmin frmA = new frmLoginAdmin();
            frmA.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Admin adm = new Admin();
            adm.Name = txt_name.Text;
            adm.Surname = txt_surname.Text;
            adm.Email = txt_email.Text;
            adm.Password = txt_password.Text;
            adm.Status = cmb_Status.SelectedItem.ToString();
            int x = dll.AddAdmin(adm);
            if (x > 0)
            {
                MessageBox.Show("Added");
            }
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            dgv_admin.DataSource = dll.GetAdmin();
        }

        private void dgv_admin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_admin.SelectedRows.Count > 0)
            {
                txt_adminID.Text = dgv_admin.SelectedRows[0].Cells["AdminID"].Value.ToString();
                txt_name.Text = dgv_admin.SelectedRows[0].Cells["Name"].Value.ToString();
                txt_surname.Text = dgv_admin.SelectedRows[0].Cells["Surname"].Value.ToString();
                txt_email.Text = dgv_admin.SelectedRows[0].Cells["Email"].Value.ToString();
                txt_password.Text = dgv_admin.SelectedRows[0].Cells["Password"].Value.ToString();
                cmb_Status.Text = dgv_admin.SelectedRows[0].Cells["Status"].Value.ToString();

            }
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            cmb_Status.Items.Add("Available");
            cmb_Status.Items.Add("Unavailable");
        }

        private void txt_adminID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_surname_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_surname.Text))
            //{
            //    e.Cancel = true;
            //    txt_surname.Focus();
            //    errorSurname.SetError(txt_surname, "Please enter surname");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorSurname.SetError(txt_surname, null);

            //}
        }

        private void groupBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txt_name_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_name.Text))
            //{
            //    e.Cancel = true;
            //    txt_name.Focus();
            //    ErrorName.SetError(txt_name, "Please enter name");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    ErrorName.SetError(txt_name, null);
            //}
        }

        private void txt_email_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_email.Text))
            //{
            //    e.Cancel = true;
            //    txt_email.Focus();
            //    errorEmail.SetError(txt_name, "Please enter email");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorEmail.SetError(txt_email, null);
            //}
        }

        private void txt_password_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_password.Text))
            //{
            //    e.Cancel = true;
            //    txt_password.Focus();
            //   errorPassword.SetError(txt_password, "Please enter surname");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorPassword.SetError(txt_name, null);
            //}

        }

        private void cmb_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_Status_Validating(object sender, CancelEventArgs e)
        {
        //    if (string.IsNullOrEmpty(cmb_Status.Text))
        //    {
        //        e.Cancel = true;
        //        txt_name.Focus();
        //        errorStatus.SetError(cmb_Status, "Please select a Status");
        //    }
        //    else
        //    {
        //        e.Cancel = true;
        //        errorStatus.SetError(txt_name, null);
        //    }
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_email.Text) || (!Regex.IsMatch(txt_email.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")))
            {

                errorEmail.SetError(txt_email, "Enter email in a correct format");
            }
        }
    }
}
