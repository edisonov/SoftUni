using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private Dictionary<string, Player> playesByName;

        public Team(string name)
        {
            this.Name = name;
            this.playesByName = new Dictionary<string, Player>();
        }

        public string Name 
        {
            get => this.name; 
            private set
            {
                Validator.ThrowIsStringIsNullOrWhiteSpace(value, GlobalConstants.InvalidNameErrorMessage);
                this.name = value;
            }
        }

        public double AverageRating
        {
            get
            {
                if (this.playesByName.Count == 0)
                {
                    return 0;
                }

                return Math.Round(this.playesByName
                    .Values
                    .Average(p => p.AverageSkillPoints));
            }
        }

        public void AddPlayer(Player player)
        {
            this.playesByName.Add(player.Name, player);
        }


        public void RemovePlayer(string playerName)
        {
            if (!this.playesByName.ContainsKey(playerName))
            {
                throw new InvalidOperationException($"Player {playerName} is not in {this.Name} team.");
            }

            this.playesByName.Remove(playerName);
        }
    }
}
