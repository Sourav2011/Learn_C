namespace LearnC
{
    partial class Contact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contact));
            this.labelAdmin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelAdminName = new System.Windows.Forms.Label();
            this.labelAdminEmail = new System.Windows.Forms.Label();
            this.comboBoxAdmin = new System.Windows.Forms.ComboBox();
            this.textBoxAdminName = new System.Windows.Forms.TextBox();
            this.textBoxAdminEmail = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBoxContact = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContact)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.BackColor = System.Drawing.Color.Transparent;
            this.labelAdmin.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.Location = new System.Drawing.Point(332, 22);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(208, 42);
            this.labelAdmin.TabIndex = 0;
            this.labelAdmin.Text = "Administrators";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(585, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelAdminName
            // 
            this.labelAdminName.AutoSize = true;
            this.labelAdminName.BackColor = System.Drawing.Color.Transparent;
            this.labelAdminName.Location = new System.Drawing.Point(153, 181);
            this.labelAdminName.Name = "labelAdminName";
            this.labelAdminName.Size = new System.Drawing.Size(35, 13);
            this.labelAdminName.TabIndex = 2;
            this.labelAdminName.Text = "Name";
            // 
            // labelAdminEmail
            // 
            this.labelAdminEmail.AutoSize = true;
            this.labelAdminEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelAdminEmail.Location = new System.Drawing.Point(153, 232);
            this.labelAdminEmail.Name = "labelAdminEmail";
            this.labelAdminEmail.Size = new System.Drawing.Size(36, 13);
            this.labelAdminEmail.TabIndex = 4;
            this.labelAdminEmail.Text = "E-Mail";
            this.labelAdminEmail.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBoxAdmin
            // 
            this.comboBoxAdmin.FormattingEnabled = true;
            this.comboBoxAdmin.Location = new System.Drawing.Point(218, 109);
            this.comboBoxAdmin.Name = "comboBoxAdmin";
            this.comboBoxAdmin.Size = new System.Drawing.Size(197, 21);
            this.comboBoxAdmin.TabIndex = 5;
            this.comboBoxAdmin.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdmin_SelectedIndexChanged);
            // 
            // textBoxAdminName
            // 
            this.textBoxAdminName.Location = new System.Drawing.Point(216, 178);
            this.textBoxAdminName.Name = "textBoxAdminName";
            this.textBoxAdminName.ReadOnly = true;
            this.textBoxAdminName.Size = new System.Drawing.Size(199, 20);
            this.textBoxAdminName.TabIndex = 6;
            // 
            // textBoxAdminEmail
            // 
            this.textBoxAdminEmail.Location = new System.Drawing.Point(216, 232);
            this.textBoxAdminEmail.Name = "textBoxAdminEmail";
            this.textBoxAdminEmail.ReadOnly = true;
            this.textBoxAdminEmail.Size = new System.Drawing.Size(199, 20);
            this.textBoxAdminEmail.TabIndex = 8;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Brown;
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(39, 59);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(53, 25);
            this.button6.TabIndex = 11;
            this.button6.Text = "<<";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBoxContact
            // 
            this.pictureBoxContact.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxContact.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxContact.Image")));
            this.pictureBoxContact.Location = new System.Drawing.Point(148, 95);
            this.pictureBoxContact.Name = "pictureBoxContact";
            this.pictureBoxContact.Size = new System.Drawing.Size(50, 48);
            this.pictureBoxContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxContact.TabIndex = 12;
            this.pictureBoxContact.TabStop = false;
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(879, 349);
            this.Controls.Add(this.pictureBoxContact);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBoxAdminEmail);
            this.Controls.Add(this.textBoxAdminName);
            this.Controls.Add(this.comboBoxAdmin);
            this.Controls.Add(this.labelAdminEmail);
            this.Controls.Add(this.labelAdminName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelAdmin);
            this.Name = "Contact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Contact_FormClosing);
            this.Load += new System.EventHandler(this.Contact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelAdminName;
        private System.Windows.Forms.Label labelAdminEmail;
        private System.Windows.Forms.ComboBox comboBoxAdmin;
        private System.Windows.Forms.TextBox textBoxAdminName;
        private System.Windows.Forms.TextBox textBoxAdminEmail;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBoxContact;
    }
}