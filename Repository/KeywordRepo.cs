using System;
using System.Collections.Generic;
using keywordfinder.Models;
using MongoDB.Driver;

namespace keywordfinder.Repository {

    public class KeywordRepo {
        public static string ConnectionString = "mongodb://localhost:27017";

        private static MongoClient _client = new MongoClient(ConnectionString);
        private IMongoDatabase _db;

        public KeywordRepo() {
            this._db = _client.GetDatabase("keywordfinder");
        }

        public List<Keyword> GetKeywords() {
            var kw = this._db.GetCollection<Keyword>("keywords");
            return kw.Find(k => true).ToList<Keyword>();
        }

        public void SetKeyword(string keyword) {
            var collection = this._db.GetCollection<Keyword>("keywords");
            var kw = collection.Find(k => k.word.ToLower().Equals(keyword)).First();
            if(kw != null) {
                var document = new Keyword() { word = keyword, occurances = 1 };
                collection.InsertOne(document);
                return;
            }
            kw.occurances++;
            collection.InsertOne(kw);
        }

        //TODO: need to verify this updates Occurances properly
        public void SetKeyword(string keyword, int numOccur) {
            var collection = this._db.GetCollection<Keyword>("keywords");
            var kw = collection.Find(k => k.word.ToLower().Equals(keyword)).First();
            if(kw != null) {
                var document = new Keyword() { word = keyword, occurances = numOccur };
                collection.InsertOne(document);
                return;
            }
            kw.occurances += numOccur;
            collection.InsertOne(kw);
        }
    }
}