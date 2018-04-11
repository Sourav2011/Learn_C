using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnC
{
    public partial class Profile : Form
    {
        LearnCDataContext DB = new LearnCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\STUDY\7TH SEMESTER\Object Oriented Programming 2\Project\Codes\LearnC\LearnC\LearnC.mdf;Integrated Security=True;Connect Timeout=30");

        public static int Score = 0;

        public static int Finish = 0;

        public Profile()
        {
            InitializeComponent();
        }

        private void Gender_Click(object sender, EventArgs e)
        {

        }

        private void pback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chapter ch = new Chapter();
            ch.Show();
        }

        private void savechanges_Click(object sender, EventArgs e)
        {
            UserInfo user = new UserInfo();
            var query = from o in DB.UserInfos
                        where o.UserName == LogIn.loginName
                        select o;
            user = query.First();

            string email = textBoxpemail4.Text;
            Regex r = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

            if (user != null)
            {
                user.Name = textBoxpname1.Text;
                if (r.IsMatch(email))
                {
                    user.Email = textBoxpemail4.Text;
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Email Address.", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    textBoxpemail4.Focus();
                    return;
                }
                user.Password = textBoxppassword5.Text;
                DB.SubmitChanges();
                MessageBox.Show("Changes Saved.");
            }

            else
            {
                MessageBox.Show("No Changes Done.");
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            UserInfo user = new UserInfo();
            var query = from o in DB.UserInfos
                            where o.UserName ==LogIn.loginName
                            select o;

            user = query.First();
            textBoxpname1.Text = user.Name;
            textBoxpname2.Text = user.UserName;
            textBoxpemail4.Text = user.Email;
            textBoxppassword5.Text = user.Password;
            textBoxpgender3.Text = user.Gender;
            textDateofBirth.Text = user.BirthDate;
            textBoxScore.Text = Convert.ToString(user.Score);
            progressBar1.Value = (user.ChapterCompleted * 100)/6;
            labelProgress.Text = Convert.ToString((user.ChapterCompleted * 100) / 6);
        }

        private void Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
