using System;
using System.Collections.Generic;
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

namespace ShopApp.Pages
{
    /// <summary>
    /// Interaction logic for Clients.xaml
    /// </summary>
    public partial class Clients : UserControl
    {
        public Clients()
        {
            InitializeComponent();
            refreshData();
        }

        private void EditData(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;

            ClientEditDialog editDialog = new ClientEditDialog(Convert.ToInt32(b.CommandParameter));
            editDialog.ShowDialog();
            refreshData();
        }

        private void DeleteData(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            using (var dbc = new AppDbContext())
            {
                var obj = dbc.Clients.Where(p => p.Id == Convert.ToInt32(b.CommandParameter)).FirstOrDefault();
                if (obj != null)
                {
                    dbc.Clients.Remove(obj);
                    dbc.SaveChanges();
                    MessageBox.Show($"Succesuflly deleted client: \n{obj.Name}");
                }
                else
                    MessageBox.Show($"An error occured when deleting client: \n{obj.Name}");
            }
            refreshData();
        }

        public void refreshData()
        {
            using (var dbc = new AppDbContext())
            {
                TableData.ItemsSource = null;
                TableData.Items.Clear();
                TableData.ItemsSource = dbc.Clients.ToList();
            }
        }
    }
}
