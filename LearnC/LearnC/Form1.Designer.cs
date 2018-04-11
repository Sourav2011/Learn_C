namespace LearnC
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.login = new System.Windows.Forms.Button();
            this.registration = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.titleicon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.titleicon)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Brown;
            this.login.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.login.Location = new System.Drawing.Point(358, 278);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(160, 46);
            this.login.TabIndex = 9;
            this.login.Text = "Log In";
            this.login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            this.login.MouseLeave += new System.EventHandler(this.login_MouseLeave);
            this.login.MouseHover += new System.EventHandler(this.login_MouseHover);
            // 
            // registration
            // 
            this.registration.BackColor = System.Drawing.Color.Brown;
            this.registration.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.registration.Location = new System.Drawing.Point(358, 201);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(160, 51);
            this.registration.TabIndex = 8;
            this.registration.Text = "Sign Up";
            this.registration.UseVisualStyleBackColor = false;
            this.registration.Click += new System.EventHandler(this.registration_Click);
            this.registration.MouseLeave += new System.EventHandler(this.registration_MouseLeave);
            this.registration.MouseHover += new System.EventHandler(this.registration_MouseHover);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.BackColor = System.Drawing.Color.Transparent;
            this.welcome.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(228, 123);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(415, 38);
            this.welcome.TabIndex = 7;
            this.welcome.Text = "Welcome To The Programming World";
            this.welcome.Click += new System.EventHandler(this.welcome_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(367, 24);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(224, 76);
            this.title.TabIndex = 6;
            this.title.Text = "Learn C";
            // 
            // titleicon
            // 
            this.titleicon.BackColor = System.Drawing.Color.Transparent;
            this.titleicon.Image = ((System.Drawing.Image)(resources.GetObject("titleicon.Image")));
            this.titleicon.Location = new System.Drawing.Point(283, 24);
            this.titleicon.Name = "titleicon";
            this.titleicon.Size = new System.Drawing.Size(78, 74);
            this.titleicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.titleicon.TabIndex = 5;
            this.titleicon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(877, 410);
            this.Controls.Add(this.login);
            this.Controls.Add(this.registration);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.title);
            this.Controls.Add(this.titleicon);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LearnC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.titleicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button registration;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox titleicon;
    }
}

