using System;
using System.Collections.Generic;
using System.Data;
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


namespace centre_de_stage_chebba
{
    /// <summary>
    /// Logique d'interaction pour UserControl1.xaml
    /// </summary>
    public partial class UserControlCreate : UserControl
    {
        
        public UserControlCreate()
        {
            InitializeComponent();
        }
        //umpty the datagrid when the form load 
        //call the method remplit_DGV from the connexion class 
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            string sql = "SELECT* FROM ajouter";
            Connexion.remplirDGV(datagridview, sql);


        }

        private void DataGridCell_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            /*string sql = "SELECT * FROM ajouter";
            Connexion.addDataFromGridView(sql);*/
            // MessageBox.Show("ok", "ok", MessageBoxButton.OK, MessageBoxImage.Error);
           

        }


        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Add search = new Add();
            search.Show();

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Add add = new Add();
            add.Show();
        }

        private void datagridview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Add addwindow = new Add();
            //DataGridCell slectedcCell = datagridview.CurrentCell;
            object item = datagridview.SelectedItem;
            string id = (datagridview.SelectedCells[0].Column.GetCellContent(item) as TextBlock)?.Text;
            addwindow.tx50.Text = id;
            addwindow.Show();
        }
    }
}

