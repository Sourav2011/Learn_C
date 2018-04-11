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
    public partial class Certificate : Form
    {
        public Certificate()
        {
            InitializeComponent();
        }

        private void pictureBoxCertificate_Click(object sender, EventArgs e)
        {

        }

        private void buttonCertoficateBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void Certificate_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
