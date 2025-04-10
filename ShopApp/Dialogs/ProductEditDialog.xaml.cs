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
using ShopApp;

namespace ShopApp
{
    /// <summary>
    /// Interaction logic for ProductAddDialog.xaml
    /// </summary>
    public partial class ProductEditDialog : Window
    {
        public int id;
        public ProductEditDialog(int id)
        {
            InitializeComponent();
            
            this.id = id;

            using (var dbc = new AppDbContext())
            {
                var p = dbc.Products.Where(p => p.Id == id).FirstOrDefault();

                productCategory.ItemsSource = dbc.Categories.ToList();
                if (p != null)
                {
                    productName.Text = p.Name;
                    productDescription.Text = p.Description;
                    productCategory.SelectedValue = p.Category.Id;
                    productPrice.Text = p.Price.ToString();
                }
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

        private void EditProduct(object sender, RoutedEventArgs e)
        {
            if (
                productName.Text.Length != 0
                && productDescription.Text.Length != 0
                && productCategory.SelectedItem != null
                && productPrice.Text.Length != 0)
            {

                using (var dbc =  new AppDbContext())
                {

                    var p = dbc.Products.Where(p => p.Id == id).FirstOrDefault();

                    p.Name = productName.Text;
                    p.Description = productDescription.Text;
                    p.CategoryId = Convert.ToInt32(productCategory.SelectedValue);
                    p.Price = Convert.ToDouble(productPrice.Text.Replace('.', ','));
                    dbc.SaveChanges();
                }

                this.Close();
            }
            else
                MessageBox.Show("Missing data in fields.", "Error!");
        }
    }
}
