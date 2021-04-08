using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Options;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;
using System;

namespace Program
{
    public class MongoDatabase<T> : IDatabase<T>
    {
        const string MongoDbConnectionString = "mongodb://localhost:27017";
        const string DataBaseName = "HansPlcDatabase";
        const string CollectionName = "HansCollection";
        private IMongoCollection<T> Collection { get; set; }
        public MongoDatabase()
        {
            MapSerializer();
            var client = new MongoClient(MongoDbConnectionString);
            var database = client.GetDatabase(DataBaseName);
            database.DropCollection(CollectionName);
            Collection = database.GetCollection<T>(CollectionName);
        }


        public void Write(T data)
        {
            ((dynamic)data).id = ObjectId.GenerateNewId();
            ((dynamic)data).TimeStamp = DateTime.Now;
            Collection.InsertOne(data);
            ((dynamic)data).id = null;
        }

        private void MapSerializer()
        {
            var bsonMap = new BsonClassMap(typeof(T));
            bsonMap.AutoMap();
            bsonMap.SetIgnoreExtraElements(true);
            bsonMap.MapIdProperty("id");
            BsonClassMap.RegisterClassMap(bsonMap);

            BsonSerializer.RegisterSerializer(typeof(UInt64), new UInt64Serializer(BsonType.Int64, new RepresentationConverter(true, false)));
            BsonSerializer.RegisterSerializer(typeof(UInt32), new UInt32Serializer(BsonType.Int32, new RepresentationConverter(true, false)));
            BsonSerializer.RegisterSerializer(DateTimeSerializer.LocalInstance);
        }

    }

}
