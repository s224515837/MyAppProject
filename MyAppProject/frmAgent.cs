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
    public partial class frmAgent : Form
    {
        public frmAgent()
        {
            InitializeComponent();
        }
       // BusinessLogicLayer bll = new BusinessLogicLayer();
        DataAccessLayer dll = new DataAccessLayer();

        private void btn_next_Click(object sender, EventArgs e)
        {
            frmLoginAgent frmA = new frmLoginAgent();
            frmA.Show();
            this.Hide();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Agent agent = new Agent();
            agent.Name = txt_Name.Text;
            agent.Surname = txt_Surname.Text;
            agent.Email = txt_Email.Text;
            agent.Password = txt_Password.Text;
            agent.Phone = int.Parse(txt_Phone.Text);
            agent.Status = cmb_Status.SelectedItem.ToString();
            agent.AgencyID = int.Parse(cmb_AgencyID.SelectedValue.ToString());
            int x = dll.AddAgent(agent);
            if (x > 0)
            {
                MessageBox.Show("Added");
            }

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Agent agent = new Agent();
            agent.AgentID = int.Parse(txt_AgentID.Text);
            agent.Email = txt_Email.Text;
            agent.Phone = int.Parse(txt_Phone.Text);
            agent.Status = cmb_Status.SelectedItem.ToString();
            int x = dll.UpdateAgent(agent);
            if (x > 0)
            {
                MessageBox.Show("Updated");
            }

        }

        private void btn_Display_Click(object sender, EventArgs e)
        {

            dgv_Agent.DataSource = dll.GetAgent();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Agent agent = new Agent();
            agent.AgentID = int.Parse(txt_AgentID.Text);
            int x = dll.DeleteAgent(agent);
            if (x > 0)
            {
                MessageBox.Show("Deleted");
            }

        }

        private void dgv_Agent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Agent.SelectedRows.Count > 0)
            {
                txt_AgentID.Text = dgv_Agent.SelectedRows[0].Cells["AgentID"].Value.ToString();
                txt_Name.Text = dgv_Agent.SelectedRows[0].Cells["Name"].Value.ToString();
                txt_Surname.Text = dgv_Agent.SelectedRows[0].Cells["Surname"].Value.ToString();
                txt_Email.Text = dgv_Agent.SelectedRows[0].Cells["Email"].Value.ToString();
                txt_Password.Text = dgv_Agent.SelectedRows[0].Cells["Password"].Value.ToString();
                txt_Phone.Text = dgv_Agent.SelectedRows[0].Cells["Phone"].Value.ToString();
                cmb_Status.Text = dgv_Agent.SelectedRows[0].Cells["Status"].Value.ToString();
                cmb_AgencyID.Text = dgv_Agent.SelectedRows[0].Cells["AgencyID"].Value.ToString();

            }
        }

        private void frmAgent_Load(object sender, EventArgs e)
        {
            cmb_Status.Items.Add("Available");
            cmb_Status.Items.Add("Unavailable");

            cmb_AgencyID.DataSource = dll.GetAgencies();
            cmb_AgencyID.DisplayMember = "AgencyName";
            cmb_AgencyID.ValueMember = "AgencyID";
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            string role = "";
            if (role == "Admin")
            {
                frmManageAdmin frmL = new frmManageAdmin();
                frmL.Show();
                this.Show();

            }
            else
            {
                btn_Add.Visible = false;
            }
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_Name_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_Name.Text))
            //{
            //    e.Cancel = true;
            //    txt_Name.Focus();
            //    errorName.SetError(txt_Name, "Please enter name");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorName.SetError(txt_Name, null);
            //}
        }

        private void txt_Surname_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_Surname.Text))
            //{
            //    e.Cancel = true;
            //    txt_Surname.Focus();
            //    errorSurname.SetError(txt_Surname, "Please enter Surname");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorSurname.SetError(txt_Surname, null);
            //}
        }

        private void txt_Email_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_Email.Text))
            //{
            //    e.Cancel = true;
            //    txt_Email.Focus();
            //    errorEmail.SetError(txt_Email, "Please enter email");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorEmail.SetError(txt_Email, null);
            //}
        }

        private void txt_Phone_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_Phone.Text))
            //{
            //    e.Cancel = true;
            //    txt_Phone.Focus();
            //    errorPhone.SetError(txt_Phone, "Please enter phone numbers");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorPhone.SetError(txt_Phone, null);
            //}
        }

        private void cmb_Status_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(cmb_Status.Text))
            //{
            //    e.Cancel = true;
            //    cmb_Status.Focus();
            //    errorStatus.SetError(cmb_Status, "Please select status");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorStatus.SetError(cmb_Status, null);
            //}
        }

        private void cmb_AgencyID_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(cmb_AgencyID.Text))
            //{
            //    e.Cancel = true;
            //    cmb_AgencyID.Focus();
            //    errorID.SetError(cmb_AgencyID, "Please select Agency ID");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorID.SetError(cmb_AgencyID, null);
            //}
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Email.Text) || (!Regex.IsMatch(txt_Email.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")))
            {

                errorEmail.SetError(txt_Email, "Enter email in a correct format");
            }
        }
    }
}
