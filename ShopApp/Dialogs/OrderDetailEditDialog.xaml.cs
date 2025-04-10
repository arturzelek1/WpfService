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
    public partial class OrderDetailEditDialog : Window
    {
        public int detailId;
        public OrderDetailEditDialog(int id)
        {
            this.detailId = id;
            InitializeComponent();
            using (var dbc = new AppDbContext())
            {
                product.ItemsSource = dbc.Products.ToList();
                var obj = dbc.OrderDetails.Include(x => x.Product).Where(x => x.Id == detailId).FirstOrDefault();
                if (obj != null)
                { 
                    product.SelectedValue = obj.ProductId;
                    count.Text = obj.Count.ToString();
                }
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

        private void EditDetail(object sender, RoutedEventArgs e)
        {
            if (product.SelectedItem != null
                && count.Text.Length != 0)
            { 
                using (var dbc = new AppDbContext())
                {
                    var obj = dbc.OrderDetails.Include(x => x.Product ).Where(x => x.Id == detailId).FirstOrDefault();
                    obj.ProductId = Convert.ToInt32(product.SelectedValue);
                    obj.Count = Convert.ToInt32(count.Text);
                    dbc.SaveChanges();
                }

                this.Close();
            }
            else
                MessageBox.Show("Missing data in fields.", "Error!");
        }
    }
}
