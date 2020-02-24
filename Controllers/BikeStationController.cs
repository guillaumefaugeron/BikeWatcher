using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using BikeWatcher.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Net.Http;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BikeWatcher.Controllers
{
    public class BikeStationController : Controller
    {
        private static readonly HttpClient client = new HttpClient();

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var stations = await ProcessRepositories();
            ViewBag.allstations = stations.OrderBy( x => x.name);
            return View("BikeStations");
        }

    private static async Task<List<BikeStation>> ProcessRepositories()
    {

    client.DefaultRequestHeaders.Accept.Clear();
    client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

    var streamTask = client.GetStreamAsync("https://download.data.grandlyon.com/ws/rdata/jcd_jcdecaux.jcdvelov/all.json");
    var bikeStations = await JsonSerializer.DeserializeAsync<RootObject>(await streamTask);
    return bikeStations.values;

    }
}

    }



