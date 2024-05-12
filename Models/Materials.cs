using MongoDB.Bson;
using Realms;

namespace Stashify.Models
{
    public class Materials : RealmObject
    {
        [PrimaryKey]
        [MapTo("_Id")]
        public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

        [MapTo("material_name")]
        [Required]
        public required string material_name { get; set; }

        [MapTo("material_type")]
        [Required]
        public required string? material_type { get; set; }

    }
}
