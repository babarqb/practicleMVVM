using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using PracticleMVVM.Annotations;

namespace PracticleMVVM.Models
{
    public class Coffee : INotifyPropertyChanged
    {
        private int _coffeeId;
        private string _coffeeName;
        private int _price;
        private string _description;
        private Country _originCountry;
        private bool _inStock;
        private int _amountInStock;
        private DateTime _firstAddedToStockDate;
        private int _imageId;

        public int CoffeeId
        {
            get { return _coffeeId; }
            set
            {
                if (value == _coffeeId) return;
                _coffeeId = value;
                OnPropertyChanged();
            }
        }

        public string CoffeeName
        {
            get { return _coffeeName; }
            set
            {
                if (value == _coffeeName) return;
                _coffeeName = value;
                OnPropertyChanged();
            }
        }

        public int Price
        {
            get { return _price; }
            set
            {
                if (value == _price) return;
                _price = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                if (value == _description) return;
                _description = value;
                OnPropertyChanged();
            }
        }

        public Country OriginCountry
        {
            get { return _originCountry; }
            set
            {
                if (value == _originCountry) return;
                _originCountry = value;
                OnPropertyChanged();
            }
        }

        public bool InStock
        {
            get { return _inStock; }
            set
            {
                if (value == _inStock) return;
                _inStock = value;
                OnPropertyChanged();
            }
        }

        public int AmountInStock
        {
            get { return _amountInStock; }
            set
            {
                if (value == _amountInStock) return;
                _amountInStock = value;
                OnPropertyChanged();
            }
        }

        public DateTime FirstAddedToStockDate
        {
            get { return _firstAddedToStockDate; }
            set
            {
                if (value.Equals(_firstAddedToStockDate)) return;
                _firstAddedToStockDate = value;
                OnPropertyChanged();
            }
        }

        public int ImageId
        {
            get { return _imageId; }
            set
            {
                if (value == _imageId) return;
                _imageId = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    }
