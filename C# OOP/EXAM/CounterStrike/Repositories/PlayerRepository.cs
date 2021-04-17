using System;
using System.Collections.Generic;
using System.Linq;
using CounterStrike.Models.Players.Contracts;
using CounterStrike.Repositories.Contracts;

namespace CounterStrike.Repositories
{
    public class PlayerRepository : IRepository<IPlayer>
    {
        private List<IPlayer> players;

        public PlayerRepository()
        {
            this.players = new List<IPlayer>();
        }

        public IReadOnlyCollection<IPlayer> Models => this.players.AsReadOnly();


        public void Add(IPlayer model)
        {
            if (players == null)
            {
                throw new ArgumentException("Cannot add null in Player Repository");
            }
        }

        public bool Remove(IPlayer model)
        {
            return this.players.Remove(model);
        }

        public IPlayer FindByName(string name)
        {
            var result = this.players.FirstOrDefault(p => p.Username == name);
            return result;
        }
    }
}