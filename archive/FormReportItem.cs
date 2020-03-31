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
using Microsoft.Reporting.WinForms;

namespace archive
{
    public partial class FormReportItem : Form
    {
        ArchieveDatabase Connect = new ArchieveDatabase();
        string type1 = "و";
        public FormReportItem()
        {
            InitializeComponent();
        }

        DataTable Dt1 = new DataTable();
        DataTable Dt = new DataTable();
        void Search()
        {
            String type = "وارد / صادر ";
            String CommandText1 = System.String.Empty;
            String CommandText2 = System.String.Empty;
            try
            {
                DataTable Dt2 = new DataTable();
                CommandText1 = "select importid as id , importdate as date, orgname , username , followingdate , summary , action , primaryfileid, secondfileid FROM importdata where note = '" + CmbBxName.Text + "'  ";
                CommandText2 = "select exportid as id , exportdate as date , orgname , username , followingdate , summary , action , primaryfileid, secondfileid FROM exportdata where id = '" + CmbBxName.Text + "'  ";
                
                    type = "وارد / صادر ";
                    Dt1 = Connect.QueryExecute(CommandText1);
                    Dt2 = Connect.QueryExecute(CommandText2);
                    Dt1.Merge(Dt2);
                    Dt1.DefaultView.Sort = "date ASC,id ASC";
                    Dt1 = Dt1.DefaultView.ToTable();
                    ReportViwerData(Dt1);
                TxtCon.ResetText();

            }
            catch (Exception ex)
            {
                MessageBox.Show("هذه المكاتبة غير موجودة");
            }
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            Search();
        }
        public void ReportViwerData(DataTable dt)
        {
            ReportDataSource rprtDTSource = new ReportDataSource("ReportData", dt);
            ReportParameterCollection ReportParameters = new ReportParameterCollection();
            this.ReportViewerFollowing.LocalReport.SetParameters(ReportParameters);
            this.ReportViewerFollowing.LocalReport.DataSources.Clear();
            this.ReportViewerFollowing.LocalReport.DataSources.Add(rprtDTSource);
            this.ReportViewerFollowing.LocalReport.Refresh();
            this.ReportViewerFollowing.RefreshReport();
            this.ReportViewerFollowing.ZoomPercent = 125;
        }
        private void ChkBxImport2_OnChange(object sender, EventArgs e)
        {
            if (ChkBxExport2.Checked == true)
            {
                ChkBxImport2.Checked = false;
                type1 = "ص";
            }
            else
            {
                ChkBxImport2.Checked = true;
                type1 = "و";
            }
        }
        private void ChkBxExport2_OnChange(object sender, EventArgs e)
        {
            if (ChkBxExport2.Checked == true)
            {
                ChkBxImport2.Checked = false;
                type1 = "ص";
            }
            else
            {
                ChkBxImport2.Checked = true;
                type1 = "و";
            }
        }

        private void FormReportItem_Load(object sender, EventArgs e)
        {
            ReportViwerData(Dt);
            FillCmbBxName();
        }

        private void btnformbrief_Click(object sender, EventArgs e)
        {
           FormBrief FormSearchReport = new FormBrief(Dt1);
            FormSearchReport.Show();
        }

        private void TxtCon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        void saveData()
        {
            try
            {

                if (ChkBxExport2.Checked == true)
                {

                 String updateQuery = "UPDATE exportdata SET note ='" + CmbBxName.Text + "'  where id = '" + int.Parse(TxtCon.Text) + '-' + TxtDate1.Text + '-' + type1 + "'  ";
                 int Test1 = Connect.MyExecuteNonQuery(updateQuery);
                  if (Test1 == 1)
                    {
                        MessageBox.Show("تم تسجيل بيانات بنجاح");
                    }
                    else
                    {
                        {
                            MessageBox.Show("تم تسجيل بيانات بنجاح لم ");
                        }
                    }

                }
                else
                {
                    String updateQuery = "UPDATE importdata SET note ='" + CmbBxName.Text + "'  where id = '" + int.Parse(TxtCon.Text) + '-' + TxtDate1.Text + '-' + type1 + "'  ";
                    int Test1 = Connect.MyExecuteNonQuery(updateQuery);
                    if (Test1 == 1)
                    {
                        MessageBox.Show("تم تسجيل بيانات بنجاح");
                    }
                    else
                    {
                        {
                            MessageBox.Show("تم تسجيل بيانات بنجاح لم ");
                        }
                    }
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show("هذه البيانات غير صحيحة");
            }

        }

        void DeleteData()
        {
            try
            {

                if (ChkBxExport2.Checked == true)
                {

                    String updateQuery = "UPDATE exportdata SET note =null  where id = '" + int.Parse(TxtCon.Text) + '-' + TxtDate1.Text + '-' + type1 + "'  ";
                    int Test1 = Connect.MyExecuteNonQuery(updateQuery);
                    if (Test1 == 1)
                    {
                        MessageBox.Show("تم حذف بيانات بنجاح");
                    }
                    else
                    {
                        {
                            MessageBox.Show("تم حذف بيانات بنجاح لم ");
                        }
                    }

                }
                else
                {
                    String updateQuery = "UPDATE importdata SET note = null  where id = '" + int.Parse(TxtCon.Text) + '-' + TxtDate1.Text + '-' + type1 + "'  ";
                    int Test1 = Connect.MyExecuteNonQuery(updateQuery);
                    if (Test1 == 1)
                    {
                        MessageBox.Show("تم حذف بيانات بنجاح");
                    }
                    else
                    {
                        {
                            MessageBox.Show("تم حذف بيانات بنجاح لم ");
                        }
                    }
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show("هذه البيانات غير صحيحة");
            }

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            saveData();
            Search();
         
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            DeleteData();
            Search();
        }

        void FillCmbBxName()
        {
            DataTable Dt = new DataTable();
            DataTable Dt1 = new DataTable();
            Dt = Connect.QueryExecute("select distinct note from importdata where note != ''");
            Dt1 = Connect.QueryExecute("select distinct note from exportdata where note != ''");
            Dt.Merge(Dt1);
            for (int Index = 0; Index < Dt.Rows.Count; Index++)
            {
                CmbBxName.Items.Add(Dt.Rows[Index][0]);
            }
            CmbBxName.Text = "اختر الموضوع";
            //CmbBxUserName.Sorted = true;
        }

        private void CmbBxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();

        }
    }
}
