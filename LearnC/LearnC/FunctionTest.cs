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
    public partial class FunctionTest : Form
    {
        LearnCDataContext DB = new LearnCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\STUDY\7TH SEMESTER\Object Oriented Programming 2\Project\Codes\LearnC\LearnC\LearnC.mdf;Integrated Security=True;Connect Timeout=30");

        public int duration = 60;

        public FunctionTest()
        {
            InitializeComponent();
        }

        private void buttonFunctionFinish_Click(object sender, EventArgs e)
        {
            Profile.Finish++;

            var query = from o in DB.UserInfos
                        where o.UserName == LogIn.loginName
                        select o;

            UserInfo user = new UserInfo();
            user = query.First();

            user.ChapterCompleted = Profile.Finish;
            DB.SubmitChanges();
            buttonFunctionFinish.Enabled = false;

            this.Hide();
            TestTopics test = new TestTopics();
            test.buttonbasictest.Enabled = false;
            test.buttonconditiontest.Enabled = false;
            test.buttonlooptest.Enabled = false;
            test.buttonarraytest.Enabled = false;
            test.buttonpointertest.Enabled = false;
            test.buttonfunctiontest.Enabled = false;
            if (user.Score >= 20)
            {
                test.buttonCertificate.Enabled = true;
            }
            else
            {
                MessageBox.Show("Sorry,you have failed to get reward.", "Message");
                test.buttonCertificate.Enabled = false;
            }
            test.Show();
        }

        private void q1submit_Click(object sender, EventArgs e)
        {
            bool ans = q103.Checked;
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
            q1submit.Enabled = false;
        }

        private void q2submit_Click(object sender, EventArgs e)
        {
            bool ans = q201.Checked;
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

        private void q3submit_Click(object sender, EventArgs e)
        {
            bool ans = q302.Checked;
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
            bool ans = q504.Checked;
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

        private void FunctionTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void q401_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timerFunction_Tick(object sender, EventArgs e)
        {
            duration--;
            textBoxFunction1.Text = duration.ToString();
            textBoxFunction2.Text = duration.ToString();
            if (duration == 0)
            {
                timerFunction.Stop();
                if (buttonFunctionFinish.Enabled == false)
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
                    buttonFunctionFinish.Enabled = false;

                    this.Hide();
                    TestTopics test = new TestTopics();
                    test.buttonbasictest.Enabled = false;
                    test.buttonconditiontest.Enabled = false;
                    test.buttonlooptest.Enabled = false;
                    test.buttonarraytest.Enabled = false;
                    test.buttonpointertest.Enabled = false;
                    test.buttonfunctiontest.Enabled = false;
                    if (user.Score >= 20)
                    {
                        test.buttonCertificate.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Sorry,you have failed to get reward.", "Message");
                        test.buttonCertificate.Enabled = false;
                    }
                    test.Show();
                }
            }
        }
    }
}
