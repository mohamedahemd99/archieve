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
    public partial class FormFollowingOrgs : Form
    {
        ArchieveDatabase Following = new ArchieveDatabase();

        string job;
        public FormFollowingOrgs(String Name, String password)
        {
            InitializeComponent();
            TxtUser.Text = Name;
        }

        private void FormFollowing_Load(object sender, EventArgs e)
        {
            if (job != null)
            {
                bunifuCustomLabel1.Visible = false;
                CmbBxUserName.Visible = false;
            }
                Authority();
            DatepickerStart.Value = DateTime.Now;
            DatepickerEnd.Value = DateTime.Now;
            DataTable dt = new DataTable();
            string[] Dates = DatesMaker();
            string Quary = "select type,importid,importdate,orgname,username,followingdate,primarysub,summary,olddates,action primaryfileid,secondfileid from import where following = 1 and ";
            if (job != "")
            {
                Quary += "  username like'" + '%' + job + '%' + "' and ";
            }
            Quary += "   followingdate >= '" + Dates[0] + "' AND followingdate <= '" + Dates[1] + "' ORDER BY DATE(followingdate) ASC , importid ASC";
            dt = Following.QuaryExecute(Quary);
            ReportViwerData(dt, Dates ,"صادر / وارد ");
            FillCmbBxUserName();
           
        }
        void Authority()
        {
            DataTable Dt = new DataTable();
            String Quary = "select * from login where name ='" + TxtUser.Text + "' ";
            Dt = Following.QuaryExecute(Quary);

            job = Dt.Rows[0]["job"].ToString();

        }

        void FillCmbBxUserName()
        {
            DataTable Dt = new DataTable();
            Dt = Following.QuaryExecute("select username from users");
            for (int Index = 0; Index < Dt.Rows.Count; Index++)
            {
                CmbBxUserName.Items.Add(Dt.Rows[Index][0]);
            }
            CmbBxUserName.Text = "اختر مختص";
            //CmbBxUserName.Sorted = true;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string[] Dates = DatesMaker();
            String type = "وارد / صادر ";
            int ActiveValue = 1;
            string Quary = "select archieve.import.type , archieve.import.importid , archieve.import.importdate , archieve.followingorgs.orgname , archieve.import.username , archieve.import.followingdate , archieve.import.summary , archieve.import.olddates , archieve.import.action ,   CASE WHEN archieve.followingorgs.active  > 0 THEN 'مطلوب الرد'  ELSE 'تم الرد' END AS active  ,  archieve.import.primaryfileid, archieve.import.secondfileid FROM archieve.followingorgs inner join archieve.import ON  archieve.import.importid = archieve.followingorgs.importid and archieve.import.importdate = archieve.followingorgs.importdate and archieve.import.type = archieve.followingorgs.type where following = 1 and ";
           // SELECT* FROM archieve.followingorgs inner join archieve.import ON  archieve.import.importid = archieve.followingorgs.importid  where archieve.import.user = 1;
            //if(orgid.Text != "")
            //{
            //    Quary += "   orgid = '" + orgid.Text + "' and ";

            //}
            if (orgname.Text != "")
            {
                Quary += "  archieve.followingorgs.orgname like'" + '%' + StringNewSearchForm(orgname.Text) + '%' + "' and ";
            }
            if (job != "")
            {
                Quary += "  archieve.import.username like'" + '%' + job + '%' + "' and ";
            }

            if (CmbBxUserName.Text != "اختر مختص")
            {


                Quary += "  archieve.import.username like'" + '%' + StringNewSearchForm(CmbBxUserName.Text) + '%' + "' and ";
            }

            if (ChkBxImport.Checked == true)
            {
                Quary += "  archieve.import.type = 'وارد' and ";
                type = "وارد";
            }
            else if (ChkBxExport.Checked == true)
            {
                Quary += "  archieve.import.type = 'صادر' and ";
                type = "صادر";
            }

            if (Active.Checked == true)
            {
                //Quary += "  type = 'وارد' and ";
                //type = "وارد";
                Quary += "  archieve.followingorgs.Active = '1' and ";

                ActiveValue = 1;
            }
            else if (NotActive.Checked == true)
            {
                //Quary += "  type = 'صادر' and ";
                //type = "صادر";
                Quary += "  archieve.followingorgs.Active = '0' and ";

                ActiveValue = 0;
            }
            else if (BothActive.Checked == true)
            {
                //Quary += "  type = 'صادر' and ";
                //type = "صادر";
               // ActiveValue = 0;
            }
            Quary += "   archieve.import.followingdate >= '" + Dates[0] + "' AND archieve.import.followingdate <= '" + Dates[1] + "'  ORDER BY DATE(archieve.import.followingdate) ASC , archieve.import.importid ASC";
 
            dt = Following.QuaryExecute(Quary);
            ReportViwerData(dt, Dates , type);
        }

        public void ReportViwerData(DataTable dt, string[] Dates , String type)
        {
            ReportDataSource rprtDTSource = new ReportDataSource("ReportData", dt);
            ReportParameterCollection ReportParameters = new ReportParameterCollection();
            ReportParameters.Add(new ReportParameter("date1", Dates[0]));
            ReportParameters.Add(new ReportParameter("date2", Dates[1]));
            ReportParameters.Add(new ReportParameter("type", type));

            this.ReportViewerFollowing.LocalReport.SetParameters(ReportParameters);
            this.ReportViewerFollowing.LocalReport.DataSources.Clear();
            this.ReportViewerFollowing.LocalReport.DataSources.Add(rprtDTSource);
            this.ReportViewerFollowing.LocalReport.Refresh();
            this.ReportViewerFollowing.RefreshReport();
            this.ReportViewerFollowing.ZoomPercent = 125;
        }

        public string[] DatesMaker()
        {
            string[] Dates = new string[2];
            DateTime[] Datespickers = { DatepickerStart.Value, DatepickerEnd.Value };
            for (int i = 0; i < Datespickers.Length; i++)
            {
                Dates[i] = Convert.ToDateTime(Datespickers[i]).ToString("yyyy-MM-dd");
            }
            return Dates;
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
            Dt = Following.QuaryExecute("select orgname from org where idorg = '" + orgid.Text + "'");
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
            Dt = Following.QuaryExecute("select idorg from org where orgname like '" + orgname.Text + "'");
            string array = String.Empty;
            if (Dt.Rows.Count > 0)
            {
                array = Dt.Rows[0]["idorg"].ToString();
            }
            orgid.Text = array;
        }

        String StringNewSearchForm(String Data)
        {
            int IndexString;
            StringBuilder NewFormat = new StringBuilder(Data);

            for (IndexString = 0; IndexString < Data.Length; IndexString++)
            {
                if (Data[IndexString] == 'أ' || Data[IndexString] == 'ا' || Data[IndexString] == 'إ' || Data[IndexString] == 'آ' || Data[IndexString] == 'ي' || Data[IndexString] == 'ى' || Data[IndexString] == 'ه' || Data[IndexString] == 'ة' || Data[IndexString] == ' ')
                {
                    NewFormat[IndexString] = '%';
                }
            }
            return NewFormat.ToString();
        }

        private void CmbBxUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBxUsers.Items.Contains(CmbBxUserName.Text) == false)
            {
                lstBxUsers.Items.Add(CmbBxUserName.Text);
            }
        }

        private void Active_OnChange(object sender, EventArgs e)
        {
            if (Active.Checked == true)
            {
                BothActive.Checked = false;
                NotActive.Checked = false;
            }
            else
            {
                if (ChkBxExport.Checked == true)
                {
                    BothActive.Checked = false;
                }
                else
                {
                    BothActive.Checked = true;
                }
            }
        }

        private void NotActive_OnChange(object sender, EventArgs e)
        {
            if (NotActive.Checked == true)
            {
                BothActive.Checked = false;
                Active.Checked = false;
            }
            else
            {
                if (Active.Checked == true)
                {
                    BothActive.Checked = false;
                }
                else
                {
                    BothActive.Checked = true;
                }
            }
        }

        private void BothActive_OnChange(object sender, EventArgs e)
        {
            if (BothActive.Checked == true)
            {
                Active.Checked = false;
                NotActive.Checked = false;
            }
            else
            {
                if (Active.Checked == true)
                {
                    NotActive.Checked = false;
                }
                else
                {
                    NotActive.Checked = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReportItem FormSearchReport = new FormReportItem();
            FormSearchReport.Show();
        }
    }
}
