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
using Microsoft.EntityFrameworkCore;

namespace ShopApp.Pages
{
    /// <summary>
    /// Interaction logic for Products.xaml
    /// </summary>
    public partial class Products : UserControl
    {
        public Products()
        {
            InitializeComponent();
            refreshData();
        }

        private void EditData(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;

            ProductEditDialog editDialog = new ProductEditDialog(Convert.ToInt32(b.CommandParameter));
            editDialog.ShowDialog();
            refreshData();
        }

        private void DeleteData(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            using (var dbc = new AppDbContext())
            {
                var product = dbc.Products.Where(p => p.Id == Convert.ToInt32(b.CommandParameter)).FirstOrDefault();
                if (product != null)
                {
                    dbc.Products.Remove(product);
                    dbc.SaveChanges();
                    MessageBox.Show($"Succesuflly deleted product: \n{product.Name}");
                }
                else
                    MessageBox.Show($"An error occured when deleting product: \n{product.Name}");
            }
            refreshData();
        }
        public void refreshData()
        {
            using (var dbc = new AppDbContext())
            {
                TableData.ItemsSource = null;
                TableData.Items.Clear();
                TableData.ItemsSource = dbc.Products.Include(x => x.Category).ToList();
            }
        }
    }
}
