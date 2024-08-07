using MongoDB.Bson;
using Realms;

namespace Stashify.Models
{
    public class Wish : RealmObject
    {
        //[PrimaryKey]
        //[MapTo("_Id")]
        //public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

        public int ProductId { get; set; }

        public string? ProductManufacturer { get; set; }

        public string? ProductDistributor { get; set; }

        public string? ProductCode { get; set;}

        public string? ProductScale { get; set; }

        public string? ProductName { get; set; }

        public string? ProductDescription { get; set;}

        public string? ProductQuantity { get; set; }

        public string? ProductMaterial { get; set; }

        public string? ProductType { get; set; }

        public string? ProductImage { get; set; }

        public string? ProductAvailable { get; set; }

        public string? ProductReleaseDate { get; set; }

        private static List<Wish> _wishItems = new List<Wish>
        {
            new Wish { ProductId = 17, ProductManufacturer = "Gecko Models", ProductDistributor="Bachmann Europe", ProductCode = "16GM0016", ProductScale = "1/16th", ProductName = "Universal Carrier Mk.II", ProductDescription = "British Mk.II Bren/Universal Carrier", ProductQuantity="1", ProductMaterial = "Injection Moulded Plastic, Etched-Brass", ProductType = "Military, armoured vehicle", ProductImage="WishListImages/gecko_ucmk2.jpg", ProductAvailable="No", ProductReleaseDate="August 2024" },
            new Wish { ProductId = 21, ProductManufacturer = "Andy's Hobby Headquarters", ProductDistributor="Andy's Hobby Headquarters Europe", ProductCode = "AHHQ-007", ProductScale = "1/16th", ProductName = "British M10 Achilles Tank Destroyer", ProductDescription = "British M10 Achilles 17pdr Tank Destroyer", ProductQuantity="1", ProductMaterial = "Injection Moulded Plastic, Etched-Brass", ProductType = "Military, armoured vehicle", ProductImage="WishListImages/ahhq_m10achilles.jpg", ProductAvailable="Yes", ProductReleaseDate="August 2023" },
        };

        public static Wish GetItemById(int productId)
        {
            return _wishItems.FirstOrDefault(item => item.ProductId == productId);
        }

        public static List<Wish> ListItems()
        {
            return _wishItems;
        }
    }
}