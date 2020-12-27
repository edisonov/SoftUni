using System;

namespace _01._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        { 
            /*
            Напишете програма, която генерира случайно фалшиво рекламно съобщение, за да рекламирате продукт.
            Съобщенията трябва да се състоят от 4 части: фраза + събитие + автор + град.
            Използвайте следните предварително дефинирани части:

            Форматът на изходното съобщение е следният: { фраза} {събитие} { автор} - { град}.
            Ще получите броя на съобщенията, които трябва да бъдат генерирани.
            Отпечатайте всяко произволно съобщение на отделен ред.
            */


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(AdvertisementMessage.GenerateMessage());
            }
        }
        
        public class AdvertisementMessage
        {
            public static string[] Phrases = new string[] { "Excellent product.", "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.", "I can’t live without this product." };

            public static string[] Events = new string[] { "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!" };

            public static string[] Authors = new string[] { "Diana", "Petya", "Stella", "Elena",
                "Katya", "Iva", "Annie", "Eva" };

            public static string[] Cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            public static string GenerateMessage()
            {
                Random rand = new Random();
                string currentPhrase = Phrases[rand.Next(0, Phrases.Length - 1)];
                string currentEvents = Events[rand.Next(0, Events.Length - 1)];
                string currentAuthors = Authors[rand.Next(0, Authors.Length - 1)];
                string currentCities = Cities[rand.Next(0, Cities.Length - 1)];

                return $"{currentPhrase} {currentEvents} {currentAuthors} - {currentCities}";
            }
        }
    }
}
