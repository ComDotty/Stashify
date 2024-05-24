using MongoDB.Bson;
using Realms;

namespace Stashify.Models
{
    public class Scales : RealmObject
    {
        [PrimaryKey]
        [MapTo("_Id")]
        public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

        [MapTo("scale")]
        [Required]
        public required string Scale { get; set; }

    }

}
