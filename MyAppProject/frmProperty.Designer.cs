namespace MyAppProject
{
    partial class frmProperty
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pct_Picture = new System.Windows.Forms.PictureBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_display = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_descr = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_propertyID = new System.Windows.Forms.TextBox();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.cmb_surbubID = new System.Windows.Forms.ComboBox();
            this.cmb_propTypeID = new System.Windows.Forms.ComboBox();
            this.dgv_property = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorDesc = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPropID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorStatus = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSUrbubID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPicture = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_Image = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_property)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPropID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSUrbubID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Image);
            this.groupBox2.Controls.Add(this.pct_Picture);
            this.groupBox2.Controls.Add(this.btn_Back);
            this.groupBox2.Controls.Add(this.btn_update);
            this.groupBox2.Controls.Add(this.btn_display);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.txt_descr);
            this.groupBox2.Controls.Add(this.txt_price);
            this.groupBox2.Controls.Add(this.txt_propertyID);
            this.groupBox2.Controls.Add(this.cmb_status);
            this.groupBox2.Controls.Add(this.cmb_surbubID);
            this.groupBox2.Controls.Add(this.cmb_propTypeID);
            this.groupBox2.Controls.Add(this.dgv_property);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(4, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 449);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PROPERTY";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // pct_Picture
            // 
            this.pct_Picture.Location = new System.Drawing.Point(316, 24);
            this.pct_Picture.Name = "pct_Picture";
            this.pct_Picture.Size = new System.Drawing.Size(180, 133);
            this.pct_Picture.TabIndex = 20;
            this.pct_Picture.TabStop = false;
            this.pct_Picture.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pct_Picture.Validating += new System.ComponentModel.CancelEventHandler(this.pct_Picture_Validating);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Blue;
            this.btn_Back.Location = new System.Drawing.Point(428, 236);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 29);
            this.btn_Back.TabIndex = 19;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(142, 207);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(67, 58);
            this.btn_update.TabIndex = 16;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(215, 207);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(70, 58);
            this.btn_display.TabIndex = 17;
            this.btn_display.Text = "DISPLAY";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(73, 207);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(63, 58);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(291, 207);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(66, 58);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_descr
            // 
            this.txt_descr.Location = new System.Drawing.Point(135, 48);
            this.txt_descr.Name = "txt_descr";
            this.txt_descr.Size = new System.Drawing.Size(164, 20);
            this.txt_descr.TabIndex = 14;
            this.txt_descr.Validating += new System.ComponentModel.CancelEventHandler(this.txt_descr_Validating);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(135, 71);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(164, 20);
            this.txt_price.TabIndex = 13;
            this.txt_price.Validating += new System.ComponentModel.CancelEventHandler(this.txt_price_Validating);
            // 
            // txt_propertyID
            // 
            this.txt_propertyID.Location = new System.Drawing.Point(135, 24);
            this.txt_propertyID.Name = "txt_propertyID";
            this.txt_propertyID.Size = new System.Drawing.Size(164, 20);
            this.txt_propertyID.TabIndex = 12;
            // 
            // cmb_status
            // 
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Location = new System.Drawing.Point(135, 116);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(164, 21);
            this.cmb_status.TabIndex = 10;
            this.cmb_status.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_status_Validating);
            // 
            // cmb_surbubID
            // 
            this.cmb_surbubID.FormattingEnabled = true;
            this.cmb_surbubID.Location = new System.Drawing.Point(135, 143);
            this.cmb_surbubID.Name = "cmb_surbubID";
            this.cmb_surbubID.Size = new System.Drawing.Size(164, 21);
            this.cmb_surbubID.TabIndex = 9;
            this.cmb_surbubID.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_surbubID_Validating);
            // 
            // cmb_propTypeID
            // 
            this.cmb_propTypeID.FormattingEnabled = true;
            this.cmb_propTypeID.Location = new System.Drawing.Point(135, 93);
            this.cmb_propTypeID.Name = "cmb_propTypeID";
            this.cmb_propTypeID.Size = new System.Drawing.Size(164, 21);
            this.cmb_propTypeID.TabIndex = 8;
            this.cmb_propTypeID.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_propTypeID_Validating);
            // 
            // dgv_property
            // 
            this.dgv_property.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_property.Location = new System.Drawing.Point(6, 271);
            this.dgv_property.Name = "dgv_property";
            this.dgv_property.Size = new System.Drawing.Size(503, 174);
            this.dgv_property.TabIndex = 7;
            this.dgv_property.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_property_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Image";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Surbub ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "PropertyType ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Property ID";
            // 
            // errorDesc
            // 
            this.errorDesc.ContainerControl = this;
            // 
            // errorPrice
            // 
            this.errorPrice.ContainerControl = this;
            // 
            // errorPropID
            // 
            this.errorPropID.ContainerControl = this;
            // 
            // errorStatus
            // 
            this.errorStatus.ContainerControl = this;
            // 
            // errorSUrbubID
            // 
            this.errorSUrbubID.ContainerControl = this;
            // 
            // errorPicture
            // 
            this.errorPicture.ContainerControl = this;
            // 
            // txt_Image
            // 
            this.txt_Image.Location = new System.Drawing.Point(135, 171);
            this.txt_Image.Name = "txt_Image";
            this.txt_Image.Size = new System.Drawing.Size(361, 20);
            this.txt_Image.TabIndex = 21;
            // 
            // frmProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 450);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmProperty";
            this.Text = "frmProperty";
            this.Load += new System.EventHandler(this.frmProperty_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_property)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPropID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSUrbubID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_descr;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_propertyID;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.ComboBox cmb_surbubID;
        private System.Windows.Forms.ComboBox cmb_propTypeID;
        private System.Windows.Forms.DataGridView dgv_property;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.PictureBox pct_Picture;
        private System.Windows.Forms.ErrorProvider errorDesc;
        private System.Windows.Forms.ErrorProvider errorPrice;
        private System.Windows.Forms.ErrorProvider errorPropID;
        private System.Windows.Forms.ErrorProvider errorStatus;
        private System.Windows.Forms.ErrorProvider errorSUrbubID;
        private System.Windows.Forms.ErrorProvider errorPicture;
        private System.Windows.Forms.TextBox txt_Image;
    }
}