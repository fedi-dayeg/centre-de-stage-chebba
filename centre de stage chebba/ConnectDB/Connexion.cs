using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static centre_de_stage_chebba.CustomException;

namespace centre_de_stage_chebba
{
    class Connexion
    {
      

        private static string connString = @"Data Source=""../centre.accdb"";
Provider=""Microsoft.ACE.OLEDB.12.0""; 
User ID=Admin";
        private OleDbConnection conn = new OleDbConnection(connString);

        public static OleDbConnection getConn()
        {
            OleDbConnection mydata = new OleDbConnection(connString);
            mydata.Open();
            return mydata;
        }

        public Connexion() { }

        public string ConnString
        {
            get { return connString; }
            set { connString = value; }
        }

        public void DbClose()
        {
            conn.Close();
        }

        internal static void remplirDGV(System.Windows.Controls.DataGrid datagridview, string sql)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagridview.ItemsSource = dt.DefaultView;
            da.Dispose();
            conn.Close();
        }

        public void DbOpen()
        {
            conn.Open();
        }

        public static void AddOrdre( string sql)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(connString);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void remplirDGV(DataGridView dgv, string sql)
        {
            

        }
       




    }
}
