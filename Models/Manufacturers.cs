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
        public required string name { get; set; }

        [MapTo("website_url")]
        public string? website_url { get; set; }

        [MapTo("location")]
        public string? location { get; set; }

        [MapTo("description")]
        public string? description { get; set; }

    }
}
