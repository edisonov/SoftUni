using System;
using System.Text;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                StringBuilder left = new StringBuilder();
                StringBuilder right = new StringBuilder();
                bool space = false;
                for (int j = 0; j < input.Length; j++)
                {
                    if (char.Parse(Convert.ToString(input[j])) == ' ')
                    {
                        space = true;
                        continue;
                    }
                    if (!space)
                    {
                        left.Append(input[j]);
                    }
                    else
                    {
                        right.Append(input[j]);
                    }
                }
                float sum = 0;
                if (double.Parse(Convert.ToString(left)) > double.Parse(Convert.ToString(right)))
                {

                    for (int k = 0; k < Convert.ToString(left).Length; k++)
                    {
                        bool symbol = int.TryParse(Convert.ToString(left[k]), out int digit);
                        sum += digit;
                    }
                }
                else
                {
                    for (int k = 0; k < Convert.ToString(right).Length; k++)
                    {
                        bool symbol = int.TryParse(Convert.ToString(right[k]), out int digit);
                        sum += digit;
                    }
                }
                Console.WriteLine(sum);
            }
        }
    }
}
