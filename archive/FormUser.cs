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
    public partial class FormUser : Form
    {
        string NameOfUsr;
        
        ArchieveDatabase Usr = new ArchieveDatabase();

        string username;
        string user;
        public FormUser(string name, string password)
        {
            InitializeComponent();
            username = name;
        }
        private void FormUser_Load(object sender, EventArgs e)
        {
            FillMyData();
            DgvUser.Columns[0].HeaderText = "كود المختص";
            DgvUser.Columns[1].HeaderText = "اسم المختص" + "";
            Authority();
        }
        void Authority()
        {
            DataTable Dt = new DataTable();
            String Quary = "select * from login where name ='" + username + "' ";
            Dt = Usr.QuaryExecute(Quary);
            user = Dt.Rows[0]["user"].ToString();
        }
        void FillMyData()
        {
            DgvUser.DataSource = Usr.QuaryExecute("select * from users");
        }


        private void TxtSearch_OnValueChanged(object sender, EventArgs e)
        {
            DgvUser.DataSource = Usr.QuaryExecute("select * from users where username like'" + '%' + TxtSearch.Text + '%' + "' ");
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (TxtUserId.Text != "" && TxtUserName.Text != "")
            {
                try
                {
                    if (user == "1")
                    {
                        int Test = Usr.MyExecuteNonQuery("INSERT INTO users (username , userid) VALUES ('" + TxtUserName.Text + "','" + TxtUserId.Text + "')");
                    if (Test == 1)
                    {
                        FillMyData();
                        MessageBox.Show("تم ادخال البيانات بنجاح");
                    }
                    else
                    {
                        MessageBox.Show("لم يتم ادخال البيانات");
                    }
                    TxtUserId.ResetText();
                    TxtUserName.ResetText();
                    }
                    else
                    {

                        MessageBox.Show("غير مسموح لك باضافة مختص");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("هذه البيانات غير صحيحة");
                }
            }
            else
            {
                MessageBox.Show("من فضلك قم بادخال البيانات");
            }
        }


        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtUserId.Text = DgvUser[0, e.RowIndex].Value.ToString();
                TxtUserName.Text = DgvUser[1, e.RowIndex].Value.ToString();
                NameOfUsr = TxtUserName.Text;
            }
            catch (Exception ex)
            {

            }
        }

        private void BtnEditUser_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (user == "1")
                {
                    DialogResult result = MessageBox.Show("هل انت متاكد من تعديل هذه الوثيقة", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (result == DialogResult.Yes)
                {
                    //  String updateQuery = "UPDATE users SET username = '" + txtUsername.Text + "' WHERE userid='" + int.Parse(txtUserid.Text) + "'";
                    String DeleteQuery = "DELETE FROM  users  WHERE username= '" + TxtUserName.Text + "'  or userid = '" + TxtUserId.Text + "' ";
                    String InsertQuery = "INSERT INTO users (username , userid) VALUES ('" + TxtUserName.Text + "','" + TxtUserId.Text + "')";
                    int Test1 = Usr.MyExecuteNonQuery(DeleteQuery);
                    int Test2 = Usr.MyExecuteNonQuery(InsertQuery);
                    if (Test1 == 1 && Test2 == 1)
                    {
                        int Test = Usr.MyExecuteNonQuery("UPDATE import SET username =REPLACE(username,'" + NameOfUsr + "','" + TxtUserName.Text + "') ");
                        if (Test == 1) { }
                        FillMyData();
                        MessageBox.Show("تم تعديل البيانات بنجاح");
                    }
                    else
                    {
                        MessageBox.Show("لم يتم التعديل");
                    }
                    TxtUserId.ResetText();
                    TxtUserName.ResetText();

                }
                else
                {
                    MessageBox.Show("لم يتم التعديل");
                }
                }
                else
                {

                    MessageBox.Show("غير مسموح لك بتعديل مختص");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("هذه البيانات غير صحيحة");
            }
        }

        private void BtnDeleteUser_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (user == "1")
                {
                    DialogResult result = MessageBox.Show("هل انت متاكد من حذف هذه الوثيقة", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (result == DialogResult.Yes)
                {
                    String DeleteQuery = "DELETE FROM users WHERE userid='" + int.Parse(TxtUserId.Text) + "'";
                int Test = Usr.MyExecuteNonQuery(DeleteQuery);
                if (Test == 1)
                {
                    FillMyData();
                    MessageBox.Show("تم حذف البيانات بنجاح");
                }
                else
                {
                    MessageBox.Show("لم يتم الحذف");
                }
                TxtUserId.ResetText();
                TxtUserName.ResetText();
                }
                else
                {
                    MessageBox.Show("لم يتم الحذف");
                }
                }
                else
                {

                    MessageBox.Show("غير مسموح لك بحذف مختص");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("هذه البيانات غير صحيحة");
            }
        }

        private void TxtUserId_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
