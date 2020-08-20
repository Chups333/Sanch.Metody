using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.Metody
{
    class Program
    {
        static void Main(string[] args)
        {

            // PrintHello("Вася", 27); - сработает метод внизу
            //var i = PrintHello("Вася", 27); - i вернет цифру 2

            //var person1 = new Person("Иванов", "Иван");
            //var person2 = new Person("Петров", "Петр");

            /*for (var i = 0; i < 10; i++)
            {
                var pos = person1.Run();
                Console.WriteLine(pos);

                Console.WriteLine(person2.Run());
            }*/

            Console.WriteLine(Factorial(3)); // вывод рекурсии ниже
            Console.ReadKey();
        }

        // модификатор доступа тип возвращаемого значения имя метода(тип аркумента и имя(мб несколько))
        //{
        //}
        // void - тип невозращаемого значения
        // класс тоже тип возвращаемого значения 
        // static экзепляр должен быть общее для всех экземпляров класса 

        public static int PrintHello(string name, int age)
        {
            Console.WriteLine($"Привет, {name}, Вам {age} лет ");
            return 2;// обязательно для возвращаемого значения 
        }

        /*public static void PrintHello(string name, int age) ничего не возвращает
        {
            Console.WriteLine($"Привет, {name}, Вам {age} лет ");
           
        }*/

            // РЕКУРСИЯ
            public static int Factorial(int value)
        {
            if (value <= 1)
            {
                return 1;
            }
            else
            {
                return value * Factorial(value - 1);
            }
        }
    }
}
