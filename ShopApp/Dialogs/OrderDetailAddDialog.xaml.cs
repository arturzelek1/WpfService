using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ShopApp.Models;

namespace ShopApp
{
    /// <summary>
    /// Interaction logic for ProductAddDialog.xaml
    /// </summary>
    public partial class OrderDetailAddDialog : Window
    {
        public int orderId;
        public OrderDetailAddDialog(int id)
        {
            this.orderId = id;
            InitializeComponent();
            using (var dbc = new AppDbContext())
            {
                product.ItemsSource = dbc.Products.ToList();
            }
        }

        private static bool isNumeric(string text)
        {
            Regex _regex = new Regex(@"^[0-9]$");

            return !_regex.IsMatch(text);

        }

        private void Validation(object sender, TextCompositionEventArgs e)
        {
            e.Handled = isNumeric(e.Text);
        }

        private void AddDetail(object sender, RoutedEventArgs e)
        {
            if (product.SelectedItem != null
                && count.Text.Length != 0)
            { 
                using (var dbc = new AppDbContext())
                {
                    var to_add = dbc.OrderDetails.Add(
                        new OrderDetail
                        {
                            OrderId = orderId,
                            Count = Convert.ToInt32(count.Text),
                            ProductId = Convert.ToInt32(product.SelectedValue)
                        });
                    dbc.SaveChanges();
                }

                this.Close();
            }
            else
                MessageBox.Show("Missing data in fields.", "Error!");
        }
    }
}
