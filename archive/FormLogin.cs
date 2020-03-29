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

namespace archive
{
    public partial class FormLogin : Form
    {
        //MySqlConnection con = new MySqlConnection("Server = 192.168.137.50 ; Database = archieve ; uid = developer ; pwd =developer ");
        //MySqlConnection con = new MySqlConnection("Server = localhost ; Database = archieve ; uid = root ; pwd =root ");
        ArchieveDatabase Archieve = new ArchieveDatabase();

        public FormLogin( )
        {
            InitializeComponent();

            txtPassword.isPassword = true;
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
            Dt = Archieve.QuaryExecute("select name from login ORDER BY number ASC");
            for (int Index = 0; Index < Dt.Rows.Count; Index++)
            {
                CmbBxUserName.Items.Add(Dt.Rows[Index][0]);
            }
          //  CmbBxUserName.Text = "اختر المستخدم";
            //CmbBxUserName.Sorted = true;
        }
        //private void CmbBxUserName_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (lstBxUsers.Items.Contains(CmbBxUserName.Text) == false)
        //    {
        //        lstBxUsers.Items.Add(CmbBxUserName.Text);
        //    }
        //    //CmbBxUserName.Items.Remove(CmbBxUserName.Text);
        //}

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

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


            //else if (e.KeyCode == Keys.F1)
            //{
            //    FormMain mainForm = new FormMain("Admin", "1");
            //    this.Hide();
            //    mainForm.Show();

            //}
        }

        private void txtUsername_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }

            //else if (e.KeyCode == Keys.F1)
            //{
            //    FormMain mainForm = new FormMain("Admin", "1");
            //    this.Hide();
            //   mainForm.Show();

            //}
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

                lblerr.Text = "Your user name or password is not exit";

            }
            //if data found open form2
            else
            {
                txtadmin.Text = dt.Rows[0]["admin"].ToString();


                FormMain mainForm = new FormMain(CmbBxUserName.Text, txtPassword.Text);
                this.Hide();
                mainForm.Show();


            }
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {

            Login();
        }

        private void PanelServer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
         
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
