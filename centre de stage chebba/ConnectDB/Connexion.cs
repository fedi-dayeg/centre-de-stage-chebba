using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static centre_de_stage_chebba.CustomException;

namespace centre_de_stage_chebba
{
    class Connexion
    {
       /* private static OleDbConnection GetNewConnection()
        {
            OleDbConnection oleDbConnection = new OleDbConnection();
            oleDbConnection.ConnectionString = System.Configuration.ConfigurationManager.AppSettings["accessServerConnString"];

            try
            {
                oleDbConnection.Open();
            }
            catch(Exception e)
            {
                oleDbConnection.Close();
                throw new CustomException("Le système ne peut pas se connecter à la base de données. Veuillez contacter votre administrateur système.", ExceptionType.Error, "Error message:" + e.Message);
            }
            return oleDbConnection;
            
        }*/

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




    }
}
