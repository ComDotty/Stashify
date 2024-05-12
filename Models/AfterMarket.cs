using MongoDB.Bson;
using Realms;

namespace Stashify.Models
{
    public class AfterMarket : RealmObject
    {
        [PrimaryKey]
        [MapTo("_Id")]
        public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

    }
}
