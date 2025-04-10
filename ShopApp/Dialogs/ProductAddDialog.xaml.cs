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
    public partial class ProductAddDialog : Window
    {
        public ProductAddDialog()
        {
            InitializeComponent();
            using (var dbc = new AppDbContext())
            {
                productCategory.ItemsSource = dbc.Categories.ToList();
            }
        }

        private static bool isNumeric(string text)
        {
            Regex _regex = new Regex(@"^[.][0-9]+$|^[0-9]*[.]{0,1}[0-9]*$");

            return !_regex.IsMatch(text);

        }

        private void Validation(object sender, TextCompositionEventArgs e)
        {
            e.Handled = isNumeric(e.Text);
        }

        private void AddProduct(object sender, RoutedEventArgs e)
        {
            if (
                productName.Text.Length != 0
                && productDescription.Text.Length != 0
                && productCategory.SelectedItem != null
                && productPrice.Text.Length != 0)
            {

                using (var dbc =  new AppDbContext())
                {
                    var to_add = dbc.Products.Add(
                        new Product
                        {
                            Name = productName.Text,
                            Description = productDescription.Text,
                            CategoryId = Convert.ToInt32(productCategory.SelectedValue),
                            Price = Convert.ToDouble(productPrice.Text.Replace('.',','))
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
