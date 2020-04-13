using System;
using System.Data;
using System.Windows.Forms;

namespace archive
{
    public partial class FormFile : Form
    {
        string username;
        string NameOfFiles;
        string NameOfSecondFiles;
        string files;

        ArchieveDatabase Files = new ArchieveDatabase();
        int GlobalPrimId = 0;

        public FormFile(string name, string password)
        {
            InitializeComponent();
            username = name;
        }

        private void Formfile_Load(object sender, EventArgs e)
        {
            FillMyData();
            DGV_Headers();
            Authority();
        }
        void Authority()
        {
            DataTable Dt = new DataTable();
            String Query = "select * from login where name ='" + username + "' ";
            Dt = Files.QueryExecute(Query);
            files = Dt.Rows[0]["files"].ToString();

        }
        void FillMyData()
        {
            DgvFile.DataSource = Files.QueryExecute("select * from primfile ORDER BY primfileid ");
            GlobalPrimId = Int32.Parse(DgvFile[0, 0].Value.ToString());
            String Query = "select * from scndfile where primfileid = '" + GlobalPrimId.ToString() + "' ORDER BY scndfileid ";
            DgvFileSub.DataSource = Files.QueryExecute(Query);
        }
        void DGV_Headers()
        {
            DgvFile.Columns[0].HeaderText = "كود الملف";
            DgvFile.Columns[1].HeaderText = "اسم الملف الرئيسى" + "";
            DgvFileSub.Columns[0].HeaderText = "كود الملف ";
            DgvFileSub.Columns[1].HeaderText = "اسم الملف الفرعى" + "";
            DgvFileSub.Columns[2].HeaderText = "كود الملف الرئيسى" + "";
            DgvFile.Columns[0].Width = 120;
            DgvFileSub.Columns[0].Width = 120;
            DgvFileSub.Columns[2].Width = 90;
            DgvFileSub.Columns[2].Visible = false;
        }

        private void DgvFile_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtFileId.Text = DgvFile[0, e.RowIndex].Value.ToString();
                TxtFileName.Text = DgvFile[1, e.RowIndex].Value.ToString();
                GlobalPrimId = int.Parse(DgvFile[0, e.RowIndex].Value.ToString());
                String Query ="select * from scndfile where primfileid = '" + GlobalPrimId.ToString() + "' ORDER BY scndfileid";
                DgvFileSub.DataSource = Files.QueryExecute(Query);
                TxtFileNameSub.ResetText();
                TxtFileidSub.ResetText();
                NameOfFiles = TxtFileName.Text;
            }

