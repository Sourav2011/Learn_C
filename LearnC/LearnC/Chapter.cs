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
    public partial class Chapter : Form
    {
        LearnCDataContext DB = new LearnCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\STUDY\7TH SEMESTER\Object Oriented Programming 2\Project\Codes\LearnC\LearnC\LearnC.mdf;Integrated Security=True;Connect Timeout=30");

        public Chapter()
        {
            InitializeComponent();
        }

        private void Basic_Click(object sender, EventArgs e)
        {

        }

        private void buttonbasic_Click(object sender, EventArgs e)
        {
            this.Hide();
            BasicConcepts basicconcept = new BasicConcepts();
            basicconcept.Show();
        }

        private void battoncondition_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConditionalStatements conditionalstatement = new ConditionalStatements();
            conditionalstatement.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void buttonfunction_Click(object sender, EventArgs e)
        {
            this.Hide();
            Function function = new Function();
            function.Show();
        }

        private void buttonloop_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loop loop = new Loop();
            loop.Show();
        }

        private void buttonarray_Click(object sender, EventArgs e)
        {
            this.Hide();
            Array array = new Array();
            array.Show();
        }

        private void buttonpointer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pointer pointer = new Pointer();
            pointer.Show();
        }

        private void Chapter_Load(object sender, EventArgs e)
        {
           
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn login = new LogIn();
            login.Show();
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 home = new Form1();
            home.Show();

        }

        private void profile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile();
            profile.Show();
        }

        private void buttonloop_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Loop loop = new Loop();
            loop.Show();
        }

        private void search_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search search = new Search();
            search.Show();
        }

        private void buttonpointer_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Pointer pointer = new Pointer();
            pointer.Show();
        }

        private void buttonarray_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Array array = new Array(); 
            array.Show();
        }

        private void paneluserhome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void About_Click(object sender, EventArgs e)
        {
            this.Hide();
            About about = new About();
            about.Show();
        }

        private void home_MouseHover(object sender, EventArgs e)
        {
            this.home.BackColor = System.Drawing.Color.SandyBrown;
        }

        private void home_MouseLeave(object sender, EventArgs e)
        {
            this.home.BackColor = System.Drawing.Color.Brown;
        }

        private void profile_MouseHover(object sender, EventArgs e)
        {
            this.profile.BackColor = System.Drawing.Color.SandyBrown;
        }

        private void profile_MouseLeave(object sender, EventArgs e)
        {
            this.profile.BackColor = System.Drawing.Color.Brown;
        }

        private void search_MouseHover(object sender, EventArgs e)
        {
            this.search.BackColor = System.Drawing.Color.SandyBrown;
        }

        private void search_MouseLeave(object sender, EventArgs e)
        {
            this.search.BackColor = System.Drawing.Color.Brown;
        }

        private void About_MouseHover(object sender, EventArgs e)
        {
            this.About.BackColor = System.Drawing.Color.SandyBrown;
        }

        private void About_MouseLeave(object sender, EventArgs e)
        {
            this.About.BackColor = System.Drawing.Color.Brown;
        }

        private void Contact_MouseHover(object sender, EventArgs e)
        {
            this.Contact.BackColor = System.Drawing.Color.SandyBrown;
        }

        private void Contact_MouseLeave(object sender, EventArgs e)
        {
            this.Contact.BackColor = System.Drawing.Color.Brown;
        }

        private void logout_MouseHover(object sender, EventArgs e)
        {
            this.logout.BackColor = System.Drawing.Color.SandyBrown;
        }

        private void logout_MouseLeave(object sender, EventArgs e)
        {
            this.logout.BackColor = System.Drawing.Color.Brown;
        }

        private void Contact_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contact contact = new Contact();
            contact.Show();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            this.Hide();

            var query1 = from o in DB.UserInfos
                         where o.UserName == LogIn.loginName
                         select o;

            UserInfo user = new UserInfo();
            user = query1.First();

            Profile.Finish = user.ChapterCompleted;
            TestTopics test = new TestTopics();

            if (Profile.Finish == 0)
            {
                test.buttonconditiontest.Enabled = false;
                test.buttonlooptest.Enabled = false;
                test.buttonarraytest.Enabled = false;
                test.buttonpointertest.Enabled = false;
                test.buttonfunctiontest.Enabled = false;
                test.buttonCertificate.Enabled = false;
            }
            if (Profile.Finish == 1)
            {
                test.buttonbasictest.Enabled = false;
                test.buttonlooptest.Enabled = false;
                test.buttonarraytest.Enabled = false;
                test.buttonpointertest.Enabled = false;
                test.buttonfunctiontest.Enabled = false;
                test.buttonCertificate.Enabled = false;
            }
            if (Profile.Finish == 2)
            {
                test.buttonbasictest.Enabled = false;
                test.buttonconditiontest.Enabled = false;
                test.buttonarraytest.Enabled = false;
                test.buttonpointertest.Enabled = false;
                test.buttonfunctiontest.Enabled = false;
                test.buttonCertificate.Enabled = false;
            }
            if (Profile.Finish == 3)
            {
                test.buttonbasictest.Enabled = false;
                test.buttonconditiontest.Enabled = false;
                test.buttonlooptest.Enabled = false;
                test.buttonpointertest.Enabled = false;
                test.buttonfunctiontest.Enabled = false;
                test.buttonCertificate.Enabled = false;
            }
            if (Profile.Finish == 4)
            {
                test.buttonbasictest.Enabled = false;
                test.buttonconditiontest.Enabled = false;
                test.buttonlooptest.Enabled = false;
                test.buttonarraytest.Enabled = false;
                test.buttonfunctiontest.Enabled = false;
                test.buttonCertificate.Enabled = false;
            }
            if (Profile.Finish == 5)
            {
                test.buttonbasictest.Enabled = false;
                test.buttonconditiontest.Enabled = false;
                test.buttonlooptest.Enabled = false;
                test.buttonarraytest.Enabled = false;
                test.buttonpointertest.Enabled = false;
                test.buttonCertificate.Enabled = false;
            }
            if (Profile.Finish == 6)
            {
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
            }
            if (user.Score < 20)
            {
                test.buttonCertificate.Enabled = false;
            }
            test.Show();
        }

        private void buttonTest_MouseHover(object sender, EventArgs e)
        {
            this.buttonTest.BackColor = System.Drawing.Color.SandyBrown;
        }

        private void buttonTest_MouseLeave(object sender, EventArgs e)
        {
            this.buttonTest.BackColor = System.Drawing.Color.Brown;
        }

        private void Chapter_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
