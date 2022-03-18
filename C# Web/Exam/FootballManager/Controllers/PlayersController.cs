using BasicWebServer.Server.Attributes;
using BasicWebServer.Server.Controllers;
using BasicWebServer.Server.HTTP;
using FootballManager.Contracts;
using FootballManager.Data.Common;
using FootballManager.Data.Models;
using FootballManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Controllers
{
    public class PlayersController : Controller
    {
        private readonly IPlayerService playerService;
        private readonly IRepository repo;
        public PlayersController(Request request, IPlayerService playerService) 
            : base(request)
        {
            this.playerService = playerService;
        }

        [Authorize]
        public Response All()
        {
            IEnumerable<CreatePlayerViewModel> trips = playerService.GetPlayers();

            return View(trips);
        }

        public Response Add()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public Response Add(AllPlayersViewModel model)
        {
            var (add, error) = playerService.Create(model);

            if (!add)
            {
                return View(new { ErrorMessage = error }, "/Error");
            }

            return Redirect("/Players/Add");
        }
    }
}
