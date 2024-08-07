using MongoDB.Bson;
using Realms;

namespace Stashify.Models
{
    internal class BuySellTrade : RealmObject
    {
        [PrimaryKey]
        [MapTo("_Id")]
        public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

    }
}
