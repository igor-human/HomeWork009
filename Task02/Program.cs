using System;
using System.Text;

// Делегати.

namespace Delegates
{

    public delegate double ArithmeticOperation(double a, double b);  // 

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            ArithmeticOperation Add = (a,b) => a + b; // Створюємо екземпляр делегату. (2)
            ArithmeticOperation Sub = (a,b) => a - b;
            ArithmeticOperation Mul = (a,b) => a * b;
            ArithmeticOperation Div = (a, b) =>
            {
                if (b == 0)
                {
                    Console.WriteLine("Ділити на нуль не можна!");
                    return 0;
                }
                return a / b;
            };

            // Запит користувача для вибору операції та введення чисел
            Console.WriteLine("Виберіть операцію: Add (1), Sub (2), Mul (3), Div (4)");
            string choice = Console.ReadLine();
            Console.WriteLine("Введіть перше число:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть друге число:");
            double b = Convert.ToDouble(Console.ReadLine());

            // Ініціалізація змінної для зберігання вибраного делегата
            ArithmeticOperation selectedOperation = null;

            switch (choice)
            {
                case "1":
                    selectedOperation = Add;
                    break;
                case "2":
                    selectedOperation = Sub;
                    break;
                case "3":
                    selectedOperation = Mul;
                    break;
                case "4":
                    selectedOperation = Div;
                    break;
                default:
                    Console.WriteLine("Неправильний вибір операції!");
                    break;
            }

            if (selectedOperation != null)
            {
                double result = selectedOperation(a, b);
                Console.WriteLine("Рузультат: " + result);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
