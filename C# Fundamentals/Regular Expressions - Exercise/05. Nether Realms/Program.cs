using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }
        public override string ToString()
        {
            return $"{Name} - {Health} health, {Damage:f2} damage";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Demon> allDemon = new List<Demon>();

            string pattern = @"[+-]?[0-9]+\.?[0-9]*";

            Regex regex = new Regex(pattern);

            string[] demons = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var demon in demons)
            {
                string filter = "0123456789+-*/.";

                int healt = demon.Where(x => !filter.Contains(x)).Sum(x => x);
                double damage = CalculateDamage(regex, demon);

                allDemon.Add(new Demon { Name = demon, Health = healt, Damage = damage });
            }

            foreach (var demon in allDemon.OrderBy(x=>x.Name))
            {
                Console.WriteLine(demon);
            }
        }

        private static double CalculateDamage(Regex regex, string demon)
        {
            MatchCollection numberMatches = regex.Matches(demon);
            double damage = 0;

            foreach (Match match in numberMatches)
            {
                damage += double.Parse(match.Value);
            }

            foreach (var ch in demon)
            {
                if (ch == '*')
                {
                    damage *= 2.0;
                }
                else if (ch == '/')
                {
                    damage /= 2.0;
                }
            }

            return damage;
        }
    }
}
