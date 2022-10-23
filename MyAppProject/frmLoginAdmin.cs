using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DAL;
using BLL;




namespace MyAppProject
{
    public partial class frmLoginAdmin : Form
    {
        public frmLoginAdmin()
        {
            InitializeComponent();
        }
        DataAccessLayer dll = new DataAccessLayer();
        //BusinessLogicLayer bll = new BusinessLogicLayer();

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //string email = "Carven@gmail.com";
            //string password = "Carven100";


            //if (txt_email.Text == email && txt_password.Text == password)
            //{

            //    frmManageAdmin frm = new frmManageAdmin();
            //    frm.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Enter correct details");
            //}

            DataTable dt = dll.LoginAdmin(txt_email.Text, txt_password.Text);
          
            if (dt.Rows.Count > 0)
            {
                string role = dt.Rows[0]["Name"].ToString();
                
                
                    frmManageAdmin frm = new frmManageAdmin();
                    frm.Show();
                    this.Hide();
                
               
            }
            else if (dt.Rows.Count == 0)
            {
                txt_email.Clear();
                txt_password.Clear();
            }
        }

        private void txt_email_Validating(object sender, CancelEventArgs e)
        {
          
        }

        private void txt_password_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_email.Text) || (!Regex.IsMatch(txt_email.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")))
            {
              
             errorEmail.SetError(txt_email, "Enter email in a correct format");
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_email.Text) )
            {

                errorPass.SetError(txt_password, "Enter Password");
            }
        }
    }
}
