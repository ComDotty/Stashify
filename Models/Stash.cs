using MongoDB.Bson;
using Realms;

namespace Stashify.Models
{
    public class Stash : RealmObject
    {
        //[PrimaryKey]
        //[MapTo("_Id")]
        //public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

        public int ProductId { get; set; }

        public int? ShoppingListId { get; set; }

        public string? ProductManufacturer { get; set; }

        public string? ProductCode { get; set;}

        public string? ProductScale { get; set; }

        public string? ProductName { get; set; }

        public string? ProductDescription { get; set;}

        public string? DatePurchased { get; set; }

        public string? WherePurchased { get; set; }

        public string? PriceValue { get; set; }

        public string? ProductAvailability { get; set; }

        public string? ProductQuantity { get; set; }

        public string? ProductMaterial { get; set; }

        public string? ProductType { get; set; }

        public string? ProductImage { get; set; }

        public static List<Stash> StashList = new List<Stash>
        {
            new Stash { ProductId = 8, ProductManufacturer = "Italeri", ProductCode = "6444", ProductScale = "1/35th", ProductName = "Crusader Mk.III AA Mk.III", ProductDescription = "British Crusader Mk.III AA Mk.III anti-aircraft tank. Re-issue of original Crusader Mk.III with new AA turret, guns and fittings.", ProductQuantity="1", ProductMaterial = "Injection Moulded Plastic", ProductType = "Military, armoured vehicle", ProductImage="StashImages/italeri_crusaderaamk3.jpg", WherePurchased="eBay", DatePurchased="18/04/2021", PriceValue="£29.99", ProductAvailability="Currently OOP" },
            new Stash { ProductId = 10, ProductManufacturer = "Tamiya", ProductCode = "35300", ProductScale = "1/35th", ProductName = "Matilda Mk.III/IV", ProductDescription = "Tamiya new-tool release of the Matilda Mk.III/IV Infantry tank", ProductQuantity="2", ProductMaterial = "Moulded Plastic", ProductType = "Military, armoured vehicle", ProductImage="StashImages/tamiya_matilda.jpg", WherePurchased="Shopee", DatePurchased="01/08/2021", PriceValue="£24.99", ProductAvailability="Currently Available" },
            new Stash { ProductId = 3, ProductManufacturer = "Tamiya", ProductCode = "32528", ProductScale = "1/48th", ProductName = "Cromwell Mk.IV", ProductDescription = "Cromwell Mk.IV British cruiser tank. C pattern hull", ProductQuantity="1", ProductMaterial = "Injection Moulded Plastic, Metal", ProductType = "Military, armoured vehicle", ProductImage="StashImages/tamiya_cromwell48.jpg", WherePurchased="eBay", DatePurchased="13/06/2009", PriceValue="£13.99", ProductAvailability="Currently Available" },
            new Stash { ProductId = 6, ProductManufacturer = "Border Models", ProductCode = "BT-012", ProductScale = "1/35th", ProductName = "Crusader Mk.III", ProductDescription = "New-tool kit of the British Crusader Mk.III cruiser tank", ProductQuantity="2", ProductMaterial = "Injection Moulded Plastic, Etched-Brass", ProductType = "Military, armoured vehicle", ProductImage="StashImages/border_crusader.jpg", WherePurchased="Hobby Store Singapore", DatePurchased="09/10/2021", PriceValue="£39.99", ProductAvailability="Currently Available" },
            new Stash { ProductId = 9, ProductManufacturer = "AFV Club", ProductCode = "AF35308", ProductScale = "1/35th", ProductName = "Centurion Mk.1", ProductDescription = "AFV Club family of Centurions. Correctly represents the longer hull of the Mk.1 and Mk.2 variants", ProductQuantity="1", ProductMaterial = "Injection Moulded Polystyrene, Metal gun, Etched-Brass", ProductType = "Military, armoured vehicle", ProductImage="StashImages/afvclub_centmk1.jpg", WherePurchased="eBay", DatePurchased="04/08/2021", PriceValue="£64.99", ProductAvailability="Currently Available" },
            new Stash { ProductId = 2, ProductManufacturer = "Trumpeter", ProductCode = "00324", ProductScale = "1/35th", ProductName = "British AS-90 155mm SPG", ProductDescription = "British AS-90 155mm Self Propelled Gun. Simple kit requires lots of additional detail and new tracks, basic but sound", ProductQuantity="1", ProductMaterial = "Injection Moulded Plastic, Etched-Brass", ProductType = "Military, armoured vehicle", ProductImage="StashImages/trumpeter_as90.jpg", WherePurchased="Lazada", DatePurchased="18/07/2019", PriceValue="£14.99", ProductAvailability="Currently Available" },
            new Stash { ProductId = 5, ProductManufacturer = "Mirror Models", ProductCode = "35402", ProductScale = "1/35th", ProductName = "Morris C8 Mk.II Quad", ProductDescription = "Morris Quad gun-tractor Mk.II. This version has also been kitted by Gecko Models. This release seems to be OOP", ProductQuantity="2", ProductMaterial = "Polystyrene, Etched-Brass, Vinyl tyres", ProductType = "Military, softskin vehicle", ProductImage="StashImages/mirror_morrisquadc8.jpg", WherePurchased="Hannants - UK", DatePurchased="10/08/2021", PriceValue="£24.99", ProductAvailability="Currently OOP(?)" },
            new Stash { ProductId = 11, ProductManufacturer = "Vulcan Scale Models", ProductCode = "56008", ProductScale = "1/35th", ProductName = "British Light Tank Mk.VIB", ProductDescription = "Only 1/35th kit of the Vickers Light Tank Mk.VIB, sadly Vulcan are now out of business and the toolings don't seem to have been picked up by any other maker", ProductQuantity="1", ProductMaterial = "Polystyrene, Etched-Brass", ProductType = "Military, armoured vehicle", ProductImage="StashImages/vulcan_vickersmkvi.jpg", WherePurchased="eBay", DatePurchased="21/04/2019", PriceValue="£39.99", ProductAvailability="OOP" },
            new Stash { ProductId = 14, ProductManufacturer = "Italeri", ProductCode = "6432", ProductScale = "1/35th", ProductName = "Crusader Mk.I", ProductDescription = "Re-issue of the Mk.III kit with Mk.I turret, gun and fittings", ProductQuantity="1", ProductMaterial = "Injection Moulded Polystyrene", ProductType = "Military, armoured vehicle", ProductImage="StashImages/italeri_crusadermk1.jpg", WherePurchased="Online - Store in Manila", DatePurchased="08/11/2022", PriceValue="£24.99", ProductAvailability="Currently OOP" },
            new Stash { ProductId = 12, ProductManufacturer = "Tamiya", ProductCode = "37025", ProductScale = "1/35th", ProductName = "Crusader Mk.III (Italeri Reissue)", ProductDescription = "Tamiya re-issue of the Italeri Crusader Mk.III kit with minor detail improvements and a new figure/equipment sprue", ProductQuantity="1", ProductMaterial = "Polystyrene, Etched-Brass, Vinyl tyres", ProductType = "Military, softskin vehicle", WherePurchased="eBay", ProductImage="StashImages/tamiya_crusaderiii.jpg", DatePurchased="18/04/2021", PriceValue="£24.99", ProductAvailability="Currently Available" },             
            new Stash { ProductId = 7, ProductManufacturer = "Trumpeter", ProductCode = "01049", ProductScale = "1/35th", ProductName = "M270/A1 MLRS", ProductDescription = "Trumpeter kit of the US M270/A1 Multiple Launch Rocket System, this is the variant currently in use with the British Army but it has a number of distinctive, UK-specific fittings", ProductQuantity="1", ProductMaterial = "Polystyrene, Etched-Brass", ProductType = "Military, armoured vehicle", ProductImage="StashImages/trumpeter_m270.jpg", WherePurchased="Shopee", DatePurchased="22/04/2022", PriceValue="£71.99", ProductAvailability="Currently Available" },
            new Stash { ProductId = 1, ProductManufacturer = "Tamiya", ProductCode = "MM100", ProductScale = "1/35th", ProductName = "British Churchill Crocodile", ProductDescription = "British Churchill Crocodile flame-thrower tank and trailer, original 1970's release. Kit has recently been re-issued (2024)", ProductQuantity="1", ProductMaterial = "Injection Moulded Plastic", ProductType = "Military, armoured vehicle", ProductImage="StashImages/tamiya_churchillcrocvii.jpg", WherePurchased="eBay", DatePurchased="12/09/2020", PriceValue="£34.99", ProductAvailability="Currently Available - Re-issued" },
            new Stash { ProductId = 13, ProductManufacturer = "Gecko Models", ProductCode = "35GM0003", ProductScale = "1/35th", ProductName = "British A9 Cruiser Mk.I", ProductDescription = "British Cruiser Mk.I, the A9, very detailed kit of the first British fast cruiser tank, etched details and individual track-links", ProductQuantity="1", ProductMaterial = "Injection Moulded Plastic,Etched-Brass", ProductType = "Military, armoured vehicle", ProductImage="StashImages/gecko_a9cruiser.jpg", WherePurchased="Online - Lazada(?)", DatePurchased="01/11/2019", PriceValue="£49.99", ProductAvailability="Currently Available" },
            new Stash { ProductId = 4, ProductManufacturer = "Tamiya", ProductCode = "35274", ProductScale = "1/35th", ProductName = "British Challenger 2 Desertised", ProductDescription = "Challenger 2 in Iraq War/Operation Granby fit", ProductQuantity="1", ProductMaterial = "Injection Moulded Plastic", ProductType = "Military, armoured vehicle", ProductImage="StashImages/tamiya_challenger2desertised.jpg", WherePurchased="eBay", DatePurchased="11/06/2021", PriceValue="£34.99", ProductAvailability="Currently Available" },
        };

        public static Stash GetItemById(int productId)
        {
            return StashList.FirstOrDefault(item => item.ProductId == productId);
        }

        public static List<Stash> ListItems()
        {
            return StashList;
        }
    }
}