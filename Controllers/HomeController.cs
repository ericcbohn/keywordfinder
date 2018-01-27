using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using keywordfinder.Business;
using keywordfinder.Models;

namespace keywordfinder.Controllers
{
    public class HomeController : Controller
    {
        private KeywordBusiness _keywordBusiness;

        public HomeController() {//IKeywordBusiness kb) {
            this._keywordBusiness = new KeywordBusiness();
        }

        public IActionResult Index()
        {
            return View();
        }

        public List<Keyword> GetKeywords() {
            return this._keywordBusiness.GetKeywords();
        }

        public void SetJobPost(string keywords) {
            this._keywordBusiness.SetJobPost(keywords);
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
