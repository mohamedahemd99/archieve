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
    public partial class FormSearch : Form
    {
        DataTable DtSearchFile = new DataTable();
        DataTable dtCombinedFilesData = new DataTable();
        OpenFileDialog Pdf = new OpenFileDialog();
        string id = "";
        ArchieveDatabase Search = new ArchieveDatabase();
        DataTable Dt = new DataTable();
        PdfClass MyPdf = new PdfClass();
        String type = "وارد / صادر ";
        string job;
        int globalIndex = 0;
        public FormSearch(string name, string password)
        {

            InitializeComponent();
            TxtUser.Text = name;

        }
        private void FormSearch_Load(object sender, EventArgs e)
        {
            initCmbBxUserName();
            Authority();
            ImportDate1.Value = Convert.ToDateTime(DateTime.Now.Year.ToString() + "-1-1");
            OrgExportDate1.Value = Convert.ToDateTime(DateTime.Now.Year.ToString() + "-1-1");
            FollowingDate1.Value = Convert.ToDateTime(DateTime.Now.Year.ToString() + "-1-1");
            ImportDate2.Value = DateTime.Now;
            OrgExportDate2.Value = DateTime.Now;
            FollowingDate2.Value = DateTime.Now;
            next_btn.Visible = false;
            prev_btn.Visible = false;
              //SearchNew();
        }
        void initCmbBxUserName()
        {
            DataTable Dt = new DataTable();
            Dt = Search.QueryExecute("select username from users");
            for (int Index = 0; Index < Dt.Rows.Count; Index++)
            {
                CmbBxUserName.Items.Add(Dt.Rows[Index][0]);
            }

            //CmbBxUserName.Sorted = true;
        }
        void fillCmbBxUserName(string [] names)
        {
            CmbBxUserName.Items.Clear();
            CmbBxUserName.Items.AddRange(names);
            CmbBxUserName.SelectedIndex = 0;

        }

        void Authority()
        {
            DataTable Dt = new DataTable();
            String Quary = "select * from login where name ='" + TxtUser.Text + "' ";
            Dt = Search.QueryExecute(Quary);

            job = Dt.Rows[0]["job"].ToString();

        }
        void Init_Dgv()
        {
            String[] DgvHeaders = { "رقم المكانبة ", "تاريخ المكاتبة ", "اسم الجهة", "المختصون", "تاريخ المتابعة ", "ملخص الموضوع ", " اجراء متخذ" };
            for (int i = 0; i < DgvHeaders.Length; i++)
            {
                DgvSearch.Columns[i].HeaderText = DgvHeaders[i];
            }

            DgvSearch.Columns[0].Width = 55;
            DgvSearch.Columns[1].Width = 75;
            DgvSearch.Columns[2].Width = 200;
            DgvSearch.Columns[3].Width = 200;
            DgvSearch.Columns[4].Width = 75;
            DgvSearch.Columns[5].Width = 300;
            DgvSearch.Columns[6].Width = 200;
            DgvSearch.Columns[7].Visible = false;

            ImportDate1.Value = Convert.ToDateTime(DateTime.Now.Year.ToString() + "-1-1");
            OrgExportDate1.Value = Convert.ToDateTime(DateTime.Now.Year.ToString() + "-1-1");
            FollowingDate1.Value = Convert.ToDateTime(DateTime.Now.Year.ToString() + "-1-1");
            ImportDate2.Value = DateTime.Now;
            OrgExportDate2.Value = DateTime.Now;
            FollowingDate2.Value = DateTime.Now;
        }


        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtImportId.Text = "";
            txtexportorg.Text = "";
            orgid.Text = "";
            txtexportchange.Text = "";
            txtsummary.Text = "";
            orgname.Text = "";


        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchNew();
            SearchFile();
        }

        private void ChkBxFollowing_OnChange(object sender, EventArgs e)
        {

            if (ChkBxFollowing.Checked == true)
            {
                FollowingDate1.Visible = true;
                FollowingDate2.Visible = true;
                LblFollowingDateFrom.Visible = true;
                LblFollowingDateTo.Visible = true;
            }
            else
            {
                FollowingDate1.Visible = false;
                FollowingDate2.Visible = false;
                LblFollowingDateFrom.Visible = false;
                LblFollowingDateTo.Visible = false;
            }
        }

        private void CkBxExportOrg_OnChange(object sender, EventArgs e)
        {
            if (CkBxExportOrg.Checked == true)
            {
                OrgExportDate1.Visible = true;
                OrgExportDate2.Visible = true;
                LblExportOrgDateFrom.Visible = true;
                LblExportOrgDateTo.Visible = true;
            }
            else
            {
                OrgExportDate1.Visible = false;
                OrgExportDate2.Visible = false;
                LblExportOrgDateFrom.Visible = false;
                LblExportOrgDateTo.Visible = false;
            }
        }

        private void TxtImportId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchNew();
                SearchFile();
            }
        }
        private void CkBxImportId_OnChange(object sender, EventArgs e)
        {
            if (CkBxImportDate.Checked == true)
            {
                ImportDate1.Visible = true;
                ImportDate2.Visible = true;
                LblImportDateFrom.Visible = true;
                LblImportDateTo.Visible = true;
            }
            else
            {
                ImportDate1.Visible = false;
                ImportDate2.Visible = false;
                LblImportDateFrom.Visible = false;
                LblImportDateTo.Visible = false;
            }
        }

        private void ChkBxImportExport_OnChange(object sender, EventArgs e)
        {
            if (ChkBxImportExport.Checked == true)
            {
                ChkBxImport.Checked = false;
                ChkBxExport.Checked = false;
            }
            else
            {
                if (ChkBxImport.Checked == true)
                {
                    ChkBxExport.Checked = false;
                    ChkBxExport.Checked = false;
                }
                else
                {
                    ChkBxExport.Checked = true;
                }
            }
        }
        private void ChkBxImport_OnChange(object sender, EventArgs e)
        {
            if (ChkBxImport.Checked == true)
            {
                ChkBxImportExport.Checked = false;
                ChkBxExport.Checked = false;
            }
            else
            {
                if (ChkBxExport.Checked == true)
                {
                    ChkBxImportExport.Checked = false;
                }
                else
                {
                    ChkBxImportExport.Checked = true;
                }
            }

        }
        private void ChkBxExport_OnChange(object sender, EventArgs e)
        {
            if (ChkBxExport.Checked == true)
            {
                ChkBxImportExport.Checked = false;
                ChkBxImport.Checked = false;
            }
            else
            {
                if (ChkBxImport.Checked == true)
                {
                    ChkBxImportExport.Checked = false;
                }
                else
                {
                    ChkBxImportExport.Checked = true;
                }
            }
        }

        private void orgid_OnValueChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = Search.QueryExecute("select orgname from org where idorg = '" + orgid.Text + "'");
            string array = String.Empty;
            if (Dt.Rows.Count > 0)
            {
                array = Dt.Rows[0]["orgname"].ToString();
            }
            orgname.Text = array;

        }

        private void orgname_OnValueChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = Search.QueryExecute("select idorg from org where orgname like '" + orgname.Text + "'");
            string array = String.Empty;
            if (Dt.Rows.Count > 0)
            {
                array = Dt.Rows[0]["idorg"].ToString();
            }
            orgid.Text = array;
        }

        public string[] DatesMaker()
        {
            DateTime[] datespickers = { ImportDate1.Value, ImportDate2.Value, OrgExportDate1.Value, OrgExportDate2.Value, FollowingDate1.Value, FollowingDate2.Value };
            string[] dates = new string[6];
            for (int i = 0; i < 6; i++)
            {
                dates[i] = Convert.ToDateTime(datespickers[i]).ToString("yyyy-MM-dd");
            }
            return dates;
        }

        void SearchNew()
        {
            string[] Temp = new string[3];
            string[] Field = new string[3];
            String type = "وارد / صادر ";
            String CommandText1 = System.String.Empty;
            String CommandText2 = System.String.Empty;
            try
            {
                string[] Dates = DatesMaker();
                DataTable Dt1 = new DataTable();
                DataTable Dt2 = new DataTable();
                CommandText1 = "select  importid as id , importdate as date, orgname , username , followingdate , summary , action ,id as mah FROM importdata where ";

                Field = new string[3] { "importid", "exportorg", "exportchange" };
                Temp = new string[3] { TxtImportId.Text, txtexportorg.Text, txtexportchange.Text };
                for (int i = 0; i < 3; i++)
                {
                    if (Temp[i] != "")
                    {
                        CommandText1 += "   " + Field[i] + " ='" + Temp[i] + "' and";
                    }
                }
                if (txtsummary.Text != "")
                {
                    CommandText1 += "  summary like'" + '%' + txtsummary.Text + '%' + "'and";
                }
                
                if (orgname.Text != "")
                {
                    CommandText1 += " orgname like'" + '%' + orgname.Text + '%' + "' and ";
                }
                if (job != "")
                {
                    CommandText1 += "username like'" + '%' + job + '%' + "' and ";
                }

                if (CmbBxUserName.Text != "اختر مختص")
                {
                    CommandText1 += " username like'" + '%' + CmbBxUserName.Text + '%' + "' and ";
                }

                if (CkBxImportDate.Checked == true)
                {
                    CommandText1 += "   importdate >= '" + Dates[0] + "' AND importdate <= '" + Dates[1] + "' and ";

                }
                if (CkBxExportOrg.Checked == true)
                {
                    CommandText1 += "   exportorgdate >= '" + Dates[2] + "' AND exportorgdate <= '" + Dates[3] + "' and ";
                }
                if (ChkBxFollowing.Checked == true)
                {
                    CommandText1 += "   followingdate >= '" + Dates[4] + "' AND followingdate <= '" + Dates[5] + "' and ";

                }
                
                CommandText1 += "  importid > 0";
                
                CommandText2 = "select exportid as id , exportdate as date , orgname , username , followingdate , summary , action ,id as mah FROM exportdata where  ";

                if (TxtExportId.Text != "")
                    CommandText2 += "  exportid ='" + TxtExportId.Text + "' and ";

                if (txtsummary.Text != "")
                    CommandText2 += "  summary like'" + '%' + txtsummary.Text + '%' + "'and";

                if (orgname.Text != "")
                    CommandText2 += " orgname like'" + '%' + orgname.Text + '%' + "' and ";

                if (job != "")
                {
                    CommandText2 += " username like'" + '%' + job + '%' + "' and ";
                }

                if (CmbBxUserName.Text != "اختر مختص")
                    CommandText2 += " username like'" + '%' + CmbBxUserName.Text + '%' + "' and ";

                if (CkBxImportDate.Checked == true)
                    CommandText2 += "   exportdate >= '" + Dates[0] + "' AND exportdate <= '" + Dates[1] + "'and  ";

                if (ChkBxFollowing.Checked == true)
                    CommandText2 += "   followingdate >= '" + Dates[4] + "' AND followingdate <= '" + Dates[5] + "' and ";

                if (txtexportorg.Text != "" || txtexportchange.Text != "" || CkBxImportDate.Checked == true)
                {
                    CommandText2 += "  exportid < 0 and";

                }
                CommandText2 += "  exportid > 0";
                Console.WriteLine(CommandText1);
                Console.WriteLine(CommandText2);

                if(TxtImportId.Text != string.Empty && TxtExportId.Text != string.Empty)
                {
                    MessageBox.Show("لا يمكن البحث برقم صادر و وارد.");

                }
                else if (TxtImportId.Text != string.Empty)
                {
                    type = "وارد";
                    Dt1 = Search.QueryExecute(CommandText1);
                    Dt1.DefaultView.Sort = "date DESC,id DESC";
                    Dt1 = Dt1.DefaultView.ToTable();
                    ReportViwerData(Dt1, type);
                    // DgvSearch.DataSource = Dt1;
                    try
                    {
                        DgvSearch.DataSource = Dt1;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }


                }
                else if (TxtExportId.Text != string.Empty)
                {
                    type = "صادر";
                    Dt2 = Search.QueryExecute(CommandText2);
                    Dt2.DefaultView.Sort = "date DESC,id DESC";
                    Dt2 = Dt2.DefaultView.ToTable();
                    ReportViwerData(Dt2, type);
                    //DgvSearch.DataSource = Dt2;
                    try
                    {
                        DgvSearch.DataSource = Dt2;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Console.WriteLine("passed function search");

        }

        public void ReportViwerData(DataTable dt, String type)
        {
            ReportDataSource rprtDTSource = new ReportDataSource("ReportData", dt);
            ReportParameterCollection ReportParameters = new ReportParameterCollection();
            ReportParameters.Add(new ReportParameter("type", type));

            this.ReportSearch.LocalReport.SetParameters(ReportParameters);
            this.ReportSearch.LocalReport.DataSources.Clear();
            this.ReportSearch.LocalReport.DataSources.Add(rprtDTSource);
            this.ReportSearch.LocalReport.Refresh();
            this.ReportSearch.RefreshReport();
            this.ReportSearch.ZoomPercent = 120;
        }

        private void DgvSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = DgvSearch[7, e.RowIndex].Value.ToString();

                if (id.Contains("و"))
                {
                    DtSearchFile.Clear();
                    string Quary = "select * from importfile where id= '" + id + "' ";
                    MySqlDataAdapter da = new MySqlDataAdapter(Quary, Search.con);
                    da.Fill(DtSearchFile);

                    byte[] pdfsdata = DtSearchFile.Rows[0]["pdffile"] as byte[];
                    showPdf(pdfsdata);

                }
                if (id.Contains("ص"))
                {
                    DtSearchFile.Clear();

                    string Quary = "select * from exportfile where id= '" + id + "' ";
                    MySqlDataAdapter da = new MySqlDataAdapter(Quary, Search.con);
                    da.Fill(DtSearchFile);
                    byte[] pdfsdata = DtSearchFile.Rows[0]["pdffile"] as byte[];
                    showPdf(pdfsdata);

                }
            }
            catch (Exception ex)
            {
            }
        }


        void SearchFile()
        {
            if (TxtImportId.Text != "")
            {
                TxtExportId.Text = "";
                DtSearchFile.Clear();
                string Quary = "select * from importfile where id= '" + TxtImportId.Text + '-' + ImportDate1.Value.Year + '-' + "و" + "' ";
                MySqlDataAdapter da = new MySqlDataAdapter(Quary, Search.con);
                da.Fill(DtSearchFile);
                byte[] pdfsdata = DtSearchFile.Rows[0]["pdffile"] as byte[];
                showPdf(pdfsdata);
            }
            if (TxtExportId.Text != "")
            {
                TxtImportId.Text = "";

                DtSearchFile.Clear();
                string Quary = "select * from exportfile where id= '" + TxtExportId.Text + '-' + ImportDate1.Value.Year + '-' + "ص" + "' ";
                MySqlDataAdapter da = new MySqlDataAdapter(Quary, Search.con);
                da.Fill(DtSearchFile);

                byte[] pdfsdata = DtSearchFile.Rows[0]["pdffile"] as byte[];
                showPdf(pdfsdata);
            }

            //Init_Dgv();

        }

        private void TxtExportId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchNew();
                Console.WriteLine("passed");
                SearchFile();
            }
        }

        private void show_original_correspondence_Click(object sender, EventArgs e)
        {
            globalIndex = 0;
            string connectionKey = get_connection_key();
            dtCombinedFilesData = get_combined_files_data(connectionKey);

            string id = (string)dtCombinedFilesData.Rows[0]["uniqueID"];
            display_data();
            byte[] pdfsdata = get_pdf_file(id);
            showPdf(pdfsdata);
            next_btn.Visible = true;
            prev_btn.Visible = true;

        }

        private string get_connection_key()
        {
            string table = (TxtExportId.Text == "") ? "importfile" : "exportfile";
            string id = (TxtExportId.Text == "") ? TxtImportId.Text : TxtExportId.Text;
            string query = "select connection from " + table + " where portid = " + id + " order by date DESC";

            DataTable dt = Search.QueryExecute(query);
            string return_value = (string)dt.Rows[0][0];
            return return_value;
        }

        private DataTable get_combined_files_data(String connectionKey)
        {
            string query = " select  importdata.id as uniqueID, importdate as date,summary,portid,connection,username, " +
            "orgid,orgname, primaryfile, secondfile, primaryfileid, secondfileid,following,followingdate from importdata join importfile on importdata.id = importfile.id " +
            " having connection =  '" + connectionKey + "'" +
            " union " +

            " select exportdata.id as uniqueID,exportdate as date,summary,portid,connection,username, " +
            "orgid,orgname, primaryfile, secondfile, primaryfileid, secondfileid,following,followingdate from exportdata join exportfile on exportdata.id = exportfile.id" +
            " having connection =  '" + connectionKey + "'" + 
             " order by date DESC";
            DataTable dt = Search.QueryExecute(query);
            Console.WriteLine("row count = " + dt.Rows.Count);
    
            return dt;
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            
            globalIndex++;
            //checked when out of bounds
            if (globalIndex == dtCombinedFilesData.Rows.Count)
            {
                globalIndex = dtCombinedFilesData.Rows.Count - 1;
                MessageBox.Show("لا يوجد مكاتبة أخرى");
                return;
            }
            

            string id = (string)dtCombinedFilesData.Rows[globalIndex]["uniqueID"];

            byte[] pdfsdata = get_pdf_file(id);
            display_data();
            showPdf(pdfsdata);
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            globalIndex--;
            //checked when out of bounds
            if (globalIndex == -1)
            {
                MessageBox.Show("لا يوجد مكاتبة أخرى");
                globalIndex = 0;
                return;
            }
                
            string id = (string)dtCombinedFilesData.Rows[globalIndex]["uniqueID"];

            byte[] pdfsdata = get_pdf_file(id);
            display_data();
            showPdf(pdfsdata);
        }


        private byte[] get_pdf_file(string id){

            string query = "select pdffile from importfile where id = '" + id + "'" +
            " union select pdffile from exportfile where id = '" + id + "'";
        
            DataTable temp = Search.QueryExecute(query);
            byte [] result_pdf= temp.Rows[0]["pdffile"] as byte[];
            return result_pdf;
        }
        private void display_data()
        {

            txtsummary.Text = (string)dtCombinedFilesData.Rows[globalIndex]["summary"];
            orgname.Text = (string)dtCombinedFilesData.Rows[globalIndex]["orgname"];
            string[] usernames = ((string)dtCombinedFilesData.Rows[globalIndex]["username"]).Split(',');
            fillCmbBxUserName(usernames);

            string [] id = ((string)dtCombinedFilesData.Rows[globalIndex]["uniqueID"]).Split('-');

            if (id[id.Length-1] == "ص")
            {
                TxtImportId.Text = String.Empty;
                TxtExportId.Text = (string)dtCombinedFilesData.Rows[globalIndex]["portid"];
            }else
            {
                TxtExportId.Text = String.Empty;
                TxtImportId.Text = (string)dtCombinedFilesData.Rows[globalIndex]["portid"];
                string query = "select exportorg,exportorgdate,exportchange from importdata " +
                    "where id = '" + (string)dtCombinedFilesData.Rows[globalIndex]["uniqueID"] +"'";
                DataTable tempDt = Search.QueryExecute(query);
                txtexportchange.Text =(string) tempDt.Rows[0]["exportchange"];
                txtexportorg.Text = (string)tempDt.Rows[0]["exportorg"];
            }
            string[] connection = ((string)dtCombinedFilesData.Rows[globalIndex]["connection"]).Split('-');

            if (connection.Length > 0)
            {
                if (connection[connection.Length - 1] == "ص")
                {
                    expCheckbox.Checked = true;
                    impCheckbox.Checked = false;
                    txtConNum.Text = connection[0];
                    txtConDate.Text = connection[1];

                }
                else if (connection[connection.Length - 1] == "و")
                {

                    expCheckbox.Checked = false;
                    impCheckbox.Checked = true;

                    txtConNum.Text = connection[0];
                    txtConDate.Text = connection[1];
                }
            }

            txt_prim_file_code.Text = (string)dtCombinedFilesData.Rows[globalIndex]["primaryfileid"];
            txt_prim_file_name.Text = (string)dtCombinedFilesData.Rows[globalIndex]["primaryfile"];
            txt_sec_file_code.Text = (string)dtCombinedFilesData.Rows[globalIndex]["secondfileid"];
            txt_sec_file_name.Text = (string)dtCombinedFilesData.Rows[globalIndex]["secondfile"];

            // FollowingDate1.Value = Convert.ToDateTime(DateTime.Now.Year.ToString() + "-1-1");
            /*
            string followDate = (string) dtCombinedFilesData.Rows[globalIndex]["followingdate"];
            if (!followDate.Equals(string.Empty)){
                FollowingDate1.Value = Convert.ToDateTime(followDate);
            }
            */

        }

        //reset form to initial search form
        private void reset_to_default()
        {

        }
        //get show the pdf file from byte array
        private void showPdf(byte [] file)
        {
            string path = @"C:\Users\Public\Documents\tempfile'" + globalIndex.ToString() + "'.pdf";
            System.IO.File.WriteAllBytes(path, file);
            AxAcroPDF.Show();
            Pdf.FileName = path;
            AxAcroPDF.LoadFile(path);
        }
    }
}
