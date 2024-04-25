using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceOOP1
{
    class InputSoft
    {
        public void Input(Software software)
        {
            Console.WriteLine();

            Console.Write("Название компании: ");
            software.Name = Console.ReadLine();
            Console.Write("Произоводитель: ");
            software.Creator = Console.ReadLine();
            Console.Write("Бесплатно?(true/false): ");
            string free = Console.ReadLine();
            while (!bool.TryParse(free, out bool result))
            {
                Console.WriteLine("Неправильно введено значение. Попробуйте ещё раз");
                free = Console.ReadLine();
            }
            software.Free = bool.Parse(free);

            Console.WriteLine();
        }
    }
}
