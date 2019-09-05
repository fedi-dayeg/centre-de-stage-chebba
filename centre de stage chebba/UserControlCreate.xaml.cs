using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using centre_de_stage_chebba.Model;
using CrystalDecisions.CrystalReports.Engine;
using SAPBusinessObjects.WPF.Viewer;

namespace centre_de_stage_chebba
{
    /// <summary>
    /// Logique d'interaction pour UserControl1.xaml
    /// </summary>
    public partial class UserControlCreate : UserControl
    {
        private static string connString = @"Data Source=""../centre.accdb"";
Provider=""Microsoft.ACE.OLEDB.12.0""; 
User ID=Admin";
        public UserControlCreate()
        {
            InitializeComponent();
        }

        public void CrystalReportText()
        {
            MainWindow f1 = new MainWindow();
            Window1 f2 = new Window1();

            ReportDocument doc = new ReportDocument();
            try
            {
                 doc.Load($"../../CrystalReport2.rpt");
               // string reportPath = System.IO.Path.Combine(Environment.CurrentDirectory, "CrystalReport2.rpt");
               // doc.Load(reportPath);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            ViewerCore view = f2.crystalReportViewer1.ViewerCore;
            view.ReportSource = doc;
            TextObject text = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text3"];
            TextObject text2 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text5"];
            TextObject text3 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text10"];
            TextObject text4 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text13"];
            TextObject text5 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text15"];
            TextObject text6 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text19"];
            TextObject text7 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text21"];
            TextObject text8 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text23"];
            TextObject text9 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text25"];
            TextObject text10 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text35"];
            TextObject text11 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text37"];
            TextObject text12 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text41"];
            TextObject text13 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text43"];
            TextObject text14 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text47"];
            TextObject text15 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text63"];
            TextObject text16 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text51"];
            TextObject text17 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text52"];
            TextObject text18 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text53"];
            TextObject text19 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text55"];
            TextObject text20 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text57"];
            TextObject text21 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text66"];
            TextObject text22 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text71"];
            TextObject text23 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text69"];
            TextObject text24 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text71"];
            TextObject text25 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text76"];
            TextObject text26 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text79"];
            TextObject text27 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text84"];
            TextObject text28 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text85"];
            TextObject text29 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text86"];
            TextObject text30 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text90"];
            TextObject text31 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text11"];
            TextObject text32 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text29"];
            TextObject text33 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text27"];
            TextObject text34 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text31"];
            TextObject text35 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text39"];
            TextObject text36 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text33"];
            TextObject text37 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text73"];
            TextObject text38 = (TextObject)doc.ReportDefinition.Sections["Section3"].ReportObjects["Text58"];
            text6.Text = tx8.Text;
            text9.Text = tx11.Text;
            text11.Text = tx13.Text;
            text12.Text = tx14.Text;
            text13.Text = tx18.Text;
            text14.Text = tx19.Text;
            text15.Text = tx23.Text;
            text16.Text = tx15.Text;
            text17.Text = tx16.Text;
            text18.Text = tx17.Text;
            text19.Text = tx20.Text;
            text20.Text = tx21.Text;
            text21.Text = tx24.Text;
            //text22.Text = tx25.Text;
            text23.Text = tx26.Text;
            text24.Text = tx27.Text;
            text25.Text = tx28.Text;
            text26.Text = tx29.Text;
            text28.Text = tx30.Text;
            text30.Text = tx33.Text;
            text31.Text = tx4.Text;
            text32.Text = tx40.Text;
            text33.Text = tx41.Text;
            text34.Text = tx42.Text;
            text35.Text = tx44.Text;
            text36.Text = tx45.Text;
            text37.Text = tx50.Text;
            text38.Text = textBox1.Text;
            f2.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CrystalReportText();
        }

        private void btn_save(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("ok", "ok", MessageBoxButton.OK, MessageBoxImage.Asterisk);


            Connexion.AddOrdre("INSERT INTO ajouter(ID,benefice,nom_prenom,sujet,fiche" +
                    ",paimentValide,compteBancaire,sujetVersement," +
                    "beneficeVers,compteBancaireVers,numOredeEchange,classe,lobe,parag," +
                    "paragSecond,numVisa,prixTotale,negation,prixTotalePayer," +
                    "arreterA,au,dans,benificeComptable,identBancaireComptable,ficheAppartient," +
                    "lobeFiche,annesFinancier)values('" +
                    int.Parse(textBox10.Text) + "','" + tx13.Text + "','" + tx50.Text + "','" + tx14.Text + "','" + tx18.Text +
                    "','" + tx19.Text + "','" + tx23.Text + "','" + tx24.Text + "','" + tx26.Text + "','" + tx27.Text +
                    "','" + tx8.Text + "','" + tx11.Text +
                    "','" + tx4.Text + "','" + tx40.Text + "','" + tx41.Text + "','" + tx42.Text + "','" + tx15.Text + "','" +
                    tx16.Text + "','" + tx17.Text + "','" + tx20.Text + "','" + tx21.Text + "','" + tx44.Text + "','" +
                    tx28.Text + "','" + tx29.Text + "','" + tx30.Text + "','" + tx45.Text +
                    "','" + tx33.Text + "')");

           /* Ordre o = new Ordre(int.Parse(textBox10.Text), tx13.Text, tx50.Text, tx14.Text, tx18.Text, tx19.Text,
                   tx23.Text, tx24.Text, tx26.Text, tx27.Text, tx8.Text, tx11.Text, tx4.Text, tx40.Text, tx41.Text,
                   tx42.Text, tx15.Text, tx16.Text, tx17.Text, tx20.Text, tx21.Text, tx44.Text, tx28.Text, tx29.Text,
                   tx30.Text, tx45.Text, tx33.Text);
            OleDbConnection conn = new OleDbConnection(connString);
            conn.Open();
            string sql = "INSERT INTO ajouter(ID,benefice,nom_prenom,sujet,fiche" +
                    ",paimentValide,compteBancaire,sujetVersement," +
                    "beneficeVers,compteBancaireVers,numOredeEchange,classe,lobe,parag," +
                    "paragSecond,numVisa,prixTotale,negation,prixTotalePayer," +
                    "arreterA,au,dans,benificeComptable,identBancaireComptable,ficheAppartient," +
                    "lobeFiche,annesFinancier)values('" +
                    int.Parse(textBox10.Text) + "','" + tx13.Text + "','" + tx50.Text + "','" + tx14.Text + "','" + tx18.Text +
                    "','" + tx19.Text + "','" + tx23.Text + "','" + tx24.Text + "','" + tx26.Text + "','" + tx27.Text +
                    "','" + tx8.Text + "','" + tx11.Text +
                    "','" + tx4.Text + "','" + tx40.Text + "','" + tx41.Text + "','" + tx42.Text + "','" + tx15.Text + "','" +
                    tx16.Text + "','" + tx17.Text + "','" + tx20.Text + "','" + tx21.Text + "','" + tx44.Text + "','" +
                    tx28.Text + "','" + tx29.Text + "','" + tx30.Text + "','" + tx45.Text +
                    "','" + tx33.Text + "')";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();*/


        }
    }
}
