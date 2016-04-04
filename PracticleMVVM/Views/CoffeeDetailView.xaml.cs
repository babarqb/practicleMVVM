using System;
using System.Windows;
using System.Windows.Media.Imaging;
using MahApps.Metro.Controls;
using PracticleMVVM.Models;

namespace PracticleMVVM.Views
{
    /// <summary>
    /// Interaction logic for CoffeeDetailView.xaml
    /// </summary>
    public partial class CoffeeDetailView : MetroWindow
    {
        public Coffee SelectedCoffee { get; set; }

        public CoffeeDetailView()
        {
            InitializeComponent();

            this.Loaded += CoffeeDetailView_Loaded;
        }

        void CoffeeDetailView_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            CoffeeNameLabel.Content = SelectedCoffee.CoffeeName;
            CoffeeIdTextBox.Text = SelectedCoffee.CoffeeId.ToString();
            CoffeeDescriptionTextBox.Text = SelectedCoffee.Description;
            CoffeePriceTextBox.Text = SelectedCoffee.Price.ToString();
            StockAmountTextBox.Text = SelectedCoffee.AmountInStock.ToString();
            FirstTimeAddedTextBox.Text = SelectedCoffee.FirstAddedToStockDate.ToShortDateString();
            if (SelectedCoffee is SuperiorCoffee)
                ExtraDescriptionTextBox.Text = (SelectedCoffee as SuperiorCoffee).ExtraDescription;
            else
                ExtraDescriptionTextBox.Text = "NA";

            BitmapImage img = new BitmapImage();
            img.BeginInit();
            img.UriSource = new Uri("/PracticleMVVM;component/Images/coffee" + SelectedCoffee.CoffeeId + ".jpg", UriKind.Relative);
            img.EndInit();
            CoffeeImage.Source = img;
        }

        private void DeleteCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SaveCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
