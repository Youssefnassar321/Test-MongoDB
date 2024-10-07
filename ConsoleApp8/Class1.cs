using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Class1
    {
        [BsonId]
        [DataMember]
        int id { get; set; }

        [DataMember]
        string titl {  get; set; }

        [DataMember]
        public string url { get; set; }

        [DataMember]
        public int enrolled { get; set; }

    }
}
