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
    public partial class BasicConcepts : Form
    {
        LearnCDataContext DB = new LearnCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\STUDY\7TH SEMESTER\Object Oriented Programming 2\Project\Codes\LearnC\LearnC\LearnC.mdf;Integrated Security=True;Connect Timeout=30");

        public BasicConcepts()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void BasicConceptspage2_Click(object sender, EventArgs e)
        {

        }

        private void basicconceptstab_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxbasic1_Click(object sender, EventArgs e)
        {

        }

        private void tabintroduction1_Click(object sender, EventArgs e)
        {

        }

        private void tabPageintroduction1_Click(object sender, EventArgs e)
        {

        }

        private void Continue_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBoxintroduction1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxdatatype3_Click(object sender, EventArgs e)
        {

        }

        private void tabPagedatatype3_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chapter ch = new Chapter();
            ch.Show();
        }

        private void pictureBoxdatatype4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void q104_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void q103_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void q102_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void q101_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelBasicq1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPagedatatype2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxdatatype1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void tabPagedatatype4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5Basic_Click(object sender, EventArgs e)
        {

        }

        private void BasicConcepts_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
