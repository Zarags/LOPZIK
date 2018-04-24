using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Kvintacia
    {
        public string Nomer { get; set; }
        public string Data { get; set; }
        public float Syma { get; set; }
   
        public Kvintacia()
        {
        }
       
        public void Input()
        {
            Nomer = Console.ReadLine();
            Data = Console.ReadLine();
            Syma = float.Parse(Console.ReadLine());
        }
    }
}
    

