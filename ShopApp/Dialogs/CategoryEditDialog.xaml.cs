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
using System.Windows.Shapes;
using ShopApp.Models;

namespace ShopApp
{
    /// <summary>
    /// Interaction logic for ProductAddDialog.xaml
    /// </summary>
    public partial class CategoryEditDialog : Window
    {
        public int id;
        public CategoryEditDialog(int id)
        {
            this.id = id;

            InitializeComponent();

            using (var dbc = new AppDbContext())
            {
                var obj = dbc.Categories.Where(p => p.Id == id).FirstOrDefault();

                if (obj != null)
                {
                    categoryName.Text = obj.Name;
                }
            }
        }

        private void EditCategory(object sender, RoutedEventArgs e)
        {
            if ( categoryName.Text.Length != 0 )
            {

                using (var dbc = new AppDbContext())
                {
                    var obj = dbc.Categories.Where(p => p.Id == id).FirstOrDefault();
                    if (obj != null)
                    {
                        obj.Name =categoryName.Text;
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
