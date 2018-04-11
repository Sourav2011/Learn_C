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
    public partial class Registration : Form
    {
        LearnCDataContext DB = new LearnCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\STUDY\7TH SEMESTER\Object Oriented Programming 2\Project\Codes\LearnC\LearnC\LearnC.mdf;Integrated Security=True;Connect Timeout=30");
        Form1 home;
        LogIn login;

        public Registration()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            home = new Form1();
            home.Show();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string email = textBox4.Text;
            Regex r=new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

            bool usernameflag = false;

            UserInfo user = new UserInfo();
            var query = from uname in DB.UserInfos
                        select uname.UserName;

            foreach (var results in query)
            {
                if (textBox2.Text.Equals(results))
                {
                    usernameflag = true;
                }
            }

            if (usernameflag == true)
            {
                MessageBox.Show("This user name is already in use. Please try another.", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                textBox2.Focus();
                return; 
            }
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please Enter Your Name.", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please Enter User Name.", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Please Enter Your Email.", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                textBox4.Focus();
                return;
            }
            /*if(email.IndexOf("@")==-1 || email.IndexOf(".")==-1)
            {
                MessageBox.Show("Please Enter Valid Email Address.", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                textBox4.Focus();
                return;
            }*/
            bool male=Maleradio.Checked;
            bool female=Femaleradio.Checked;
            if (male == false && female == false)
            {
                MessageBox.Show("Please Select Your Gender.", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Please Enter Your Passowrd.", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                textBox5.Focus();
                return;
            }
            if (textBox5.Text.Length < 6 || textBox5.Text.Length > 15)
            {
                MessageBox.Show("Please enter a password of 6 - 15 digit!");
                textBox5.Focus();
                return;
            }
            if (textBox2.Text.Length < 6 || textBox2.Text.Length > 15)
            {
                MessageBox.Show("Please enter a user name of 6 - 15 digit!");
                textBox2.Focus();
                return;
            }
            /*if (user.UserName == textBox2.Text)
            {
                MessageBox.Show("This user name is already in use. Please try another.", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                textBox5.Focus();
                return;
            }*/
            else
            {
                user.Name = textBox1.Text;
                user.UserName = textBox2.Text;
                if (r.IsMatch(email))
                {
                    user.Email = textBox4.Text;
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Email Address.", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    textBox4.Focus();
                    return;
                }
                user.Password = textBox5.Text;
                user.BirthDate = "" + dateTimePicker2.Value.Day + "." + dateTimePicker2.Value.Month + "." + dateTimePicker2.Value.Year;
                string value = "";
                bool a = Maleradio.Checked;
                if (a == true)
                {
                    value = Maleradio.Text;
                }
                else
                {
                    value = Femaleradio.Text;
                }
                user.Gender = value;
                user.Score = 0;
                user.ChapterCompleted = 0;
                DB.UserInfos.InsertOnSubmit(user);
                DB.SubmitChanges();
                MessageBox.Show("You Have Successfully Registered.", "Response");

                this.Hide();
                login = new LogIn();
                login.Show();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void Gender_Click(object sender, EventArgs e)
        {

        }

        private void agecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {
        
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void Maleradio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
