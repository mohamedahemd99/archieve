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
    public partial class FormErgent : Form
    {
        ArchieveDatabase Ergernt = new ArchieveDatabase();
        string nameofuser;
        public FormErgent(string name)
        {
            nameofuser = name;
            InitializeComponent();
        }

        private void Formergent_Load(object sender, EventArgs e)
        {
            FillDgv();
        }

      
        void FillDgv()
        {
            String CommandText1 = System.String.Empty;
            String CommandText2 = System.String.Empty;
            try
            {
                DataTable dt = new DataTable();

                DataTable Dt1 = new DataTable();
                DataTable Dt2 = new DataTable();

                for (int j = 0; j < 4; j++)
                    {
                       DateTime[] DatesPickers = { DateTime.Now.AddDays(j), DateTime.Now.AddDays(j) };
                        string[] Dates = DatesMaker(DatesPickers);
                    CommandText1 = "select importid as id , importdate as date, orgname , username , followingdate , summary , action  FROM importdata where following = 1 and ";
                    CommandText1 += "   followingdate >= '" + Dates[0] + "' AND followingdate <= '" + Dates[1] + "'  ";
                    CommandText2 = "select exportid as id , exportdate as date , orgname , username , followingdate , summary , action  FROM exportdata where following = 1 and ";
                    CommandText2 += "   followingdate >= '" + Dates[0] + "' AND followingdate <= '" + Dates[1] + "'  ";

                    Dt1 = Ergernt.QueryExecute(CommandText1);
                    Dt2 = Ergernt.QueryExecute(CommandText2);
                    Dt1.Merge(Dt2);
                    Dt1.DefaultView.Sort = "followingdate ASC,id ASC";
                    Dt1 = Dt1.DefaultView.ToTable();
                    dt.Merge(Dt1);
                    }
                    DgvSearch.DataSource = dt;
                    DgvHeaders();
                    DgvColor(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string[] DatesMaker(DateTime[] DatesPickersTemp)
        {
            DateTime[] DatesPickers = DatesPickersTemp;
            string[] Dates = new string[DatesPickers.Length];
            for (int i = 0; i < DatesPickers.Length; i++)
            {
                Dates[i] = Convert.ToDateTime(DatesPickers[i]).ToString("yyyy-MM-dd");
            }
            return Dates;
        }

        void DgvHeaders()
        {
            String[] DgvHeaders = { "رقم المكاتبة  ", "  تاريخ المكاتبة ", "اسم الجهة", " المختصون", "تاريخ المتابعة ", "ملخص الموضوع ",  " اجراء متخذ" };
            for (int i = 0; i < DgvHeaders.Length; i++)
            {
                DgvSearch.Columns[i].HeaderText = DgvHeaders[i];
            }
            int[] DgvHeadersWidth = { 50, 70, 150, 200, 75, 300,  150 };
            for (int i = 0; i < DgvHeadersWidth.Length; i++)
            {
                DgvSearch.Columns[i].Width = DgvHeadersWidth[i];
            }
        }

        public void DgvColor(DataTable dt)
        {
            try
            {
                for (int k = 0; k < dt.Rows.Count; k++)
                {
                    DateTime date = Convert.ToDateTime(DgvSearch[4, k].Value);
                    TimeSpan Time = date - DateTime.Now;
                    if (Time.Days == 0)
                    {
                        DgvSearch.Rows[k].DefaultCellStyle.BackColor = Color.Red;
                        DgvSearch.Rows[k].DefaultCellStyle.ForeColor = Color.White;

                    }
                    if (Time.Days == 1)
                    {
                        DgvSearch.Rows[k].DefaultCellStyle.BackColor = Color.Yellow;
                        DgvSearch.Rows[k].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    if (Time.Days == 2)
                    {
                        DgvSearch.Rows[k].DefaultCellStyle.BackColor = Color.Green;
                        DgvSearch.Rows[k].DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        
    }

}
