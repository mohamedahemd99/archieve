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
    public partial class FormHistory : Form
    {
        ArchieveDatabase Hist = new ArchieveDatabase();
        public FormHistory()
        {
            InitializeComponent();
         
        }

        private void History_Load(object sender, EventArgs e)
        {
          
        }
        void FillMyData()
        {
            DgvHistory.DataSource = Hist.QueryExecute("select * from history");
            DgvHistory.Columns[0].HeaderText = "الفعل";
            DgvHistory.Columns[1].HeaderText = " رقم الوثيقة";
            DgvHistory.Columns[2].HeaderText = "اسم المستخدم";
            DgvHistory.Columns[3].HeaderText = "التاريخ";
            DgvHistory.Columns[4].HeaderText = "النوع";
        }

        private void TxtId_OnValueChanged(object sender, EventArgs e)
        {
            DgvHistory.DataSource = Hist.QueryExecute("select * from history where id ='"  + TxtId.Text  + "'");
    
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            FillMyData();
        }
    }
}
