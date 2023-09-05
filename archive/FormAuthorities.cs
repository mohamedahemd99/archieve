using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace archive
{
    public partial class FormAuthorities : Form
    {
        ArchieveDatabase Authorties = new ArchieveDatabase();
        string regist ;
        string edit ;
        string delete ;
        string following ;
        string user ;
        string org ;
        string conn ;
        string admin ;
        string files;
        string visit;
        string history;


        public FormAuthorities(string name, string password)
        {
           InitializeComponent();     
        }
        private void FormAuthorities_Load(object sender, EventArgs e)
        {
            FillCmbBxUserName();
            FillMyData();
            DgvUser.Columns[0].HeaderText = "اسم المستخدم";
            DgvUser.Columns[1].HeaderText = "الرقم السري" + "";
            DgvUser.Columns[10].HeaderText = "الاختصاص" + "";
            DgvUser.Columns[3].Visible = false;
            DgvUser.Columns[4].Visible = false;
            DgvUser.Columns[5].Visible = false;
            DgvUser.Columns[6].Visible = false;
            DgvUser.Columns[7].Visible = false;
            DgvUser.Columns[8].Visible = false;
            DgvUser.Columns[9].Visible = false;
            DgvUser.Columns[2].Visible = false;
            DgvUser.Columns[11].Visible = false;
            DgvUser.Columns[12].Visible = false;
            DgvUser.Columns[13].Visible = false;
            DgvUser.Columns[14].Visible = false;






        }
        void FillCmbBxUserName()
        {
            DataTable Dt = new DataTable();
            Dt = Authorties.QueryExecute("select username from users");
            for (int Index = 0; Index < Dt.Rows.Count; Index++)
            {
                CmbBxUserName.Items.Add(Dt.Rows[Index][0]);
            }
            CmbBxUserName.Text = "تحديد الاختصاص";
            //CmbBxUserName.Sorted = true;
        }
        void FillMyData()
        {
            DgvUser.DataSource = Authorties.QueryExecute("select * from login");
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text != "" && txtUsername.Text != "")
            {
                if (registchk.Checked.ToString() == "True")
                {
                    regist ="1" ;

                }
                else
                {
                    regist = "0";
                }


                if (editchk.Checked.ToString() == "True")
                {
                    edit = "1";

                }
                else
                {
                    edit = "0";
                }

                if (deletechk.Checked.ToString() == "True")
                {
                    delete = "1";

                }
                else
                {
                    delete = "0";
                }

                if (followingchk.Checked.ToString() == "True")
                {
                    following = "1";

                }
                else
                {
                    following = "0";
                }
                if (userchk.Checked.ToString() == "True")
                {
                    user = "1";

                }
                else
                {
                    user = "0";
                }


                if (orgchk.Checked.ToString() == "True")
                {
                    org = "1";

                }
                else
                {
                    org = "0";
                }
                if (conchk.Checked.ToString() == "True")
                {
                    conn = "1";

                }
                else
                {
                    conn = "0";
                }
                if (adminchk.Checked.ToString() == "True")
                {
                    admin = "1";

                }
                else
                {
                    admin = "0";
                }

                if (filesck.Checked.ToString() == "True")
                {
                    files = "1";

                }
                else
                {
                    files = "0";
                }
                if (visitck.Checked.ToString() == "True")
                {
                    visit = "1";

                }
                else
                {
                    visit = "0";
                }
                if (historychk.Checked.ToString() == "True")
                {
                    history = "1";

                }
                else
                {
                    history = "0";
                }


                try
                {

                 String insertQuery = "INSERT INTO login (name , password,admin,user,org,con,following,edit,register,remov,job,files,visit,history) VALUES ('" + txtUsername.Text + "','" + int.Parse(txtpassword.Text) + "','" + admin + "','" + user + "','" + org + "','" + conn + "','" + following + "','" + edit + "','" + regist + "','" + delete + "','" + CmbBxUserName.Text + "','" + files + "','" + visit + "','" + history + "')";
                    Authorties.con.Open();
                    MySqlCommand cmd = new MySqlCommand(insertQuery, Authorties.con);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                      
                        MessageBox.Show("تم ادخال البيانات بنجاح");
                        txtUsername.ResetText();
                        txtpassword.ResetText();
                        txtnewpassword.ResetText();
                        CmbBxUserName.ResetText();
                        registchk.Checked = false;
                        editchk.Checked = false;
                        deletechk.Checked = false;
                        followingchk.Checked = false;
                        userchk.Checked = false;
                        orgchk.Checked = false;
                        conchk.Checked = false;
                        adminchk.Checked = false;
                        filesck.Checked = false;
                        visitck.Checked = false;
                        historychk.Checked = false;
                        FillMyData();

                    }
                    else
                    {
                        MessageBox.Show("لم يتم ادخال البيانات");
                    }

                    Authorties.con.Close();
                }
                catch (Exception ex)
                {
                    Authorties.con.Close();
                    MessageBox.Show("هذه البيانات غير صحيحة");
                }
            }
            else
            {
                MessageBox.Show("من فضلك قم بادخال البيانات");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (registchk.Checked.ToString() == "True")
            {
                regist = "1";

            }
            else
            {
                regist = "0";
            }


            if (editchk.Checked.ToString() == "True")
            {
                edit = "1";

            }
            else
            {
                edit = "0";
            }

            if (deletechk.Checked.ToString() == "True")
            {
                delete = "1";

            }
            else
            {
                delete = "0";
            }

            if (followingchk.Checked.ToString() == "True")
            {
                following = "1";

            }
            else
            {
                following = "0";
            }
            if (userchk.Checked.ToString() == "True")
            {
                user = "1";

            }
            else
            {
                user = "0";
            }


            if (orgchk.Checked.ToString() == "True")
            {
                org = "1";

            }
            else
            {
                org = "0";
            }
            if (conchk.Checked.ToString() == "True")
            {
                conn = "1";

            }
            else
            {
                conn = "0";
            }
            if (adminchk.Checked.ToString() == "True")
            {
                admin = "1";

            }
            else
            {
                admin = "0";
            }
            if (filesck.Checked.ToString() == "True")
            {
                files = "1";

            }
            else
            {
                files = "0";
            }
            if (visitck.Checked.ToString() == "True")
            {
                visit = "1";

            }
            else
            {
                visit = "0";
            }
            if (historychk.Checked.ToString() == "True")
            {
                history = "1";

            }
            else
            {
                history = "0";
            }

            try
            {
                Authorties.con.Open();
               
                String DeleteQuery = "DELETE FROM  login  WHERE name= '" + txtUsername.Text + "'  or password = '" + int.Parse(txtpassword.Text) + "' ";
                String insertQuery = "INSERT INTO login (name , password,admin,user,org,con,following,edit,register,remov,job,files,visit,history) VALUES ('" + txtUsername.Text + "','" + int.Parse(txtnewpassword.Text) + "','" + admin + "','" + user + "','" + org + "','" + conn + "','" + following + "','" + edit + "','" + regist + "','" + delete + "','" + CmbBxUserName.Text + "','" + files + "','" + visit + "','" + history + "')";
                int Test1 = Authorties.MyExecuteNonQuery(DeleteQuery);
                int Test2 = Authorties.MyExecuteNonQuery(insertQuery);
                if (Test1 == 1 && Test2 == 1)
                {
                    MessageBox.Show("تم تعديل البيانات بنجاح");
                    FillMyData();

                }
                else
                {

                    MessageBox.Show("لم يتم التعديل");
                }

                Authorties.con.Close();


                txtUsername.ResetText();
                txtpassword.ResetText();
                txtnewpassword.ResetText();
                CmbBxUserName.ResetText();
                registchk.Checked = false;
                editchk.Checked = false;
                deletechk.Checked = false;
                followingchk.Checked = false;
                userchk.Checked = false;
                orgchk.Checked = false;
                conchk.Checked = false;
                adminchk.Checked = false;
                filesck.Checked = false;
                visitck.Checked = false;
                historychk.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Authorties.con.Close();

            }
        }

        private void btndelet_Click(object sender, EventArgs e)
        {
            try
            {
                String DeleteQuery = "DELETE FROM login WHERE password='" + int.Parse(txtpassword.Text) + "'and  name ='" + txtUsername.Text + "'";
                Authorties.con.Open();
                MySqlCommand cmd = new MySqlCommand(DeleteQuery, Authorties.con);
                if (cmd.ExecuteNonQuery() == 1)
                {
             
                    MessageBox.Show("تم حذف البيانات بنجاح");
                    FillMyData();

                    txtUsername.ResetText();
                    txtpassword.ResetText();
                    txtnewpassword.ResetText();
                    registchk.Checked=false;
                    editchk.Checked = false;
                    deletechk.Checked = false;
                    followingchk.Checked = false;
                    userchk.Checked = false;
                    orgchk.Checked = false;
                    conchk.Checked = false;
                    adminchk.Checked = false;
                    filesck.Checked = false;
                    visitck.Checked = false;
                    historychk.Checked = false;
                }
                else
                {


                    MessageBox.Show("لم يتم الحذف");
                }
                txtpassword.ResetText();
                txtUsername.ResetText();
                Authorties.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Authorties.con.Close();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            DgvUser.Visible = true;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            DgvUser.Visible = false;
        }

        private void DgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtUsername.Text = DgvUser[0, e.RowIndex].Value.ToString();
                txtpassword.Text = DgvUser[1, e.RowIndex].Value.ToString();
                txtnewpassword.Text = DgvUser[1, e.RowIndex].Value.ToString();
                admin = DgvUser[2, e.RowIndex].Value.ToString();
               regist = DgvUser[3, e.RowIndex].Value.ToString();
               edit = DgvUser[4, e.RowIndex].Value.ToString();
                following = DgvUser[5, e.RowIndex].Value.ToString();
                user = DgvUser[6, e.RowIndex].Value.ToString();
                  org = DgvUser[7, e.RowIndex].Value.ToString();
                 conn = DgvUser[8, e.RowIndex].Value.ToString();
                delete = DgvUser[9, e.RowIndex].Value.ToString();
                CmbBxUserName.Text = DgvUser[10, e.RowIndex].Value.ToString();
                files = DgvUser[11, e.RowIndex].Value.ToString();
                visit = DgvUser[12, e.RowIndex].Value.ToString();
                history = DgvUser[13, e.RowIndex].Value.ToString();

                if (regist == "1")
                {

                    registchk.Checked=true;
                }
                else
                {
                    registchk.Checked = false;
                }



                if (admin == "1")
                {

                    adminchk.Checked = true;
                }
                else
                {
                    adminchk.Checked = false;
                }






                if (edit == "1")
                {

                    editchk.Checked = true;
                }
                else
                {
                    editchk.Checked = false;
                }






                if (following == "1")
                {

                    followingchk.Checked = true;
                }
                else
                {
                    followingchk.Checked = false;
                }



                if (user == "1")
                {

                    userchk.Checked = true;
                }
                else
                {
                    userchk.Checked = false;
                }


                if (org == "1")
                {

                    orgchk.Checked = true;
                }
                else
                {
                    orgchk.Checked = false;
                }





                if (conn == "1")
                {

                    conchk.Checked = true;
                }
                else
                {
                    conchk.Checked = false;
                }




                if (delete == "1")
                {

                    deletechk.Checked = true;
                }
                else
                {
                    deletechk.Checked = false;
                }




                if (files == "1")
                {

                    filesck.Checked = true;
                }
                else
                {
                    filesck.Checked = false;
                }




                if (visit == "1")
                {

                    visitck.Checked = true;
                }
                else
                {
                    visitck.Checked = false;
                }



                if (history == "1")
                {

                    historychk.Checked = true;
                }
                else
                {
                    historychk.Checked = false;
                }



            }
            catch (Exception ex)
            {
            }
        }
    }
}
