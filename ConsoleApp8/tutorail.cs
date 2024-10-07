using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Linq;
using MongoDB.Bson.Serialization.Attributes;
using System.Runtime.Serialization;


namespace ConsoleApp8
{
    internal class tutorail
    {
        [BsonId]
        [DataMember]
        public ObjectId Id { get; set; }

        [DataMember]
        public string title { get; set; }

        [DataMember]
        public string by { get; set; }

        [DataMember]
        public string url { get; set; }

        [DataMember]
        public int enrolled { get; set; }

        [DataMember]
        public BsonArray tags { get; set; }
    }
}
