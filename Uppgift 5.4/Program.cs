using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = new string[5];
            namn[0] = "Sven";
            namn[1] = "Ulla";
            namn[2] = "Britt";
            namn[3] = "Nils";
            namn[4] = "Geraldin";

            Array.Sort(namn);

            Console.WriteLine($"Namen i alafbetsordning blir {namn[0]} {namn[1]} {namn[2]} {namn[3]} {namn[4]} ");
        }
    }
}

