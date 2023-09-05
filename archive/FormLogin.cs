using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace archive
{
    public partial class FormLogin : Form
    {
        ArchieveDatabase Archieve = new ArchieveDatabase();
        public FormLogin( )
        {
            InitializeComponent();            
            FillCmbBxUserName();
        }
        int counter;
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void FillCmbBxUserName()
        {
            DataTable Dt = new DataTable();
            Dt = Archieve.QueryExecute("select name from login ORDER BY number ASC");
            for (int Index = 0; Index < Dt.Rows.Count; Index++)
            {
                CmbBxUserName.Items.Add(Dt.Rows[Index][0]);
            }
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void txtUsername_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void Login ()
        {
            counter = 0;
            try
            {
                //open the connection
                Archieve.con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //create command
            DataTable dt1 = new DataTable();
            MySqlCommand cmd = Archieve.con.CreateCommand();
            //enter select command by username and password
            cmd.CommandText = "select * from login where name ='" + CmbBxUserName.Text + "' and password = '" + txtPassword.Text + "' ";

            //create datatable
            DataTable dt = new DataTable();
            //create database adapter
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            //fill the dt with the recived data from da
            da.Fill(dt);
            //close database connection
            Archieve.con.Close();
            //set counter by number of rows of selected user and password found in database
            counter = dt.Rows.Count;
            //if data not found print error
            if (counter == 0)
            {
                lblerr.Visible = true;
                lblerr.Text = "Your user name or password does not exit";
            }
            //if data found open form2
            else
            {
                FormMain mainForm = new FormMain(CmbBxUserName.Text, txtPassword.Text);
                this.Hide();
                mainForm.Show();
            }
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            Login();
        }
    }
}
