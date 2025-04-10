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

namespace ShopApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window
    {

        Pages.Products productsPage = new Pages.Products();
        Pages.Clients clientsPage = new Pages.Clients();
        Pages.Categories categoriesPage = new Pages.Categories();
        Pages.Orders ordersPage = new Pages.Orders();


        public MainWindow()
        {
            InitializeComponent();

            AppDbContext dbc = new AppDbContext();

            this.contentControl.Content = new Pages.Welcome();

        }

        private void ShowProductAdd(object sender, RoutedEventArgs e)
        {
            ProductAddDialog productAddDialog = new ProductAddDialog();
            productAddDialog.ShowDialog();
            refreshPages();
        }

        private void ShowOrderAdd(object sender, RoutedEventArgs e)
        {
            OrderAddDialog orderAddDialog = new OrderAddDialog();
            orderAddDialog.ShowDialog();
            refreshPages();
        }

        private void ShowCategoryAdd(object sender, RoutedEventArgs e)
        {
            CategoryAddDialog categoryAddDialog = new CategoryAddDialog();
            categoryAddDialog.ShowDialog();
            refreshPages();
        }

        private void ShowClientAdd(object sender, RoutedEventArgs e)
        {
            ClientAddDialog clientAddDialog = new ClientAddDialog();
            clientAddDialog.ShowDialog();
            refreshPages();
        }

        public void ShowProducts(object sender, RoutedEventArgs e) {
            this.contentControl.Content = productsPage;
        }

        public void ShowClients(object sender, RoutedEventArgs e)
        {
            this.contentControl.Content = clientsPage;
        }

        public void ShowCategories(object sender, RoutedEventArgs e)
        {
            this.contentControl.Content = categoriesPage;
        }

        public void ShowOrders(object sender, RoutedEventArgs e)
        {
            this.contentControl.Content = ordersPage;
        }

        public void refreshPages()
        {
            productsPage.refreshData();
            clientsPage.refreshData();
            categoriesPage.refreshData();
            ordersPage.refreshData();
        }

    }

}
