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
    public partial class BasicTest : Form
    {
        LearnCDataContext DB = new LearnCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\STUDY\7TH SEMESTER\Object Oriented Programming 2\Project\Codes\LearnC\LearnC\LearnC.mdf;Integrated Security=True;Connect Timeout=30");

        public int duration = 60;

        public BasicTest()
        {
            InitializeComponent();
        }

        private void q1submit_Click(object sender, EventArgs e)
        {

        }

        private void q1submit_Click_1(object sender, EventArgs e)
        {
            bool ans = q101.Checked;
            if (ans == true)
            {
                Profile.Score++;

                var query = from o in DB.UserInfos
                            where o.UserName == LogIn.loginName
                            select o;

                UserInfo user = new UserInfo();
                user = query.First();

                user.Score = Profile.Score + 1;
                DB.SubmitChanges();
                MessageBox.Show("The answer is correct.");
            }
            else
            {
                MessageBox.Show("The answer is wrong.");
            }
            q1submit.Enabled = false;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TestTopics test = new TestTopics();
            test.Show();
        }

        private void q2submit_Click(object sender, EventArgs e)
        {
            bool ans = q203.Checked;
            if (ans == true)
            {
                Profile.Score++;

                var query = from o in DB.UserInfos
                            where o.UserName == LogIn.loginName
                            select o;

                UserInfo user = new UserInfo();
                user = query.First();

                user.Score = Profile.Score + 1;
                DB.SubmitChanges();
                MessageBox.Show("The answer is correct.");
            }
            else 
            {
                MessageBox.Show("The answer is wrong");
            }
            q2submit.Enabled = false;
        }

        private void q601_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonbasicfinish_Click(object sender, EventArgs e)
        {
            Profile.Finish++;

            var query = from o in DB.UserInfos
                        where o.UserName == LogIn.loginName
                        select o;

            UserInfo user = new UserInfo();
            user = query.First();

            user.ChapterCompleted = Profile.Finish;
            DB.SubmitChanges();
            buttonbasicfinish.Enabled = false;

            this.Hide();
            TestTopics test = new TestTopics();
            test.buttonbasictest.Enabled = false;
            test.buttonconditiontest.Enabled = true;
            test.buttonlooptest.Enabled = false;
            test.buttonarraytest.Enabled = false;
            test.buttonpointertest.Enabled = false;
            test.buttonfunctiontest.Enabled = false;
            test.buttonCertificate.Enabled = false;
            test.Show();
        }

        private void tabPagebasic2_Click(object sender, EventArgs e)
        {
            /*buttonbasicfinish.Enabled = false;
            if(q1submit.Enabled==false && q2submit.Enabled==false && q3submit.Enabled==false && q4submit.Enabled==false && q5submit.Enabled==false && q6submit.Enabled==false && q7submit.Enabled==false && q8submit.Enabled==false)
            {
                buttonbasicfinish.Enabled = true;
            }*/
        }

        private void q3submit_Click(object sender, EventArgs e)
        {
            bool ans = q304.Checked;
            if (ans == true)
            {
                Profile.Score++;

                var query = from o in DB.UserInfos
                            where o.UserName == LogIn.loginName
                            select o;

                UserInfo user = new UserInfo();
                user = query.First();

                user.Score = Profile.Score + 1;
                DB.SubmitChanges();
                MessageBox.Show("The answer is correct.");
            }
            else
            {
                MessageBox.Show("The answer is wrong");
            }
            q3submit.Enabled = false;
        }

        private void q4submit_Click(object sender, EventArgs e)
        {
            bool ans = q402.Checked;
            if (ans == true)
            {
                Profile.Score++;

                var query = from o in DB.UserInfos
                            where o.UserName == LogIn.loginName
                            select o;

                UserInfo user = new UserInfo();
                user = query.First();

                user.Score = Profile.Score + 1;
                DB.SubmitChanges();
                MessageBox.Show("The answer is correct.");
            }
            else
            {
                MessageBox.Show("The answer is wrong");
            }
            q4submit.Enabled = false;
        }

        private void q5submit_Click(object sender, EventArgs e)
        {
            bool ans = q501.Checked;
            if (ans == true)
            {
                Profile.Score++;

                var query = from o in DB.UserInfos
                            where o.UserName == LogIn.loginName
                            select o;

                UserInfo user = new UserInfo();
                user = query.First();

                user.Score = Profile.Score + 1;
                DB.SubmitChanges();
                MessageBox.Show("The answer is correct.");
            }
            else
            {
                MessageBox.Show("The answer is wrong");
            }
            q5submit.Enabled = false;
        }

        private void q6submit_Click(object sender, EventArgs e)
        {
            bool ans = q602.Checked;
            if (ans == true)
            {
                Profile.Score++;

                var query = from o in DB.UserInfos
                            where o.UserName == LogIn.loginName
                            select o;

                UserInfo user = new UserInfo();
                user = query.First();

                user.Score = Profile.Score + 1;
                DB.SubmitChanges();
                MessageBox.Show("The answer is correct.");
            }
            else
            {
                MessageBox.Show("The answer is wrong");
            }
            q6submit.Enabled = false;
        }

        private void q7submit_Click(object sender, EventArgs e)
        {
            bool ans = q702.Checked;
            if (ans == true)
            {
                Profile.Score++;

                var query = from o in DB.UserInfos
                            where o.UserName == LogIn.loginName
                            select o;

                UserInfo user = new UserInfo();
                user = query.First();

                user.Score = Profile.Score + 1;
                DB.SubmitChanges();
                MessageBox.Show("The answer is correct.");
            }
            else
            {
                MessageBox.Show("The answer is wrong");
            }
            q7submit.Enabled = false;
        }

        private void q8submit_Click(object sender, EventArgs e)
        {
            bool ans = q802.Checked;
            if (ans == true)
            {
                Profile.Score++;

                var query = from o in DB.UserInfos
                            where o.UserName == LogIn.loginName
                            select o;

                UserInfo user = new UserInfo();
                user = query.First();

                user.Score = Profile.Score + 1;
                DB.SubmitChanges();
                MessageBox.Show("The answer is correct.");
            }
            else
            {
                MessageBox.Show("The answer is wrong");
            }
            q8submit.Enabled = false;
        }

        private void BasicTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void timerBasic1_Tick(object sender, EventArgs e)
        {
            duration--;
            textBoxBasicTime1.Text = duration.ToString();
            textBoxBasicTime2.Text = duration.ToString();
            if (duration == 0)
            {
                timerBasic1.Stop();
                if (buttonbasicfinish.Enabled == false)
                {

                }
                else
                {
                    MessageBox.Show("Time Out.");
                    Profile.Finish++;

                    var query = from o in DB.UserInfos
                                where o.UserName == LogIn.loginName
                                select o;

                    UserInfo user = new UserInfo();
                    user = query.First();

                    user.ChapterCompleted = Profile.Finish;
                    DB.SubmitChanges();
                    buttonbasicfinish.Enabled = false;

                    this.Hide();
                    TestTopics test = new TestTopics();
                    test.buttonbasictest.Enabled = false;
                    test.buttonconditiontest.Enabled = true;
                    test.buttonlooptest.Enabled = false;
                    test.buttonarraytest.Enabled = false;
                    test.buttonpointertest.Enabled = false;
                    test.buttonfunctiontest.Enabled = false;
                    test.buttonCertificate.Enabled = false;
                    test.Show();
                }
            }
        }
    }
}
