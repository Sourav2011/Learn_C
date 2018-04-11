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
    public partial class ConditionalStatementsTest : Form
    {
        LearnCDataContext DB = new LearnCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\STUDY\7TH SEMESTER\Object Oriented Programming 2\Project\Codes\LearnC\LearnC\LearnC.mdf;Integrated Security=True;Connect Timeout=30");

        public int duration = 60;

        public ConditionalStatementsTest()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPageconditiontest1_Click(object sender, EventArgs e)
        {

        }

        private void tabPageconditiontest2_Click(object sender, EventArgs e)
        {
            /*buttonConditionalFinish.Enabled = false;
            if (q1submit.Enabled == false && q2submit.Enabled == false && q3submit.Enabled == false && q4submit.Enabled == false && q5submit.Enabled == false && q6submit.Enabled == false)
            {
                buttonConditionalFinish.Enabled = true;
            }*/
        }

        private void labelConditionalq1_Click(object sender, EventArgs e)
        {

        }

        private void q101_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void q102_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void q104_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void q103_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void q1submit_Click(object sender, EventArgs e)
        {

        }

        private void labelConditionalq2_Click(object sender, EventArgs e)
        {

        }

        private void q202_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void q201_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void q204_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void q203_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void q2submit_Click(object sender, EventArgs e)
        {

        }

        private void lebelConditionalq3_Click(object sender, EventArgs e)
        {

        }

        private void q302_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void q301_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void q304_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void q303_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void q3submit_Click(object sender, EventArgs e)
        {

        }

        private void labelconditionalq4_Click(object sender, EventArgs e)
        {

        }

        private void q402_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void q401_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void q404_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void q403_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void q4submit_Click(object sender, EventArgs e)
        {

        }

        private void q102_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void labelConditioanlq5l1_Click(object sender, EventArgs e)
        {

        }

        private void buttonConditionalFinish_Click(object sender, EventArgs e)
        {
            Profile.Finish++;

            var query = from o in DB.UserInfos
                        where o.UserName == LogIn.loginName
                        select o;

            UserInfo user = new UserInfo();
            user = query.First();

            user.ChapterCompleted = Profile.Finish;
            DB.SubmitChanges();
            buttonConditionalFinish.Enabled = false;

            this.Hide();
            TestTopics test = new TestTopics();
            test.buttonbasictest.Enabled = false;
            test.buttonconditiontest.Enabled = false;
            test.buttonlooptest.Enabled = true;
            test.buttonarraytest.Enabled = false;
            test.buttonpointertest.Enabled = false;
            test.buttonfunctiontest.Enabled = false;
            test.buttonCertificate.Enabled = false;
            test.Show();
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

        private void q2submit_Click_1(object sender, EventArgs e)
        {
            bool ans = q202.Checked;
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
            q2submit.Enabled = false;
        }

        private void q3submit_Click_1(object sender, EventArgs e)
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
                MessageBox.Show("The answer is wrong.");
            }
            q3submit.Enabled = false;
        }

        private void q4submit_Click_1(object sender, EventArgs e)
        {
            bool ans = q401.Checked;
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
                MessageBox.Show("The answer is wrong.");
            }
            q5submit.Enabled = false;
        }

        private void q6submit_Click(object sender, EventArgs e)
        {
            bool ans = q604.Checked;
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
            q6submit.Enabled = false;
        }

        private void ConditionalStatementsTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void timerConditionalStatements_Tick(object sender, EventArgs e)
        {
            duration--;
            textBoxConditional1.Text = duration.ToString();
            textBoxConditionalTime2.Text = duration.ToString();
            if (duration == 0)
            {
                timerConditionalStatements.Stop();
                if (buttonConditionalFinish.Enabled == false)
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
                    buttonConditionalFinish.Enabled = false;

                    this.Hide();
                    TestTopics test = new TestTopics();
                    test.buttonbasictest.Enabled = false;
                    test.buttonconditiontest.Enabled = false;
                    test.buttonlooptest.Enabled = true;
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
