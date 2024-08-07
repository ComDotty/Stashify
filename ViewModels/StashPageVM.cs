using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;  // Added for async Task methods
using System.Windows.Input;
using Stashify.Models;
using Stashify.Services;
using Stashify.Commands;

namespace Stashify.ViewModels
{
    public class StashPageVM : BaseVM
    {
        public ObservableCollection<Stash> Items { get; }

        public List<string> ItemsPerPageOptions { get; } = new List<string> { "10", "20", "50", "All" };

        private string _itemsPerPageOption;
        public string ItemsPerPageOption
        {
            get => _itemsPerPageOption;
            set
            {
                _itemsPerPageOption = value;
                OnPropertyChanged(nameof(ItemsPerPageOption));
                UpdateItemsPerPage();  // Method to update ItemsPerPage based on selection
            }
        }

        private int _itemsPerPage = 10;
        public int ItemsPerPage
        {
            get => _itemsPerPage;
            private set
            {
                _itemsPerPage = value;
                LoadInitialItems();  // Load items when ItemsPerPage is updated
                UpdateShowMoreButtonVisibility();  // Update visibility of Show More button
            }
        }

        // Tracks the current count of items loaded
        private int _currentItemCount = 0;

        private bool _isShowMoreVisible;
        public bool IsShowMoreVisible
        {
            get => _isShowMoreVisible;
            private set
            {
                _isShowMoreVisible = value;
                OnPropertyChanged(nameof(IsShowMoreVisible));
            }
        }

        public ICommand AddCommand { get; }
        public ICommand FilterCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand ShowMoreCommand { get; }  // Command for Show More button

        private readonly IAlertService _alertService;

        public StashPageVM(IAlertService alertService)
        {
            _alertService = alertService;

            Items = new ObservableCollection<Stash>();

            AddCommand = new DelegateCommand(async _ => await Add());
            FilterCommand = new DelegateCommand(async _ => await Filter());
            EditCommand = new DelegateCommand(async param => await Edit(param), CanExecuteEditDelete);
            DeleteCommand = new DelegateCommand(async param => await Delete(param), CanExecuteEditDelete);
            ShowMoreCommand = new DelegateCommand(_ => ShowMoreItems());  // Initialize Show More command
        }

        // Method to update the number of items per page based on selection
        private void UpdateItemsPerPage()
        {
            if (_itemsPerPageOption == "All")
            {
                ItemsPerPage = Stash.StashList.Count;
            }
            else if (int.TryParse(_itemsPerPageOption, out int itemsPerPage))
            {
                ItemsPerPage = itemsPerPage;
            }
        }

        // Method to load initial items into the collection
        public void LoadInitialItems()
        {
            _currentItemCount = 0;  // Reset current item count
            var sortedList = Stash.StashList.OrderBy(stash => stash.ProductId).Take(_itemsPerPage).ToList();

            Items.Clear();
            foreach (var stashItem in sortedList)
            {
                Items.Add(stashItem);
            }

            _currentItemCount = Items.Count;  // Update current item count
            UpdateShowMoreButtonVisibility();  // Update Show More button visibility
        }

        // Method to load more items when Show More is clicked
        private void ShowMoreItems()
        {
            var sortedList = Stash.StashList.OrderBy(stash => stash.ProductId).Skip(_currentItemCount).Take(_itemsPerPage).ToList();

            foreach (var stashItem in sortedList)
            {
                Items.Add(stashItem);
            }

            _currentItemCount += sortedList.Count;  // Update current item count
            UpdateShowMoreButtonVisibility();  // Update Show More button visibility
        }

        // Method to update the visibility of the Show More button
        private void UpdateShowMoreButtonVisibility()
        {
            IsShowMoreVisible = _currentItemCount < Stash.StashList.Count;
        }

        private async Task Add()
        {
            await _alertService.ShowAlertAsync("Stash Collection", "Add command called successfully.", "OK");
        }

        private async Task Filter()
        {
            await _alertService.ShowAlertAsync("Stash Collection", "Filter command called successfully.", "OK");
        }

        private async Task Edit(object? param)
        {
            if (param is int productId)
            {
                await _alertService.ShowAlertAsync("Stash Collection", $"Edit command called successfully for Product ID: {productId}.", "OK");
            }
        }

        private async Task Delete(object? param)
        {
            if (param is int productId)
            {
                await _alertService.ShowAlertAsync("Stash Collection", $"Delete command called successfully for Product ID: {productId}.", "OK");
            }
        }

        private bool CanExecuteEditDelete(object? param)
        {
            return param is int;
        }
    }
}
