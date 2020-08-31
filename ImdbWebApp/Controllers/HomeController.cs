using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ImdbWebApp.Models;
using System.Net.Http;
using ImdbWebApp.services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ImdbWebApp.Controllers
{
    
    public class HomeController : Controller
    {
        public struct SearchResponse
        {
            public Movie[] Search { get; set; }
        }
        public SearchResponse GetData(string search)
        {
            string url = $"http://www.omdbapi.com/?s={ search }&apikey=59b358d2";
            var con = ApiConnection<SearchResponse>.getData(url).GetAwaiter().GetResult();
            return con;
        }
        [HttpGet]
        public IActionResult Index(string search)
        {
            if (String.IsNullOrEmpty(search))
            {
                return View();
            }
            else
            {
                Movie[] movies = (Movie[])GetData(search).Search;
                return View(movies);
            }


            
        }
        public IActionResult Index()
        {
            //GetData();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
