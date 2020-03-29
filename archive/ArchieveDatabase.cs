using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace archive
{
    class ArchieveDatabase
    {
        public MySqlConnection con { get; set; }

        public ArchieveDatabase()
        {
         //con = new MySqlConnection("Server = 192.168.0.1 ; Database = archieve ; uid = developer ; pwd =developer ; SslMode=None ");
        con = new MySqlConnection("Server = localhost; Database = archieve ; uid = developer ; pwd =developer ; SslMode=None");

        }
           //Function that get data from the database to c# in datatable representation
 

       public DataTable ShowMyData(String Data)
       {
           DataTable dt = new DataTable();
           MySqlDataAdapter da = new MySqlDataAdapter("select * from " + Data, con);
           da.Fill(dt);
           return dt;
       }

        //Function that get data from the database to c# in datatable representation based on quary sent

        public DataTable QuaryExecute(String Quary)
        {
            //Create DataTable that return data from function
            DataTable dt = new DataTable();

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            MySqlDataAdapter da = new MySqlDataAdapter(Quary, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        //public MySqlDataReader MyExecuteReader(String Query)
        //{
        //    con.Open();
        //    MySqlCommand cmd = new MySqlCommand(Query, con);
        //    MySqlDataReader dr= cmd.ExecuteReader();
        //    dr.Read();
        //    con.Close();
        //    return dr;
        //}
        public int MyExecuteNonQuery(String Query)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            MySqlCommand cmd = new MySqlCommand(Query, con);
            int RetResult = cmd.ExecuteNonQuery();
            con.Close();
            return RetResult;
        }



        public int MyExecuteNonQueryAddedWithValues(String Query)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            MySqlCommand cmd = new MySqlCommand(Query, con);
            //for
                int RetResult = cmd.ExecuteNonQuery();
                con.Close();
                return RetResult;
           
        }
        //function to Search_users_username_using_like

        public DataTable Search_users_username_using_like(String Data, String username)
        {
            DataTable dt = new DataTable();
            string quary = "select * from " + Data + " where username like'" + '%' + username + '%' + "' ";
            MySqlDataAdapter da = new MySqlDataAdapter(quary, con);
            da.Fill(dt);
          
            return dt;
        }
        public DataTable orgSearch(String Data, String orgname)
        {
            DataTable dt2 = new DataTable();
            string quary = "select * from " + Data + " where orgname like'" + '%' + orgname + '%' + "' ";
            MySqlDataAdapter da = new MySqlDataAdapter(quary, con);
            da.Fill(dt2);
            return dt2;
        }
    }
}
