using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        /* 
        Ще получите неизвестен брой редове.
        Всеки ред ще се състои от масив от 3 елемента. 
        Първият елемент ще бъде низ и той ще представлява името на човек. 
        Вторият елемент ще бъде низ и той ще представлява идентификационния номер на човека.
        Последният елемент ще бъде цяло число - възрастта на човека. 
        Когато получите командата "Край", отпечатайте всички хора, подредени по възраст.
         */
        static void Main(string[] args)
        {
            List<People> people = new List<People>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArgs = command.Split();

                string name = cmdArgs[0];
                string ide = cmdArgs[1];
                int age = int.Parse(cmdArgs[2]);

                People names = new People(name, ide, age);

                people.Add(names);

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, people.OrderBy(x=>x.Age)));
        }
    }

    class People
    {
        public People(string name, string ide, int age)
        {
            Name = name;
            Ide = ide;
            Age = age;
        }

        public string Name { get; set; }
        public string Ide { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {Ide} is {Age} years old.";
        }

    }
}
