namespace LearnC
{
    partial class Loop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loop));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageloop1 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBoxloop1 = new System.Windows.Forms.PictureBox();
            this.tabPageloop2 = new System.Windows.Forms.TabPage();
            this.pictureBoxloop2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPageloop1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxloop1)).BeginInit();
            this.tabPageloop2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxloop2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageloop1);
            this.tabControl1.Controls.Add(this.tabPageloop2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(868, 414);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageloop1
            // 
            this.tabPageloop1.Controls.Add(this.button4);
            this.tabPageloop1.Controls.Add(this.pictureBoxloop1);
            this.tabPageloop1.Location = new System.Drawing.Point(4, 22);
            this.tabPageloop1.Name = "tabPageloop1";
            this.tabPageloop1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageloop1.Size = new System.Drawing.Size(860, 388);
            this.tabPageloop1.TabIndex = 0;
            this.tabPageloop1.Text = "For Loop";
            this.tabPageloop1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Brown;
            this.button4.ForeColor = System.Drawing.Color.Cornsilk;
            this.button4.Location = new System.Drawing.Point(17, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 26);
            this.button4.TabIndex = 11;
            this.button4.Text = "<<";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBoxloop1
            // 
            this.pictureBoxloop1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxloop1.Image")));
            this.pictureBoxloop1.InitialImage = null;
            this.pictureBoxloop1.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxloop1.Name = "pictureBoxloop1";
            this.pictureBoxloop1.Size = new System.Drawing.Size(864, 388);
            this.pictureBoxloop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxloop1.TabIndex = 0;
            this.pictureBoxloop1.TabStop = false;
            this.pictureBoxloop1.Click += new System.EventHandler(this.pictureBoxloop1_Click);
            // 
            // tabPageloop2
            // 
            this.tabPageloop2.Controls.Add(this.pictureBoxloop2);
            this.tabPageloop2.Location = new System.Drawing.Point(4, 22);
            this.tabPageloop2.Name = "tabPageloop2";
            this.tabPageloop2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageloop2.Size = new System.Drawing.Size(860, 388);
            this.tabPageloop2.TabIndex = 1;
            this.tabPageloop2.Text = ">>";
            this.tabPageloop2.UseVisualStyleBackColor = true;
            // 
            // pictureBoxloop2
            // 
            this.pictureBoxloop2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxloop2.Image")));
            this.pictureBoxloop2.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxloop2.Name = "pictureBoxloop2";
            this.pictureBoxloop2.Size = new System.Drawing.Size(864, 388);
            this.pictureBoxloop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxloop2.TabIndex = 0;
            this.pictureBoxloop2.TabStop = false;
            // 
            // Loop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 414);
            this.Controls.Add(this.tabControl1);
            this.Name = "Loop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Loop_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPageloop1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxloop1)).EndInit();
            this.tabPageloop2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxloop2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageloop1;
        private System.Windows.Forms.PictureBox pictureBoxloop1;
        private System.Windows.Forms.TabPage tabPageloop2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBoxloop2;
    }
}