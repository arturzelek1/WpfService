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
    public partial class ClientEditDialog : Window
    {
        public int id;

        public ClientEditDialog(int id)
        {
            this.id = id;
            InitializeComponent();
            using (var dbc = new AppDbContext())
            {
                var c = dbc.Clients.Where(p => p.Id == id).FirstOrDefault();

                if (c != null)
                {
                    clientName.Text = c.Name;
                    clientAddress.Text = c.Address;
                    clientDiscount.Text = c.Discount.ToString();
                }
            }
        }

        private static bool isNumeric(string text)
        {
            Regex _regex = new Regex(@"^[0-9]+$");
           
            return !_regex.IsMatch(text);
        }

        private void Validation(object sender, TextCompositionEventArgs e)
        {
            e.Handled = isNumeric(e.Text);
        }

        private void EditClient(object sender, RoutedEventArgs e)
        {
            if (
                clientName.Text.Length != 0
                && clientAddress.Text.Length != 0
                && clientDiscount.Text.Length != 0)
            {

                using (var dbc =  new AppDbContext())
                {
                    var obj = dbc.Clients.Where(p => p.Id == id).FirstOrDefault();
                    if(obj != null)
                    {
                        obj.Name = clientName.Text;
                        obj.Address = clientAddress.Text;

                        obj.Discount = Convert.ToInt32(clientDiscount.Text);
                    }

                    dbc.SaveChanges();
                }

                this.Close();
            }
            else
                MessageBox.Show("Missing data in fields.", "Error!");
        }
    }
}
