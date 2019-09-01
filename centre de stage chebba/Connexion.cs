using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static centre_de_stage_chebba.CustomException;

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
                throw new CustomException("Le système ne peut pas se connecter à la base de données. Veuillez contacter votre administrateur système.", ExceptionType.Error, "Error message:" + e.Message);
            }
            return oleDbConnection;
            
        }
    }
}
