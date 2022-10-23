namespace MyAppProject
{
    partial class frmCity
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
            this.dgv_City = new System.Windows.Forms.DataGridView();
            this.txt_CitySDesc = new System.Windows.Forms.TextBox();
            this.txt_CityID = new System.Windows.Forms.TextBox();
            this.cmb_ProvinceID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Display = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.errorDesc = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorID = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_City)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Back);
            this.groupBox1.Controls.Add(this.dgv_City);
            this.groupBox1.Controls.Add(this.txt_CitySDesc);
            this.groupBox1.Controls.Add(this.txt_CityID);
            this.groupBox1.Controls.Add(this.cmb_ProvinceID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Display);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 436);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "City";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Blue;
            this.btn_Back.Location = new System.Drawing.Point(361, 186);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 29);
            this.btn_Back.TabIndex = 14;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // dgv_City
            // 
            this.dgv_City.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_City.Location = new System.Drawing.Point(6, 259);
            this.dgv_City.Name = "dgv_City";
            this.dgv_City.Size = new System.Drawing.Size(430, 171);
            this.dgv_City.TabIndex = 8;
            this.dgv_City.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_City_CellContentClick);
            // 
            // txt_CitySDesc
            // 
            this.txt_CitySDesc.Location = new System.Drawing.Point(141, 79);
            this.txt_CitySDesc.Name = "txt_CitySDesc";
            this.txt_CitySDesc.Size = new System.Drawing.Size(203, 20);
            this.txt_CitySDesc.TabIndex = 7;
            this.txt_CitySDesc.Validating += new System.ComponentModel.CancelEventHandler(this.txt_CitySDesc_Validating);
            // 
            // txt_CityID
            // 
            this.txt_CityID.Location = new System.Drawing.Point(141, 37);
            this.txt_CityID.Name = "txt_CityID";
            this.txt_CityID.Size = new System.Drawing.Size(203, 20);
            this.txt_CityID.TabIndex = 6;
            // 
            // cmb_ProvinceID
            // 
            this.cmb_ProvinceID.FormattingEnabled = true;
            this.cmb_ProvinceID.Location = new System.Drawing.Point(141, 120);
            this.cmb_ProvinceID.Name = "cmb_ProvinceID";
            this.cmb_ProvinceID.Size = new System.Drawing.Size(203, 21);
            this.cmb_ProvinceID.TabIndex = 5;
            this.cmb_ProvinceID.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_ProvinceID_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Province ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "City Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "City ID";
            // 
            // btn_Display
            // 
            this.btn_Display.Location = new System.Drawing.Point(269, 177);
            this.btn_Display.Name = "btn_Display";
            this.btn_Display.Size = new System.Drawing.Size(75, 38);
            this.btn_Display.TabIndex = 1;
            this.btn_Display.Text = "DISPLAY";
            this.btn_Display.UseVisualStyleBackColor = true;
            this.btn_Display.Click += new System.EventHandler(this.btn_Display_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(141, 174);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 41);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // errorDesc
            // 
            this.errorDesc.ContainerControl = this;
            // 
            // errorID
            // 
            this.errorID.ContainerControl = this;
            // 
            // frmCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCity";
            this.Text = "frmCity";
            this.Load += new System.EventHandler(this.frmCity_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_City)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_City;
        private System.Windows.Forms.TextBox txt_CitySDesc;
        private System.Windows.Forms.TextBox txt_CityID;
        private System.Windows.Forms.ComboBox cmb_ProvinceID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Display;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.ErrorProvider errorDesc;
        private System.Windows.Forms.ErrorProvider errorID;
    }
}