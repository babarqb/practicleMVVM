using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using MahApps.Metro.Controls;
using PracticleMVVM.Extensions;
using PracticleMVVM.Models;
using PracticleMVVM.Services;

namespace PracticleMVVM.Views
{
    /// <summary>
    /// Interaction logic for CoffeeOverviewView.xaml
    /// </summary>
    public partial class CoffeeOverviewView : MetroWindow
    {
        private Coffee _selectedCoffee;
        private ObservableCollection<Coffee> _coffees;
        public CoffeeOverviewView()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            CoffeeDataService coffeeDataService = new CoffeeDataService();
            //CoffeeListView.ItemsSource = coffeeDataService.GetAllCoffees();
            _coffees = coffeeDataService.GetAllCoffees().ToObservableCollection();
            CoffeeListView.ItemsSource = _coffees;
        }

        private void EditCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            CoffeeDetailView coffeeDetailView = new CoffeeDetailView();
            coffeeDetailView.SelectedCoffee = _selectedCoffee;
            coffeeDetailView.ShowDialog();
        }

        private void CoffeeListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _selectedCoffee = e.AddedItems[0] as Coffee;

            if (e != null)
            {
                CoffeeIdLabel.Content = _selectedCoffee.CoffeeId;
                CoffeeNameLabel.Content = _selectedCoffee.CoffeeName;
                DescriptionLabel.Content = _selectedCoffee.Description;
                PriceLabel.Content = _selectedCoffee.Price;
                StockAmountLabel.Content = _selectedCoffee.AmountInStock.ToString();
                FirstTimeAddedLabel.Content = _selectedCoffee.FirstAddedToStockDate.ToShortDateString();

                BitmapImage img = new BitmapImage();
                img.BeginInit();
                img.UriSource = new Uri("/PracticleMVVM;component/Images/coffee" + _selectedCoffee.CoffeeId + ".jpg", UriKind.Relative);
                img.EndInit();
                CoffeeImage.Source = img;
            }
        }

        private void AddFakeCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            Coffee coffe = new Coffee()
            {
                CoffeeId = 24,
                OriginCountry = Country.Brasil,
                CoffeeName = "Capichino",
                Price = 1000,
                AmountInStock = 20,
                Description = "A awesome coffee",
                FirstAddedToStockDate = DateTime.Now,
                InStock = true
            };
            _coffees.Add(coffe);
        }
    }
}
