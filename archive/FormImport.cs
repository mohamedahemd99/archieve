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
using System.IO;
using System.Web;
using Tulpep.NotificationWindow;
using System.Media;



namespace archive
{
    public partial class FormImport : Form
    {
        String ConnectKey = String.Empty;
        PdfClass MyPdf = new PdfClass();
        //Create Archive Object 
        ArchieveDatabase Archive = new ArchieveDatabase();
        //Create OpenFileDialog To open Pdf
        OpenFileDialog Pdf = new OpenFileDialog();
        //Create DataTable to put Searched files
        DataTable DtSearch = new DataTable();
        DataTable DtSearchFile = new DataTable();
        //Create Index to exchange between Files 
        int Index = 0;
        //Create primarySubject  
        String PrimarySubject = "";
        //Create GlobalPrimId  
        int GlobalPrimId = 0;
        string Regist;
        string Edit;
        string Following;
        string Remove;
        String job;
        string ConnectAblity;
        string NameOfUser;
        String ConnectType = "و";



        public FormImport(string Name ,string password)
        {
            InitializeComponent();
            TxtUser.Text = Name;
            NameOfUser = Name;
        }

        private void Forminsert_Load(object sender, EventArgs e)
        {
            Authority();
            //Intializations Of DateTimePicker
            InitDateTimePickers();
            //Fill CmbBx Of UserName
            FillCmbBxUserName();
            // DgvFile and DgvSubFile Updated
            FillMydata();
            DGV_Headers();
            //Set PDF Settings
            SetPDFSettings();
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
        void Authority()
        {
            DataTable Dt = new DataTable();
            String Quary = "select * from login where name ='" + TxtUser.Text + "' ";
            Dt = Archive.QueryExecute(Quary);
            Regist = Dt.Rows[0]["register"].ToString();
            Edit = Dt.Rows[0]["edit"].ToString();
            Following = Dt.Rows[0]["following"].ToString();
            Remove = Dt.Rows[0]["remov"].ToString();
            job = Dt.Rows[0]["job"].ToString();
            ConnectAblity = Dt.Rows[0]["con"].ToString();
            if (Following == "0")
            {
                CkbxFollowing.Checked = false;
            }
        }

        void InitDateTimePickers ()
        {
            DateImport.Value = DateTime.Now;
            DateExportOrg.Value = DateTime.Now;
            TxtFollowingDate.Value = DateTime.Now;
        }

        void FillMydata()
        {
            DgvOrg.DataSource = Archive.QueryExecute("SELECT * FROM org ");
            DgvFile.DataSource = Archive.QueryExecute("SELECT * FROM primfile ORDER BY primfileid ");
            GlobalPrimId = Int32.Parse(DgvFile[0, 0].Value.ToString());
            String Quary = "SELECT scndfileid,scndfilename FROM scndfile WHERE primfileid = '" + GlobalPrimId.ToString() + "'ORDER BY scndfileid";
            DgvSubFile.DataSource = Archive.QueryExecute(Quary);
        }

        void DGV_Headers()
        {
            DgvOrg.Columns[0].HeaderText = "كــودالجـهة";
            DgvOrg.Columns[1].HeaderText = "     اســـم الجـهة      ";
            DgvFile.Columns[0].HeaderText = "كـود المـلف";
            DgvFile.Columns[1].HeaderText = "اسـم المـلف الرئـيسى" + "";
            DgvSubFile.Columns[0].HeaderText = "كـود المـلف ";
            DgvSubFile.Columns[1].HeaderText = "اسم الملف الفرعى" + "";
            DgvOrg.Columns[0].Width = 70;
            DgvFile.Columns[0].Width = 70;
            DgvSubFile.Columns[0].Width = 70;
            DgvOrg.ColumnHeadersHeight = 30;
          //  DgvOrg.RowTemplate.Height = 40;
         //   DgvOrg.RowTemplate.MinimumHeight = 90;

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

        void FillCmbBxUserName ()
        {
            DataTable Dt = new DataTable();
            Dt = Archive.QueryExecute("select username from users");
            for (int Index = 0; Index<Dt.Rows.Count ; Index++)
            {
                CmbBxUserName.Items.Add(Dt.Rows[Index][0]);
            }
            CmbBxUserName.Text = "اختر مختص";
            //CmbBxUserName.Sorted = true;
        }

        void ClearInputs()
        {

            TxtExportChange.ResetText();
            TxtExportOrg.ResetText();
            DateExportOrg.ResetText();
            TxtFollowingDate.ResetText();
            DateImport.Refresh();
            TxtImportId.ResetText();
            TxtOrgId.ResetText();
            TxtOrgName.ResetText();
            TxtSummary.ResetText();
            TxtFileId.ResetText();
            TxtSubFileId.ResetText();
            TxtFileName.ResetText();
            TxtSubFileName.ResetText();
            FilesFound.Visible = false;
            TxtAction.ResetText();
            Pdf.FileName = "NotEnteredTillNow.pdf";
            AxAcroPDF.Hide();
            CkbxFollowing.Checked = false;
            TxtFollowingDate.Hide();
            TxtSubFileName.ResetText();
            TxtMinisterNum.ResetText();
            TxtSerial.ResetText();
            TxtSeialK.ResetText();
            TxtSeialG.ResetText();
            TxtCon.ResetText();
            lstBxUsers.Items.Clear();
            TxtCon.ResetText();
            TxtDate.ResetText();
            InitDateTimePickers();
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
        private void BtnConnection_Click(object sender, EventArgs e)
        {
            String FinalPath = System.String.Empty;
            String CommandText = System.String.Empty;
            String CommandText1 = System.String.Empty;
            String CommandText2 = System.String.Empty;
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
                    /*
                    CommandText1 = "SELECT id FROM exportfile  where connection = '" + ConnectKey + "'";
                    CommandText2 = "SELECT id FROM importfile  where connection = '" + ConnectKey + "'";
                    Dt1 = Archive.QueryExecute(CommandText1);
                    Dt2 = Archive.QueryExecute(CommandText2);
                    foreach (DataRow dtRow in Dt1.Rows)
                    {
                        string id = "select pdffile,date,portid from exportfile where id= '" + dtRow[0].ToString() + "'";
                        Dt3 = Archive.QueryExecute(id);
                        Dtlong.Merge(Dt3);
                    }
                    foreach (DataRow dtRow in Dt2.Rows)
                    {
                        string id = "select pdffile,date,portid from importfile where id= '" + dtRow[0].ToString() + "' ";
                        Dt4 = Archive.QueryExecute(id);
                        Dtlongall.Merge(Dt4);
                    }
                    Dtlongall.Merge(Dtlong);
                    Dtlongall.DefaultView.Sort = "date DESC, portid DESC";
                    Dtlongall = Dtlongall.DefaultView.ToTable();
                    FinalPath = MyPdf.CreatePdfs(Dtlongall);
                    AxAcroPDF.src = FinalPath;
                    */
                    string queryExport = "select pdffile,date,portid from exportfile where id in (SELECT id FROM exportfile  where connection = '" + ConnectKey + "')";
                    string queryImport = "select pdffile,date,portid from importfile where id in (SELECT id FROM importfile  where connection = '" + ConnectKey + "')";
                    Dt1 = Archive.QueryExecute(queryExport);
                    Dt2 = Archive.QueryExecute(queryImport);
                    Dtlongall.Merge(Dt1);
                    Dtlongall.Merge(Dt2);
                    Dtlongall.DefaultView.Sort = "date DESC, portid DESC";
                    Dtlongall = Dtlongall.DefaultView.ToTable();
                    FinalPath = MyPdf.CreatePdfs(Dtlongall);
                    AxAcroPDF.src = FinalPath;

                }
                else
                {
                    CommandText = "select pdffile from importfile where id= '" + TxtImportId.Text + '-' + DateImport.Value.Year + '-' + "و" + "' ";
                    Dtlongall = Archive.QueryExecute(CommandText);
                    FinalPath = MyPdf.CreatePdfs(Dtlongall);
                    AxAcroPDF.src = FinalPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TxtImportId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
                SearchFile();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        void DisplayDataFile(int index)
        {
            int FileIndex = index;
          // FilesFound.Text = " العثور على عدد " + (index + 1).ToString() + "/" + DtSearchFile.Rows.Count.ToString() + " من الوثائق";
            ConnectKey = DtSearchFile.Rows[FileIndex]["connection"].ToString();
            if (ConnectKey != "")
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
            System.IO.File.WriteAllBytes(path, pdfsdata);
            AxAcroPDF.Show();
            Pdf.FileName = path;
            AxAcroPDF.LoadFile(path);

        }
        void DisplayData(int index)
        {

            int FileIndex = index;
         FilesFound.Text = " العثور على عدد " + (index + 1).ToString() + "/" + DtSearch.Rows.Count.ToString() + " من الوثائق";

            if (DtSearch.Rows[0]["username"].ToString().Contains(job))
            {
            TxtImportId.Text = DtSearch.Rows[FileIndex]["importid"].ToString();
            DateImport.Value = Convert.ToDateTime(DtSearch.Rows[FileIndex]["importdate"]);
            TxtExportOrg.Text = DtSearch.Rows[FileIndex]["exportorg"].ToString();
            DateExportOrg.Value = Convert.ToDateTime(DtSearch.Rows[FileIndex]["exportorgdate"]);
            TxtExportChange.Text = DtSearch.Rows[FileIndex]["exportchange"].ToString();
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

            TxtOrgId.Text = DtSearch.Rows[FileIndex]["orgid"].ToString();
            TxtOrgName.Text = DtSearch.Rows[FileIndex]["orgname"].ToString();

            string[] Words = DtSearch.Rows[FileIndex]["username"].ToString().Split(',');
            for (int j = 0; j < Words.Length; j++)
            {
                Words[j] = Words[j].TrimStart(' ');
                Words[j] = Words[j].TrimEnd(' ');
                lstBxUsers.Items.Add(Words[j]);
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

        void DeleteAll()
        {
            String DeleteQuery = "delete  FROM importdata where id= '" + TxtImportId.Text + '-' + DateImport.Value.Year + '-' + "و" + "'";
            int Executed = Archive.MyExecuteNonQuery(DeleteQuery);
            if (Executed == 1)
            {
                note("تم حذف البيانات بنجاح");
                //MessageBox.Show("تم حذف البيانات بنجاح");
                String DeleteQuery1 = "delete  FROM importfile where id= '" + TxtImportId.Text + '-' + DateImport.Value.Year + '-' + "و" + "'";
                int Executed1 = Archive.MyExecuteNonQuery(DeleteQuery1);
                if (Executed1 == 1)
                {
                   // MessageBox.Show("تم حذف الملف بنجاح");
                }
                else
                {
                    note("لم يتم حذف البيانات بنجاح ");
                    //MessageBox.Show("تم حذف الملف بنجاح لم  ");

                }

            }
            else
            {
                MessageBox.Show("لم يتم الحذف");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (Remove == "1")
            {
                try
                {
                    DialogResult result = MessageBox.Show("هل انت متاكد من حذف هذه الوثيقة", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (result == DialogResult.Yes)
                    {
                        DeleteAll();
                        FillMydata();                                                     
                        ClearInputs();
                       
                    }
                    else
                    {
                        MessageBox.Show("لم يتم الحذف");
                    }
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
        void EditData()
        {

            int chkbx;
            int Index = 0;
            string UserName = System.String.Empty;

            String exportorgdate = Convert.ToDateTime(DateExportOrg.Value).ToString("yyyy-MM-dd");
            String ImportDate = Convert.ToDateTime(DateImport.Value).ToString("yyyy-MM-dd");
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
            string UpdateQuery = "UPDATE importdata SET exportorg ='" + TxtExportOrg.Text + "',importdate='" + ImportDate + "',exportorgdate= '" + exportorgdate + "',exportchange= '" + TxtExportChange.Text + "',summary='" + TxtSummary.Text + "', following='" + chkbx + "',followingdate= @followdate,orgid='" + TxtOrgId.Text + "',orgname= '" + TxtOrgName.Text + "',action='" + TxtAction.Text + "',username=@usernamelst ,primaryfile='" + TxtFileName.Text + "',secondfile= '" + TxtSubFileName.Text + "',primaryfileid='" + TxtFileId.Text + "',secondfileid='" + TxtSubFileId.Text + "' where  id= '" + TxtImportId.Text + '-' + DateImport.Value.Year + '-' + "و" + "'";
            MySqlCommand cmd = new MySqlCommand(UpdateQuery, Archive.con);
            cmd.Parameters.AddWithValue("@followdate", FollowingDate);
            cmd.Parameters.AddWithValue("@usernamelst", UserName);
            if (Archive.con.State == ConnectionState.Closed)
            {
                Archive.con.Open();
            }
            int Check = cmd.ExecuteNonQuery();
            Archive.con.Close();

            if (Check == 1)
            {
                note("تم تعديل البيانات بنجاح");

              //  MessageBox.Show("تم تعديل البيانات بنجاح");
            }
            else
            {
               // MessageBox.Show("لم يتم التعديل");
                note("لم يتم التعديل");
            }
        }
        void EditFile()
        {
            typechange();
            byte[] PdfData;
            String ImportDate = Convert.ToDateTime(DateImport.Value).ToString("yyyy-MM-dd");

            PdfData = File.ReadAllBytes(Pdf.FileName);
            Connect();
            string UpdateQuery = "UPDATE importfile SET pdffile=@data , connection = '" + ConnectKey + "',date= '" + ImportDate + "',portid = '" + TxtImportId.Text + "' where id = '" + TxtImportId.Text + '-' + DateImport.Value.Year + '-' + "و" + "' ";
            MySqlCommand cmd = new MySqlCommand(UpdateQuery, Archive.con);
            cmd.Parameters.AddWithValue("@data", PdfData);
            if (Archive.con.State == ConnectionState.Closed)
            {
                Archive.con.Open();
            }
            int Check = cmd.ExecuteNonQuery();
            Archive.con.Close();

            if (Check == 1)
            {
                //MessageBox.Show("تم تعديل الملف بنجاح");
            }
            else
            {
                MessageBox.Show("لم يتم التعديل الملف");
            }

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (Edit == "1")
            {
                try
                {
                    DialogResult result = MessageBox.Show("هل انت متاكد من تعديل هذه الوثيقة", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (result == DialogResult.Yes)
                    {
                        EditData();
                        EditFile();
                        ClearInputs();

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
            else
            {
                MessageBox.Show("غير مسموح لك بتعديل مكاتبة");
            }
            ClearInputs();
        }

        void SaveData()
        {
            if (TxtImportId.Text != "")
            {

                int ChkBx;
                int Index = 0;
                string UsersName = System.String.Empty;

                try
                {
                    String ImportDate = Convert.ToDateTime(DateImport.Value).ToString("yyyy-MM-dd");
                    String ExportOrgDate = Convert.ToDateTime(DateExportOrg.Value).ToString("yyyy-MM-dd");
                    String FollowingDate = Convert.ToDateTime(TxtFollowingDate.Value).ToString("yyyy-MM-dd");

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
                    string InsertQuery = "INSERT INTO importdata(id,importid , importdate , exportorg , exportorgdate , exportchange , summary , following , followingdate , orgid  , orgname ,action,primaryfile,secondfile,primaryfileid,secondfileid,user,username ) VALUES ('" + TxtImportId.Text + '-' + DateImport.Value.Year + '-' + "و" + "','" + TxtImportId.Text + "','" + ImportDate + "','" + TxtExportOrg.Text + "','" + ExportOrgDate + "','" + TxtExportChange.Text + "','" + TxtSummary.Text + "','" + ChkBx + "' , @followdate , '" + TxtOrgId.Text + "','" + TxtOrgName.Text + "','" + TxtAction.Text + "','" + TxtFileName.Text + "','" + TxtSubFileName.Text + "','" + TxtFileId.Text + "','" + TxtSubFileId.Text + "','" + TxtUser.Text + "', @usernamelst)";

                    MySqlCommand cmd = new MySqlCommand(InsertQuery, Archive.con);
                    cmd.Parameters.AddWithValue("@usernamelst", UsersName);
                    cmd.Parameters.AddWithValue("@followdate", FollowingDate);
                    if (Archive.con.State == ConnectionState.Closed)
                    {
                        Archive.con.Open();
                    }
                    int Check = cmd.ExecuteNonQuery();
                    Archive.con.Close();
                    if (Check == 1)
                    {
                       // MessageBox.Show("تم حفظ البيانات");
                        note("تم حفظ البيانات");
                    }
                    else
                    {
                      //  MessageBox.Show(" لم يتم حفظ البيانات");
                        note(" لم يتم حفظ البيانات");

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("هذه البيانات غير صحيحة");

                }

            }
            else
            {
                MessageBox.Show(" من فضلك قم بادخال رقم الوارد");
            }
        }
        void SaveFile()
        {
            try
            {
                typechange();
                byte[] PdfData;
                if (TxtImportId.Text != "")
                {
                    PdfData = File.ReadAllBytes(Pdf.FileName);
                    Connect();
                    String ImportDate = Convert.ToDateTime(DateImport.Value).ToString("yyyy-MM-dd");
                    string InsertQuery = "INSERT INTO importfile(id,pdffile,Connection,date, portid ) VALUES ('" + TxtImportId.Text + '-' + DateImport.Value.Year + '-' + "و" + "', @data,'" + ConnectKey + "','" + ImportDate + "','" + TxtImportId.Text + "') ";
                    MySqlCommand cmd = new MySqlCommand(InsertQuery, Archive.con);
                    cmd.Parameters.AddWithValue("@data", PdfData);
                    if (Archive.con.State == ConnectionState.Closed)
                    {
                        Archive.con.Open();
                    }
                    int Check = cmd.ExecuteNonQuery();
                    Archive.con.Close();
                    if (Check == 1)
                    {
                     //   MessageBox.Show("تم حفظ الملف");

                    }
                    else
                    {
                        MessageBox.Show(" لم يتم حفظ الملف");
                    }
                }
                else
                {
                    MessageBox.Show("من فضلك ادخل رقم الوارد");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("هذه البانات غير صحيحة");
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Regist == "1")
            {
                try
                {
                    SaveData();
                    SaveFile();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("غير مسموح لك بتسجيل المكاتبة");
            }
        }

        private void Connect()
        {
            DataTable Dt = new DataTable();
            try
            {

                if (ChkBxImport.Checked == true)
                {
                    String Quary = "select  connection from importfile where id = '" + TxtCon.Text + '-' + TxtDate.Text + '-' + ConnectType + "'";
                    Dt = Archive.QueryExecute(Quary);
                    int count = Dt.Rows.Count;
                    if (count == 1)
                    {
                        ConnectKey = Dt.Rows[0][0].ToString();

                        if (ConnectKey == "")
                        {
                            ConnectKey = TxtCon.Text + "-" + TxtDate.Text + "-" + ConnectType[0];
                            String UpdateQuery = "UPDATE importfile SET Connection = '" + ConnectKey + "'where id = '" + TxtCon.Text + '-' + TxtDate.Text + '-' + ConnectType + "'";
                            Archive.QueryExecute(UpdateQuery);
                        }
                    }
                    else
                    {
                        ConnectKey = "";
                    }


                }


                if (ChkBxExport.Checked == true)
                {

                    String Quary = "select connection from exportfile where id = '" + TxtCon.Text + '-' + TxtDate.Text + '-' + ConnectType + "'";
                    Dt = Archive.QueryExecute(Quary);
                    int count = Dt.Rows.Count;
                    if (count == 1)
                    {
                        ConnectKey = Dt.Rows[0][0].ToString();

                        if (ConnectKey == "")
                        {
                            ConnectKey = TxtCon.Text + "-" + TxtDate.Text + "-" + ConnectType;
                            String UpdateQuery = "UPDATE exportfile SET Connection = '" + ConnectKey + "'where id = '" + TxtCon.Text + '-' + TxtDate.Text + '-' + ConnectType + "'";
                            Archive.QueryExecute(UpdateQuery);
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

   

        void Search()
        {
            string[] Temp = new string[4];
            string[] Field = new string[4];
            Index = 0;
            DtSearch.Clear();
            string Quary = "select * from importdata where";
            Field = new string[3] { "importid", "exportorg", "exportchange" };
            Temp = new string[3] { TxtImportId.Text, TxtExportOrg.Text, TxtExportChange.Text };
            for (int i = 0; i < Field.Length; i++)
            {
                if (Temp[i] != "")
                {
                    Quary += "   " + Field[i] + " ='" + Temp[i] + "' and";
                }
            }

            if (TxtOrgId.Text != "")
            {
                Quary += " orgid like '" + '%' + "," + TxtOrgId.Text + "," + '%' + "' and ";
            }
            Quary += "  summary like'" + '%' + TxtSummary.Text + '%' + "'";
            Quary += " and orgname like'" + '%' + TxtOrgName.Text + '%' + "'";

            String DateFollow = Convert.ToDateTime(TxtFollowingDate.Value).ToString("yyyy-MM-dd");
            if (CkbxFollowing.Checked == true)
            {
                Quary += " and  followingdate >= '" + DateFollow + "' AND followingdate <= '" + DateFollow + "' ";
            }
            Quary += " ORDER BY importdate DESC ";
            MySqlDataAdapter da = new MySqlDataAdapter(Quary, Archive.con);
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
            string Quary = "select * from importfile where id= '" + TxtImportId.Text + '-' + DateImport.Value.Year + '-' + "و" + "' ";
            MySqlDataAdapter da = new MySqlDataAdapter(Quary, Archive.con);
            da.Fill(DtSearchFile);

            if (DtSearchFile.Rows.Count != 0)
            {
                DisplayDataFile(0);
            }
            else
            {

            }


        }     
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (ConnectAblity == "1")
            {
                FormConection MyFormConnection = new FormConection(TxtUser.Text);
                MyFormConnection.Show();
            }
            else
            {
                MessageBox.Show("غير مسموح لك بدخول هذة الصفحة");
            }
        }

        private void DgvFile_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtFileId.Text = DgvFile[0, e.RowIndex].Value.ToString();
                TxtFileName.Text = DgvFile[1, e.RowIndex].Value.ToString();
                GlobalPrimId = int.Parse(DgvFile[0, e.RowIndex].Value.ToString());
                String Quary = "select scndfileid,scndfilename from scndfile where primfileid = '" + GlobalPrimId.ToString() + "'ORDER BY scndfileid";
                DgvSubFile.DataSource = Archive.QueryExecute(Quary);
                TxtSubFileName.ResetText();
                TxtSubFileId.ResetText();
            }
            catch (Exception ex)
            {
            }
        }

        String StringNewSearchForm(String Data)
        {
            int IndexString;
            StringBuilder NewFormat = new StringBuilder(Data);

            //for (IndexString =0; IndexString < Data.Length; IndexString++)
            //{
            //    if (Data[IndexString] == 'أ' || Data[IndexString] == 'ا'   || Data[IndexString] == 'إ' || Data[IndexString] == 'آ' || Data[IndexString] == 'ي' || Data[IndexString] == 'ى' || Data[IndexString] == 'ه' || Data[IndexString] == 'ة' || Data[IndexString] == ' ')
            //    {
            //        NewFormat[IndexString] = '%';
            //    }
            //}
            return NewFormat.ToString();
        }
        private void DgvFile_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtFileId.Text = DgvFile[0, e.RowIndex].Value.ToString();
                TxtFileName.Text = DgvFile[1, e.RowIndex].Value.ToString();
                GlobalPrimId = int.Parse(DgvFile[0, e.RowIndex].Value.ToString());
                String Quary = "select scndfileid , scndfilename  from scndfile where primfileid = '" + GlobalPrimId.ToString() + "'ORDER BY scndfileid";
                DgvSubFile.DataSource = Archive.QueryExecute(Quary);
                TxtSubFileName.ResetText();
                TxtSubFileId.ResetText();
            }
            catch (Exception ex) { };
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

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

        private void TxtSubFileId_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                String Quary = "select scndfileid,scndfilename from scndfile where scndfileid ='"+ TxtSubFileId .Text+ "'and  primfileid = '" + TxtFileId.Text  + "'ORDER BY scndfileid ";
                DgvSubFile.DataSource = Archive.QueryExecute(Quary);
            }
            catch (Exception ex)
            {
            }
        }

        private void lstBxUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lstBxUsers.Items.Remove(lstBxUsers.SelectedItem);
        }

        private void TxtFileName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TxtFileName.ResetText();
            TxtFileId.ResetText();
        }

        private void TxtFileId_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TxtFileName.ResetText();
            TxtFileId.ResetText();
        }

        private void TxtSubFileId_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TxtSubFileId.ResetText();
            TxtSubFileName.ResetText();
        }

        private void TxtSubFileName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TxtSubFileId.ResetText();
            TxtSubFileName.ResetText();
        }

        private void LblFileId_Click(object sender, EventArgs e)
        {
            TxtFileName.ResetText();
            TxtFileId.ResetText();
        }

        private void LblSubFileId_Click(object sender, EventArgs e)
        {
            TxtSubFileId.ResetText();
            TxtSubFileName.ResetText();
        }

     
        private void TxtImportId_OnValueChanged(object sender, EventArgs e)
        {

        }
        private void TxtOrgId_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                String Quary = "select * from org where idorg like '" + '%' + TxtOrgId.Text + '%' + "' ORDER BY idorg";
                DgvOrg.DataSource = Archive.QueryExecute(Quary);
            }
            catch (Exception ex)
            { }
        }

        private void TxtFileId_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                String Quary = "select * from primfile where primfileid like '" + '%' + TxtFileId.Text + '%' + "'ORDER BY primfileid ";
                DgvFile.DataSource = Archive.QueryExecute(Quary);
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
            //CmbBxUserName.Items.Remove(CmbBxUserName.Text);
        }

        private void DgvOrg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string RowData = DgvOrg[0, e.RowIndex].Value.ToString();
                string ClmData = DgvOrg[1, e.RowIndex].Value.ToString();
                TxtOrgId.Text = RowData;
                TxtOrgName.Text = ClmData;
            }
            catch (Exception ex)
            {
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            ClearInputs();
            ++Index;
            if ((Index > DtSearch.Rows.Count - 1))
            {
                Index = 0;
            }
            else if ((Index < 0))
            {
                Index = DtSearch.Rows.Count - 1;
            }
            if (DtSearch.Rows.Count != 0)
            {
                DisplayData(Index);
            }
            SearchFile();
        }

        private void BtnPast_Click(object sender, EventArgs e)
        {
            ClearInputs();

            --Index;
            if ((Index > DtSearch.Rows.Count - 1))
            {
                Index = 0;
            }
            else if ((Index < 0))
            {
                Index = DtSearch.Rows.Count - 1;
            }
            if (DtSearch.Rows.Count != 0)
            {
                DisplayData(Index);
            }
            SearchFile();
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

        private void TxtOrgName_OnValueChanged(object sender, EventArgs e)
        {
            String Quary = "select * from org where orgname like'" + '%' + TxtOrgName.Text + '%' + "' ";
            DgvOrg.DataSource = Archive.QueryExecute(Quary);
        }

        private void TxtFileName_OnValueChanged(object sender, EventArgs e)
        {
            string Quary = "select * from primfile where primfilename like'" + '%' + TxtFileName.Text + '%' + "' or primfileid like'" + '%' + TxtFileId.Text + '%' + "' ORDER BY primfileid ";
            DgvFile.DataSource = Archive.QueryExecute(Quary);
        }

        private void DgvFile_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtFileId.Text = DgvFile[0, e.RowIndex].Value.ToString();
                TxtFileName.Text = DgvFile[1, e.RowIndex].Value.ToString();
                GlobalPrimId = int.Parse(DgvFile[0, e.RowIndex].Value.ToString());
                String Quary = "select scndfileid,scndfilename from scndfile where primfileid = '" + GlobalPrimId.ToString() + "'ORDER BY scndfileid";
                DgvSubFile.DataSource = Archive.QueryExecute(Quary);
                TxtSubFileName.ResetText();
                TxtSubFileId.ResetText();
            }
            catch (Exception ex)
            {
            }
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
           // MessageBox.Show(text);
        }

    }
}
