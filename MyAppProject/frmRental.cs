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
    public partial class frmRental : Form
    {
        public frmRental()
        {
            InitializeComponent();
        }
        //BusinessLogicLayer bll = new BusinessLogicLayer();
        DataAccessLayer dll = new DataAccessLayer();
        private void btn_Add_Click(object sender, EventArgs e)
        {
            Rental p = new Rental();
            p.PropertyTenantID = int.Parse(cmb_propertyTenantID.SelectedValue.ToString());
            p.TenantID = int.Parse(cmb_tenantID.SelectedValue.ToString()); ;
            p.StartDate = date_start.Text;
            p.EndDate = date_end.Text;

            //endDate
            dll.AddRental(p);

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Rental p = new Rental();
            p.StartDate = date_start.Text;
            p.EndDate = date_end.Text;
            p.RentalID = int.Parse(txt_RentalID.Text);
            dll.UpdateRental(p);
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource = dll.GetRental();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txt_RentalID.Text = dataGridView1.SelectedRows[0].Cells["RentalID"].Value.ToString();
                cmb_tenantID.Text = dataGridView1.SelectedRows[0].Cells["TenantID"].Value.ToString();
                cmb_propertyTenantID.Text = dataGridView1.SelectedRows[0].Cells["PropertyTenantID"].Value.ToString();
                date_end.Text = dataGridView1.SelectedRows[0].Cells["EndDate"].Value.ToString();
                date_start.Text = dataGridView1.SelectedRows[0].Cells["StartDate"].Value.ToString();
                //date
            }

        }

        private void frmRental_Load(object sender, EventArgs e)
        {
            cmb_propertyTenantID.DataSource = dll.GetPropertyAgent();
            cmb_propertyTenantID.DisplayMember = "PropertyAgentID";
            cmb_propertyTenantID.ValueMember = "PropertyAgentID";

            cmb_tenantID.DataSource = dll.GetTenant();
            cmb_tenantID.DisplayMember = "Name";
            cmb_tenantID.ValueMember = "TenantID";
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frmLoginAgent frmLA = new frmLoginAgent();
            frmLA.Show();
            this.Hide();
        }

        private void cmb_propertyTenantID_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(cmb_propertyTenantID.Text))
            //{
            //    e.Cancel = true;
            //    cmb_propertyTenantID.Focus();
            //    errorProvider1.SetError(cmb_propertyTenantID, "Please Select ID");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(cmb_propertyTenantID, null);
            //}
        }

        private void cmb_tenantID_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(cmb_tenantID.Text))
            //{
            //    e.Cancel = true;
            //    cmb_tenantID.Focus();
            //    errorProvider1.SetError(cmb_tenantID, "Please Select ID");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorProvider2.SetError(cmb_tenantID, null);
            //}
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTenantAgent frm = new frmTenantAgent();
            frm.Show();
            this.Hide();
        }
    }
}
