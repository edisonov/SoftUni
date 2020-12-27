using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _05._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Време е за проекти за екипна работа и вие сте отговорни за събирането на екипите.
             * Първо ще получите цяло число - броят на отборите, които ще трябва да регистрирате.
             * Ще получите потребител и екип, разделени с „-“. Потребителят е създателят на екипа. 
             * За всеки новосъздаден екип трябва да отпечатате съобщение:„Екипът {teamName} е създаден от {user}!“.
             * След това ще получите потребител с екип, разделен с „->“, което означава,
             * че потребителят иска да се присъедини към този екип. След получаване на командата:
             * „край на заданието“, трябва да отпечатате всеки екип, 
             * подреден по броя на членовете му (низходящ) и след това по име (възходящ).
             * За всеки отбор трябва да отпечатате членовете му, сортирани по име (възходящо). 
             * Има обаче няколко правила:
             * 
             * 
             • Ако потребител се опита да създаде екип повече от веднъж, трябва да се покаже съобщение:
        ◦      „Екипът {teamName} вече беше създаден!“
             • Създател на екип не може да създаде друг екип - трябва да се изпрати следното съобщение:
        ◦      „{потребител} не може да създаде друг екип!“
             • Ако потребител се опита да се присъедини към несъществуващ екип, трябва да се покаже съобщение:
        ◦      „Екипът {teamName} не съществува!“
             • Член на екип не може да се присъедини към друг екип - трябва да се изпрати следното съобщение:
        ◦     „Член {потребител} не може да се присъедини към екип {име на екип}!“
             • В крайна сметка екипите с нулев член (само със създател) 
               трябва да се разпуснат и трябва да ги отпечатате подредени по име във възходящ ред.
             • Всеки валиден екип трябва да бъде отпечатан подредено по име (възходящо) в следния формат:

             "{teamName}:
             - {creator}
             -- {member}…"

             */

            int teamCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            
            for (int i = 0; i < teamCount; i++)
            {
                string[] newTeam = Console.ReadLine().Split("-");

                string creatorName = newTeam[0];
                string teamName = newTeam[1];

                Team team = new Team(teamName, creatorName);

                bool isTeamNameExist = teams
                    .Select(x => x.TeamName)
                    .Contains(teamName);

                bool isCreatorNameExist = teams
                    .Select(x => x.CreatorName)
                    .Contains(creatorName);

                if (!isTeamNameExist)
                {
                    if (!isCreatorNameExist)
                    {
                        teams.Add(team);
                        Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                    }
                    else
                    {
                        Console.WriteLine($"{creatorName} cannot create another team!");
                    }
                   
                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }

            }

            string teamMembers = Console.ReadLine();

            while (teamMembers != "end of assignment")
            {
                string[] cmdArg = teamMembers
                    .Split(new char[] {'-','>'})
                    .ToArray();

                string newUser = cmdArg[0];
                string teamName = cmdArg[2];

                bool isTeamExist = teams
                    .Select(x => x.TeamName)
                    .Contains(teamName);

                bool isCreatorExist = teams
                    .Select(x => x.CreatorName)
                    .Contains(newUser);

                bool isMembersExist = teams
                    .Select(x => x.Members)
                    .Any(x => x.Contains(newUser));

                if (!isTeamExist)
                {
                    Console.WriteLine($"Team {teamName} does not exist!"); 
                }
                else if (isCreatorExist || isMembersExist)
                {
                    Console.WriteLine($"Member {newUser} cannot join team {teamName}!");
                }
                else
                {
                    int index = teams.FindIndex(x => x.TeamName == teamName);
                    teams[index].Members.Add(newUser);
                }

                teamMembers = Console.ReadLine();

            }

            Team[] teamsToDisband = teams
                .OrderBy(x => x.TeamName)
                .Where(x => x.Members.Count == 0)
                .ToArray();

            Team[] fullTeam = teams
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.TeamName)
                .Where(x => x.Members.Count > 0)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (Team team in fullTeam)
            {
                sb.AppendLine($"{team.TeamName}");
                sb.AppendLine($"- {team.CreatorName}");

                foreach (var member in team.Members.OrderBy(x=>x))
                {
                    sb.AppendLine($"-- {member}");
                }
            }

            sb.AppendLine("Teams to disband:");

            foreach (Team item in teamsToDisband)
            {
                sb.AppendLine(item.TeamName);
            }

            Console.WriteLine(sb.ToString());
           
        }

        public class Team
        {
            public Team(string teamName, string creatorName)
            {
                TeamName = teamName;
                CreatorName = creatorName;
                Members = new List<string>();
            }

            public string TeamName { get; set; }
            public string CreatorName { get; set; }
            public List<string> Members { get; set; }

           
        }
    }
}
