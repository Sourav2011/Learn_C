namespace LearnC
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.Gender = new System.Windows.Forms.Label();
            this.savechanges = new System.Windows.Forms.Button();
            this.pback = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxppassword5 = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.textBoxpemail4 = new System.Windows.Forms.TextBox();
            this.textBoxpname2 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.textBoxpname1 = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.textBoxpgender3 = new System.Windows.Forms.TextBox();
            this.labeldateofbirth = new System.Windows.Forms.Label();
            this.textDateofBirth = new System.Windows.Forms.TextBox();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.labelpercentage = new System.Windows.Forms.Label();
            this.labelProgressBar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.BackColor = System.Drawing.Color.Transparent;
            this.Gender.Location = new System.Drawing.Point(97, 187);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(45, 13);
            this.Gender.TabIndex = 39;
            this.Gender.Text = "Gender:";
            this.Gender.Click += new System.EventHandler(this.Gender_Click);
            // 
            // savechanges
            // 
            this.savechanges.BackColor = System.Drawing.Color.Brown;
            this.savechanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savechanges.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.savechanges.Location = new System.Drawing.Point(709, 331);
            this.savechanges.Name = "savechanges";
            this.savechanges.Size = new System.Drawing.Size(124, 29);
            this.savechanges.TabIndex = 38;
            this.savechanges.Text = "Save Changes";
            this.savechanges.UseVisualStyleBackColor = false;
            this.savechanges.Click += new System.EventHandler(this.savechanges_Click);
            // 
            // pback
            // 
            this.pback.BackColor = System.Drawing.Color.Brown;
            this.pback.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pback.ForeColor = System.Drawing.Color.Cornsilk;
            this.pback.Location = new System.Drawing.Point(37, 27);
            this.pback.Name = "pback";
            this.pback.Size = new System.Drawing.Size(57, 29);
            this.pback.TabIndex = 37;
            this.pback.Text = "<<";
            this.pback.UseVisualStyleBackColor = false;
            this.pback.Click += new System.EventHandler(this.pback_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(518, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Password:";
            // 
            // textBoxppassword5
            // 
            this.textBoxppassword5.Location = new System.Drawing.Point(605, 184);
            this.textBoxppassword5.Multiline = true;
            this.textBoxppassword5.Name = "textBoxppassword5";
            this.textBoxppassword5.Size = new System.Drawing.Size(228, 26);
            this.textBoxppassword5.TabIndex = 35;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Location = new System.Drawing.Point(518, 130);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(35, 13);
            this.email.TabIndex = 34;
            this.email.Text = "Email:";
            // 
            // textBoxpemail4
            // 
            this.textBoxpemail4.Location = new System.Drawing.Point(605, 127);
            this.textBoxpemail4.Multiline = true;
            this.textBoxpemail4.Name = "textBoxpemail4";
            this.textBoxpemail4.Size = new System.Drawing.Size(228, 29);
            this.textBoxpemail4.TabIndex = 33;
            // 
            // textBoxpname2
            // 
            this.textBoxpname2.Location = new System.Drawing.Point(192, 75);
            this.textBoxpname2.Multiline = true;
            this.textBoxpname2.Name = "textBoxpname2";
            this.textBoxpname2.ReadOnly = true;
            this.textBoxpname2.Size = new System.Drawing.Size(229, 28);
            this.textBoxpname2.TabIndex = 31;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Location = new System.Drawing.Point(518, 78);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(38, 13);
            this.name.TabIndex = 30;
            this.name.Text = "Name:";
            // 
            // textBoxpname1
            // 
            this.textBoxpname1.Location = new System.Drawing.Point(605, 72);
            this.textBoxpname1.Multiline = true;
            this.textBoxpname1.Name = "textBoxpname1";
            this.textBoxpname1.Size = new System.Drawing.Size(228, 28);
            this.textBoxpname1.TabIndex = 29;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Location = new System.Drawing.Point(97, 75);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(63, 13);
            this.username.TabIndex = 28;
            this.username.Text = "User Name:";
            // 
            // textBoxpgender3
            // 
            this.textBoxpgender3.Location = new System.Drawing.Point(192, 184);
            this.textBoxpgender3.Multiline = true;
            this.textBoxpgender3.Name = "textBoxpgender3";
            this.textBoxpgender3.ReadOnly = true;
            this.textBoxpgender3.Size = new System.Drawing.Size(229, 29);
            this.textBoxpgender3.TabIndex = 40;
            // 
            // labeldateofbirth
            // 
            this.labeldateofbirth.AutoSize = true;
            this.labeldateofbirth.BackColor = System.Drawing.Color.Transparent;
            this.labeldateofbirth.Location = new System.Drawing.Point(97, 241);
            this.labeldateofbirth.Name = "labeldateofbirth";
            this.labeldateofbirth.Size = new System.Drawing.Size(69, 13);
            this.labeldateofbirth.TabIndex = 41;
            this.labeldateofbirth.Text = "Date of Birth:";
            // 
            // textDateofBirth
            // 
            this.textDateofBirth.Location = new System.Drawing.Point(192, 238);
            this.textDateofBirth.Multiline = true;
            this.textDateofBirth.Name = "textDateofBirth";
            this.textDateofBirth.ReadOnly = true;
            this.textDateofBirth.Size = new System.Drawing.Size(229, 28);
            this.textDateofBirth.TabIndex = 42;
            // 
            // textBoxScore
            // 
            this.textBoxScore.Location = new System.Drawing.Point(192, 127);
            this.textBoxScore.Multiline = true;
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.ReadOnly = true;
            this.textBoxScore.Size = new System.Drawing.Size(229, 29);
            this.textBoxScore.TabIndex = 43;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Location = new System.Drawing.Point(97, 130);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(38, 13);
            this.labelScore.TabIndex = 44;
            this.labelScore.Text = "Score:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(605, 238);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(229, 25);
            this.progressBar1.TabIndex = 45;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgress.Location = new System.Drawing.Point(693, 239);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(66, 24);
            this.labelProgress.TabIndex = 46;
            this.labelProgress.Text = "label1";
            // 
            // labelpercentage
            // 
            this.labelpercentage.AutoSize = true;
            this.labelpercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelpercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpercentage.Location = new System.Drawing.Point(733, 239);
            this.labelpercentage.Name = "labelpercentage";
            this.labelpercentage.Size = new System.Drawing.Size(26, 24);
            this.labelpercentage.TabIndex = 47;
            this.labelpercentage.Text = "%";
            // 
            // labelProgressBar
            // 
            this.labelProgressBar.AutoSize = true;
            this.labelProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.labelProgressBar.Location = new System.Drawing.Point(518, 246);
            this.labelProgressBar.Name = "labelProgressBar";
            this.labelProgressBar.Size = new System.Drawing.Size(51, 13);
            this.labelProgressBar.TabIndex = 48;
            this.labelProgressBar.Text = "Progress:";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(869, 397);
            this.Controls.Add(this.labelProgressBar);
            this.Controls.Add(this.labelpercentage);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.textDateofBirth);
            this.Controls.Add(this.labeldateofbirth);
            this.Controls.Add(this.textBoxpgender3);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.savechanges);
            this.Controls.Add(this.pback);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxppassword5);
            this.Controls.Add(this.email);
            this.Controls.Add(this.textBoxpemail4);
            this.Controls.Add(this.textBoxpname2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.textBoxpname1);
            this.Controls.Add(this.username);
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Profile_FormClosing);
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Button savechanges;
        private System.Windows.Forms.Button pback;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxppassword5;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox textBoxpemail4;
        private System.Windows.Forms.TextBox textBoxpname2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox textBoxpname1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox textBoxpgender3;
        private System.Windows.Forms.Label labeldateofbirth;
        private System.Windows.Forms.TextBox textDateofBirth;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Label labelpercentage;
        private System.Windows.Forms.Label labelProgressBar;
    }
}