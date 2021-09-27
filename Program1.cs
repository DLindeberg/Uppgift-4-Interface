using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_1
{
    class Program1 : IMyInterface1, IMyInterface2
    {
        public void Start()
        {
            Console.WriteLine("Nu kör vi program 1");
        }
        public void Test()
        {
            Console.WriteLine("Nu kör vi program 1 igen");
        }
        //public void Run()
        //{
        //    Console.WriteLine("Nu kör vi program 1");
        //}
    }
}
    
