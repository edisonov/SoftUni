using FootballManager.ViewModels;
using FootballManager.ViewModels.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Services.Contracts
{
    public interface IPlayerService
    {
        List<AllPlayersViewModel> GetAllPlayersModel();
        List<UserConectionViewModel> GetAllCollection(string userId);
        List<string> CreatePlayer(CreatePlayerViewModel model, string userId);
        
        void RemovePlayerFromCollection(string userId, string playerId);
        string AddPlayerToUserCollection(string userId, string cardId);
    }
}
