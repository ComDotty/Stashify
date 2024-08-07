using MongoDB.Bson;
using Realms;

namespace Stashify.Models
{
    internal class Shopping : RealmObject
    {
        //[PrimaryKey]
        //[MapTo("_Id")]
        //public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

        public int ShoppingListId { get; set; }

        public string? ShoppingListLocation { get; set; }

        public string? ShoppingListDate { get; set; }

    }
}
