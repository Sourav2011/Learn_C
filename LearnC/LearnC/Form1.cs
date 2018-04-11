using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnC
{
    public partial class Form1 : Form
    {
        Registration reg;
        LogIn log;

        public Form1()
        {
            InitializeComponent();
        }


        private void registration_Click(object sender, EventArgs e)
        {
            this.Hide();
            reg = new Registration();
            reg.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            this.Hide();
            log = new LogIn();
            log.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void registration_MouseHover(object sender, EventArgs e)
        {
            this.registration.BackColor = System.Drawing.Color.SandyBrown;
        }

        private void registration_MouseLeave(object sender, EventArgs e)
        {
            this.registration.BackColor = System.Drawing.Color.Brown;
        }

        private void login_MouseHover(object sender, EventArgs e)
        {
            this.login.BackColor = System.Drawing.Color.SandyBrown;
        }

        private void login_MouseLeave(object sender, EventArgs e)
        {
            this.login.BackColor = System.Drawing.Color.Brown;
        }
    }
}
