using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonInfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<IBirthable> birthable = new List<IBirthable>();

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                var parts = line.Split();

                string type = parts[0];

                if (type == nameof(Citizen))
                {
                    string name = parts[1];
                    int age = int.Parse(parts[2]);
                    string id = parts[3];
                    string birthdate = parts[4];

                    birthable.Add(new Citizen(name, age, id, birthdate));
                }
                else if (type == nameof(Pet))
                {
                    string name = parts[1];
                    string birthdate = parts[2];

                    birthable.Add(new Pet(name, birthdate));
                }

                
            }

            string filterYear = Console.ReadLine();

            List<IBirthable> filter = birthable.Where(x => x.Birthdate.EndsWith(filterYear)).ToList();

            foreach (var item in filter)
            {
                Console.WriteLine(item.Birthdate);
            }



        }
    }
}
