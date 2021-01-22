using System;
using System.Threading.Tasks;
namespace Projet1_app_console_cédric_
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            int score = 0;
            Console.WriteLine("Quelles sont les bonnes boucles en C# ?");
            Console.WriteLine("");
            Console.WriteLine("Reponse A: do...while; while; else if; etc...");
            Console.WriteLine("Reponse B: if...else; switch; else if; etc...");
            Console.WriteLine("Reponse C: Console.Write(); Console.ReadLine(); Console.ReadKey(); etc...");
            Console.WriteLine("Reponse D: //; /*; */; etc...");
            Console.WriteLine("");
            answer = Console.ReadLine();
            if(answer == "A" || answer == "a" || answer == "Reponse A" || answer == "reponse a")
            {
                score++;
                Console.WriteLine("Bonne reponse !");
            }
            else
            {
                Console.WriteLine("Dommage la reponse était la réponse A");
            }
            Console.WriteLine("Comment déclarer une enumeration sur C# ?");
            Console.WriteLine("");
            Console.WriteLine("Reponse A: Console.ReadLine();");
            Console.WriteLine("Reponse B: Enumeration");
            Console.WriteLine("Reponse C: enum");
            Console.WriteLine("Reponse D: Console.EnumLine()");
            answer = Console.ReadLine();
            if(answer == "C" || answer == "c" || answer == "Reponse C" || answer == "reponse c")
            {
                score++;
                Console.WriteLine("Bonne reponse !");
            }
            else
            {
                Console.WriteLine("Dommage la reponse était la reponse C");
            }
            Console.ReadKey();
        }
    }
}
