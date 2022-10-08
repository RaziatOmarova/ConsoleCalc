using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Техническое_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое значение:");
            int one = int.Parse(Console.ReadLine());
            Console.Write("Введите второе значение:");
            int two = int.Parse(Console.ReadLine());

            Console.WriteLine("Выберите действие: \n 1. Сложение \n 2. Вычитание \n 3. Умножение \n 4. Деление");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Результат:" + Addition(one, two));
                    break;
                case 2: 
                    Console.WriteLine("Результат:" + Subtraction(one, two));
                    break;
                case 3:
                    Console.WriteLine("Результат:" + Multication(one, two));
                    break;
                case 4:
                    Console.WriteLine("Результат:" + Division(one, two));
                    break;
                default:
                    Console.WriteLine("Вы ввели действие не из предложенных вариантов");
                    break;
            }

            Console.ReadKey();
        }

        public static int Addition(int numberone, int numbertwo)
        {
            return (numberone + numbertwo);
        }

        public static int Subtraction(int numberone, int numbertwo)
        {
            return (numberone - numbertwo);
        }

        public static int Multication(int numberone, int numbertwo)
        {
            return (numberone * numbertwo);
        }

        public static int Division(int numberone, int numbertwo)
        {
            if (numbertwo < 0)
            {
                return (numberone / numbertwo);
            }
            else
            {
                Console.WriteLine("Делить на ноль нельзя");
                return numbertwo;
            }
        }
    }
}
