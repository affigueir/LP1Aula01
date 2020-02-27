using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 9;
            string x = "smalljackson";
            string Mom = "Wheres Dad?";
            string Son = @"(?##|\)";
            string Sister = "\"Kill Dad he says.\"";
            string Dog = @"""/Woof\?""";

            string QuickMaths = "two" + "+" + 2 + " is four"; 
            string Jackson5 = "abc" + x;
            string Bob = String.Format("Numbers like {1} and {0} give me the goose", 24, 25);
            Console.WriteLine(Mom);
            Console.WriteLine(Son);
            Console.WriteLine(Sister);
            Console.WriteLine(Dog);
            Console.WriteLine(QuickMaths);
            Console.WriteLine(Jackson5);
            Console.WriteLine($"{a} mais {b} e' igual a {a + b}");
            Console.WriteLine(Bob);
            Console.WriteLine(@"Marmotas comem algas do mato {0}", 42);
            
        }
    }
}
