namespace MyAppProject
{
    partial class frmPropertyAgent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_display = new System.Windows.Forms.Button();
            this.date_propertAgent = new System.Windows.Forms.DateTimePicker();
            this.cmb_propertyID = new System.Windows.Forms.ComboBox();
            this.cmb_AgentID = new System.Windows.Forms.ComboBox();
            this.txt_propertyAgentID = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgv_propertAgent = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorPrpID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorID = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_propertAgent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrpID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_display);
            this.groupBox1.Controls.Add(this.date_propertAgent);
            this.groupBox1.Controls.Add(this.cmb_propertyID);
            this.groupBox1.Controls.Add(this.cmb_AgentID);
            this.groupBox1.Controls.Add(this.txt_propertyAgentID);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.dgv_propertAgent);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 381);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property Agent";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(247, 175);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(75, 35);
            this.btn_display.TabIndex = 47;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // date_propertAgent
            // 
            this.date_propertAgent.Location = new System.Drawing.Point(117, 134);
            this.date_propertAgent.Name = "date_propertAgent";
            this.date_propertAgent.Size = new System.Drawing.Size(205, 20);
            this.date_propertAgent.TabIndex = 46;
            // 
            // cmb_propertyID
            // 
            this.cmb_propertyID.FormattingEnabled = true;
            this.cmb_propertyID.Location = new System.Drawing.Point(117, 62);
            this.cmb_propertyID.Name = "cmb_propertyID";
            this.cmb_propertyID.Size = new System.Drawing.Size(205, 21);
            this.cmb_propertyID.TabIndex = 45;
            this.cmb_propertyID.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_propertyID_Validating);
            // 
            // cmb_AgentID
            // 
            this.cmb_AgentID.FormattingEnabled = true;
            this.cmb_AgentID.Location = new System.Drawing.Point(117, 96);
            this.cmb_AgentID.Name = "cmb_AgentID";
            this.cmb_AgentID.Size = new System.Drawing.Size(205, 21);
            this.cmb_AgentID.TabIndex = 44;
            this.cmb_AgentID.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_AgentID_Validating);
            // 
            // txt_propertyAgentID
            // 
            this.txt_propertyAgentID.Location = new System.Drawing.Point(117, 29);
            this.txt_propertyAgentID.Name = "txt_propertyAgentID";
            this.txt_propertyAgentID.Size = new System.Drawing.Size(205, 20);
            this.txt_propertyAgentID.TabIndex = 39;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(148, 175);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 35);
            this.btn_update.TabIndex = 38;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(67, 175);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 35);
            this.btn_add.TabIndex = 37;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dgv_propertAgent
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_propertAgent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_propertAgent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_propertAgent.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_propertAgent.Location = new System.Drawing.Point(13, 228);
            this.dgv_propertAgent.Name = "dgv_propertAgent";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_propertAgent.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_propertAgent.Size = new System.Drawing.Size(449, 137);
            this.dgv_propertAgent.TabIndex = 36;
            this.dgv_propertAgent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_propertAgent_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Agent ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Property ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Property Agent ID";
            // 
            // errorPrpID
            // 
            this.errorPrpID.ContainerControl = this;
            // 
            // errorID
            // 
            this.errorID.ContainerControl = this;
            // 
            // frmPropertyAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 402);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPropertyAgent";
            this.Text = "frmPropertyAgent";
            this.Load += new System.EventHandler(this.frmPropertyAgent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_propertAgent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrpID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.DateTimePicker date_propertAgent;
        private System.Windows.Forms.ComboBox cmb_propertyID;
        private System.Windows.Forms.ComboBox cmb_AgentID;
        private System.Windows.Forms.TextBox txt_propertyAgentID;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgv_propertAgent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorPrpID;
        private System.Windows.Forms.ErrorProvider errorID;
    }
}