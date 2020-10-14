using System;
using System.Data;
using System.Windows.Forms;

namespace archive
{
    public partial class ShowRemindersDetails : Form
    {
        ArchieveDatabase databaseInstance = new ArchieveDatabase();
        string reminderTitle = "";
        DataTable remindersDatatable;
        int reminderId = -1;
        public ShowRemindersDetails(string title)
        {
            reminderTitle = title;
            remindersDatatable = new DataTable();
            InitializeComponent();
        }

        private void ShowRemindersDetails_Load(object sender, EventArgs e)
        {
            this.Location = this.Owner.Location;
            this.Left += this.Owner.ClientSize.Width / 2 - this.Width / 2;
            this.Top += this.Owner.ClientSize.Height / 2 - this.Height / 2;
            populate_dgv();
            DgvReminders.Columns[0].Visible = false;
            DgvReminders.Columns[1].HeaderText = " تاريخ المتابعة";
            DgvReminders.Columns[2].HeaderText = " تاريخ الاضافة";
            DgvReminders.Columns[3].HeaderText = " تعديل في التفاصيل";
            
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string deleteStatement = "delete from reminders " +
                                     "where " +
                                     "id = '" + reminderId.ToString() + "'";
            int result = databaseInstance.MyExecuteNonQuery(deleteStatement);
            if (result == 1)
            {
                MessageBox.Show("تم الحذف");
                populate_dgv();
            }

        }

        private void DgvReminders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (remindersDatatable.Rows.Count > 0)
                reminderId = int.Parse(DgvReminders[0, e.RowIndex].Value.ToString());
        }
        private void populate_dgv()
        {
            string query = "select id,date,insertion_date,description_has_changed from reminders where title = '" + reminderTitle + "' order by date";
            remindersDatatable = databaseInstance.QueryExecute(query);
            //get the id of the first row as the selected reminder id
            if(remindersDatatable.Rows.Count > 0)
            {
                reminderId = int.Parse(remindersDatatable.Rows[0][0].ToString());
            }
            DgvReminders.DataSource = remindersDatatable;
            txt_title.Text = reminderTitle;
        }
    }
}
