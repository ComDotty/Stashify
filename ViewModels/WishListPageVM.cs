using System.Collections.ObjectModel;
using Stashify.Models;
using Stashify.Services;
using Stashify.Commands;
using System.Windows.Input;

namespace Stashify.ViewModels
{
    public class WishListPageVM : BaseVM
    {
        public ObservableCollection<Wish> Items { get; }

        public ICommand AddCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        private readonly IAlertService _alertService;

        // Constructor
        public WishListPageVM(IAlertService alertService)
        {
            _alertService = alertService;

            Items = new ObservableCollection<Wish>();
            LoadData();

            AddCommand = new DelegateCommand(async _ => await Add());
            EditCommand = new DelegateCommand(async param => await Edit(param), CanExecuteEditDelete);
            DeleteCommand = new DelegateCommand(async param => await Delete(param), CanExecuteEditDelete);
        }
        
        // Create and load test data for the stash page collectionview
        public void LoadData()
        {
            // Clear existing items
            Items.Clear();

            // Add hard-coded items (for initial testing)
            var hardCodedItems = new[]
            {
                new Wish { ProductId = 17, ProductManufacturer = "Gecko Models", ProductDistributor="Bachmann Europe", ProductCode = "16GM0016", ProductScale = "1/16th", ProductName = "Universal Carrier Mk.II", ProductDescription = "British Mk.II Bren/Universal Carrier", ProductQuantity="1", ProductMaterial = "Injection Moulded Plastic, Etched-Brass", ProductType = "Military, armoured vehicle", ProductImage="WishListImages/gecko_ucmk2.jpg", ProductAvailable="No", ProductReleaseDate="August 2024" },
                new Wish { ProductId = 21, ProductManufacturer = "Andy's Hobby Headquarters", ProductDistributor="Andy's Hobby Headquarters Europe", ProductCode = "AHHQ-007", ProductScale = "1/16th", ProductName = "British M10 Achilles Tank Destroyer", ProductDescription = "British M10 Achilles 17pdr Tank Destroyer", ProductQuantity="1", ProductMaterial = "Injection Moulded Plastic, Etched-Brass", ProductType = "Military, armoured vehicle", ProductImage="WishListImages/ahhq_m10achilles.jpg", ProductAvailable="Yes", ProductReleaseDate="August 2023" },
            };

            foreach (var item in hardCodedItems)
            {
                if (item != null)
                {
                    Items.Add(item);
                }
            }
        }
        private async Task Add()
        {
            await _alertService.ShowAlertAsync("Wishlist Collection", "Add command called successfully.", "OK");
        }

        private async Task Edit(object? param)
        {
            if (param is int productId)
            {
                await _alertService.ShowAlertAsync("Wishlist Collection", $"Edit command called successfully for Product ID: {productId}.", "OK");
            }
        }

        private async Task Delete(object? param)
        {
            if (param is int productId)
            {
                await _alertService.ShowAlertAsync("Wishlist Collection", $"Delete command called successfully for Product ID: {productId}.", "OK");
            }
        }

        private bool CanExecuteEditDelete(object? param)
        {
            return param is int;
        }        
    }
}