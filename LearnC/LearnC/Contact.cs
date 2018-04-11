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
    public partial class Contact : Form
    {
        LearnCDataContext DB = new LearnCDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\STUDY\7TH SEMESTER\Object Oriented Programming 2\Project\Codes\LearnC\LearnC\LearnC.mdf;Integrated Security=True;Connect Timeout=30");
        
        string paths;
        string fileName;
        OpenFileDialog open;

        public Contact()
        {
            InitializeComponent();

            comboBoxAdmin.DataSource = DB.Admins;
            comboBoxAdmin.DisplayMember = "Name";
            comboBoxAdmin.ValueMember = "Id";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        /*private void buttonUpload_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.InitialDirectory = "C:\\";
            open.Filter = "Image Files(*.jpg)|*.jpg|All Files(*.*)|*.*";
            open.FilterIndex = 1;
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (open.CheckFileExists)
                {
                    paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    fileName = System.IO.Path.GetFileName(open.FileName);
                    pictureBox1.ImageLocation = open.FileName.ToString();
                }
            }
        }*/

        /*private void buttonADD_Click(object sender, EventArgs e)
        {
            paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            Admin admin = new Admin();
            admin.Name = textBoxAdminName.Text;
            admin.Email = textBoxAdminEmail.Text;
            admin.Image = @"E:\STUDY\7TH SEMESTER\Object Oriented Programming 2\Project\Pictures\" + fileName;
            DB.Admins.InsertOnSubmit(admin);
            DB.SubmitChanges();
            MessageBox.Show("Data Inserted!");
        }*/

        private void comboBoxAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(comboBoxAdmin.SelectedValue.ToString());
            Admin admin = DB.Admins.SingleOrDefault(x => x.Id == id);
            AdminInfo();
            
        }

        private void Contact_Load(object sender, EventArgs e)
        {
           /* paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            Admin admin = new Admin();
            var query = from o in DB.Admins
                        select o;
            admin = query.First();
            textBoxAdminName.Text = admin.Name;
            textBoxAdminEmail.Text = admin.Email;
            string temp = string.Format("{0}", admin.Image);
            pictureBox1.ImageLocation = temp; */
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AdminInfo()
        {
            string t = comboBoxAdmin.Text;
            paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            Admin admin = new Admin();
            var query = from o in DB.Admins
                        where o.Name==comboBoxAdmin.Text
                        select o;
            
            admin = query.First();
            textBoxAdminName.Text = admin.Name;
            textBoxAdminEmail.Text = admin.Email;
            string temp = string.Format("{0}", admin.Image);
            pictureBox1.ImageLocation = temp;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chapter ch = new Chapter();
            ch.Show();
        }

        private void Contact_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
