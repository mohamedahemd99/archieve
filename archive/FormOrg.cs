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

    public partial class FormOrg : Form
    {
        string NameOfOrg;
        ArchieveDatabase Org = new ArchieveDatabase();
        string nameofuser;
        string org;
        public FormOrg(string name, string password)
        {
            InitializeComponent();
            nameofuser = name;

        }
        private void FormOrg_Load(object sender, EventArgs e)
        {
            FillMyData();
            DGV_Headers();
            Authority();
        }
        void Authority()
        {
            DataTable Dt = new DataTable();
            String Quary = "select * from login where name ='" + nameofuser + "' ";
            Dt = Org.QueryExecute(Quary);
            org = Dt.Rows[0]["org"].ToString();
        }
        void FillMyData()
        {
            DgvOrg.DataSource = Org.QueryExecute("select * from org");
        }
        void DGV_Headers()
        {
            DgvOrg.Columns[0].HeaderText = "كودالجهة ";
            DgvOrg.Columns[1].HeaderText = "اسم الجهة";
            DgvOrg.Columns[0].Width = 80;
        }


        private void DgvOrg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
              TxtOrgId.Text = DgvOrg[0, e.RowIndex].Value.ToString();
              TxtOrgName.Text = DgvOrg[1, e.RowIndex].Value.ToString();
                NameOfOrg = TxtOrgName.Text;
            }
            catch (Exception ex)
            {
            }
            
        }

        //private void TxtSearch_OnValueChanged(object sender, EventArgs e)
        //{
        //    DgvOrg.DataSource = Org.QuaryExecute("select * from org where username like'" + '%' + TxtSearch.Text + '%' + "' ");
        //}

        private void BtnDeleteOrgClick(object sender, EventArgs e)
        {
            try
            {
                if (org == "1")
                {

                    DialogResult result = MessageBox.Show("هل انت متاكد من حذف هذه الوثيقة", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (result == DialogResult.Yes)
                    {
                        String DeleteQuery = "DELETE FROM org WHERE idorg='" + int.Parse(TxtOrgId.Text) + "'";
                        int Test = Org.MyExecuteNonQuery(DeleteQuery);
                        if (Test == 1)
                        {
                            FillMyData();
                            MessageBox.Show("تم حذف البيانات بنجاح");

                        }
                        else
                        {
                            MessageBox.Show("لم يتم الحذف");
                        }
                        TxtOrgName.ResetText();
                        TxtOrgId.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("لم يتم الحذف");
                    }
                }
                else
                {

                    MessageBox.Show("غير مسموح لك بحذف جهة");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEditOrgClick(object sender, EventArgs e)
        {
            try
            {
                if (org == "1")
                {
                    DialogResult result = MessageBox.Show("هل انت متاكد من تعديل هذه الوثيقة", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (result == DialogResult.Yes)
                {
                    String DeleteQuery = "DELETE FROM  org  WHERE orgname= '" + TxtOrgName.Text + "'  or idorg = '" + TxtOrgId.Text + "' ";
                    String InsertQuery = "INSERT INTO org (orgname , idorg) VALUES ('" + TxtOrgName.Text + "','" + TxtOrgId.Text + "')";
                    int Test1 = Org.MyExecuteNonQuery(DeleteQuery);
                    int Test2 = Org.MyExecuteNonQuery(InsertQuery);
                    if (Test1 == 1 && Test2 == 1)
                    {
                        int Test = Org.MyExecuteNonQuery("UPDATE import SET orgname =REPLACE(orgname,'" + NameOfOrg + "','" + TxtOrgName.Text + "') ");
                        if (Test == 1) { }
                        FillMyData();
                        MessageBox.Show("تم تعديل البيانات بنجاح");
                    }
                    else
                    {
                        MessageBox.Show("لم يتم التعديل");
                    }
                    TxtOrgId.ResetText();
                    TxtOrgName.ResetText();
                }
                else
                {
                    MessageBox.Show("لم يتم التعديل");
                }
                }
                else
                {

                    MessageBox.Show("غير مسموح لك بتعديل جهة");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAddOrgClick(object sender, EventArgs e)
        {
            if (TxtOrgId.Text != "" && TxtOrgName.Text != "")
            {
                try
                {
                    if (org == "1")
                    {
                        int Test = Org.MyExecuteNonQuery("INSERT INTO org (orgname , idorg) VALUES ('" + TxtOrgName.Text + "','" + TxtOrgId.Text + "')");
                    if (Test == 1)
                    {
                        FillMyData();
                        MessageBox.Show("تم ادخال البيانات بنجاح");
                    }
                    else
                    {
                        MessageBox.Show("لم يتم ادخال البيانات");
                    }
                    TxtOrgId.ResetText();
                    TxtOrgName.ResetText();
                }
                else
                {

                    MessageBox.Show("غير مسموح لك باضافة جهة");

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

        private void TxtSearch_OnValueChanged_1(object sender, EventArgs e)
        {
           // String Quary = "select * from org where username like'" + ' % ' + TxtSearch.Text + ' % ' + "' ";
           //DgvOrg.DataSource = Org.QuaryExecute(Quary);

        }

        private void TxtOrgId_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                String Quary = "select * from org where idorg = '"  + TxtOrgId.Text + "' ORDER BY idorg";
                DgvOrg.DataSource = Org.QueryExecute(Quary);
            }
            catch (Exception ex)
            { }
        }

        private void TxtOrgName_OnValueChanged(object sender, EventArgs e)
        {
            String Quary = "select * from org where orgname like'" + '%' + TxtOrgName.Text + '%' + "' ";
            DgvOrg.DataSource = Org.QueryExecute(Quary);
        }
    }
}
