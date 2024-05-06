using APIIntegration.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using System.Collections.Generic;


namespace APIIntegration.Controllers
{
    [Route("weatherCont")]
    public class IntegrateAndFetchController : Controller
    {
        IService service;
        public IntegrateAndFetchController(IService service)
        {
            this.service = service;
        }
        public IActionResult Get()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https:9999//someUrl.com/someApi");
            //client.DefaultRequestHeaders = new Requ;
            //var response = client.GetAsync(client.BaseAddress).Wait();
            System.Collections.Generic.List<Player> players = new System.Collections.Generic.List<Player>();
            players.Add(new Player("player 1"));
            players.Add(new Player("player 2"));
            players.Add(new Player("player 3"));
            players.Add(new Player("player 3"));
            for (int i = 0; i < players.Count; i++)
            {
                for (int j = i+1; j < players.Count; j++)
                {
                    if (players.ElementAt(i).name==players.ElementAt(j).name)
                    {
                        players.Remove(players.ElementAt(j));
                    }
                }
            }
            return View();
        }
    }

    class Player
    {
        public Player(String _name)
        {
            this.name = _name;
        }
        public String name = "";
    }
}
