namespace LearnC
{
    partial class ConditionalStatements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConditionalStatements));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagecondi1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBoxcondi1 = new System.Windows.Forms.PictureBox();
            this.tabPagecondi2 = new System.Windows.Forms.TabPage();
            this.pictureBoxcondi2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPagecondi1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcondi1)).BeginInit();
            this.tabPagecondi2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcondi2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagecondi1);
            this.tabControl1.Controls.Add(this.tabPagecondi2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(874, 415);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPagecondi1
            // 
            this.tabPagecondi1.Controls.Add(this.button2);
            this.tabPagecondi1.Controls.Add(this.pictureBoxcondi1);
            this.tabPagecondi1.Location = new System.Drawing.Point(4, 22);
            this.tabPagecondi1.Name = "tabPagecondi1";
            this.tabPagecondi1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagecondi1.Size = new System.Drawing.Size(866, 389);
            this.tabPagecondi1.TabIndex = 0;
            this.tabPagecondi1.Text = "If-Else";
            this.tabPagecondi1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.ForeColor = System.Drawing.Color.Cornsilk;
            this.button2.Location = new System.Drawing.Point(25, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 26);
            this.button2.TabIndex = 9;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBoxcondi1
            // 
            this.pictureBoxcondi1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxcondi1.Image")));
            this.pictureBoxcondi1.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxcondi1.Name = "pictureBoxcondi1";
            this.pictureBoxcondi1.Size = new System.Drawing.Size(866, 389);
            this.pictureBoxcondi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxcondi1.TabIndex = 0;
            this.pictureBoxcondi1.TabStop = false;
            // 
            // tabPagecondi2
            // 
            this.tabPagecondi2.Controls.Add(this.pictureBoxcondi2);
            this.tabPagecondi2.Location = new System.Drawing.Point(4, 22);
            this.tabPagecondi2.Name = "tabPagecondi2";
            this.tabPagecondi2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagecondi2.Size = new System.Drawing.Size(866, 389);
            this.tabPagecondi2.TabIndex = 1;
            this.tabPagecondi2.Text = ">>";
            this.tabPagecondi2.UseVisualStyleBackColor = true;
            // 
            // pictureBoxcondi2
            // 
            this.pictureBoxcondi2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxcondi2.Image")));
            this.pictureBoxcondi2.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxcondi2.Name = "pictureBoxcondi2";
            this.pictureBoxcondi2.Size = new System.Drawing.Size(866, 393);
            this.pictureBoxcondi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxcondi2.TabIndex = 0;
            this.pictureBoxcondi2.TabStop = false;
            // 
            // ConditionalStatements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 415);
            this.Controls.Add(this.tabControl1);
            this.Name = "ConditionalStatements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConditionalStatements";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConditionalStatements_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPagecondi1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcondi1)).EndInit();
            this.tabPagecondi2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcondi2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagecondi1;
        private System.Windows.Forms.TabPage tabPagecondi2;
        private System.Windows.Forms.PictureBox pictureBoxcondi2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBoxcondi1;
    }
}