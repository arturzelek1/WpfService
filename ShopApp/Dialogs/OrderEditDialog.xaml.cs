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
using Microsoft.EntityFrameworkCore;

namespace ShopApp
{
    /// <summary>
    /// Interaction logic for ProductAddDialog.xaml
    /// </summary>
    public partial class OrderEditDialog : Window
    {

        public int orderId;
        public OrderEditDialog(int id)
        {
            this.orderId = id;

            InitializeComponent();
            refreshData();
        }

        private void EditOrder(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void EditDetail(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            OrderDetailEditDialog addDialog = new OrderDetailEditDialog(Convert.ToInt32(b.CommandParameter));
            addDialog.ShowDialog();
            refreshData();
        }

        private void AddDetail(object sender, RoutedEventArgs e)
        {
            OrderDetailAddDialog editDialog = new OrderDetailAddDialog(orderId);
            editDialog.ShowDialog();
            refreshData();
        }

        private void DeleteDetail(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            using (var dbc = new AppDbContext())
            {
                var obj = dbc.OrderDetails.Where(p => p.Id == Convert.ToInt32(b.CommandParameter)).FirstOrDefault();
                if (obj != null)
                {
                    dbc.OrderDetails.Remove(obj);
                    dbc.SaveChanges();
                    MessageBox.Show($"Succesuflly deleted order detail.");
                }
                else
                    MessageBox.Show($"An error occured when deleting order detail.");
            }
            refreshData();
        }

        public void refreshData()
        {
            using (var dbc = new AppDbContext())
            {
                TableData.ItemsSource = null;
                TableData.Items.Clear();
                TableData.ItemsSource = dbc.OrderDetails.Include(x => x.Product).Where(x => x.OrderId == orderId).ToList();
            }
        }
    }
}
