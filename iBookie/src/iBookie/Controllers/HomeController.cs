using iBookie.Services;
using Microsoft.AspNet.Mvc;

namespace iBookie.Controllers
{
    public class HomeController : Controller
    {
        private readonly IChampionsLeagueService _championsLeagueService;       
        public HomeController(IChampionsLeagueService championsLeagueService)
        {
            _championsLeagueService = championsLeagueService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            //Champions League
            var competition = _championsLeagueService.InitCompetition();
            return View(competition);
        }

        public IActionResult Team(int id)
        {            
            return View(_championsLeagueService.InitChampionsLeagueTeam(id));
        }

        public IActionResult Fixtures(int id)
        {
            return View(_championsLeagueService.InitFixturesFor(id));
        }

        public IActionResult MyBet()
        {
            return View(_championsLeagueService.InitFixturesFor(7));
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
