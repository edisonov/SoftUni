namespace FootballManager.Controllers
{
    using BasicWebServer.Server.Controllers;
    using BasicWebServer.Server.HTTP;
    using FootballManager.Contracts;
    using FootballManager.ViewModels;

    public class HomeController : Controller
    {
        private readonly IUserService userService;
        private readonly IPlayerService playerService;

        public HomeController(Request request, IUserService userService)
            : base(request)
        {
            this.userService = userService;
        }

        public Response Index()
        {
            if (User.IsAuthenticated)
            {
                string username = userService.GetUsername(User.Id);

                var model = new
                {
                    Username = username,
                    IsAuthenticated = true,
                };

                return View(model, "/Players/All");
            }

            return this.View(new { IsAuthenticated = false });
        }
    }
}
