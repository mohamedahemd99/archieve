﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using Tulpep.NotificationWindow;
using System.Media;
namespace archive
{
    public partial class FormExport : Form
    {
        String ConnectKey = String.Empty;
        ArchieveDatabase Export = new ArchieveDatabase();
        OpenFileDialog Pdf = new OpenFileDialog();
        DataTable DtSearch = new DataTable();
        DataTable DtSearchFile = new DataTable();


        PdfClass MyPdf = new PdfClass();
        //Create Index to exchange between Files 
        int Index = 0;
        int globalPrimId = 0;
        string regist;
        string edit;
        string following;
        string remove;
        string nameOfUser;
        string connectAblity;
        string job;
        string ConnectType = "و";

        public FormExport(string Name, string Password)
        {
            InitializeComponent();
            TxtUser.Text = Name;
            nameOfUser = Name;
        }

        private void FormExport_Load(object sender, EventArgs e)
        {
            GetAuthority();
            //Intializations Of DateTimePicker
            InitDateTimePickers();
            // DgvFile and DgvSubFile Updated
            FillMydata();
            DGV_Headers();
            //Fill CmbBx Of UserName
            FillCmbBxUserName();
            //Set PDF Settings
            SetPDFSettings(); 
        }

        void GetAuthority()
        {
            DataTable Dt = new DataTable();
            string Query = "select * from login where name ='" + TxtUser.Text + "' ";
            Dt = Export.QueryExecute(Query);
            regist = Dt.Rows[0]["register"].ToString();
            edit = Dt.Rows[0]["edit"].ToString();
            following = Dt.Rows[0]["following"].ToString();
            remove = Dt.Rows[0]["remov"].ToString();
            job = Dt.Rows[0]["job"].ToString();
            connectAblity = Dt.Rows[0]["con"].ToString();
            if (following=="0")
            {
                CkbxFollowing.Checked = false;
            }
        }

        void InitDateTimePickers()
        {
            DateExport.Value = DateTime.Now;
            TxtFollowingDate.Value = DateTime.Now;
        }

        void FillMydata()
        {
            DgvOrg.DataSource = Export.QueryExecute("SELECT * FROM org ");
            DgvFile.DataSource = Export.QueryExecute("SELECT * FROM primfile ORDER BY primfileid ");
            globalPrimId = Int32.Parse(DgvFile[0, 0].Value.ToString());
            String Query = "SELECT scndfileid,scndfilename FROM scndfile WHERE primfileid = '" + globalPrimId.ToString() + "'ORDER BY scndfileid";
            DgvSubFile.DataSource = Export.QueryExecute(Query);
        }

        void typechange()
        {
            if (ChkBxImport.Checked == true)
            {
                ChkBxExport.Checked = false;
                ConnectType = "و";
            }
            else
            {
                ChkBxExport.Checked = true;
                ConnectType = "ص";
            }
        }

        private void ChkBxImport_OnChange(object sender, EventArgs e)
        {
            if (ChkBxImport.Checked == true)
            {
                ChkBxExport.Checked = false;
                ConnectType = "و";
            }
            else
            {
                ChkBxExport.Checked = true;
                ConnectType = "ص";
            }
        }

        private void ChkBxExport_OnChange(object sender, EventArgs e)
        {
            if (ChkBxExport.Checked == true)
            {
                ChkBxImport.Checked = false;
                ConnectType = "ص";
            }
            else
            {
                ChkBxImport.Checked = true;
                ConnectType = "و";
            }
        }

        void DGV_Headers()
        {
            DgvOrg.Columns[0].HeaderText = "كودالجهة ";
            DgvOrg.Columns[1].HeaderText = "  اســم الجـهـة";
            DgvFile.Columns[0].HeaderText = "كـود الملف";
            DgvFile.Columns[1].HeaderText = "اسـم المـلف الرئـيـسى" + "";
            DgvSubFile.Columns[0].HeaderText = "كـود الملف ";
            DgvSubFile.Columns[1].HeaderText = "اسم المـلف الفـرعى" + "";
           // DgvSubFile.Columns[2].HeaderText = "كـود الملف الرئيسى" + "";
            DgvOrg.Columns[0].Width = 70;
            DgvFile.Columns[0].Width = 70;
            DgvSubFile.Columns[0].Width = 70;
            DgvOrg.ColumnHeadersHeight = 30;
            DgvFile.ColumnHeadersHeight = 30;
            DgvSubFile.ColumnHeadersHeight = 30;

        }

