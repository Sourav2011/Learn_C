namespace LearnC
{
    partial class Certificate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Certificate));
            this.pictureBoxCertificate = new System.Windows.Forms.PictureBox();
            this.labelCertificate = new System.Windows.Forms.Label();
            this.buttonCertoficateBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCertificate)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCertificate
            // 
            this.pictureBoxCertificate.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCertificate.Image")));
            this.pictureBoxCertificate.Location = new System.Drawing.Point(-1, -1);
            this.pictureBoxCertificate.Name = "pictureBoxCertificate";
            this.pictureBoxCertificate.Size = new System.Drawing.Size(869, 372);
            this.pictureBoxCertificate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCertificate.TabIndex = 0;
            this.pictureBoxCertificate.TabStop = false;
            this.pictureBoxCertificate.Click += new System.EventHandler(this.pictureBoxCertificate_Click);
            // 
            // labelCertificate
            // 
            this.labelCertificate.AutoSize = true;
            this.labelCertificate.BackColor = System.Drawing.Color.NavajoWhite;
            this.labelCertificate.Font = new System.Drawing.Font("Gabriola", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCertificate.ForeColor = System.Drawing.Color.Black;
            this.labelCertificate.Location = new System.Drawing.Point(486, 136);
            this.labelCertificate.Name = "labelCertificate";
            this.labelCertificate.Size = new System.Drawing.Size(94, 65);
            this.labelCertificate.TabIndex = 1;
            this.labelCertificate.Text = "label1";
            // 
            // buttonCertoficateBack
            // 
            this.buttonCertoficateBack.BackColor = System.Drawing.Color.Brown;
            this.buttonCertoficateBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCertoficateBack.Location = new System.Drawing.Point(783, 12);
            this.buttonCertoficateBack.Name = "buttonCertoficateBack";
            this.buttonCertoficateBack.Size = new System.Drawing.Size(74, 36);
            this.buttonCertoficateBack.TabIndex = 6;
            this.buttonCertoficateBack.Text = "Home";
            this.buttonCertoficateBack.UseVisualStyleBackColor = false;
            this.buttonCertoficateBack.Click += new System.EventHandler(this.buttonCertoficateBack_Click);
            // 
            // Certificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 370);
            this.Controls.Add(this.buttonCertoficateBack);
            this.Controls.Add(this.labelCertificate);
            this.Controls.Add(this.pictureBoxCertificate);
            this.Name = "Certificate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Certificate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Certificate_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCertificate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCertificate;
        internal System.Windows.Forms.Label labelCertificate;
        private System.Windows.Forms.Button buttonCertoficateBack;
    }
}