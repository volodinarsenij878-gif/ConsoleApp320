using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program160
{
    internal class Program
    {
        static void Main()
        {

            Console.Write("Номер масти (1 — пики, 2 — трефы, 3 — бубны, 4 — червы): ");
            if (int.TryParse(Console.ReadLine(), out int suit))
            {
                string name;
                switch (suit)
                {
                    case 1: name = "Пики"; break;
                    case 2: name = "Трефы"; break;
                    case 3: name = "Бубны"; break;
                    case 4: name = "Червы"; break;
                    default:
                        Console.WriteLine("Неверная масть.");
                        return;
                }
                Console.WriteLine(name);
            }
            else
            {
                Console.WriteLine("Ошибка ввода.");
            }
        }
    }
}