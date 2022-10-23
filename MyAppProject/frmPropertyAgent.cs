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
    public partial class frmPropertyAgent : Form
    {
        public frmPropertyAgent()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        DataAccessLayer dll = new DataAccessLayer();

        private void btn_add_Click(object sender, EventArgs e)
        {
            PropertyAgent pa = new PropertyAgent();
            pa.PropertyID = int.Parse(cmb_propertyID.SelectedValue.ToString());
            pa.AgentID = int.Parse(cmb_AgentID.SelectedValue.ToString());
            pa.Date = date_propertAgent.Text;
            dll.AddPropertyAgent(pa);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            PropertyAgent pa = new PropertyAgent();
            pa.PropertyAgentID = int.Parse(txt_propertyAgentID.Text);
            pa.PropertyID = int.Parse(cmb_propertyID.SelectedValue.ToString());
            pa.AgentID = int.Parse(cmb_AgentID.SelectedValue.ToString());
            pa.Date = date_propertAgent.Text;
            dll.UpdatePropertyAgent(pa);
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            dgv_propertAgent.DataSource = dll.GetPropertyAgent();
        }

        private void dgv_propertAgent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_propertAgent.SelectedRows.Count > 0)
            {

                txt_propertyAgentID.Text = dgv_propertAgent.SelectedRows[0].Cells["PropertyAgentID"].Value.ToString();
                cmb_AgentID.Text = dgv_propertAgent.SelectedRows[0].Cells["AgentID"].Value.ToString();
                cmb_propertyID.Text = dgv_propertAgent.SelectedRows[0].Cells["PropertyID"].Value.ToString();
                date_propertAgent.Text = dgv_propertAgent.SelectedRows[0].Cells["Date"].Value.ToString();
            }
        }

        private void frmPropertyAgent_Load(object sender, EventArgs e)
        {
            cmb_AgentID.DataSource = bll.GetAgent();
            cmb_AgentID.DisplayMember = "AgentID";
            cmb_AgentID.ValueMember = "AgentID";

            cmb_propertyID.DataSource = bll.GetProperty();
            cmb_propertyID.DisplayMember = "PropertyID";
            cmb_propertyID.ValueMember = "PropertyID";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmb_propertyID_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_propertyAgentID.Text))
            //{
            //    e.Cancel = true;
            //    txt_propertyAgentID.Focus();
            //    errorPrpID.SetError(txt_propertyAgentID, "Please Select ID");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorPrpID.SetError(txt_propertyAgentID, null);
            //}
        }

        private void cmb_AgentID_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(cmb_AgentID.Text))
            //{
            //    e.Cancel = true;
            //    cmb_AgentID.Focus();
            //    errorID.SetError(cmb_AgentID, "Please select ID");
            //}
            //else
            //{
            //    e.Cancel = true;
            //    errorID.SetError(cmb_AgentID, null);
            //}
        }
    }
}
