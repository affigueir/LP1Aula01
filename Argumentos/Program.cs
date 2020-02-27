using System;

namespace Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            //gets arguments from command line
            {
                Console.WriteLine(args[i]);
                //writes arguments
            }
        }
    }
}
