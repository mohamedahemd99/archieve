using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace archive
{
    class ArchieveDatabase
    {
        public MySqlConnection con { get; set; }

        /// <summary>
        /// The ip address of the connection string changes 
        /// server ip : 192.168.0.1
        /// localhost is used when testing or debugging the code locally
        /// and server's ip is used when deploying the code to the target computers
        /// </summary>
        public ArchieveDatabase()
        {
           //con = new MySqlConnection("Server = 192.168.1.110 ; Database = archieve ; uid = developer ; pwd =developer ; SslMode=None ");
           con = new MySqlConnection("Server = localhost; Database = archieve ; uid = root ; pwd =root ; SslMode=None");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataTable QueryExecute(String query)
        {
            Console.WriteLine("Query : " + query);
            //Create DataTable that return data from function
            DataTable dt = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                da.Fill(dt);
                con.Close();

            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return dt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Query"></param>
        /// <returns></returns>
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

    }
}
