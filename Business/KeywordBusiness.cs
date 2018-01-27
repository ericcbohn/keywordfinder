using System;
using System.Collections.Generic;
using keywordfinder.Models;
using keywordfinder.Repository;
using MongoDB;

namespace keywordfinder.Business {
    public class KeywordBusiness : IKeywordBusiness {
    private KeywordRepo _keywordRepo = new KeywordRepo();

        public List<Keyword> GetKeywords() {
            return this._keywordRepo.GetKeywords();
        }

        public void SetKeyword(string keyword) {
            this._keywordRepo.SetKeyword(keyword);
        }

        public void SetKeyword(string keyword, int numOccur) {
            this._keywordRepo.SetKeyword(keyword, numOccur);
        }

        public void SetJobPost(string jobPost) {
            // TODO: R script to parse keywords?
            // foreach(string s in keywords) {
            //     this._keywordRepo.SetKeyword(s);
            // }
        }
    }
}