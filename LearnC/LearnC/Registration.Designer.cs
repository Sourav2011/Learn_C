namespace LearnC
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.submit = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.BirthDatelabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.Maleradio = new System.Windows.Forms.RadioButton();
            this.Femaleradio = new System.Windows.Forms.RadioButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.Brown;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submit.Location = new System.Drawing.Point(472, 345);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 29);
            this.submit.TabIndex = 23;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Brown;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.Cornsilk;
            this.back.Location = new System.Drawing.Point(357, 345);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 29);
            this.back.TabIndex = 22;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(226, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Password:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(357, 286);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.PasswordChar = '*';
            this.textBox5.Size = new System.Drawing.Size(190, 26);
            this.textBox5.TabIndex = 20;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Location = new System.Drawing.Point(226, 131);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(35, 13);
            this.email.TabIndex = 18;
            this.email.Text = "Email:";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(357, 128);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(190, 29);
            this.textBox4.TabIndex = 17;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // BirthDatelabel
            // 
            this.BirthDatelabel.AutoSize = true;
            this.BirthDatelabel.BackColor = System.Drawing.Color.Transparent;
            this.BirthDatelabel.Location = new System.Drawing.Point(226, 177);
            this.BirthDatelabel.Name = "BirthDatelabel";
            this.BirthDatelabel.Size = new System.Drawing.Size(51, 13);
            this.BirthDatelabel.TabIndex = 16;
            this.BirthDatelabel.Text = "BirthDate";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(357, 71);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 28);
            this.textBox2.TabIndex = 15;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Location = new System.Drawing.Point(226, 22);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(38, 13);
            this.name.TabIndex = 14;
            this.name.Text = "Name:";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(357, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 28);
            this.textBox1.TabIndex = 13;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Location = new System.Drawing.Point(226, 74);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(63, 13);
            this.username.TabIndex = 12;
            this.username.Text = "User Name:";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.BackColor = System.Drawing.Color.Transparent;
            this.Gender.Location = new System.Drawing.Point(226, 221);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(42, 13);
            this.Gender.TabIndex = 24;
            this.Gender.Text = "Gender";
            this.Gender.Click += new System.EventHandler(this.Gender_Click);
            // 
            // Maleradio
            // 
            this.Maleradio.AutoSize = true;
            this.Maleradio.BackColor = System.Drawing.Color.Transparent;
            this.Maleradio.Location = new System.Drawing.Point(357, 217);
            this.Maleradio.Name = "Maleradio";
            this.Maleradio.Size = new System.Drawing.Size(48, 17);
            this.Maleradio.TabIndex = 25;
            this.Maleradio.TabStop = true;
            this.Maleradio.Text = "Male";
            this.Maleradio.UseVisualStyleBackColor = false;
            this.Maleradio.CheckedChanged += new System.EventHandler(this.Maleradio_CheckedChanged);
            // 
            // Femaleradio
            // 
            this.Femaleradio.AutoSize = true;
            this.Femaleradio.BackColor = System.Drawing.Color.Transparent;
            this.Femaleradio.Location = new System.Drawing.Point(357, 240);
            this.Femaleradio.Name = "Femaleradio";
            this.Femaleradio.Size = new System.Drawing.Size(59, 17);
            this.Femaleradio.TabIndex = 26;
            this.Femaleradio.TabStop = true;
            this.Femaleradio.Text = "Female";
            this.Femaleradio.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(357, 177);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(190, 20);
            this.dateTimePicker2.TabIndex = 29;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(881, 411);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.Femaleradio);
            this.Controls.Add(this.Maleradio);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.email);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.BirthDatelabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.username);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registration_FormClosing);
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label BirthDatelabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.RadioButton Maleradio;
        private System.Windows.Forms.RadioButton Femaleradio;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}