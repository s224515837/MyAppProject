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
    public partial class frmLoginAgent : Form
    {
        public frmLoginAgent()
        {
            InitializeComponent();
        }

        private void txt_email_Validating(object sender, CancelEventArgs e)
        {
            
        }
        DataAccessLayer dll = new DataAccessLayer();
        private void txt_password_Validating(object sender, CancelEventArgs e)
        {
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            DataTable dt = dll.AgentLogin(txt_email.Text, txt_password.Text);

            if (dt.Rows.Count > 0)
            {
                string role = dt.Rows[0]["Name"].ToString();


                frmManageAgent frm = new frmManageAgent();
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

                erroremail.SetError(txt_email, "Enter email in a correct format");
            }
        }
    }
}
