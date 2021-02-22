using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Sum_of_Coins
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> coins = new List<int>() { 1, 2, 5, 10, 20, 50 };
            int targetSum = 923;

            try
            {
                Dictionary<int, int> wallet = GreedySum(coins, targetSum);

                foreach (KeyValuePair<int, int> kvp in wallet)
                {
                    Console.WriteLine($"${kvp.Key} -> {kvp.Value}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static Dictionary<int, int> GreedySum(List<int> coins, int targetSum)
        {
            coins = coins.OrderByDescending(c => c).ToList();

            int currentSum = 0;

            Dictionary<int, int> wallet = new Dictionary<int, int>();

            for (int i = 0; i < coins.Count; i++)
            {
                int currCoins = coins[i];

                if (currentSum + currCoins > targetSum)
                {
                    continue;
                }

                int coinsToTake = (targetSum - currentSum) / currCoins;

                currentSum += currCoins * coinsToTake;

                wallet.Add(currCoins, coinsToTake);

                if (currentSum == targetSum)
                {
                    break;
                }
            }

            if (currentSum != targetSum)
            {
                throw new InvalidOperationException("Error");
            }

            return wallet;
        }
    }
}