        void SetPDFSettings()
        {
            Pdf.FileName = "NotEnteredTillNow.pdf";
            AxAcroPDF.src = Pdf.FileName;
            AxAcroPDF.setPageMode("none");
            AxAcroPDF.Show();
            AxAcroPDF.setShowToolbar(false);
            AxAcroPDF.setView("fit");
            AxAcroPDF.setLayoutMode("SinglePage");
            AxAcroPDF.setShowScrollbars(false);
        }

        void FillCmbBxUserName()
        {
            DataTable Dt = new DataTable();
            Dt = Export.QueryExecute("select username from users");
            for (int Index = 0; Index < Dt.Rows.Count; Index++)
            {
                CmbBxUserName.Items.Add(Dt.Rows[Index][0]);
            }
            CmbBxUserName.Text = "اختر مختص";
            //CmbBxUserName.Sorted = true;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            Pdf.Filter = "pdf|*.pdf";
            Pdf.ValidateNames = true;
            Pdf.Title = "اختيار الوثيقة";
            Pdf.Multiselect = false;
            if (Pdf.ShowDialog() == DialogResult.OK)
            {
                AxAcroPDF.src = (Pdf.FileName);
            }
            AxAcroPDF.Show();
        }

        private void CkbxFollowing_OnChange(object sender, EventArgs e)
        {
            if (CkbxFollowing.Checked.ToString() == "True")
            {
                TxtFollowingDate.Visible = true;
            }
            else
            {
                TxtFollowingDate.Visible = false;
            }
        }

        private void DgvOrg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string rowData = DgvOrg[0, e.RowIndex].Value.ToString();
                string clmData = DgvOrg[1, e.RowIndex].Value.ToString();

                if (!(LstBxOrgId.Items.Contains(rowData)))
                {

                    LstBxOrgId.Items.Add(rowData);
                    LstBxOrg.Items.Add(clmData);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void TxtOrgId_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = "select * from org where idorg like '" + '%' + TxtOrgId.Text + '%' + "' ";
                DgvOrg.DataSource = Export.QueryExecute(Query);
            }
            catch (Exception ex)
            { }
        }

