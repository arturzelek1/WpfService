using Microsoft.EntityFrameworkCore;
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
    /// Interaction logic for Orders.xaml
    /// </summary>
    public partial class Orders : UserControl
    {
        public Orders()
        {
            InitializeComponent();
            refreshData();
        }

        private void EditData(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;

            OrderEditDialog editDialog = new OrderEditDialog(Convert.ToInt32(b.CommandParameter));
            editDialog.ShowDialog();
            refreshData();
        }

        private void DeleteData(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            using (var dbc = new AppDbContext())
            {
                var obj = dbc.Orders.Where(p => p.Id == Convert.ToInt32(b.CommandParameter)).FirstOrDefault();
                if (obj != null) { 
                    dbc.OrderDetails.RemoveRange(dbc.OrderDetails.Where(r => r.Order == obj).ToList());
                    dbc.Orders.Remove(obj);
                    dbc.SaveChanges();
                    MessageBox.Show($"Succesuflly deleted order id: \n{obj.Id}");
                }
                else
                    MessageBox.Show($"An error occured when deleting order id: \n{obj.Id}");
            }
            refreshData();
        }

        private void EndOrder (object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            using (var dbc = new AppDbContext())
            {
                var obj = dbc.Orders.Where(p => p.Id == Convert.ToInt32(b.CommandParameter)).FirstOrDefault();
                if (obj == null)
                    MessageBox.Show($"An error occured when deleting order id: \n{obj.Id}");
                else if (obj.OrderEndDate != null)
                    MessageBox.Show("That order has been finished.");
                else
                {
                    obj.OrderEndDate = DateTime.Now;
                    dbc.SaveChanges();
                    MessageBox.Show($"Succesuflly finished order id: \n{obj.Id}");
                }
            }
            refreshData();
        }

        public void refreshData()
        {
            using (var dbc = new AppDbContext())
            {
                TableData.ItemsSource = null;
                TableData.Items.Clear();
                TableData.ItemsSource = dbc.Orders.Include(x => x.Client).Include(x => x.Items).Include("Items.Product").ToList();
            }
        }
    }
}
