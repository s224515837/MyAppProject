namespace MyAppProject
{
    partial class frmAgency
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.txt_AgencyID = new System.Windows.Forms.TextBox();
            this.txt_AgencyName = new System.Windows.Forms.TextBox();
            this.cmb_SurbubID = new System.Windows.Forms.ComboBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Display = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dgv_Agency = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorID = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Agency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_Back);
            this.groupBox1.Controls.Add(this.txt_AgencyID);
            this.groupBox1.Controls.Add(this.txt_AgencyName);
            this.groupBox1.Controls.Add(this.cmb_SurbubID);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.btn_Display);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Controls.Add(this.dgv_Agency);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 415);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agency";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Blue;
            this.btn_Back.Location = new System.Drawing.Point(6, 19);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 29);
            this.btn_Back.TabIndex = 15;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // txt_AgencyID
            // 
            this.txt_AgencyID.Location = new System.Drawing.Point(147, 51);
            this.txt_AgencyID.Name = "txt_AgencyID";
            this.txt_AgencyID.Size = new System.Drawing.Size(307, 20);
            this.txt_AgencyID.TabIndex = 9;
            // 
            // txt_AgencyName
            // 
            this.txt_AgencyName.Location = new System.Drawing.Point(147, 83);
            this.txt_AgencyName.Name = "txt_AgencyName";
            this.txt_AgencyName.Size = new System.Drawing.Size(307, 20);
            this.txt_AgencyName.TabIndex = 8;
            this.txt_AgencyName.TextChanged += new System.EventHandler(this.txt_AgencyName_TextChanged);
            this.txt_AgencyName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_AgencyName_Validating);
            // 
            // cmb_SurbubID
            // 
            this.cmb_SurbubID.FormattingEnabled = true;
            this.cmb_SurbubID.Location = new System.Drawing.Point(147, 115);
            this.cmb_SurbubID.Name = "cmb_SurbubID";
            this.cmb_SurbubID.Size = new System.Drawing.Size(307, 21);
            this.cmb_SurbubID.TabIndex = 7;
            this.cmb_SurbubID.SelectedIndexChanged += new System.EventHandler(this.cmb_SurbubID_SelectedIndexChanged);
            this.cmb_SurbubID.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_SurbubID_Validating);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(379, 161);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 37);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "DELETE";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Display
            // 
            this.btn_Display.Location = new System.Drawing.Point(259, 161);
            this.btn_Display.Name = "btn_Display";
            this.btn_Display.Size = new System.Drawing.Size(75, 37);
            this.btn_Display.TabIndex = 5;
            this.btn_Display.Text = "DISPLAY";
            this.btn_Display.UseVisualStyleBackColor = true;
            this.btn_Display.Click += new System.EventHandler(this.btn_Display_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(147, 161);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 37);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dgv_Agency
            // 
            this.dgv_Agency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Agency.Location = new System.Drawing.Point(6, 227);
            this.dgv_Agency.Name = "dgv_Agency";
            this.dgv_Agency.Size = new System.Drawing.Size(536, 178);
            this.dgv_Agency.TabIndex = 3;
            this.dgv_Agency.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Agency_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surbub ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agency Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agency ID";
            // 
            // errorName
            // 
            this.errorName.ContainerControl = this;
            // 
            // errorID
            // 
            this.errorID.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 16;
            this.button1.Text = ">>More>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAgency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 421);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAgency";
            this.Text = "frmAgency";
            this.Load += new System.EventHandler(this.frmAgency_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Agency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Agency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_AgencyID;
        private System.Windows.Forms.TextBox txt_AgencyName;
        private System.Windows.Forms.ComboBox cmb_SurbubID;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Display;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.ErrorProvider errorName;
        private System.Windows.Forms.ErrorProvider errorID;
        private System.Windows.Forms.Button button1;
    }
}