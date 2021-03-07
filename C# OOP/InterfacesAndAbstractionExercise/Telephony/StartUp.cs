using System;

namespace Telephony
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split();
            var urls = Console.ReadLine().Split();

            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            foreach (var number in numbers)
            {
                try
                {
                    var result = number.Length == 10 ? smartphone.Call(number) : stationaryPhone.Call(number);

                    Console.WriteLine(result);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }

            foreach (var url in urls)
            {
                try
                {
                    var result = smartphone.Browse(url);

                    Console.WriteLine(result);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
