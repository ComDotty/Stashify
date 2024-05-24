using MongoDB.Bson;
using Realms;

namespace Stashify.Models
{
    public class Materials : RealmObject
    {
        [PrimaryKey]
        [MapTo("_Id")]
        public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

        [MapTo("materialname")]
        [Required]
        public required string MaterialName { get; set; }

        [MapTo("materialtype")]
        [Required]
        public required string? MaterialType { get; set; }

    }
}
