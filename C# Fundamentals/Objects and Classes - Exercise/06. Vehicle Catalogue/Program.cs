using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Трябва да създадете каталог с превозни средства. 
            Ще съхранявате само два вида превозни средства - лек и камион.
            Докато не получите командата „End“, ще получавате входни редове в следния формат:
            {typeOfVehicle} {модел} {цвят} {конски сили}
            След командата „Край“ ще започнете да получавате модели превозни средства.
            Отпечатайте данните за всяко получено превозно средство в следния формат:

            Type: {typeOfVehicle}
            Model: {modelOfVehicle}
            Color: {colorOfVehicle}
            Horsepower: {horsepowerOfVehicle}

            
            Когато получите командата „Close the Catalogue“, 
            отпечатайте средната конска мощност за леките и товарни автомобили в следния формат:
            {typeOfVehicles} имат средни конски сили от {средни конски сили}.
            Средната конска мощност се изчислява,
            като сумата от конските сили на всички превозни средства от даден тип се раздели
            на общия брой превозни средства от същия тип. Закръглете отговора до 2-рата цифра след десетичния разделител.
             */
            List<Vehiche> catalogue = new List<Vehiche>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArgs = command.Split();
                string type = cmdArgs[0].ToLower();
                string model = cmdArgs[1];
                string color = cmdArgs[2].ToLower();
                int hp = int.Parse(cmdArgs[3]);

                Vehiche currentVehiche = new Vehiche(type, model, color, hp);

                catalogue.Add(currentVehiche);

                command = Console.ReadLine();
            }
            string seconCommand = Console.ReadLine();

            while (seconCommand != "Close the Catalogue")
            {
                string modelType = seconCommand;

                Vehiche printCar = catalogue.First(x => x.Model == modelType);

                Console.WriteLine(printCar);

                seconCommand = Console.ReadLine();
            }

            List<Vehiche> onlyCars = catalogue
                .Where(x => x.Type == "car")
                .ToList();

            List<Vehiche> onlyTrucks = catalogue
                .Where(x => x.Type == "truck")
                .ToList();

            double totalCarsHp = onlyCars.Sum(x => x.HorsePower);
            double totalTrucksHp = onlyTrucks.Sum(x => x.HorsePower);

            double avgCarHp = 0.00;
            double avgTruckHp = 0.00;

            if (onlyCars.Count > 0)
            {
                avgCarHp = totalCarsHp / onlyCars.Count;
            }
            if (onlyTrucks.Count > 0)
            {
                avgTruckHp = totalTrucksHp / onlyTrucks.Count;
            }

            Console.WriteLine($"Cars have average horsepower of: {avgCarHp:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avgTruckHp:f2}.");

        }
    }

    class Vehiche
    {
        public Vehiche(string type, string model, string color, int horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Type: {(Type == "car" ? "Car" : "Truck")}");

            sb.AppendLine($"Model: {Model}");

            sb.AppendLine($"Color: {Color}");

            sb.AppendLine($"Horsepower: {HorsePower}");

            return sb.ToString().TrimEnd();
        }
    }
}
