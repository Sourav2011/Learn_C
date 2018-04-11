namespace LearnC
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.submit = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.passtext = new System.Windows.Forms.TextBox();
            this.usertext = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.loginicon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loginicon)).BeginInit();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.Brown;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submit.Location = new System.Drawing.Point(494, 207);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 29);
            this.submit.TabIndex = 29;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Brown;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.Cornsilk;
            this.back.Location = new System.Drawing.Point(379, 207);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 29);
            this.back.TabIndex = 28;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(261, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Password:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // passtext
            // 
            this.passtext.Location = new System.Drawing.Point(379, 141);
            this.passtext.Multiline = true;
            this.passtext.Name = "passtext";
            this.passtext.PasswordChar = '*';
            this.passtext.Size = new System.Drawing.Size(190, 26);
            this.passtext.TabIndex = 26;
            // 
            // usertext
            // 
            this.usertext.Location = new System.Drawing.Point(379, 88);
            this.usertext.Multiline = true;
            this.usertext.Name = "usertext";
            this.usertext.Size = new System.Drawing.Size(190, 28);
            this.usertext.TabIndex = 25;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Location = new System.Drawing.Point(261, 93);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(63, 13);
            this.username.TabIndex = 24;
            this.username.Text = "User Name:";
            // 
            // loginicon
            // 
            this.loginicon.BackColor = System.Drawing.Color.Transparent;
            this.loginicon.Image = ((System.Drawing.Image)(resources.GetObject("loginicon.Image")));
            this.loginicon.Location = new System.Drawing.Point(170, 96);
            this.loginicon.Name = "loginicon";
            this.loginicon.Size = new System.Drawing.Size(76, 71);
            this.loginicon.TabIndex = 30;
            this.loginicon.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(882, 412);
            this.Controls.Add(this.loginicon);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passtext);
            this.Controls.Add(this.usertext);
            this.Controls.Add(this.username);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogIn_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.loginicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passtext;
        private System.Windows.Forms.TextBox usertext;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.PictureBox loginicon;
    }
}