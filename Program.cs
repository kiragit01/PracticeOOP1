using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceOOP1
{
    class Program
    {
        static void Main()
        {
            InputSoft inputSoft = new InputSoft();
            CheckFree checkFree = new CheckFree();

            Software software1 = new Software();
            inputSoft.Input(software1);
            Software software2 = new Software();
            inputSoft.Input(software2);
            Software software3 = new Software();
            inputSoft.Input(software3);

            Console.WriteLine(software1.GetInfo());
            Console.WriteLine(software2.GetInfo());
            Console.WriteLine(software3.GetInfo());

            software1.ReWriteFree();
            checkFree.Сheck(software1);

            Software Photoshop = new Software("Photoshop");
            Software IOS = new Software("iOS", "Apple");
            Software Chrome = new Software("Chrome", "Google", true);

            Console.ReadKey();
        }
    }
}
