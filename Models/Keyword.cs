using System;
using MongoDB.Bson;

namespace keywordfinder.Models {
    public class Keyword {
        public ObjectId _id { get; set; }
        public string word { get; set; }
        public int occurances { get; set; }
    }
}