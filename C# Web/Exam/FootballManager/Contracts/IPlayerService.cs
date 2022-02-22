using FootballManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Contracts
{
    public interface IPlayerService
    {
        (bool created, string error) Create(AddViewModel model);

        IEnumerable<PlayerViewModel> GetProducts();
        IEnumerable<PlayerListViewModel> GetPlayers();
    }
}
