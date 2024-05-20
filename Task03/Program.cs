using System;
using System.Text;

// Делегати.

namespace Delegates
{

    public delegate int RandomValue();  // 

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Random random = new Random();

            RandomValue[] delegates = new RandomValue[5];

            for (int i = 0; i < delegates.Length; i++)
            {
                delegates[i] = delegate ()
                {
                    return random.Next(1, 101);
                };
            }
            Func<RandomValue[], double> calculateAverage = delegate (RandomValue[] delArray)
            {
                double sum = 0;
                int count = delArray.Length;

                foreach (var del in delArray)
                {
                    sum += del();
                }

                return sum / count;
            };
            // Виклик анонімного методу та виведення результату
            double average = calculateAverage(delegates);
            Console.WriteLine($"Середнє арифметичне значення: {average}");
            // Delay.
            Console.ReadKey();
        }
    }
}
