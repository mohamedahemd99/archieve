﻿using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace archive
{
    public partial class FormReminders : Form
    {
        enum changedField
        {
            description,
            date
        }

        int selectedId =-1;
        string date = null;
        string oldDescription = "";
        string oldDate = "";
        public FormReminders()
        {
            InitializeComponent();
        }

        ArchieveDatabase databaseInstance = new ArchieveDatabase();
        string username;

        public FormReminders(string name, string password,string date)
        {
            if(date != null)
            {
                this.date = date;
            }
            InitializeComponent();
            username = name;
        }

        private void FormReminders_Load(object sender, EventArgs e)
        {
            if(date != null)
            {
                search(date);
            }
            else
                FillMyData();

            datePicker.Value = DateTime.Now;
            DgvReminders.Columns[3].Width = 80;
            DgvReminders.Columns[4].Width = 90;
            DgvReminders.Columns[0].HeaderText = " م";
            DgvReminders.Columns[0].Visible = false;
            DgvReminders.Columns[1].HeaderText = "الموضوع ";
            DgvReminders.Columns[2].HeaderText = "التفاصيل";
            DgvReminders.Columns[3].HeaderText = " تاريخ المتابعة";
            DgvReminders.Columns[4].HeaderText = " تاريخ الإضافة";
        }


        // check functionality
        void FillMyData()
        {
            string query = "select id,title,description,date,insertion_date " +
            "from reminders " +
            "where id in "+
            "(select max(id) from reminders group by title) " +
            "and date >= CURDATE() " +
            "group by title " +
            "order by date ";
            DataTable dt = databaseInstance.QueryExecute(query);
            DgvReminders.DataSource = dt;
            getRemindersTotalCount();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            FillMyData();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //string query = "select * from reminders where date >= CURDATE() order by date";
            string query = "select id,title,description,date,insertion_date " +
            "from reminders " +
            "where id in " +
            "(select max(id) from reminders group by title) " +
            "and date >= CURDATE() " +
            "group by title " +
            "order by date ";

            DataTable dt = databaseInstance.QueryExecute(query);
            DgvReminders.DataSource = dt;
        }

        private void BtnAddVisit_Click(object sender, EventArgs e)
        {
            if (txt_title.Text == string.Empty)
            {
                MessageBox.Show("من فضلك ادخل موضوع المتابعة");
                return;
            }

            string date = datePicker.Value.ToString("yyyy-MM-dd");
            string addStatement = "insert into reminders(title,description,date,insertion_date)" +
                "values(" +
                "'" + txt_title.Text + "',"+
                "'" + description_richTextBox.Text + "'," +
                "'" + date + "'," +
                " curdate()"+
                ")";
            Console.WriteLine(addStatement);
            try
            {
              int result =  databaseInstance.MyExecuteNonQuery(addStatement);
              if(result == 1)
                {
                    MessageBox.Show("تم اضافة البيانات");
                    FillMyData();
                    clearAll();
                }
                else
                {
                    MessageBox.Show("هذه البيانات غير صحيحة");
                }
            }catch (MySqlException ex)
            {
                MessageBox.Show("هذه البيانات غير صحيحة");
                Console.WriteLine(ex.Message);
            }
            
        }

        private void BtnEditVisit_Click(object sender, EventArgs e)
        {
            if(txt_title.Text == string.Empty)
            {
                MessageBox.Show("من فضلك ادخل موضوع المتابعة");
                return;
            }

            try
            {
                bool descriptionHasChanged = false;
                if (getChangedField() == (int)changedField.description)
                    descriptionHasChanged = true;
                string date = datePicker.Value.ToString("yyyy-MM-dd");
                string addStatement = "insert into reminders(title,description,date,insertion_date,description_has_changed)" +
                    "values(" +
                    "'" + txt_title.Text + "'," +
                    "'" + description_richTextBox.Text + "'," +
                    "'" + date + "'," +
                    " curdate()"+ ","+
                    descriptionHasChanged.ToString()+
                    ")";

                Console.WriteLine(addStatement);
                int result = databaseInstance.MyExecuteNonQuery(addStatement);

                if (result == 1)
                {
                    FillMyData();
                    MessageBox.Show("تم تعديل البيانات");
                    clearAll();
                }
                else
                {
                    MessageBox.Show("لم يتم تعديل البيانات");
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("لم يتم تعديل البيانات");
            }

        }

        private void DgvVisit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                selectedId = int.Parse(DgvReminders[0, e.RowIndex].Value.ToString());
                txt_title.Text = DgvReminders[1, e.RowIndex].Value.ToString();
                description_richTextBox.Text = DgvReminders[2, e.RowIndex].Value.ToString();
                oldDate = DgvReminders[3, e.RowIndex].Value.ToString();
                oldDescription = description_richTextBox.Text;
                datePicker.Value = Convert.ToDateTime(oldDate);

               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void BtnDeleteVisit_Click(object sender, EventArgs e)
        {
            if(selectedId == -1)
            {
                MessageBox.Show("من فضلك قم باختيار المتابعة المراد حذفها");

            }else
            {
                try
                {
                    string disableUpdateStatment = "SET SQL_SAFE_UPDATES = 0";
                    databaseInstance.MyExecuteNonQuery(disableUpdateStatment);
                    string deleteStatement = "delete from reminders " +
                        "where " +
                        "title ='"+txt_title.Text+"'";
                    Console.WriteLine(deleteStatement);
                    int result = databaseInstance.MyExecuteNonQuery(deleteStatement);
                    if (result >= 1)
                    {
                        MessageBox.Show("تم الحذف");
                        showAllReminders();
                        clearAll();
                    }
                    else
                    {
                        MessageBox.Show(" لم يتم الحذف ");
                    }
                } catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(" لم يتم الحذف ");

                }
            }
        }


        private void clearAll()
        {
            description_richTextBox.Text = "";
            txt_title.Text = "";
            datePicker.Value = DateTime.Now;
        }

        private void show_all_btn_Click(object sender, EventArgs e)
        {
            showAllReminders();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        private void search(string date)
        {
            txt_title.Text = "";
            string query = "select id,title,description,date,insertion_date from reminders where date = curdate() order by date";
            DataTable dt = databaseInstance.QueryExecute(query);
            Console.WriteLine(query);
            DgvReminders.DataSource = dt;
            getRemindersTotalCount();

        }

        private void DgvReminders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string title = DgvReminders[1, e.RowIndex].Value.ToString();
            ShowRemindersDetails showRemindersDetails = new ShowRemindersDetails(title);
            showRemindersDetails.StartPosition = FormStartPosition.Manual;
            showRemindersDetails.Show(this);
            showRemindersDetails.Show();
        }

        private void getRemindersTotalCount()
        {
            string query = "select count(distinct title) from reminders";

            DataTable dt = databaseInstance.QueryExecute(query);
            remindersTotalTextBox.Text = dt.Rows[0][0].ToString();

        }

        private int getChangedField()
        {
            if (oldDescription != description_richTextBox.Text.ToString())
            {
                return (int)changedField.description;
            }else
                return (int)changedField.date;
        }

        private void show_report_btn_Click(object sender, EventArgs e)
        {
            if (txt_title.Text == string.Empty)
                return;
            string query = "select * from reminders where title = '" + txt_title.Text + "' order by date";
            DataTable dt = databaseInstance.QueryExecute(query);
            FormRemindersReport formRemindersReport = new FormRemindersReport(dt);
            formRemindersReport.Show();

        }

        private void showAllReminders()
        {
            string query = "select id,title,description,date,insertion_date " +
            "from reminders " +
            "where id in " +
            "(select max(id) from reminders group by title) " +
            "group by title " +
            "order by date ";

            clearAll();
            DataTable dt = databaseInstance.QueryExecute(query);
            DgvReminders.DataSource = dt;
            getRemindersTotalCount();
        }

        private void FormReminders_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Program.mode == "auto")
                Environment.Exit(0);
        }

    }
}
