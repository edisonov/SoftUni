using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bakery.Core.Contracts;
using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Drinks;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables;
using Bakery.Models.Tables.Contracts;
using Bakery.Utilities.Messages;

namespace Bakery.Core
{
    public class Controller : IController
    {
        private readonly ICollection<IBakedFood> bakedFoods;
        private readonly ICollection<IDrink> drinks;
        private readonly ICollection<ITable> tables;

        private decimal totalIncome;

        public Controller()
        {
            this.bakedFoods = new List<IBakedFood>();
            this.drinks = new List<IDrink>();
            this.tables = new List<ITable>();
            this.totalIncome = 0;
        }

        public IBakedFood IBakedFood { get; private set; }

        public string AddDrink(string type, string name, int portion, string brand)
        {
            if (type == "Tea")
            {
                this.drinks.Add(new Tea(name, portion, brand));
            }
            else if (type == "Water")
            {
                this.drinks.Add(new Water(name, portion, brand));
            }

            var message = string.Format(OutputMessages.DrinkAdded, name,
                brand);

            return message;
        }

        public string AddFood(string type, string name, decimal price)
        {

            if (type == "Bread")
            {
                this.bakedFoods.Add(new Bread(name, price));
            }
            else if (type == "Cake")
            {
                this.bakedFoods.Add(new Ceke(name, price));
            }

            var message = string.Format(OutputMessages.FoodAdded, name, type);

            return message;
        }

        public string AddTable(string type, int tableNumber, int capacity)
        {
            if (type == "InsideTable")
            {
                this.tables.Add(new InsideTable(tableNumber, capacity));
            }
            else if (type == "OutsideTable")
            {
                this.tables.Add(new OutsideTable(tableNumber, capacity));
            }

            var message = string.Format(OutputMessages.TableAdded,
                tableNumber);

            return message;
        }

        public string GetFreeTablesInfo()
        {
            var notReservedTables = tables.Where(x => !x.IsReserved).ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var table in notReservedTables)
            {
                sb.AppendLine(table.GetFreeTableInfo());
            }

            return sb.ToString().TrimEnd();
        }

        public string GetTotalIncome()
        {
            return string.Format(OutputMessages.TotalIncome, totalIncome);
        }

        public string LeaveTable(int tableNumber)
        {
            ITable table = tables.FirstOrDefault(x => x.TableNumber == tableNumber);

            //if (table == null)
            //{
            //    throw new ArgumentException
            //        (string.Format(OutputMessages.WrongTableNumber, tableNumber));
            //}

            var totalTableSum = table.GetBill();
            totalIncome += totalTableSum;
            table.Clear();

            var sb = new StringBuilder();

            sb.AppendLine($"Table: {tableNumber}");
            sb.AppendLine($"Bill: {totalTableSum:f2}");

            return sb.ToString().TrimEnd();


        }

        public string OrderDrink(int tableNumber, string drinkName, string drinkBrand)
        {
            ITable table = tables.FirstOrDefault(t => t.TableNumber == tableNumber);
            IDrink drink = drinks.FirstOrDefault(f => f.Name == drinkName
                                                      && f.Brand == drinkBrand);

            if (table == null)
            {
                return string.Format(OutputMessages.WrongTableNumber, tableNumber);
            }

            if (drink == null)
            {
                return string.Format(OutputMessages.NonExistentDrink, drinkName, drinkBrand);
            }

            table.OrderDrink(drink);

            return $"Table {tableNumber} ordered {drinkName} {drinkBrand}";
        }

        public string OrderFood(int tableNumber, string foodName)
        {
            ITable table = tables.FirstOrDefault(t => t.TableNumber == tableNumber);
            IBakedFood bakedFood = bakedFoods.FirstOrDefault(f => f.Name == foodName);

            if (table == null)
            {
                return string.Format(OutputMessages.WrongTableNumber, tableNumber);
            }

            if (bakedFood == null)
            {
                return string.Format(OutputMessages.NonExistentFood, foodName);
            }

            table.OrderFood(bakedFood);

            return string.Format(OutputMessages.FoodOrderSuccessful,
                tableNumber, foodName);

        }

        public string ReserveTable(int numberOfPeople)
        {
            ITable table = tables.FirstOrDefault(x => !x.IsReserved
                                                      && x.Capacity >= numberOfPeople);

            if (table == null)
            {
                return string.Format(OutputMessages.ReservationNotPossible, numberOfPeople);
            }
            else
            {
                table.Reserve(numberOfPeople);

                return string.Format(OutputMessages.TableReserved,
                    table.TableNumber, numberOfPeople);
            }
        }
    }
}