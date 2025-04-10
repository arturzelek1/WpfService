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
    public partial class OrderAddDialog : Window
    {
        public OrderAddDialog()
        {
            InitializeComponent();
            using (var dbc = new AppDbContext())
            {
                clients.ItemsSource = dbc.Clients.ToList();
            }
        }

        private void AddOrder(object sender, RoutedEventArgs e)
        {
            if (clients.SelectedItem != null)
            {
                using (var dbc =  new AppDbContext())
                {
                    var to_add = dbc.Orders.Add(
                        new Order
                        {
                            ClientId = Convert.ToInt32(clients.SelectedValue),
                            OrderDate = DateTime.Now
                        }
                    );
                    dbc.SaveChanges();
                }

                this.Close();
            }
            else
                MessageBox.Show("Missing data in fields.", "Error!");
        }
    }
}
