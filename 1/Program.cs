using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите градусы, минуты и секунды угла");
            Ugol ugol = new Ugol();
            ugol.Write();
            ugol.ToRadians();
            Console.ReadKey();
        }
    }
    class Ugol
    {
        private int gradus;
        private int min;
        private int sec;
        public Ugol ()
        {
            gradus = Convert.ToInt32(Console.ReadLine());
            if ((gradus <= 0) || (gradus > 180))
            {
                Console.WriteLine("Некорректное значение градуса");
                Console.ReadKey();
                return;
            }
            min = Convert.ToInt32(Console.ReadLine());
            if ((min <= 0) || (min > 60))
            {
                Console.WriteLine("Некорректное значение минут");
                Console.ReadKey();
                return;
            }
            sec = Convert.ToInt32(Console.ReadLine());
            if ((sec <= 0) || (sec > 60))
            {
                Console.WriteLine("Некорректное значение секунд");
                Console.ReadKey();
                return;
            }
        }
        public void ToRadians()
        {
            double radians = ((Math.PI / 180) * gradus) + ((Math.PI / (180 * 60)) * min) + ((Math.PI/(180*60*60))*sec);
            Console.WriteLine("Значение угла в радианах равно {0}", Math.Round (radians, 2));
        }
        public void Write()
        {
            Console.WriteLine("Угол равен {0}° {1}' {2}\".", gradus, min, sec);
        }
    }
}
