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
    public partial class frmLoginTenant : Form
    {
        public frmLoginTenant()
        {
            InitializeComponent();
        }
        DataAccessLayer dll = new DataAccessLayer();
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

        private void txt_password_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_password.Text))
            //{
            //    e.Cancel = true;
            //    txt_password.Focus();
            //    errorPass.SetError(txt_password, "Please enter password");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorPass.SetError(txt_password, null);
            //}
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            DataTable dt = dll.TenantLogin(txt_email.Text, txt_password.Text);

            if (dt.Rows.Count > 0)
            {
                string role = dt.Rows[0]["Name"].ToString();


                frmManageTenant frm = new frmManageTenant();
                frm.Show();
                this.Hide();


            }
            else if (dt.Rows.Count == 0)
            {
                txt_email.Clear();
                txt_password.Clear();
            }
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
