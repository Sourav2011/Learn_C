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
    public partial class LogIn : Form
    {
        LearnCDataContext DB = new LearnCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\STUDY\7TH SEMESTER\Object Oriented Programming 2\Project\Codes\LearnC\LearnC\LearnC.mdf;Integrated Security=True;Connect Timeout=30");
        public  static string loginName = "";
        Chapter ch;
        Form1 home;

        public LogIn()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usertext.Text))
            {
                MessageBox.Show("Please Enter User Name.","Message",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                usertext.Focus();
                return;
            }

            try
            {
                var query = from o in DB.UserInfos
                            where o.UserName == usertext.Text && o.Password == passtext.Text
                            select o;

                if (query.SingleOrDefault() != null)
                {
                    MessageBox.Show("You Have Successfully Logged In.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loginName = usertext.Text;
                    this.Hide();

                    var query1 = from o in DB.UserInfos
                                where o.UserName == LogIn.loginName
                                select o;

                    ch = new Chapter();
                    ch.Show();
                }
                else
                {
                    MessageBox.Show("Invalid User Name or Password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            home = new Form1();
            home.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
