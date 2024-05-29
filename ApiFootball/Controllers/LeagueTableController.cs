using ApiFootball.Models;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ApiFootball.Controllers
{
    public class LeagueTableController : Controller
    {
        // GET: LeagueTable
        [HttpPost]

        public async Task<ActionResult> Deneme(FormCollection frm)
        {

            int ligId = Convert.ToInt32(frm["leagueListt"]);
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://football-web-pages1.p.rapidapi.com/league-table.json?comp=" + ligId),
                Headers =
    {
        { "X-RapidAPI-Key", "d317931d34msh05c39424a217125p134a3cjsn3214b19f3e1d" },
        { "X-RapidAPI-Host", "football-web-pages1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();


                Root ligSiralama = JsonConvert.DeserializeObject<Root>(body);
                return View(ligSiralama.league_table);
            }

        }
        public async Task<ActionResult> MatchDetails(int id)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://football-web-pages1.p.rapidapi.com/match.json?match=" + id),
                Headers =
    {
        { "X-RapidAPI-Key", "d317931d34msh05c39424a217125p134a3cjsn3214b19f3e1d" },
        { "X-RapidAPI-Host", "football-web-pages1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Match match = JsonConvert.DeserializeObject<Match>(body);
                var dene = match.awayteam.name;
                return View(match.awayteam);
            }


        }

        public async Task<ActionResult> TeamDetails(int id)
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://football-web-pages1.p.rapidapi.com/fixtures-results.json?team=" + id),
                Headers =
    {
        { "X-RapidAPI-Key", "d317931d34msh05c39424a217125p134a3cjsn3214b19f3e1d" },
        { "X-RapidAPI-Host", "football-web-pages1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Root teamDetails = JsonConvert.DeserializeObject<Root>(body);
                return View(teamDetails.fixturesresults);
            }
        }
        [HttpGet]
        public async Task<ActionResult> LeagueList()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://football-web-pages1.p.rapidapi.com/competitions.json?include=rounds"),
                Headers =
    {
        { "X-RapidAPI-Key", "d317931d34msh05c39424a217125p134a3cjsn3214b19f3e1d" },
        { "X-RapidAPI-Host", "football-web-pages1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                List<Competition> leagueList = JsonConvert.DeserializeObject<List<Competition>>(body);
                List<SelectListItem> competitionList = (from i in leagueList
                                                        select new SelectListItem
                                                        {
                                                            Text = i.fullname,
                                                            Value = i.id.ToString(),


                                                        }).ToList();
                ViewBag.leagueListt = competitionList;

                return View();
            }
        }
    }
}