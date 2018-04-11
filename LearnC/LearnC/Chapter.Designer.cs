namespace LearnC
{
    public partial class Chapter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chapter));
            this.buttonbasic = new System.Windows.Forms.Button();
            this.battoncondition = new System.Windows.Forms.Button();
            this.buttonarray = new System.Windows.Forms.Button();
            this.buttonfunction = new System.Windows.Forms.Button();
            this.buttonpointer = new System.Windows.Forms.Button();
            this.buttonloop = new System.Windows.Forms.Button();
            this.paneluserhome = new System.Windows.Forms.Panel();
            this.buttonTest = new System.Windows.Forms.Button();
            this.Contact = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.profile = new System.Windows.Forms.Button();
            this.pictureBoxChapter = new System.Windows.Forms.PictureBox();
            this.paneluserhome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChapter)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonbasic
            // 
            this.buttonbasic.BackColor = System.Drawing.Color.Brown;
            this.buttonbasic.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbasic.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonbasic.Location = new System.Drawing.Point(268, 85);
            this.buttonbasic.Name = "buttonbasic";
            this.buttonbasic.Size = new System.Drawing.Size(131, 44);
            this.buttonbasic.TabIndex = 1;
            this.buttonbasic.Text = "Basic Concept";
            this.buttonbasic.UseVisualStyleBackColor = false;
            this.buttonbasic.Click += new System.EventHandler(this.buttonbasic_Click);
            // 
            // battoncondition
            // 
            this.battoncondition.BackColor = System.Drawing.Color.Brown;
            this.battoncondition.Font = new System.Drawing.Font("Papyrus", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battoncondition.ForeColor = System.Drawing.SystemColors.Info;
            this.battoncondition.Location = new System.Drawing.Point(483, 22);
            this.battoncondition.Name = "battoncondition";
            this.battoncondition.Size = new System.Drawing.Size(121, 46);
            this.battoncondition.TabIndex = 2;
            this.battoncondition.Text = "Conditional Satatement";
            this.battoncondition.UseVisualStyleBackColor = false;
            this.battoncondition.Click += new System.EventHandler(this.battoncondition_Click);
            // 
            // buttonarray
            // 
            this.buttonarray.BackColor = System.Drawing.Color.Brown;
            this.buttonarray.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonarray.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonarray.Location = new System.Drawing.Point(710, 235);
            this.buttonarray.Name = "buttonarray";
            this.buttonarray.Size = new System.Drawing.Size(121, 44);
            this.buttonarray.TabIndex = 3;
            this.buttonarray.Text = "Array ";
            this.buttonarray.UseVisualStyleBackColor = false;
            this.buttonarray.Click += new System.EventHandler(this.buttonarray_Click_1);
            // 
            // buttonfunction
            // 
            this.buttonfunction.BackColor = System.Drawing.Color.Brown;
            this.buttonfunction.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonfunction.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonfunction.Location = new System.Drawing.Point(268, 232);
            this.buttonfunction.Name = "buttonfunction";
            this.buttonfunction.Size = new System.Drawing.Size(131, 44);
            this.buttonfunction.TabIndex = 4;
            this.buttonfunction.Text = "Function";
            this.buttonfunction.UseVisualStyleBackColor = false;
            this.buttonfunction.Click += new System.EventHandler(this.buttonfunction_Click);
            // 
            // buttonpointer
            // 
            this.buttonpointer.BackColor = System.Drawing.Color.Brown;
            this.buttonpointer.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonpointer.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonpointer.Location = new System.Drawing.Point(483, 313);
            this.buttonpointer.Name = "buttonpointer";
            this.buttonpointer.Size = new System.Drawing.Size(121, 44);
            this.buttonpointer.TabIndex = 5;
            this.buttonpointer.Text = "Pointer";
            this.buttonpointer.UseVisualStyleBackColor = false;
            this.buttonpointer.Click += new System.EventHandler(this.buttonpointer_Click_1);
            // 
            // buttonloop
            // 
            this.buttonloop.BackColor = System.Drawing.Color.Brown;
            this.buttonloop.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonloop.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonloop.Location = new System.Drawing.Point(710, 85);
            this.buttonloop.Name = "buttonloop";
            this.buttonloop.Size = new System.Drawing.Size(121, 44);
            this.buttonloop.TabIndex = 6;
            this.buttonloop.Text = "Loop ";
            this.buttonloop.UseVisualStyleBackColor = false;
            this.buttonloop.Click += new System.EventHandler(this.buttonloop_Click_1);
            // 
            // paneluserhome
            // 
            this.paneluserhome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paneluserhome.BackgroundImage")));
            this.paneluserhome.Controls.Add(this.buttonTest);
            this.paneluserhome.Controls.Add(this.Contact);
            this.paneluserhome.Controls.Add(this.About);
            this.paneluserhome.Controls.Add(this.search);
            this.paneluserhome.Controls.Add(this.logout);
            this.paneluserhome.Controls.Add(this.home);
            this.paneluserhome.Controls.Add(this.profile);
            this.paneluserhome.Location = new System.Drawing.Point(0, 2);
            this.paneluserhome.Name = "paneluserhome";
            this.paneluserhome.Size = new System.Drawing.Size(175, 412);
            this.paneluserhome.TabIndex = 7;
            this.paneluserhome.Paint += new System.Windows.Forms.PaintEventHandler(this.paneluserhome_Paint);
            // 
            // buttonTest
            // 
            this.buttonTest.BackColor = System.Drawing.Color.Brown;
            this.buttonTest.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTest.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonTest.Location = new System.Drawing.Point(0, 184);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(172, 43);
            this.buttonTest.TabIndex = 8;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = false;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            this.buttonTest.MouseLeave += new System.EventHandler(this.buttonTest_MouseLeave);
            this.buttonTest.MouseHover += new System.EventHandler(this.buttonTest_MouseHover);
            // 
            // Contact
            // 
            this.Contact.BackColor = System.Drawing.Color.Brown;
            this.Contact.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.ForeColor = System.Drawing.SystemColors.Info;
            this.Contact.Location = new System.Drawing.Point(0, 245);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(172, 47);
            this.Contact.TabIndex = 5;
            this.Contact.Text = "Contact";
            this.Contact.UseVisualStyleBackColor = false;
            this.Contact.Click += new System.EventHandler(this.Contact_Click);
            this.Contact.MouseLeave += new System.EventHandler(this.Contact_MouseLeave);
            this.Contact.MouseHover += new System.EventHandler(this.Contact_MouseHover);
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.Brown;
            this.About.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.ForeColor = System.Drawing.SystemColors.Info;
            this.About.Location = new System.Drawing.Point(0, 308);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(175, 47);
            this.About.TabIndex = 4;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = false;
            this.About.Click += new System.EventHandler(this.About_Click);
            this.About.MouseLeave += new System.EventHandler(this.About_MouseLeave);
            this.About.MouseHover += new System.EventHandler(this.About_MouseHover);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Brown;
            this.search.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.SystemColors.Info;
            this.search.Location = new System.Drawing.Point(0, 123);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(175, 43);
            this.search.TabIndex = 3;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            this.search.MouseLeave += new System.EventHandler(this.search_MouseLeave);
            this.search.MouseHover += new System.EventHandler(this.search_MouseHover);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Brown;
            this.logout.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.SystemColors.Info;
            this.logout.Location = new System.Drawing.Point(0, 365);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(175, 47);
            this.logout.TabIndex = 2;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            this.logout.MouseLeave += new System.EventHandler(this.logout_MouseLeave);
            this.logout.MouseHover += new System.EventHandler(this.logout_MouseHover);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.Brown;
            this.home.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.SystemColors.Info;
            this.home.Location = new System.Drawing.Point(0, 0);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(175, 44);
            this.home.TabIndex = 1;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            this.home.MouseLeave += new System.EventHandler(this.home_MouseLeave);
            this.home.MouseHover += new System.EventHandler(this.home_MouseHover);
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.Color.Brown;
            this.profile.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile.ForeColor = System.Drawing.SystemColors.Info;
            this.profile.Location = new System.Drawing.Point(0, 59);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(175, 49);
            this.profile.TabIndex = 0;
            this.profile.Text = "Profile";
            this.profile.UseVisualStyleBackColor = false;
            this.profile.Click += new System.EventHandler(this.profile_Click);
            this.profile.MouseLeave += new System.EventHandler(this.profile_MouseLeave);
            this.profile.MouseHover += new System.EventHandler(this.profile_MouseHover);
            // 
            // pictureBoxChapter
            // 
            this.pictureBoxChapter.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxChapter.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxChapter.Image")));
            this.pictureBoxChapter.Location = new System.Drawing.Point(415, 85);
            this.pictureBoxChapter.Name = "pictureBoxChapter";
            this.pictureBoxChapter.Size = new System.Drawing.Size(266, 209);
            this.pictureBoxChapter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxChapter.TabIndex = 8;
            this.pictureBoxChapter.TabStop = false;
            // 
            // Chapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(880, 413);
            this.Controls.Add(this.pictureBoxChapter);
            this.Controls.Add(this.paneluserhome);
            this.Controls.Add(this.buttonloop);
            this.Controls.Add(this.buttonpointer);
            this.Controls.Add(this.buttonfunction);
            this.Controls.Add(this.buttonarray);
            this.Controls.Add(this.battoncondition);
            this.Controls.Add(this.buttonbasic);
            this.Name = "Chapter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Chapter_FormClosing);
            this.Load += new System.EventHandler(this.Chapter_Load);
            this.paneluserhome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChapter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button buttonbasic;
        internal System.Windows.Forms.Button battoncondition;
        internal System.Windows.Forms.Button buttonarray;
        internal System.Windows.Forms.Button buttonfunction;
        internal System.Windows.Forms.Button buttonpointer;
        internal System.Windows.Forms.Button buttonloop;
        private System.Windows.Forms.Panel paneluserhome;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button profile;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button Contact;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.PictureBox pictureBoxChapter;

    }
}