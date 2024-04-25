using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace practiceOOP1
{
    class Software
    {
        private string name;
        public string Name 
        { 
            get { return name; } 
            set { if(value != string.Empty) name = value; } 
        }
        private string creator;
        public string Creator
        {
            get { return creator; }
            set { if (value != string.Empty) creator = value; }
        }
        private bool free;
        public bool Free
        {
            get { return free; }
            set { free = value; }
        }

        public Software()
        {
            name = "Неизвестно";
            creator = "Неизвестно";
            free = true;
        }
        public Software(string _name)
        {
            name = _name;
            creator = "Неизвестно";
            free = true;
        }
        public Software(string _name, string _creator)
        {
            name = _name;
            creator = _creator;
            free = true;
        }
        public Software(string _name, string _creator, bool _free)
        {
            name = _name;
            creator = _creator;
            free = _free;
        }

        public string GetInfo()
        {
            return $"Название компании: {name} \nПроизводитель: {creator} \nБесплатно? - {free}";
            //Console.WriteLine($"Название компании: {name}");
            //Console.WriteLine($"Производитель: {creator}");
            //Console.WriteLine($"Бесплатно? - {free}");
        }

        public void ReWriteFree() => free = !free;
        
    }
}
