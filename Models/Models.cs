using MongoDB.Bson;
using Realms;

namespace Stashify.Models
{
    public class Models : RealmObject
    {
        [PrimaryKey]
        [MapTo("_Id")]
        public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

    }
}
