using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceOOP1
{
    class CheckFree
    {
        public void Сheck(Software software)
        {
            if (software.Free) Console.WriteLine("Данное ПО является бесплатным продуктом");
            else Console.WriteLine("Данное ПО является платным продуктом");
        }
    }
}
