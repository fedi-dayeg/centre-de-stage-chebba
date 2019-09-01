using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace centre_de_stage_chebba
{
    class Connexion
    {
        private static OleDbConnection GetNewConnection()
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
                
            }
            return oleDbConnection;

        }
    }
}
