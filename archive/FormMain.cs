using System;
using System.Data;
using System.Timers;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Tulpep.NotificationWindow;
using System.Media;


namespace archive
{
    public partial class FormMain : Form
    {
       
        ArchieveDatabase Archieve = new ArchieveDatabase();
        static string username;
        static string pass;
        static bool FormFollowingOpen = false;
        static bool FormReminderOpen = false;
        string admin;
        string following;
        string user;
        string org;
        string conn;
        string job;
        int counter;
        string history;
        private System.Timers.Timer aTimer;

        public FormMain(string name,string password)
        {
           
            InitializeComponent();
            txtname.Text =name ;
            txtpassword.Text = password;
            username = name;
            pass = password;
            InitTimer(name);

            
            
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
            //MessageBox.Show(System.Security.Principal.WindowsIdentity.GetCurrent().Name);
            //MessageBox.Show(Environment.UserName);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
            FormImport insertform = new FormImport(txtname.Text,txtpassword.Text);
            insertform.Show();
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            FormSearch Formsearch = new FormSearch(txtname.Text, txtpassword.Text,null);
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
            FormFollowing formFollowing = new FormFollowing(txtname.Text, txtpassword.Text,DateTime.Now,DateTime.Now);
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

        /*
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            FollowingOrgs followingOrgsPage = new FollowingOrgs();
            followingOrgsPage.Show();
        }
        */
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            FormReportItem item = new FormReportItem();
            item.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (username == "لواء / محمد فرج" || username == "مصطفى الجندي")
            {
                FormReminders form = new FormReminders();
                form.Show();
            }
            else
            {
                MessageBox.Show("غير مسموح لك بدخول هذة الصفحة");
            }
        }

        private static void OnTimedFollowingEvent(object source, ElapsedEventArgs e)
        {


            //TimeSpan end = new TimeSpan(12, 30, 0); //13 o'clock
            TimeSpan end = new TimeSpan(7, 30, 0); //13 o'clock
            TimeSpan now = DateTime.Now.TimeOfDay;

            DateTime today = DateTime.Now;
            DateTime tomorrow = today.AddDays(1);
            if (now > end  && !FormFollowingOpen)
            {
                FormFollowingOpen = true;
                FormMain.MakePopUp("عرض تقرير متابعة غدا");

                Application.Run(new FormFollowing(username, pass,tomorrow,tomorrow));
            }
            
        }

        private static void OnTimedReminderEvent(object source, ElapsedEventArgs e)
        {

            //change time to 7
            TimeSpan end = new TimeSpan(7, 0, 0); //7o'clock
            TimeSpan now = DateTime.Now.TimeOfDay;

            DateTime today = DateTime.Now;
           
            if (now > end && !FormFollowingOpen)
            {
                FormFollowingOpen = true;
                FormMain.MakePopUp("عرض متابعات اليوم");
                Console.WriteLine("showing pop up");
                //open form reminders
                Application.Run(new FormReminders(username,pass,DateTime.Today.ToString("d")));
               
            }

        }

        private void InitTimer(string name)
        {
            Console.WriteLine(name);
            if (name == "عميد / ياسر فاروق")
            {
                aTimer = new System.Timers.Timer(1 * 60 * 1000); //one hour in milliseconds
                aTimer.Elapsed += new ElapsedEventHandler(OnTimedFollowingEvent);
                aTimer.Start();
            }
            else if (name == "لواء / محمد فرج" || name == "مصطفى الجندي")
            {
                aTimer = new System.Timers.Timer(5 * 1000); //quarter hour in milliseconds
                aTimer.Elapsed += new ElapsedEventHandler(OnTimedReminderEvent);
                aTimer.Start();
            }

        }

        static void MakePopUp(string text)
        {
            PopupNotifier popup = new PopupNotifier();
      
            popup.ContentText = text;
            
            popup.ShowCloseButton = true;
            popup.ShowOptionsButton = true;
            popup.ContentFont = new Font("Tahoma", 15);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.TitleColor = Color.White;
            popup.BorderColor = Color.CornflowerBlue;
            popup.BodyColor = Color.CornflowerBlue;
            popup.ContentColor = Color.DarkBlue;       // should be
            popup.ContentHoverColor = Color.DarkBlue;   // the same
            popup.AnimationDuration = 1000;
            popup.AnimationInterval = 1;
            popup.HeaderColor = Color.DodgerBlue;
            popup.ButtonHoverColor = Color.CadetBlue;
            popup.ContentPadding = new Padding(2);
            popup.ShowGrip = true;
            popup.Scroll = true;
            
            popup.Popup();// show  

            SoundPlayer splayer = new SoundPlayer(@"11.wav");
            splayer.Play();
            //MessageBox.Show(text);
        }

    }
}
