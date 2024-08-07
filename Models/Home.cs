using MongoDB.Bson;
using Realms;

namespace Stashify.Models
{
    public class Home : RealmObject
    {
        //[PrimaryKey]
        //[MapTo("_Id")]
        //public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

        public int? SectionId { get; set; }

        public string? SectionTitle { get; set; }

        public string? SectionCount { get; set;}

        public string? MostRecentListed { get; set; }

        public string? MostRecentListedLabel { get; set; }

        public string? SectionImage { get; set; }
    }
}