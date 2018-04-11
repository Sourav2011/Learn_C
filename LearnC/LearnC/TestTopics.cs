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
    public partial class TestTopics : Form
    {
        LearnCDataContext DB = new LearnCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\STUDY\7TH SEMESTER\Object Oriented Programming 2\Project\Codes\LearnC\LearnC\LearnC.mdf;Integrated Security=True;Connect Timeout=30");

        public TestTopics()
        {
            InitializeComponent();
        }

        private void buttonbasictest_Click(object sender, EventArgs e)
        {
            this.Hide();
            BasicTest basictest = new BasicTest();
            basictest.Show();

            basictest.timerBasic1.Enabled = true;
            basictest.timerBasic1.Start();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chapter ch = new Chapter();
            ch.Show();
        }

        private void TestTopics_Load(object sender, EventArgs e)
        {
            /*UserInfo user = new UserInfo();
            var query = from o in DB.UserInfos
                        where o.UserName == LogIn.loginName
                        select o;
            user = query.First();

            TestTopics test = new TestTopics();
            test.buttonconditiontest.Enabled = false;
            test.buttonlooptest.Enabled = false;
            test.buttonarraytest.Enabled = false;
            test.buttonpointertest.Enabled = false;
            test.buttonfunctiontest.Enabled = false;

            ConditionalStatementsTest conditionalstatementstest=new ConditionalStatementsTest();
            LoopTest looptest=new LoopTest();
            ArrayTest arraytest=new ArrayTest();
            PointerTest pointertest= new PointerTest();
            FunctionTest functiontest=new FunctionTest();

            if (conditionalstatementstest.buttonConditionalFinish.Enabled == false)
            {
                test.buttonbasictest.Enabled = false;
                test.buttonconditiontest.Enabled = false;
                test.buttonlooptest.Enabled = true;
            }

            if (looptest.buttonLoopFinish.Enabled == false)
            {
                test.buttonbasictest.Enabled = false;
                test.buttonconditiontest.Enabled = false;
                test.buttonlooptest.Enabled = false;
                test.buttonarraytest.Enabled = true;
            }

            if (arraytest.buttonArrayFinish.Enabled == false)
            {
                test.buttonbasictest.Enabled = false;
                test.buttonconditiontest.Enabled = false;
                test.buttonlooptest.Enabled = false;
                test.buttonarraytest.Enabled = false;
                test.buttonpointertest.Enabled = true;
            }

            if (pointertest.buttonPointerFinish.Enabled == false)
            {
                test.buttonbasictest.Enabled = false;
                test.buttonconditiontest.Enabled = false;
                test.buttonlooptest.Enabled = false;
                test.buttonarraytest.Enabled = false;
                test.buttonpointertest.Enabled = false;
                test.buttonfunctiontest.Enabled = true;
            }

            if (functiontest.buttonFunctionFinish.Enabled == false)
            {
                test.buttonbasictest.Enabled = false;
                test.buttonconditiontest.Enabled = false;
                test.buttonlooptest.Enabled = false;
                test.buttonarraytest.Enabled = false;
                test.buttonpointertest.Enabled = false;
                test.buttonfunctiontest.Enabled = false;
            }*/
        }

        private void buttonconditiontest_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConditionalStatementsTest conditionaltest = new ConditionalStatementsTest();
            conditionaltest.Show();

            conditionaltest.timerConditionalStatements.Enabled = true;
            conditionaltest.timerConditionalStatements.Start();
        }

        private void buttonlooptest_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoopTest looptest = new LoopTest();
            looptest.Show();

            looptest.timerLoop.Enabled = true;
            looptest.timerLoop.Start();
        }

        private void buttonarraytest_Click(object sender, EventArgs e)
        {
            this.Hide();
            ArrayTest arraytest = new ArrayTest();
            arraytest.Show();

            arraytest.timerArray.Enabled = true;
            arraytest.timerArray.Start();
        }

        private void buttonpointertest_Click(object sender, EventArgs e)
        {
            this.Hide();
            PointerTest pointertest = new PointerTest();
            pointertest.Show();

            pointertest.timerPointer.Enabled = true;
            pointertest.timerPointer.Start();
        }

        private void buttonfunctiontest_Click(object sender, EventArgs e)
        {
            this.Hide();
            FunctionTest functiontest = new FunctionTest();
            functiontest.Show();

            functiontest.timerFunction.Enabled = true;
            functiontest.timerFunction.Start();
        }

        private void buttonCertificate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Certificate certificate = new Certificate();
            certificate.Show();

            UserInfo user = new UserInfo();
            var query = from o in DB.UserInfos
                        where o.UserName == LogIn.loginName
                        select o;
            user = query.First();
            certificate.labelCertificate.Text = user.Name;
        }

        private void TestTopics_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
