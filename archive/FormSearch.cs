using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


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
        Utils utils = new Utils();
        public FormSearch(string name, string password,string[] followingParams )
        {

            InitializeComponent();
            TxtUser.Text = name;
            if(followingParams != null)
            {
                FillFollowingParams(followingParams);
                SearchNew();
            }

        }
        private void FormSearch_Load(object sender, EventArgs e)
        {
            initCmbBxUserName();
            //Authority();
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
            CmbBxUserName.Items.Clear();
            CmbBxUserName.Text = "";
            Dt = Search.QueryExecute("select username from users");
            for (int Index = 0; Index < Dt.Rows.Count; Index++)
            {
                CmbBxUserName.Items.Add(Dt.Rows[Index][0]);
            }

        }

        void Authority()
        {
            DataTable Dt = new DataTable();
            string Query = "select * from login where name ='" + TxtUser.Text + "' ";
            Dt = Search.QueryExecute(Query);

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
            TxtImportId.Text = string.Empty;
            txtexportorg.Text = string.Empty;
            orgid.Text = string.Empty;
            txtexportchange.Text = string.Empty;
            txtsummary.Text = string.Empty;
            orgname.Text = string.Empty;
            initCmbBxUserName();
            TxtExportId.Text = string.Empty;
            next_btn.Visible = false;
            prev_btn.Visible = false;
            txtConDate.Text = string.Empty;
            txtConNum.Text = string.Empty;
            txt_prim_file_code.Text = string.Empty;
            txt_prim_file_name.Text = string.Empty;
            txt_sec_file_code.Text = string.Empty;
            txt_sec_file_name.Text = string.Empty;
            documentDate.Visible = false;
            documentDateLabel.Visible = false;
            AxAcroPDF.LoadFile("not found");
            documentDateLabel.Visible = false;
            CkBxImportDate.Checked = false;
            ChkBxFollowing.Checked = false;
            CkBxExportOrg.Checked = false;
            DgvSearch.DataSource = null;
            DgvSearch.Refresh();
            CkBxImportId_OnChange(null, null);
            ChkBxFollowing_OnChange(null, null);
            CkBxExportOrg_OnChange(null, null);


        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchNew();
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
            string CommandText1 = string.Empty;
            string CommandText2 = string.Empty;

            if (isEmptySearch())
            {
                MessageBox.Show("لا يوجد بيانات للبحث بها");
            }
            else
            {
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
                    /*
                    if (job != "")
                    {
                        CommandText1 += "username like'" + '%' + job + '%' + "' and ";
                    }
                    */

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
                    {
                        CommandText2 += "  exportid ='" + TxtExportId.Text + "' and ";
                    }

                    if (txtsummary.Text != "")
                    {
                        CommandText2 += "  summary like'" + '%' + txtsummary.Text + '%' + "'and";
                    }

                    if (orgname.Text != "")
                    {
                        CommandText2 += " orgname like'" + '%' + orgname.Text + '%' + "' and ";
                    }
                    /*
                    if (job != "")
                    {
                        CommandText2 += " username like'" + '%' + job + '%' + "' and ";
                    }
                    */
                    if (CmbBxUserName.Text != "اختر مختص")
                    {
                        CommandText2 += " username like'" + '%' + CmbBxUserName.Text + '%' + "' and ";
                    }

                    if (CkBxImportDate.Checked == true)
                    {
                        CommandText2 += "   exportdate >= '" + Dates[0] + "' AND exportdate <= '" + Dates[1] + "'and  ";
                    }

                    if (ChkBxFollowing.Checked == true)
                    {
                        CommandText2 += "   followingdate >= '" + Dates[4] + "' AND followingdate <= '" + Dates[5] + "' and ";
                    }

                    if (txtexportorg.Text != "" || txtexportchange.Text != "" || CkBxImportDate.Checked == true)
                    {
                        //CommandText2 += "  exportid < 0 and";

                    }
                    CommandText2 += "  exportid > 0";
                    Console.WriteLine("first command: " + CommandText1);
                    Console.WriteLine("second command: " + CommandText2);
                    if (TxtImportId.Text != string.Empty && TxtExportId.Text != string.Empty)
                    {
                        MessageBox.Show("لا يمكن البحث برقم صادر و وارد.");

                    }
                    else if (TxtImportId.Text != string.Empty)
                    {
                        Dt1 = Search.QueryExecute(CommandText1);
                        Dt1.DefaultView.Sort = "date DESC,id DESC";
                        Dt1 = Dt1.DefaultView.ToTable();

                        documentDateLabel.Visible = true;
                        documentDate.Visible = true;
                        documentDate.Value = (DateTime)Dt1.Rows[0]["date"];

                        
                        try
                        {
                            DgvSearch.DataSource = Dt1;
                            SearchFile();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("here " + e.Message);
                            MessageBox.Show("here " + e.Message);
                        }


                    }
                    else if (TxtExportId.Text != string.Empty)
                    {
                        Dt2 = Search.QueryExecute(CommandText2);
                        Dt2.DefaultView.Sort = "date DESC,id DESC";
                        Dt2 = Dt2.DefaultView.ToTable();
                        Console.WriteLine("rows count  " + Dt2.Rows.Count);

                        Console.WriteLine(CommandText2);
                        documentDateLabel.Visible = true;
                        documentDate.Visible = true;
                        documentDate.Value = (DateTime)Dt2.Rows[0]["date"];

                        try
                        {
                            DgvSearch.DataSource = Dt2;
                            SearchFile();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message + "   txtexportid");
                            MessageBox.Show(e.Message);
                        }
                    }
                    else
                    {
                        Dt1 = Search.QueryExecute(CommandText1);
                        Dt2 = Search.QueryExecute(CommandText2);
                        DataTable dtMerged = new DataTable();
                        dtMerged.Merge(Dt1);
                        dtMerged.Merge(Dt2);
                        dtMerged.DefaultView.Sort = "date DESC,id DESC";
                        dtMerged = dtMerged.DefaultView.ToTable();
                        documentDateLabel.Visible = true;
                        documentDate.Visible = true;
                        documentDate.Value = (DateTime)Dt2.Rows[0]["date"];

                        try
                        {
                            Console.WriteLine("rows count  merged " + dtMerged.Rows.Count);
                            DgvSearch.DataSource = dtMerged;
                            SearchFile();
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
            }
        }
        private void DgvSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = DgvSearch[7, e.RowIndex].Value.ToString(); //to get id of clicked cell
                Console.WriteLine(id);
                documentDate.Value = (DateTime)DgvSearch[1, e.RowIndex].Value;
                if (id.Contains("و"))
                {
                    DtSearchFile.Clear();
                    string idNum = id.Split('-')[0];
                    TxtImportId.Text = idNum;
                    TxtExportId.Text = string.Empty;
                    string Query = "select * from importfile where id= '" + id + "' ";
                    MySqlDataAdapter da = new MySqlDataAdapter(Query, Search.con);
                    da.Fill(DtSearchFile);

                    byte[] pdfsdata = DtSearchFile.Rows[0]["pdffile"] as byte[];
                    showPdf(pdfsdata);

                }
                if (id.Contains("ص"))
                {
                    DtSearchFile.Clear();
                    TxtImportId.Text = string.Empty;
                    string idNum = id.Split('-')[0];
                    TxtExportId.Text = idNum;

                    string Query = "select * from exportfile where id= '" + id + "' ";
                    MySqlDataAdapter da = new MySqlDataAdapter(Query, Search.con);
                    da.Fill(DtSearchFile);
                    byte[] pdfsdata = DtSearchFile.Rows[0]["pdffile"] as byte[];
                    showPdf(pdfsdata);

                }
            }
            catch (Exception)
            {
            }
        }


        void SearchFile()
        {
            try
            {
                // string docDate = Convert.ToDateTime(documentDate.Value).ToString("yyyy-MM-dd");
                string docDate = "2019-02-15";
                if (TxtImportId.Text != "")
                {
                    TxtExportId.Text = "";
                    DtSearchFile.Clear();
                    //string Query = "select * from importfile where portid= '" + TxtImportId.Text + "' and date = '" + docDate +"' " + " order by date DESC";
                    string Query = "select * from importfile where portid= '" + TxtImportId.Text + "' " + " order by date DESC";

                    MySqlDataAdapter da = new MySqlDataAdapter(Query, Search.con);
                    da.Fill(DtSearchFile);
                    byte[] pdfsdata = DtSearchFile.Rows[0]["pdffile"] as byte[];
                    showPdf(pdfsdata);
                }
                if (TxtExportId.Text != "")
                {
                    TxtImportId.Text = "";
                    DtSearchFile.Clear();
                    //string Query = "select * from exportfile where portid= '" + TxtExportId.Text + "' and date = '" + docDate + "' " + " order by date DESC";
                    string Query = "select * from exportfile where portid= '" + TxtExportId.Text + "' " + " order by date DESC";

                    MySqlDataAdapter da = new MySqlDataAdapter(Query, Search.con);

                    da.Fill(DtSearchFile);

                    byte[] pdfsdata = DtSearchFile.Rows[0]["pdffile"] as byte[];
                    showPdf(pdfsdata);
                }
                Init_Dgv();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        private void TxtExportId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchNew();
            }
        }

        private void show_original_correspondence_Click(object sender, EventArgs e)
        {
            globalIndex = 0;
            if (TxtImportId.Text == string.Empty && TxtExportId.Text == string.Empty)
            {
                MessageBox.Show("ادخل رقم صادر أو وارد للبحث");
            }
            else
            {
                string connectionKey = get_connection_key();
                if (connectionKey == string.Empty)
                {
                    MessageBox.Show("لا يوجد أصل موضوع لهذة الوثيقة");
                    return;
                }
                dtCombinedFilesData = get_combined_files_data(connectionKey);

                string id = (string)dtCombinedFilesData.Rows[0]["uniqueID"];
                display_data();
                byte[] pdfsdata = get_pdf_file(id);
                showPdf(pdfsdata);
                next_btn.Visible = true;
                prev_btn.Visible = true;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string get_connection_key()
        {
            String docDate = Convert.ToDateTime(documentDate.Value).ToString("yyyy-MM-dd");
            string table = (TxtExportId.Text == "") ? "importfile" : "exportfile";
            string id = (TxtExportId.Text == "") ? TxtImportId.Text : TxtExportId.Text;
            string query = "select connection from " + table + " where portid = " + id + " and date = '" + docDate + "'  order by date DESC";
            Console.WriteLine(query);
            DataTable dt = Search.QueryExecute(query);
            string return_value = "";
            if (dt.Rows.Count > 0)
            {
                return_value = (string)dt.Rows[0][0];
            }
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


        private byte[] get_pdf_file(string id)
        {

            string query = "select pdffile from importfile where id = '" + id + "'" +
            " union select pdffile from exportfile where id = '" + id + "'";
            DataTable temp = Search.QueryExecute(query);
            byte[] result_pdf = temp.Rows[0]["pdffile"] as byte[];
            return result_pdf;
        }
        private void display_data()
        {

            txtsummary.Text = (string)dtCombinedFilesData.Rows[globalIndex]["summary"];
            orgname.Text = (string)dtCombinedFilesData.Rows[globalIndex]["orgname"];
            string[] usernames = ((string)dtCombinedFilesData.Rows[globalIndex]["username"]).Split(',');
            utils.FillComoBox(CmbBxUserName, usernames);

            //fillCmbBxUserName(usernames);
            documentDate.Value = (DateTime)dtCombinedFilesData.Rows[globalIndex]["date"];

            string[] id = ((string)dtCombinedFilesData.Rows[globalIndex]["uniqueID"]).Split('-');

            if (id[id.Length - 1] == "ص")
            {
                TxtImportId.Text = String.Empty;
                TxtExportId.Text = (string)dtCombinedFilesData.Rows[globalIndex]["portid"];
            }
            else
            {
                TxtExportId.Text = String.Empty;
                TxtImportId.Text = (string)dtCombinedFilesData.Rows[globalIndex]["portid"];
                string query = "select exportorg,exportorgdate,exportchange from importdata " +
                    "where id = '" + (string)dtCombinedFilesData.Rows[globalIndex]["uniqueID"] + "'";
                DataTable tempDt = Search.QueryExecute(query);
                txtexportchange.Text = (string)tempDt.Rows[0]["exportchange"];
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

        }
        //show the pdf file from byte array
        private void showPdf(byte[] file)
        {
            string path = @"C:\Users\Public\Documents\tempfile'" + globalIndex.ToString() + "'.pdf";
            System.IO.File.WriteAllBytes(path, file);
            AxAcroPDF.Show();
            Pdf.FileName = path;
            AxAcroPDF.LoadFile(path);
        }

        //Check if the user has entered any field to search with
        private Boolean isEmptySearch()
        {
            string[] Temp = new string[7] { TxtExportId.Text,TxtImportId.Text, txtexportorg.Text, txtexportchange.Text,
                txtsummary.Text,orgname.Text,job };

            for (int i = 0; i < Temp.Length; i++)
            {
                if (Temp[i] != string.Empty)
                {
                    return false;
                }
            }
            if (CmbBxUserName.SelectedIndex >= 0)
            {
                return false;
            }

            if (CkBxImportDate.Checked == true)
            {
                return false;
            }

            if (CkBxExportOrg.Checked == true)
            {
                return false;
            }

            if (ChkBxFollowing.Checked == true)
            {
                return false;
            }

            return true;
        }

        private void FillFollowingParams(string [] parameters)
        {
            // fill import or export text box
            if(parameters[0] == "import")
            {
                TxtImportId.Text = parameters[1];
            }
            else
            {
                TxtExportId.Text = parameters[1];
            }
            txtsummary.Text = parameters[2];
          
        }
    }
}
