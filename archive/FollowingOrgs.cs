using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace archive
{
    public partial class FollowingOrgs : Form
    {
        ArchieveDatabase FollowingOrgsDb = new ArchieveDatabase();
        DataTable DtSearch = new DataTable();
        PdfClass MyPdf = new PdfClass();
        //Create OpenFileDialog To open Pdf
        OpenFileDialog Pdf = new OpenFileDialog();
        //Create Index to exchange between Files 
        int Index = 0;
        public FollowingOrgs()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void ChkBxImport_OnChange(object sender, EventArgs e)
        {
            if (ChkBxImport.Checked == true)
            {
                ChkBxExport.Checked = false;
            }
            else
            {
                ChkBxExport.Checked = true;
            }
        }

        private void ChkBxExport_OnChange(object sender, EventArgs e)
        {
            if (ChkBxExport.Checked == true)
            {
                ChkBxImport.Checked = false;
            }
            else
            {
                ChkBxImport.Checked = true;

            }
        }

        private void FollowingOrgs_Load(object sender, EventArgs e)
        {
            DateImport.Value = DateTime.Now;

            FillMydata();
            DGV_Headers();

        }

        void FillMydata()
        {
            DgvOrg.DataSource = FollowingOrgsDb.QueryExecute("SELECT * FROM org ");
        }

        void DGV_Headers()
        {
            DgvOrg.Columns[0].HeaderText = "الكود";
            DgvOrg.Columns[1].HeaderText = "  اســم الجـهـة";
            DgvOrg.Columns[0].Width = 70;

            Dgv1.Columns[0].Width = 150;
            Dgv1.Columns[1].Width = 100;
            Dgv1.Columns[2].Width = 350;
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


        private void TxtOrgId_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                String Query = "select * from org where idorg like '" + '%' + TxtOrgId.Text + '%' + "' ";
                DgvOrg.DataSource = FollowingOrgsDb.QueryExecute(Query);
            }
            catch (Exception ex)
            { }
        }


        private void TxtOrgName_OnValueChanged(object sender, EventArgs e)
        {
            String Quary = "select * from org where orgname like'" + '%' + TxtOrgName.Text + '%' + "' ";
            DgvOrg.DataSource = FollowingOrgsDb.QueryExecute(Quary);
        }

        private void DgvOrg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Boolean Exist = false;
            string Rowdata = DgvOrg[0, e.RowIndex].Value.ToString();
            string Clmdata = DgvOrg[1, e.RowIndex].Value.ToString();
            foreach (DataGridViewRow row in Dgv1.Rows)
            {
                if (row.Cells[2].Value.ToString().Equals(Clmdata))
                {
                    row.Selected = true;
                    Exist = true;
                    break;
                }
            }
            if (!Exist)
            {
                Dgv1.Rows.Add("مطلوب الرد", Rowdata, Clmdata);
            }
        }


        //private void Dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    Dgv.Rows.RemoveAt(e.RowIndex);
        //}
        private void Dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Dgv1.Rows.RemoveAt(e.RowIndex);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtImportId.Text != "" && CkbxFollowing.Checked == true)
            {
                String type = "وارد";
                int checkbx = 0;
                String ImportDate = Convert.ToDateTime(DateImport.Value).ToString("yyyy-MM-dd");
                //  String FollowingDate = Convert.ToDateTime(TxtFollowingDate.Value).ToString("yyyy-MM-dd");
                if (ChkBxImport.Checked == true)
                {
                    type = "وارد";
                }
                else
                {
                    type = "صادر";
                }

                String DeleteQuery = "DELETE FROM Followingorgs WHERE importid='" + int.Parse(TxtImportId.Text) + "'and type ='" + type + "' and importdate='" + ImportDate + "'";
                FollowingOrgsDb.QueryExecute(DeleteQuery);

                foreach (DataGridViewRow row in Dgv1.Rows)
                {
                    //row.Cells[0].Selected = false;
                    //row.Cells[0].
                    if (row.Cells[0].Value == "مطلوب الرد")
                    {
                        checkbx = 1;
                    }
                    else
                    {
                        checkbx = 0;
                    }
                   // MessageBox.Show(row.Cells[0].Value.ToString());

                    string InsertQuery = "INSERT INTO Followingorgs(importid , importdate , type , orgid , orgname , active  ) VALUES ('" + TxtImportId.Text + "','" + ImportDate + "','" + type + "' , '" + row.Cells[1].Value.ToString() + "' ,'" + row.Cells[2].Value.ToString() + "','" + checkbx + "') ";
                    FollowingOrgsDb.QueryExecute(InsertQuery);
                }


                    int chkbx;



                    String importdate = Convert.ToDateTime(DateImport.Value).ToString("yyyy-MM-dd");
                    String followingdate = Convert.ToDateTime(TxtFollowingDate.Value).ToString("yyyy-MM-dd");

                    if (CkbxFollowing.Checked.ToString() == "True")
                    {
                        TxtFollowingDate.Visible = true;
                        chkbx = 1;
                    }
                    else
                    {
                        chkbx = 0;
                    }

                    string UpdateQuery = "UPDATE import SET   following='" + chkbx + "',followingdate= '"+ followingdate + "'  , action='" + TxtAction.Text + "' WHERE importid ='" + TxtImportId.Text + "' and type = '"+ type + "' and importdate = '" + importdate + "' ";
                    FollowingOrgsDb.QueryExecute(UpdateQuery);
                ClearInputs();

                MessageBox.Show("تم ادخال البيانات ");
            }
            else
            {
                MessageBox.Show("من فضلك ادخل رقم الوارد و تاريخ المتابعة");
            }
        }

        private void TxtImportId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        void Search()
        {
            string[] Temp = new string[4];
            string[] Field = new string[4];
            Index = 0;
            DtSearch.Clear();
            String type = "وارد";
            if (ChkBxImport.Checked == true)
            {
                type = "وارد";
            }
            else
            {
                type = "صادر";
            }
            string Quary = "select * from import where type = '"+type+"' and importid = '" +TxtImportId.Text+"' ";
            Quary += " ORDER BY importdate DESC ";
            DtSearch = FollowingOrgsDb.QueryExecute(Quary);
            if (DtSearch.Rows.Count != 0)
            {
                DisplayData(0);
            }
            else
            {
                MessageBox.Show("لا توجد معلومات مسجلة ");
            }
        }

        void DisplayData(int index)
        {

            int FileIndex = index;
            String type = "وارد";

            if (ChkBxImport.Checked == true)
            {
                type = "وارد";
            }
            else
            {
                type = "صادر";
            }


            TxtImportId.Text = DtSearch.Rows[FileIndex][0].ToString();
            DateImport.Value = Convert.ToDateTime(DtSearch.Rows[FileIndex][1]);

            string Quary = "select active,orgid,orgname from FollowingOrgs where type = '" + type + "' and importid = '" + TxtImportId.Text + "' and importdate = '" + Convert.ToDateTime(DateImport.Value).ToString("yyyy-MM-dd") + "'";
            DataTable Dt = FollowingOrgsDb.QueryExecute(Quary); ;
            String Active = "تم الرد";
            for (int i =0 ; i< Dt.Rows.Count; i++)
            {
                //MessageBox.Show(Dt.Rows[i][0].ToString());
                if (Dt.Rows[i][0].ToString() == "1")
                {
                    Active = "مطلوب الرد";
                }
                else
                {
                    Active = "تم الرد";
                }
                Dgv1.Rows.Add(Active, Dt.Rows[i][1], Dt.Rows[i][2]);

            }



                if (Convert.ToBoolean(DtSearch.Rows[FileIndex][6]) == true)
                {
                    CkbxFollowing.Checked = true;
                    TxtFollowingDate.Visible = true;
                    TxtFollowingDate.Value = Convert.ToDateTime(DtSearch.Rows[FileIndex][7]);
                }
                else
                {
                    CkbxFollowing.Checked = false;
                    TxtFollowingDate.Visible = false;
                }


                TxtAction.Text = DtSearch.Rows[FileIndex][15].ToString();

                byte[] pdfsdata = DtSearch.Rows[FileIndex][11] as byte[];
                string path = @"C:\Users\Public\Documents\tempfile'" + "'.pdf";
                System.IO.File.WriteAllBytes(path, pdfsdata);
                AxAcroPDF.Show();
                Pdf.FileName = path;
                AxAcroPDF.LoadFile(path);
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
        }

        void ClearInputs()
        {

            TxtFollowingDate.ResetText();
            DateImport.Refresh();
            TxtImportId.ResetText();

            TxtOrgId.ResetText();
            TxtOrgName.ResetText();

            TxtAction.ResetText();

            CkbxFollowing.Checked = false;
            TxtFollowingDate.Hide();

            Pdf.FileName = "NotEnteredTillNow.pdf";
            AxAcroPDF.Hide();

            Dgv1.Rows.Clear();
        }



        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void Dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // CheckBox.
                if (Dgv1[0, e.RowIndex].Value == "مطلوب الرد")
                {
                    Dgv1[0, e.RowIndex].Value = "تم الرد";
                }
                else
                {
                    Dgv1[0, e.RowIndex].Value = "مطلوب الرد";
                }
                Dgv1.Update();
                Dgv1.UpdateCellValue(e.ColumnIndex, e.RowIndex);
                Dgv1.ClearSelection();
            }
            catch (Exception ex)
            {

            }
            
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Dgv1.Rows.Clear();
            Dgv1.Refresh();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            FormFollowingOrgs FormFollowingOrgsPage = new FormFollowingOrgs("1","1");
            FormFollowingOrgsPage.Show();
        }
    }
    
}
