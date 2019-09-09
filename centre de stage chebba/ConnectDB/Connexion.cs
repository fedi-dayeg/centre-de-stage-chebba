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
      
        // get the connection string 
        //PS: i am using the access database
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

        /// <summary>
        /// this method let me to umpty the DataGrid from the data that they are in the database
        /// add the header to the datagrid
        /// </summary>
        /// <param name="datagridview"></param>
        /// <param name="sql"></param>
        public static void remplirDGV(System.Windows.Controls.DataGrid datagridview, string sql)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagridview.ItemsSource = dt.DefaultView;
            datagridview.Columns[0].Header = "الرقم";
            datagridview.Columns[1].Header = "المستفيد";
            datagridview.Columns[2].Header = "الإسم و اللقب الإجتماعى";
            datagridview.Columns[3].Header = "موضوع النفقة";
            datagridview.Columns[4].Header = "الوثائق المثبة للنفقة";
            datagridview.Columns[5].Header = "صالح الدفع";
            datagridview.Columns[6].Header = "الهوية البنكية";
            datagridview.Columns[7].Header = "موضوع التحويل";
            datagridview.Columns[8].Header = "الهوية البريدية";
            datagridview.Columns[9].Header = "رقم الأمر بالصرف";
            datagridview.Columns[10].Header = "القسم";
            datagridview.Columns[11].Header = "الفصل";
            datagridview.Columns[12].Header = "الفقرة";
            datagridview.Columns[13].Header = "الفقرة الفرعية";
            datagridview.Columns[14].Header = "رقم التأشيرة";
            datagridview.Columns[15].Header = "المبلغ الخام للنفقة";
            datagridview.Columns[16].Header = "يخصم";
            datagridview.Columns[17].Header = "المبلغ الصافى للدفع";
            datagridview.Columns[18].Header = "أوقف مبلغ";
            datagridview.Columns[19].Header = "بـــــ";
            datagridview.Columns[20].Header = "في";
            datagridview.Columns[21].Header = "المستفيد";
            datagridview.Columns[22].Header = "الهوية البنكية البريدية";
            datagridview.Columns[23].Header = "الوثائق المرفقة";
            datagridview.Columns[24].Header = "الفصل";
            da.Dispose();
            conn.Close();
        }

        public void DbOpen()
        {
            conn.Open();
        }

        /// <summary>
        /// this method add the ordre form the database
        /// </summary>
        /// <param name="sql"></param>
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
