namespace MyAppProject
{
    partial class frmPropertyType
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_display = new System.Windows.Forms.Button();
            this.dgv_propType = new System.Windows.Forms.DataGridView();
            this.txt_propTypeDesc = new System.Windows.Forms.TextBox();
            this.txt_propTypeID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_propType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Back);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.btn_display);
            this.groupBox1.Controls.Add(this.dgv_propType);
            this.groupBox1.Controls.Add(this.txt_propTypeDesc);
            this.groupBox1.Controls.Add(this.txt_propTypeID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 407);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PROPERTYTYPE ";
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Blue;
            this.btn_Back.Location = new System.Drawing.Point(311, 378);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 29);
            this.btn_Back.TabIndex = 7;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(164, 106);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 45);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(253, 106);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(75, 45);
            this.btn_display.TabIndex = 5;
            this.btn_display.Text = "DISPLAY";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // dgv_propType
            // 
            this.dgv_propType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_propType.Location = new System.Drawing.Point(6, 181);
            this.dgv_propType.Name = "dgv_propType";
            this.dgv_propType.Size = new System.Drawing.Size(380, 168);
            this.dgv_propType.TabIndex = 4;
            this.dgv_propType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_propType_CellContentClick);
            // 
            // txt_propTypeDesc
            // 
            this.txt_propTypeDesc.Location = new System.Drawing.Point(164, 80);
            this.txt_propTypeDesc.Name = "txt_propTypeDesc";
            this.txt_propTypeDesc.Size = new System.Drawing.Size(164, 20);
            this.txt_propTypeDesc.TabIndex = 3;
            this.txt_propTypeDesc.Validating += new System.ComponentModel.CancelEventHandler(this.txt_propTypeDesc_Validating);
            // 
            // txt_propTypeID
            // 
            this.txt_propTypeID.Location = new System.Drawing.Point(164, 42);
            this.txt_propTypeID.Name = "txt_propTypeID";
            this.txt_propTypeID.Size = new System.Drawing.Size(164, 20);
            this.txt_propTypeID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PropertyType Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PropertyType ID";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmPropertyType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPropertyType";
            this.Text = "frmPropertyType";
            this.Load += new System.EventHandler(this.frmPropertyType_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_propType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.DataGridView dgv_propType;
        private System.Windows.Forms.TextBox txt_propTypeDesc;
        private System.Windows.Forms.TextBox txt_propTypeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}