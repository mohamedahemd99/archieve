using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Linq;

namespace archive
{
    public partial class FormMain : Form
    {
       
        ArchieveDatabase Archieve = new ArchieveDatabase();

        string admin;
        string following;
        string user;
        string org;
        string conn;
        string job;
        int counter;
        string history;

        public FormMain(string name,string password)
        {
           
            InitializeComponent();
            txtname.Text =name ;
            txtpassword.Text = password;


            Archieve.con.Open();
            DataTable dt1 = new DataTable();
            MySqlCommand cmd = Archieve.con.CreateCommand();
            //enter select command by username and password
            cmd.CommandText = "select * from login where name ='" + txtname.Text + "' and password = '" + txtpassword.Text + "' ";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt1);
            Archieve.con.Close();
            if (dt1.Rows.Count == 0)
            {
                admin = "1";
                following = "1";
                user = "1";
                org = "1";
                conn = "1";
                job = "";
            }
            else
            {
                admin = dt1.Rows[0]["admin"].ToString();
                following = dt1.Rows[0]["following"].ToString();
                user = dt1.Rows[0]["user"].ToString();
                org = dt1.Rows[0]["org"].ToString();
                conn = dt1.Rows[0]["con"].ToString();
                job = dt1.Rows[0]["job"].ToString();
                history = dt1.Rows[0]["history"].ToString();
            }

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
            FormImport insertform = new FormImport(txtname.Text,txtpassword.Text);
            insertform.Show();
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            FormSearch Formsearch = new FormSearch(txtname.Text, txtpassword.Text);
            Formsearch.Show();
            Formsearch.BringToFront();
           // this.SendToBack();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            if (conn == "1")
            {
                FormConection formconection = new FormConection(txtname.Text);
                formconection.Show();
            }
            else
            {
                MessageBox.Show("غير مسموح لك بدخول هذة الصفحة");
            }

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            
                FormOrg formorg = new FormOrg(txtname.Text, txtpassword.Text);
                formorg.Show();
            
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            
                FormUser formuser = new FormUser(txtname.Text, txtpassword.Text);
                formuser.Show();
            

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
          
                FormFile formfile = new FormFile(txtname.Text, txtpassword.Text);
            formfile.Show();
            
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            FormExport insertform = new FormExport(txtname.Text, txtpassword.Text);
            insertform.Show();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
                FormFollowing formFollowing = new FormFollowing(txtname.Text, txtpassword.Text);
                formFollowing.Show();

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            if (following == "1")
            {
                FormErgent formergent = new FormErgent(txtname.Text);
                formergent.Show();
            }
            else
            {
                MessageBox.Show("غير مسموح لك بدخول هذة الصفحة");
            }
        }

        private void bunifuThinButton210_Click(object sender, EventArgs e)
        {
            if (admin == "1")
            {

                FormAuthorities formuser1 = new FormAuthorities(txtname.Text, txtpassword.Text);
                formuser1.Show();
            }
              if (admin == "0")
                {
                MessageBox.Show("غير مسموح لك بدخول هذة الصفحة");

            }

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnhistory_Click(object sender, EventArgs e)
        {
            if (history == "1")
            {

                FormHistory formhistory = new FormHistory();
                formhistory.Show();
            }
            if (history == "0")
            {
                MessageBox.Show("غير مسموح لك بدخول هذة الصفحة");

            }
        }

        private void bunifuThinButton23_Click_1(object sender, EventArgs e)
        {
           FormVisit formVisit = new FormVisit(txtname.Text, txtpassword.Text);
            formVisit.Show();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FormReports formReports = new FormReports(txtname.Text, txtpassword.Text);
            formReports.Show();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            FollowingOrgs followingOrgsPage = new FollowingOrgs();
            followingOrgsPage.Show();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            FormReportItem item = new FormReportItem();
            item.Show();
        }
    }
}
