using System;

namespace Interface_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program1 program1 = new Program1();
            Program2 program2 = new Program2();

            program1.Start();
            program2.Start();
            program1.Test();
            //program1.Run();
            //program2.Go();
        }
    }
}