        private void CmbBxUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBxUsers.Items.Contains(CmbBxUserName.Text) == false)
            {
                lstBxUsers.Items.Add(CmbBxUserName.Text);
            }
            // CmbBxUserName.Items.Remove(CmbBxUserName.Text);
        }

        private void TxtFileName_OnValueChanged(object sender, EventArgs e)
        {
            string Query = "select * from primfile where primfilename like'" + '%' + TxtFileName.Text + '%' + "' or primfileid like'" + '%' + TxtFileId.Text + '%' + "' ORDER BY primfileid ";
            DgvFile.DataSource = Export.QueryExecute(Query);
        }

        private void DgvSubFile_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtSubFileId.Text = DgvSubFile[0, e.RowIndex].Value.ToString();
                TxtSubFileName.Text = DgvSubFile[1, e.RowIndex].Value.ToString();
            }
            catch (Exception ex) { }
        }

        private void DgvFile_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtFileId.Text = DgvFile[0, e.RowIndex].Value.ToString();
                TxtFileName.Text = DgvFile[1, e.RowIndex].Value.ToString();
                globalPrimId = int.Parse(DgvFile[0, e.RowIndex].Value.ToString());
                string Query = "select scndfileid , scndfilename  from scndfile where primfileid = '" + globalPrimId.ToString() + "'ORDER BY scndfileid";
                DgvSubFile.DataSource = Export.QueryExecute(Query);
                TxtSubFileName.ResetText();
                TxtSubFileId.ResetText();
            }
            catch (Exception ex) { };
        }

        private void TxtFileId_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                String Query = "select * from primfile where primfileid like '" + '%' + TxtFileId.Text + '%' + "'ORDER BY primfileid ";
                DgvFile.DataSource = Export.QueryExecute(Query);
            }
            catch (Exception ex)
            { }
        }

        private void ClearSelectedOrg_Click(object sender, EventArgs e)
        {
            LstBxOrgId.SelectedIndex = LstBxOrg.SelectedIndex;
            LstBxOrgId.Items.Remove(LstBxOrgId.SelectedItem);
            LstBxOrg.Items.Remove(LstBxOrg.SelectedItem);
        }

        private void TxtOrgName_OnValueChanged(object sender, EventArgs e)
        {
            String Query = "select * from org where orgname like'" + '%' + TxtOrgName.Text + '%' + "' ";
            DgvOrg.DataSource = Export.QueryExecute(Query);
        }

        private void TxtImportId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
                SearchFile();
            }else if(e.KeyCode == Keys.Escape)
            {
                Clear();
            }
        }

         void Clear()
        {
            TxtFollowingDate.ResetText();
            DateExport.Refresh();
            TxtExportId.ResetText();
            TxtOrgId.ResetText();
            TxtOrgName.ResetText();
            TxtSummary.ResetText();
            TxtFileId.ResetText();
            TxtSubFileId.ResetText();
            TxtFileName.ResetText();
            TxtSubFileName.ResetText();
            TxtAction.ResetText();
            Pdf.FileName = "NotEnteredTillNow.pdf";
            AxAcroPDF.Hide();
            CkbxFollowing.Checked = false;
            TxtFollowingDate.Hide();
            TxtSubFileName.ResetText();
            LstBxOrg.Items.Clear();
            LstBxOrgId.Items.Clear();
            lstBxUsers.Items.Clear();
            TxtCon.ResetText();
            TxtDate.ResetText();
            InitDateTimePickers();
        }

        void DeleteAll()
        {
            String DeleteQuery = "delete  FROM archieve.exportdata where id= '" + TxtExportId.Text + '-' + DateExport.Value.Year + '-' + "ص" + "'";
            int Executed = Export.MyExecuteNonQuery(DeleteQuery);
            if (Executed == 1)
            {
                note("تم حذف البيانات بنجاح");
               // MessageBox.Show("تم حذف البيانات بنجاح");
                String DeleteQuery1 = "delete  FROM archieve.exportfile where id= '" + TxtExportId.Text + '-' + DateExport.Value.Year + '-' + "ص" + "'";
                int Executed1 = Export.MyExecuteNonQuery(DeleteQuery1);
                if (Executed1 == 1)
                {
                   // MessageBox.Show("تم حذف الملف بنجاح");
                }
                else
                {
                    note("لم يتم حذف البيانات بنجاح ");
                }

            }
            else
            {
                MessageBox.Show("لم يتم الحذف");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (remove == "1")
            {
                try
                {
                    DialogResult Result = MessageBox.Show("هل انت متاكد من حذف هذه الوثيقة", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (Result == DialogResult.Yes)
                    {
                        DeleteAll();
                        Clear();
                    }
                    else { MessageBox.Show("لم يتم الحذف"); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("غير مسموح لك بخذف مكاتبة");
            }
        }

        void Search()
        {
            Index = 0;
            DtSearch.Clear();
            string Query = "select * from exportdata where";
            if (TxtExportId.Text != "")
            {
                Query += "   exportid = '" + TxtExportId.Text + "' and";
            }

            if (TxtOrgId.Text != "")
            {
                Query += " orgid like '" + '%' + "," + TxtOrgId.Text + "," + '%' + "' and ";
            }
            Query += "  summary like'" + '%' + TxtSummary.Text + '%' + "'";
            Query += " and orgname like'" + '%' + TxtOrgName.Text + '%' + "'";

            String DateFollow = Convert.ToDateTime(TxtFollowingDate.Value).ToString("yyyy-MM-dd");
            if (CkbxFollowing.Checked == true)
            {
                Query += " and  followingdate >= '" + DateFollow + "' AND followingdate <= '" + DateFollow + "' ";
            }
            Query += " ORDER BY exportdate DESC ";
            MySqlDataAdapter da = new MySqlDataAdapter(Query, Export.con);
            da.Fill(DtSearch);

            if (DtSearch.Rows.Count != 0)
            {
                DisplayData(0);
            }
            else
            {
                MessageBox.Show("لا توجد معلومات مسجلة ");
            }
        }

        void SearchFile()
        {
            //Index = 0;
            DtSearchFile.Clear();
            string Query = "select * from exportfile where id= '" + TxtExportId.Text + '-' + DateExport.Value.Year + '-' + "ص" + "' ";
            MySqlDataAdapter da = new MySqlDataAdapter(Query, Export.con);
            da.Fill(DtSearchFile);
            Console.WriteLine(DtSearchFile.Rows.Count);
            if (DtSearchFile.Rows.Count != 0)
            {
                DisplayDataFile(0);
            }
        }

        void DisplayDataFile(int index)
        {
            int FileIndex = index;
            ConnectKey = DtSearchFile.Rows[FileIndex]["connection"].ToString();
            //Console.WriteLine(ConnectKey);
            if (ConnectKey !="")
            {
                string[] ConnectId = DtSearchFile.Rows[FileIndex]["connection"].ToString().Split('-');
                TxtCon.Text = ConnectId[0];
                TxtDate.Text = ConnectId[1];
                string type = ConnectId[2];
                if (type == "ص")
                {
                    ChkBxExport.Checked = true;
                    ChkBxImport.Checked = false;
                }
                if (type == "و")
                {
                    ChkBxImport.Checked = true;
                    ChkBxExport.Checked = false;

                }
            }

            byte[] pdfsdata = DtSearchFile.Rows[FileIndex]["pdffile"] as byte[];
            string path = @"C:\Users\Public\Documents\tempfile'" + "'.pdf";
            //Console.WriteLine(path);
            System.IO.File.WriteAllBytes(path, pdfsdata);
            AxAcroPDF.Show();
            Pdf.FileName = path;
            AxAcroPDF.LoadFile(path);

        }

        void DisplayData(int index)
        {
            int FileIndex = index;
            if (DtSearch.Rows[0]["username"].ToString().Contains(job))
            {

                      TxtExportId.Text = DtSearch.Rows[FileIndex]["exportid"].ToString();
                      DateExport.Value = Convert.ToDateTime(DtSearch.Rows[FileIndex]["exportdate"]);
                      TxtSummary.Text = DtSearch.Rows[FileIndex]["summary"].ToString();
                         if (Convert.ToBoolean(DtSearch.Rows[FileIndex]["following"]) == true)
                         {
                            CkbxFollowing.Checked = true;
                            TxtFollowingDate.Visible = true;
                            TxtFollowingDate.Value = Convert.ToDateTime(DtSearch.Rows[FileIndex]["followingdate"]);
                         }
                           else
                           {
                                CkbxFollowing.Checked = false;
                                TxtFollowingDate.Visible = false;
                           }

                    string[] Words = DtSearch.Rows[FileIndex]["orgid"].ToString().Split(',');
                    for (int j = 0; j < Words.Length; j++)
                    {
                        Words[j] = Words[j].TrimStart(' ');
                        Words[j] = Words[j].TrimEnd(' ');

                        LstBxOrgId.Items.Add(Words[j]);
                    }

                        string[] Words1 = DtSearch.Rows[FileIndex]["orgname"].ToString().Split(',');
                        for (int j = 0; j < Words1.Length; j++)
                        {
                            Words1[j] = Words1[j].TrimStart(' ');
                            Words1[j] = Words1[j].TrimEnd(' ');

                            LstBxOrg.Items.Add(Words1[j]);
                        }


                        string[] words2 = DtSearch.Rows[FileIndex]["username"].ToString().Split(',');
                        for (int j = 0; j < words2.Length; j++)
                        {
                            words2[j] = words2[j].TrimStart(' ');
                            words2[j] = words2[j].TrimEnd(' ');
                            lstBxUsers.Items.Add(words2[j]);
                        }



            TxtFileName.Text = DtSearch.Rows[FileIndex]["primaryfile"].ToString();
            TxtSubFileName.Text = DtSearch.Rows[FileIndex]["secondfile"].ToString();
            TxtAction.Text = DtSearch.Rows[FileIndex]["action"].ToString();
            TxtFileId.Text = DtSearch.Rows[FileIndex]["primaryfileid"].ToString();
            TxtSubFileId.Text = DtSearch.Rows[FileIndex]["secondfileid"].ToString();
            TxtUser.Text = DtSearch.Rows[FileIndex]["user"].ToString();


            }
            else
            {
                MessageBox.Show("ليس لديك صلاحية لرؤية هذة الوثيقة");
            }
        }

        void SaveData()
        {
            if (TxtExportId.Text != "")
            {

                int ChkBx;
                int Index = 0;
                string UsersName = string.Empty;
                string OrgsName = string.Empty;
                string OrgsId = ",";

                try
                {
                    String FollowingDate = Convert.ToDateTime(TxtFollowingDate.Value).ToString("yyyy-MM-dd");
                    String ExportDate = Convert.ToDateTime(DateExport.Value).ToString("yyyy-MM-dd");

                    if (CkbxFollowing.Checked.ToString() == "True")
                    {
                        TxtFollowingDate.Visible = true;
                        ChkBx = 1;
                        FollowingDate = Convert.ToDateTime(TxtFollowingDate.Value).ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        ChkBx = 0;
                        FollowingDate = null;
                    }

                    for (Index = 0; Index < lstBxUsers.Items.Count; Index++)
                    {
                        UsersName += lstBxUsers.Items[Index].ToString();
                        if (Index < lstBxUsers.Items.Count - 1) { UsersName += " , "; }
                    }

                    for (Index = 0; Index < LstBxOrg.Items.Count; Index++)
                    {
                        OrgsName += LstBxOrg.Items[Index].ToString();
                        if (Index < LstBxOrg.Items.Count - 1) { OrgsName += " , "; }
                    }
                    for (Index = 0; Index < LstBxOrgId.Items.Count; Index++)
                    {
                        OrgsId += LstBxOrgId.Items[Index].ToString() + ",";
                    }

                    string InsertQuery = "INSERT INTO exportdata(id,exportid , exportdate ,summary , following , followingdate , orgid  , orgname ,action,primaryfile,secondfile,primaryfileid,secondfileid,user, username) VALUES ('" + TxtExportId.Text + '-' + DateExport.Value.Year + '-' + "ص" + "','" + TxtExportId.Text + "','" + ExportDate + "','" + TxtSummary.Text + "','" + ChkBx + "' , @followdate , '" + OrgsId + "', '" + OrgsName + "','" + TxtAction.Text + "' ,'" + TxtFileName.Text + "','" + TxtSubFileName.Text + "','" + TxtFileId.Text + "','" + TxtSubFileId.Text + "','" + TxtUser.Text + "', @usernamelst) ";
                    MySqlCommand cmd = new MySqlCommand(InsertQuery, Export.con);
                    cmd.Parameters.AddWithValue("@usernamelst", UsersName);
                    cmd.Parameters.AddWithValue("@followdate", FollowingDate);
                    if (Export.con.State == ConnectionState.Closed)
                    {
                        Export.con.Open();
                    }
                    int Check = cmd.ExecuteNonQuery();
                    Export.con.Close();
                    if (Check == 1)
                    {
                        note("تم حفظ البيانات");
                    }
                    else
                    {
                        note(" لم يتم حفظ البيانات");
                    }

                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("هذه البيانات غير صحيحة ");
                }

            }
            else
            {
                MessageBox.Show(" من فضلك قم بادخال رقم الصادر");
            }
        }

        void SaveFile()
        {
            try
            {
                 typechange();
                byte[] PdfData;
                if (TxtExportId.Text != "")
                {
                    PdfData = File.ReadAllBytes(Pdf.FileName);
                   Connect();
                    String ExportDate = Convert.ToDateTime(DateExport.Value).ToString("yyyy-MM-dd");
                    string InsertQuery = "INSERT INTO exportfile(id,pdffile,Connection,date,portid ) VALUES ('" + TxtExportId.Text + '-' + DateExport.Value.Year + '-' + "ص" + "', @data,'" + ConnectKey + "','" + ExportDate + "','" + TxtExportId.Text +"') ";
                    MySqlCommand cmd = new MySqlCommand(InsertQuery, Export.con);
                    cmd.Parameters.AddWithValue("@data", PdfData);
                    if (Export.con.State == ConnectionState.Closed)
                    {
                        Export.con.Open();
                    }
                    int Check = cmd.ExecuteNonQuery();
                    Export.con.Close();
                    if (Check == 1)
                    {
                    }
                    else
                    {
                        MessageBox.Show(" لم يتم حفظ الملف");
                    }
                }
                else
                {
                    MessageBox.Show("من فضلك ادخل رقم الصادر");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (regist == "1")
            {
                SaveData();
                SaveFile();
                Clear();
            }
            else
            {
                MessageBox.Show("غير مسموح لك بتسجيل المكاتبة");
            }
        }

        void EditData()
        {

            int chkbx;
            int Index = 0;         
            string UserName = string.Empty;
            string OrgsName = string.Empty;
            string OrgsId = ",";
            String ImportDate = Convert.ToDateTime(DateExport.Value).ToString("yyyy-MM-dd");
            String FollowingDate = Convert.ToDateTime(TxtFollowingDate.Value).ToString("yyyy-MM-dd");

            if (CkbxFollowing.Checked.ToString() == "True")
            {
                TxtFollowingDate.Visible = true;
                FollowingDate = Convert.ToDateTime(TxtFollowingDate.Value).ToString("yyyy-MM-dd");
                chkbx = 1;
            }
            else
            {
                FollowingDate = null;
                chkbx = 0;
            }

            for (Index = 0; Index < lstBxUsers.Items.Count; Index++)
            {
                UserName += lstBxUsers.Items[Index].ToString();
                if (Index < lstBxUsers.Items.Count - 1) { UserName += " , "; }
            }
            for (Index = 0; Index < LstBxOrg.Items.Count; Index++)
            {
                OrgsName += LstBxOrg.Items[Index].ToString();
                if (Index < LstBxOrg.Items.Count - 1) { OrgsName += " , "; }
            }
            for (Index = 0; Index < LstBxOrgId.Items.Count; Index++)
            {
                OrgsId += LstBxOrgId.Items[Index].ToString() + ",";
            }
            string UpdateQuery = "UPDATE exportdata SET exportdate='" + ImportDate + "',summary='" + TxtSummary.Text + "', following='" + chkbx + "',orgid='" + OrgsId + "',orgname= '" + OrgsName + "',action='" + TxtAction.Text + "', primaryfile='" + TxtFileName.Text + "',secondfile= '" + TxtSubFileName.Text + "', primaryfileid='" + TxtFileId.Text + "',secondfileid= '" + TxtSubFileId.Text + "',followingdate= @followdate,username=@usernamelst  where  id= '" + TxtExportId.Text + '-' + DateExport.Value.Year + '-' + "ص" + "' ";
            MySqlCommand cmd = new MySqlCommand(UpdateQuery, Export.con);
            cmd.Parameters.AddWithValue("@followdate", FollowingDate);
            cmd.Parameters.AddWithValue("@usernamelst", UserName);
            if (Export.con.State == ConnectionState.Closed)
            {
                Export.con.Open();
            }
            int Check = cmd.ExecuteNonQuery();
            Export.con.Close();

            if (Check == 1)
            {
                note("تم تعديل البيانات بنجاح");
            }
            else
            {
                note("لم يتم التعديل");
            }
        }

        void EditFile()
        {
            typechange();
            byte[] PdfData;
            String ExportDate = Convert.ToDateTime(DateExport.Value).ToString("yyyy-MM-dd");

            PdfData = File.ReadAllBytes(Pdf.FileName);           
            Connect();
            string UpdateQuery = "UPDATE exportfile SET pdffile=@data , connection = '" + ConnectKey + "',date= '" + ExportDate + "',portid = '" + TxtExportId.Text +"' where id = '" + TxtExportId.Text + '-' + DateExport.Value.Year + '-' + "ص" + "' ";
            MySqlCommand cmd = new MySqlCommand(UpdateQuery, Export.con);
            cmd.Parameters.AddWithValue("@data", PdfData);
            if (Export.con.State == ConnectionState.Closed)
            {
                Export.con.Open();
            }
            int Check = cmd.ExecuteNonQuery();
            Export.con.Close();

            if (Check == 1)
            {
              //  MessageBox.Show("تم تعديل الملف بنجاح");
            }
            else
            {
                MessageBox.Show("لم يتم التعديل الملف");
            }

        }
  
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (edit == "1")
            {
                try
                {
                    DialogResult result = MessageBox.Show("هل انت متاكد من تعديل هذه الوثيقة", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (result == DialogResult.Yes)
                    {
                        EditData();
                        EditFile();
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("لم يتم التعديل");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else { MessageBox.Show("غير مسموح لك بتعديل مكاتبة"); }
        }

        private void BtnConnection_Click(object sender, EventArgs e)
        {
            String FinalPath = string.Empty;
            String CommandText = string.Empty;
            String CommandText1 = string.Empty;
            String CommandText2 = string.Empty;
            try
            {
                DataTable Dtlong = new DataTable();
                DataTable Dtlongall = new DataTable();
                DataTable Dt1 = new DataTable();
                DataTable Dt2 = new DataTable();
                DataTable Dt3 = new DataTable();
                DataTable Dt4 = new DataTable();
                if (ConnectKey != "")
                {
                    string queryExport = "select pdffile,date,portid from exportfile where id in (SELECT id FROM exportfile  where connection = '" + ConnectKey + "')";
                    string queryImport = "select pdffile,date,portid from importfile where id in (SELECT id FROM importfile  where connection = '" + ConnectKey + "')";
                    Dt1 = Export.QueryExecute(queryExport);
                    Dt2 = Export.QueryExecute(queryImport);
                    Dtlongall.Merge(Dt1);
                    Dtlongall.Merge(Dt2);
                    Dtlongall.DefaultView.Sort = "date DESC, portid DESC";
                    Dtlongall = Dtlongall.DefaultView.ToTable();
                    FinalPath = MyPdf.CreatePdfs(Dtlongall);
                    AxAcroPDF.src = FinalPath;

                }
                else
                {
                    CommandText = "select pdffile from exportfile where id= '" + TxtExportId.Text + '-' + DateExport.Value.Year + '-' + "ص" + "' ";
                    Dtlongall = Export.QueryExecute(CommandText);
                    FinalPath = MyPdf.CreatePdfs(Dtlongall);
                    AxAcroPDF.src = FinalPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (connectAblity == "1")
            {
                FormConection MyFormConnection = new FormConection(TxtUser.Text);
                MyFormConnection.Show();
            }
            else
            {
                MessageBox.Show("غير مسموح لك بدخول هذة الصفحة");
            }
        }

        private void Connect()
        {
            DataTable Dt = new DataTable();
            try
            {

                if (ChkBxImport.Checked == true)
                {
                    String Query = "select  connection from importfile where id = '" + TxtCon.Text + '-' + TxtDate.Text + '-' + ConnectType + "'";
                    Dt = Export.QueryExecute(Query);
                    int count = Dt.Rows.Count;
                    if (count == 1)
                    {
                        ConnectKey = Dt.Rows[0][0].ToString();

                        if (ConnectKey == "")
                        {
                            ConnectKey = TxtCon.Text + "-" + TxtDate.Text + "-" + ConnectType[0];
                            String UpdateQuery = "UPDATE importfile SET Connection = '" + ConnectKey + "'where id = '" + TxtCon.Text + '-' + TxtDate.Text + '-' + ConnectType + "'";
                            Export.QueryExecute(UpdateQuery);
                        }
                    }
                    else
                    {
                        ConnectKey = "";
                    }

                
            }


                if (ChkBxExport.Checked == true)
                {

                    String Query = "select connection from exportfile where id = '" + TxtCon.Text + '-' + TxtDate.Text + '-' + ConnectType + "'";
                    Dt = Export.QueryExecute(Query);
                    int count = Dt.Rows.Count;
                    if (count == 1)
                    {
                        ConnectKey = Dt.Rows[0][0].ToString();

                        if (ConnectKey == "")
                        {
                            ConnectKey = TxtCon.Text + "-" + TxtDate.Text + "-" + ConnectType;
                            String UpdateQuery = "UPDATE exportfile SET Connection = '" + ConnectKey + "'where id = '" + TxtCon.Text + '-' + TxtDate.Text + '-' + ConnectType + "'";
                            Export.QueryExecute(UpdateQuery);
                        }
                    }
                    else
                    {
                        ConnectKey = "";
                    }

                }

            }

            catch (Exception ex)
            {
            }
        }


        private void BtnPast_Click(object sender, EventArgs e)
        {
            Clear();
            --Index;
            if (Index > DtSearch.Rows.Count - 1)
            {
                Index = 0;
            }
            else if (Index < 0)
            {
                Index = DtSearch.Rows.Count - 1;
            }
            if (DtSearch.Rows.Count != 0)
            {
                DisplayData(Index);
             
            }
            SearchFile();

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            Clear();
            ++Index;

            if (Index > DtSearch.Rows.Count - 1)
            {
                Index = 0;
            }
            else if (Index < 0)
            {
                Index = DtSearch.Rows.Count - 1;
            }
            if (DtSearch.Rows.Count != 0)
            {
                DisplayData(Index);
            }

            SearchFile();

        }

        private void TxtSubFileId_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                String Query = "select scndfileid,scndfilename from scndfile where scndfileid ='" + TxtSubFileId.Text + "'and  primfileid = '" + TxtFileId.Text + "'ORDER BY scndfileid ";
                DgvSubFile.DataSource = Export.QueryExecute(Query);
            }
            catch (Exception ex)
            { }
        }

        private void LstBxOrg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LstBxOrgId.SelectedIndex = LstBxOrg.SelectedIndex;
                LstBxOrgId.Items.Remove(LstBxOrgId.SelectedItem);
                LstBxOrg.Items.Remove(LstBxOrg.SelectedItem);
            }
        }

        private void LstBxOrg_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LstBxOrgId.SelectedIndex = LstBxOrg.SelectedIndex;
            LstBxOrgId.Items.Remove(LstBxOrgId.SelectedItem);
            LstBxOrg.Items.Remove(LstBxOrg.SelectedItem);
        }

        private void lstBxUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lstBxUsers.Items.Remove(lstBxUsers.SelectedItem);
        }

        private void bunifuCustomLabel14_Click(object sender, EventArgs e)
        {
            TxtFileName.ResetText();
            TxtFileId.ResetText();
        }

        private void labelFileName_Click(object sender, EventArgs e)
        {
            TxtFileName.ResetText();
            TxtFileId.ResetText();
        }

        private void labelSubFileId_Click(object sender, EventArgs e)
        {
            TxtSubFileId.ResetText();
            TxtSubFileName.ResetText();
        }

        void note(string text)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "مرحبا بك  ";
            popup.ContentText = text;
            popup.ShowCloseButton = true;
            popup.ShowOptionsButton = true;
            popup.ContentFont = new Font("Tahoma", 15);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.TitleColor = Color.White;
            popup.BorderColor = Color.CornflowerBlue;
            popup.BodyColor = Color.CornflowerBlue;
            popup.ContentColor = Color.DarkBlue;       // should be
            popup.ContentHoverColor = Color.DarkBlue;   // the same
            popup.AnimationDuration = 1000;
            popup.AnimationInterval = 1;
            popup.HeaderColor = Color.DodgerBlue;
            popup.ButtonHoverColor = Color.CadetBlue;
            popup.ContentPadding = new Padding(0);
            popup.ShowGrip = true;
            popup.Scroll = true;
            popup.Popup();// show  

            SoundPlayer splayer = new SoundPlayer(@"11.wav");
            splayer.Play();
        }
    }

}
