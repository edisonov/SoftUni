using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var people = new Dictionary<string, Person>();
            var product = new Dictionary<string, Product>();
            try
            {
                people = ReadPeople();
                product = ReadProducts();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
           

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                var parts = line.Split();

                var parsonName = parts[0];
                var productName = parts[1];

                var person = people[parsonName];
                var products = product[productName];
                try
                {
                    person.AddProduct(products);

                    Console.WriteLine($"{parsonName} bought {productName}");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var person in people.Values)
            {
                Console.WriteLine(person);
            }
        }

        private static Dictionary<string, Product> ReadProducts()
        {
            var result = new Dictionary<string, Product>();

            var parts = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var part in parts)
            {
                var productData = part.Split('=', StringSplitOptions.RemoveEmptyEntries);
               
                var productName = productData[0];
                var cost = decimal.Parse(productData[1]);

                result[productName] = new Product(productName, cost);

            }

            return result;
        }

        private static Dictionary<string, Person> ReadPeople()
        {
            var result = new Dictionary<string, Person>();

            var parts = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var part in parts)
            {
                var personData = part.Split('=', StringSplitOptions.RemoveEmptyEntries);

                var name = personData[0];
                var money = decimal.Parse(personData[1]);

                result[name] = new Person(name, money);

            }

            return result;
        }
    }
}
