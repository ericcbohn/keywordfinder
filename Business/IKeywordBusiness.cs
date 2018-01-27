using System;
using System.Collections.Generic;
using keywordfinder.Models;

namespace keywordfinder.Business {
    
    public interface IKeywordBusiness {
        List<Keyword> GetKeywords();
        void SetJobPost(string jobPost);
    }
}