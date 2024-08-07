using Stashify.Models;
using System.Collections.ObjectModel;

namespace Stashify.ViewModels
{
    public class HomePageVM : BaseVM
    {
            public ObservableCollection<Home> Items { get; }

            // Constructor
            public HomePageVM()
            {

                Items = new ObservableCollection<Home>();
                LoadData();
            
            }    
            
            // Create and load test data for the home page collectionview
            public void LoadData()
            {
                // Clear existing items
                Items.Clear();

                // Add hard-coded items (for initial testing)
                var hardCodedItems = new[]
                {
                    new Home { SectionId = 1, SectionTitle = "Your Stash", SectionCount = "14", MostRecentListedLabel="Last item added:", MostRecentListed = "Italeri Crusader Mk.III AA Mk.III", SectionImage="HomeImages/stash.jpg" },
                    new Home { SectionId = 2, SectionTitle = "Your Wishlist", SectionCount = "2", MostRecentListedLabel="Last item addedt:", MostRecentListed = "Gecko Models 1/16th Universal Carrier Mk.II.", SectionImage="HomeImages/wishlist.jpg" },
                    new Home { SectionId = 3, SectionTitle = "Your Shopping Lists", SectionCount = "1", MostRecentListedLabel="Next event or trip:", MostRecentListed = "List for Romsey Show (Jul 14th)", SectionImage="HomeImages/shoppinglist.jpg" },
                };

                foreach (var item in hardCodedItems)
                {
                    if (item != null)
                    {
                        Items.Add(item);
                    }
                }
            }
    }
}
