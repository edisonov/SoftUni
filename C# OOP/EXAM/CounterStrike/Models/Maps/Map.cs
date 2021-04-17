using System;
using System.Collections.Generic;
using System.Linq;
using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players;
using CounterStrike.Models.Players.Contracts;

namespace CounterStrike.Models.Maps
{
    public class Map : IMap
    {
        private List<IPlayer> terrorist;
        private List<IPlayer> counterTerrorist;

        public Map()
        {
            terrorist = new List<IPlayer>();
            counterTerrorist = new List<IPlayer>();
        }

        private void AttackTeam(List<IPlayer> attackingTeam, List<IPlayer> defendingTeam)
        {
            foreach (var attacker in attackingTeam)
            {
                if (!attacker.IsAlive)
                {
                    continue;
                }

                foreach (var defender in defendingTeam)
                {
                    defender.TakeDamage(attacker.Gun.Fire());
                }
            }
        }
        public string Start(ICollection<IPlayer> players)
        {
            foreach (var player in players)
            {
                if (player is CounterTerrorist)
                {
                    counterTerrorist.Add(player);
                }
                else if (player is Terrorist)
                {
                    terrorist.Add(player);
                }
            }

            while (IsTeamAlive(terrorist) && IsTeamAlive(counterTerrorist))
            {
                AttackTeam(terrorist, counterTerrorist);
                AttackTeam(counterTerrorist, terrorist);
            }

            if (IsTeamAlive(counterTerrorist))
            {
                return "Counter Terrorist wins!";
            }
            else if (IsTeamAlive(terrorist))
            {
                return "Terrorist wins!";
            }

            return "Something horrible happened";
        }

        private bool IsTeamAlive(List<IPlayer> players)
        {
            return players.Any(x => x.IsAlive);
        }
    }
}