            catch(Exception ex)
            {
            }
        }

        private void DgvFileSub_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtFileidSub.Text = DgvFileSub[0, e.RowIndex].Value.ToString();
                TxtFileNameSub.Text = DgvFileSub[1, e.RowIndex].Value.ToString();
                NameOfSecondFiles = TxtFileNameSub.Text;
            }
            catch (Exception ex)
            {
            }
        }


        private void TxtSearch_OnValueChanged(object sender, EventArgs e)
        {
            string Query = "select * from primfile where primfilename like'" + '%' + TxtSearch.Text + '%' + "' or primfileid like'" + '%' + TxtSearch.Text + '%' + "' ";
            DgvFile.DataSource = Files.QueryExecute(Query);
        }

        private void BtnAddFile_Click(object sender, EventArgs e)
        {

            if (TxtFileId.Text != "" && TxtFileName.Text != "")
            {
                try
                {

                    if (files == "1")
                    {
                        String InsertQuery = "INSERT INTO primfile (primfilename , primfileid) VALUES ('" + TxtFileName.Text + "','" + TxtFileId.Text + "')";
                    int Test = Files.MyExecuteNonQuery(InsertQuery);
                    if (Test == 1)
                    {
                        FillMyData();
                        MessageBox.Show("تم ادخال البيانات بنجاح");
                    }
                    else
                    {
                        MessageBox.Show("لم يتم ادخال البيانات");
                    }
                    TxtFileId.ResetText();
                    TxtFileName.ResetText();
                    }
                    else
                    {

                        MessageBox.Show("غير مسموح لك باضافة ملف رئيسي");

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

        private void BtnEditFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (files == "1")
                {
                    DialogResult result = MessageBox.Show("هل انت متاكد من تعديل هذه الوثيقة", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (result == DialogResult.Yes)
                {
                    //String updateQuery = "UPDATE primfile SET primfilename= '" + TxtFileName.Text + "'WHERE primfileid='" + int.Parse(TxtFileName.Text) + "'";
                    String DeleteQuery = "DELETE FROM  primfile  WHERE primfilename= '" + TxtFileName.Text + "'  or primfileid = '" + TxtFileId.Text + "' ";
                    String InsertQuery = "INSERT INTO primfile (primfilename , primfileid) VALUES ('" + TxtFileName.Text + "','" + TxtFileId.Text + "')";
                    int Test1 = Files.MyExecuteNonQuery(DeleteQuery);
                    int Test2 = Files.MyExecuteNonQuery(InsertQuery);
                    if (Test1 == 1 && Test2 == 1)
                    {
                        int Test = Files.MyExecuteNonQuery("UPDATE import SET primaryfile =REPLACE(primaryfile,'" + NameOfFiles + "','" + TxtFileName.Text + "') ");
                        if (Test == 1) { }
                        FillMyData();
                        MessageBox.Show("تم تعديل البيانات بنجاح");
                    }
                    else
                    {
                        TxtFileName.Text = "";
                        TxtFileId.Text = "";
                        MessageBox.Show("لم يتم التعديل");
                    }
                }
                else
                {
                    TxtFileName.Text = "";
                    TxtFileId.Text = "";
                    MessageBox.Show("لم يتم التعديل");
                }
                }
                else
                {

                    MessageBox.Show("غير مسموح لك بتعديل ملف رئيسي");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDeleteFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (files == "1")
                {
                    DialogResult result = MessageBox.Show("هل انت متاكد من حذف هذه الوثيقة", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (result == DialogResult.Yes)
                {
                    String DeleteQuery = "DELETE FROM primfile WHERE primfileid ='" + int.Parse(TxtFileId.Text) + "'";
                int Test = Files.MyExecuteNonQuery(DeleteQuery);
                if (Test == 1)
                {
                    FillMyData();
                    TxtFileName.ResetText();
                    TxtFileId.ResetText();
                    MessageBox.Show("تم حذف البيانات بنجاح");
                }
                else
                {
                    MessageBox.Show("لم يتم الحذف");
                }
                }
                else
                {
                    MessageBox.Show("لم يتم الحذف");
                }
                }
                else
                {

                    MessageBox.Show("غير مسموح لك بحذف ملف رئيسي");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtSearchSub_OnValueChanged(object sender, EventArgs e)
        {
            string Query = "select scndfilename,scndfileid from scndfile where scndfilename like'" + '%' + TxtSearchSub.Text + '%' + "' or scndfileid like'" + '%' + TxtSearchSub.Text + '%' + "' ";
            DgvFileSub.DataSource = Files.QueryExecute(Query);
        }

        private void BtnAddFileSub_Click(object sender, EventArgs e)
        {
            if (TxtFileId.Text != "" && TxtFileName.Text != "")
            {
                try
                {
                    if (files == "1")
                    {
                        String InsertQuery = "INSERT INTO scndfile (scndfilename , scndfileid , primfileid) VALUES ('" + TxtFileNameSub.Text + "','" + TxtFileidSub.Text + "' , '" + GlobalPrimId.ToString() + "' )";
                    int Test = Files.MyExecuteNonQuery(InsertQuery);
                    if (Test == 1)
                    {
                        string Query = "select * from scndfile where  primfileid = '" + GlobalPrimId.ToString() + "' ORDER BY scndfileid";
                        DgvFileSub.DataSource = Files.QueryExecute(Query);
                        MessageBox.Show("تم ادخال البيانات بنجاح");
                    }
                    else
                    {
                        MessageBox.Show("لم يتم ادخال البيانات");
                    }
                    TxtFileidSub.ResetText();
                    TxtFileNameSub.ResetText();
                    }
                    else
                    {

                        MessageBox.Show("غير مسموح لك باضافة ملف فرعي");

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

        private void BtnEditFileSub_Click(object sender, EventArgs e)
        {
            try
            {
                if (files == "1")
                {
                    DialogResult result = MessageBox.Show("هل انت متاكد من تعديل هذه الوثيقة", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (result == DialogResult.Yes)
                {
                    //String updateQuery = "UPDATE scndfile SET scndfilename= '" + TxtFileNameSub.Text + "'WHERE scndfileid='" + int.Parse(TxtFileidSub.Text) + "'";
                    String DeleteQuery = "DELETE FROM  scndfile  WHERE scndfileid = '" + TxtFileidSub.Text + "' and primfileid = '" + GlobalPrimId + "' ";
                    String InsertQuery = "INSERT INTO scndfile (scndfilename , scndfileid, primfileid) VALUES ('" + TxtFileNameSub.Text + "','" + TxtFileidSub.Text + "','" + GlobalPrimId.ToString() + "')";
                    int Test1 = Files.MyExecuteNonQuery(DeleteQuery);
                    int Test2 = Files.MyExecuteNonQuery(InsertQuery);
                    if (Test1 == 1 && Test2 == 1)
                    {
                        int Test = Files.MyExecuteNonQuery("UPDATE import SET secondfile =REPLACE(secondfile,'" + NameOfSecondFiles + "','" + TxtFileNameSub.Text + "') ");
                        if (Test == 1) { }
                        string Query = "select * from scndfile where  primfileid = '" + GlobalPrimId.ToString() + "' ORDER BY scndfileid";
                        DgvFileSub.DataSource = Files.QueryExecute(Query);
                        MessageBox.Show("تم تعديل البيانات بنجاح");
                    }
                    else
                    {
                        MessageBox.Show("لم يتم التعديل");
                    }

                }
                else
                {
                    MessageBox.Show("لم يتم التعديل");
                }
                }
                else
                {

                    MessageBox.Show("غير مسموح لك بتعديل ملف فرعي");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            TxtFileNameSub.ResetText();
            TxtFileidSub.ResetText();
        }

        private void BtnDeleteFileSub_Click(object sender, EventArgs e)
        {
            try
            {
                if (files == "1")
                {
                    DialogResult result = MessageBox.Show("هل انت متاكد من حذف هذه الوثيقة", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (result == DialogResult.Yes)
                {
                    String DeleteQuery = "DELETE FROM scndfile WHERE scndfileid ='" + TxtFileidSub.Text + "' and primfileid = '" + GlobalPrimId + "'  ";
                int Test = Files.MyExecuteNonQuery(DeleteQuery);
                if (Test == 1)
                {
                    string Query = "select * from scndfile where  primfileid = '" + GlobalPrimId.ToString() + "'ORDER BY scndfileid";
                    DgvFileSub.DataSource = Files.QueryExecute(Query);
                    TxtFileNameSub.ResetText();
                    TxtFileidSub.ResetText();
                    MessageBox.Show("تم حذف البيانات بنجاح");
                }
                else
                {
                    MessageBox.Show("لم يتم الحذف");
                }
                }
                else
                {
                    MessageBox.Show("لم يتم الحذف");
                }
                }
                else
                {

                    MessageBox.Show("غير مسموح لك بحذف ملف فرعي");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtFileId_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                String Query = "select * from primfile where primfileid like '" + '%' + TxtFileId.Text + '%' + "'ORDER BY primfileid ";
                DgvFile.DataSource = Files.QueryExecute(Query);
            }
            catch (Exception ex)
            { }
        }

        private void TxtFileName_OnValueChanged(object sender, EventArgs e)
        {
            string Query = "select * from primfile where primfilename like'" + '%' + TxtFileName.Text + '%' + "' or primfileid like'" + '%' + TxtFileId.Text + '%' + "' ORDER BY primfileid ";
            DgvFile.DataSource = Files.QueryExecute(Query);
        }
    }
}
