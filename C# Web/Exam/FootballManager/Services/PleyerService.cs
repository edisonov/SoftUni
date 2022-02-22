using FootballManager.Contracts;
using FootballManager.Data.Common;
using FootballManager.Data.Models;
using FootballManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Services
{
    public class PleyerService : IPlayerService
    {
        private readonly IRepository repo;
        private readonly IValidationService validationService;

        public PleyerService(IRepository repo, IValidationService validationService)
        {
            this.repo = repo;
            this.validationService = validationService;
        }
        public (bool created, string error) Create(AddViewModel model)
        {
            bool registered = false;
            string error = null;

            var (isValid, validationError) = validationService.ValidateModel(model);

            if (!isValid)
            {
                return (isValid, validationError);
            }

            Player player = new Player()
            {
                FullName = model.FullName,
                ImageUrl = model.ImageUrl,
                Position = model.Position,
                Speed = model.Speed,
                Endurance = model.Endurance,
                Description = model.Description,
            };

            try
            {
                repo.Add(player);
                repo.SaveChanges();
                registered = true;
            }
            catch (Exception)
            {
                error = "Could not save player in DB";
            }

            return (registered, error);
        }

        public IEnumerable<PlayerListViewModel> GetPlayers()
        {
            return repo.All<Player>()
                .Select(p => new PlayerListViewModel()
                {
                    Id = p.Id,
                    FullName = p.FullName,
                    Endurance = p.Endurance,
                    Position = p.Position,
                    Speed= p.Speed,
                })
                .ToList();
        }

        public IEnumerable<PlayerViewModel> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
