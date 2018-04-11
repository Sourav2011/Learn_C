namespace LearnC
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.textBoxsearch1 = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.buttongo1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxsearch1
            // 
            this.textBoxsearch1.Location = new System.Drawing.Point(230, 9);
            this.textBoxsearch1.Multiline = true;
            this.textBoxsearch1.Name = "textBoxsearch1";
            this.textBoxsearch1.ReadOnly = true;
            this.textBoxsearch1.Size = new System.Drawing.Size(335, 29);
            this.textBoxsearch1.TabIndex = 0;
            this.textBoxsearch1.Text = "www.google.com";
            this.textBoxsearch1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 72);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(843, 325);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // buttongo1
            // 
            this.buttongo1.BackColor = System.Drawing.Color.Brown;
            this.buttongo1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttongo1.Location = new System.Drawing.Point(623, 9);
            this.buttongo1.Name = "buttongo1";
            this.buttongo1.Size = new System.Drawing.Size(75, 31);
            this.buttongo1.TabIndex = 2;
            this.buttongo1.Text = "Go";
            this.buttongo1.UseVisualStyleBackColor = false;
            this.buttongo1.Click += new System.EventHandler(this.buttongo1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Brown;
            this.button4.ForeColor = System.Drawing.Color.Cornsilk;
            this.button4.Location = new System.Drawing.Point(12, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 26);
            this.button4.TabIndex = 11;
            this.button4.Text = "<<";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(867, 409);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttongo1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.textBoxsearch1);
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Search_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxsearch1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button buttongo1;
        private System.Windows.Forms.Button button4;
    }
}