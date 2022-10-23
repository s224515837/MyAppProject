namespace MyAppProject
{
    partial class frmMenu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Tenant = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Agent = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(5, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 449);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MAIN MENU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select User";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Tenant);
            this.groupBox3.Location = new System.Drawing.Point(108, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btn_Tenant
            // 
            this.btn_Tenant.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Tenant.Location = new System.Drawing.Point(41, 28);
            this.btn_Tenant.Name = "btn_Tenant";
            this.btn_Tenant.Size = new System.Drawing.Size(118, 45);
            this.btn_Tenant.TabIndex = 1;
            this.btn_Tenant.Text = "TENANT";
            this.btn_Tenant.UseVisualStyleBackColor = false;
            this.btn_Tenant.Click += new System.EventHandler(this.btn_Tenant_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Agent);
            this.groupBox4.Location = new System.Drawing.Point(108, 168);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // btn_Agent
            // 
            this.btn_Agent.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Agent.Location = new System.Drawing.Point(41, 30);
            this.btn_Agent.Name = "btn_Agent";
            this.btn_Agent.Size = new System.Drawing.Size(118, 45);
            this.btn_Agent.TabIndex = 2;
            this.btn_Agent.Text = "AGENT";
            this.btn_Agent.UseVisualStyleBackColor = false;
            this.btn_Agent.Click += new System.EventHandler(this.btn_Agent_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Admin);
            this.groupBox2.Location = new System.Drawing.Point(108, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btn_Admin
            // 
            this.btn_Admin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Admin.Location = new System.Drawing.Point(41, 32);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(118, 45);
            this.btn_Admin.TabIndex = 0;
            this.btn_Admin.Text = "ADMIN";
            this.btn_Admin.UseVisualStyleBackColor = false;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Records";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Tenant;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Agent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.Button button1;
    }
}

