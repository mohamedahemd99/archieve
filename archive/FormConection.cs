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
    public partial class FormConection : Form
    {
        ArchieveDatabase Connect = new ArchieveDatabase();
        String Connection = "";
        string type1 = "و";
        string type2 = "و";
        string nameofuser;
        public FormConection(string name)
        {
            InitializeComponent();
            nameofuser = name;
        }
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            ConnectNew();
            UpdateData();

        }

        private void ChkBxImport1_OnChange(object sender, EventArgs e)
        {
            if (ChkBxImport1.Checked == true)
            {
                ChkBxExport1.Checked = false;
                type1 = "و";
            }
            else
            {
                ChkBxExport1.Checked = true;
                type1 = "ص";
            }
        }

        private void ChkBxExport1_OnChange(object sender, EventArgs e)
        {
            if (ChkBxExport1.Checked == true)
            {
                ChkBxImport1.Checked = false;
                type1 = "ص";

            }
            else
            {
                ChkBxImport1.Checked = true;
                type1 = "و";

            }
        }

        private void ChkBxImport2_OnChange(object sender, EventArgs e)
        {
            if (ChkBxImport2.Checked == true)
            {
                ChkBxExport2.Checked = false;
                type2 = "و";
            }
            else
            {
                ChkBxExport2.Checked = true;
                type2 = "ص";
            }
        }

        private void ChkBxExport2_OnChange(object sender, EventArgs e)
        {
            if (ChkBxExport2.Checked == true)
            {
                ChkBxImport2.Checked = false;
                type2 = "ص";
            }
            else
            {
                ChkBxImport2.Checked = true;
                type2 = "و";
            }
        }

        private void ConnectNew()
        {
            DataTable Dt = new DataTable();
            try
            {

                if (ChkBxImport2.Checked == true)
                {
                    String Quary = "select  connection from importfile where id = '" + TxtCon2.Text + '-' + TxtDate2.Text + '-' + type2 + "'";
                    Dt = Connect.QuaryExecute(Quary);
                    int count = Dt.Rows.Count;
                    if (count == 1)
                    {
                        Connection = Dt.Rows[0][0].ToString();

                        if (Connection == "")
                        {
                            Connection = TxtCon2.Text + "-" + TxtDate2.Text + "-" + type2;
                            String UpdateQuery = "UPDATE importfile SET Connection = '" + Connection + "'where id = '" + TxtCon2.Text + '-' + TxtDate2.Text + '-' + type2 + "'";
                            Connect.QuaryExecute(UpdateQuery);
                        }
                    }
                    else
                    {
                        Connection = "";
                    }


                }


                if (ChkBxExport2.Checked == true)
                {

                    String Quary = "select connection from exportfile where id = '" + TxtCon2.Text + '-' + TxtDate2.Text + '-' + type2 + "'";
                    Dt = Connect.QuaryExecute(Quary);
                    int count = Dt.Rows.Count;
                    if (count == 1)
                    {
                        Connection = Dt.Rows[0][0].ToString();

                        if (Connection == "")
                        {
                            Connection = TxtCon2.Text + "-" + TxtDate2.Text + "-" + type2;
                            String UpdateQuery = "UPDATE exportfile SET Connection = '" + Connection + "'where id = '" + TxtCon2.Text + '-' + TxtDate2.Text + '-' + type2 + "'";
                            Connect.QuaryExecute(UpdateQuery);
                        }
                    }
                    else
                    {
                        Connection = "";
                    }

                }

            }

            catch (Exception ex)
            {
            }
        }
        private void UpdateData()
        {
            DataTable Dt = new DataTable();
            try
            {

                if (ChkBxImport1.Checked == true)
                {
                   String UpdateQuery = "UPDATE importfile SET Connection = '" + Connection + "'where id = '" + TxtCon1.Text + '-' + TxtDate1.Text + '-' + type1 + "'";

                    int Test = Connect.MyExecuteNonQuery(UpdateQuery);
                    if (Test == 1)
                    {
                        MessageBox.Show("تم ربط المكاتبة  بنجاح");
                    }
                    else
                    {
                        MessageBox.Show("لم يتم ربط المكاتبة ");
                    }

                }


                if (ChkBxExport1.Checked == true)
                {
                    String UpdateQuery = "UPDATE exportfile SET Connection = '" + Connection + "'where id = '" + TxtCon1.Text + '-' + TxtDate1.Text + '-' + type1 + "'";
                    int Test = Connect.MyExecuteNonQuery(UpdateQuery);
                    if (Test == 1)
                    {
                        MessageBox.Show("تم ربط المكاتبة  بنجاح");
                    }
                    else
                    {
                        MessageBox.Show("لم يتم ربط المكاتبة ");
                    }
                }

            }

            catch (Exception ex)
            {
            }


        }


    }
}
