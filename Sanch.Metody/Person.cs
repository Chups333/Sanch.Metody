using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.Metody
{
    public class Person
    {

        public string SecondName { get; set; }

        public string Name { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public Person (string secondName, string name)
        {
            SecondName = secondName;
            Name = name;
            X = 0;
            Y = 0;
        }

        public string Run()
        {
            var rnd = new Random();

            X += rnd.Next(-2, 2);
            Y += rnd.Next(-2, 2);

            return $"{Name} ({X}),({Y})";
        }

        // Перегрузка метода

        /*public string RunToPos(int x,int y) // так делать не надо
        {
            X = x;
            Y = y;

            return $"{Name} ({X}),({Y})";
        }

        public string Run(int x, int y) // а так надо !!!! перегрузка с аргументами
        {

            return $"{Name} ({X}),({Y})";
        }

        public string Run(int x) // перегрузка с одной сигнатурой 
        {

            return $"{Name} ({X}),({Y})";
        }

        public string Run(double x) // перегрузка с одной сигнатурой которая не повторяет верхнюю (другой тип сигнатуры)
        {

            return $"{Name} ({X}),({Y})";
        }*/
    }
}
