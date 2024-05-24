using MongoDB.Bson;
using Realms;

namespace Stashify.Models
{
    public class Manufacturers : RealmObject
    {
        [PrimaryKey]
        [MapTo("_Id")]
        public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

        [MapTo("name")]
        [Required]
        public required string ManufacturerName { get; set; }

        [MapTo("websiteurl")]
        public string? ManufacturerWebsiteURL { get; set; }

        [MapTo("address")]
        public string? ManufacturerAddress { get; set; }

        [MapTo("country")]
        public string? ManufacturerCountry { get; set; }

        [MapTo("description")]
        public string? ManufacturerDescription { get; set; }

    }
}
