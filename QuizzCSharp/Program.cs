using System;
using System.Threading;

namespace Projet1_app_console_cédric_
{
    class Program
    {
        static void Main(string[] args)
        {
            static void wrongAnswer()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                Thread.Sleep(100);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Thread.Sleep(100);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                Thread.Sleep(100);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Thread.Sleep(100);
                Console.WriteLine("Mauvaise réponse...");
            }
            static void goodAnswer()
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                Thread.Sleep(100);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Thread.Sleep(100);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                Thread.Sleep(100);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Thread.Sleep(100);
                Console.WriteLine("Bonne réponse !!!");
            }

            string answer = "";
            int score = 0;
            Console.WriteLine("Quelles sont les bonnes boucles en C# ? \r\n\r\n" +
                "Reponse A: do...while; while; else if; etc...\r\n" +
                "Reponse B: if...else; switch; else if; etc...\r\n" +
                "Reponse C: Console.Write(); Console.ReadLine(); Console.ReadKey(); etc... \r\n" +
                "Reponse D: //; /*; */; etc...");
            answer = Console.ReadLine();
            if (answer == "A" || answer == "a" || answer == "Reponse A" || answer == "reponse a")
            {
                score++;
                goodAnswer();
            }
            else
            {
                wrongAnswer();
            }
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Comment déclarer une enumeration sur C# ? \r\n\r\n" +
            "Reponse A: Console.ReadLine();\r\n" +
            "Reponse B: Enumeration\r\n" +
            "Reponse C: enum\r\n" +
            "Reponse D: Console.EnumLine()");
            answer = Console.ReadLine();
            if (answer == "C" || answer == "c" || answer == "Reponse C" || answer == "reponse c")
            {
                score++;
                goodAnswer();
            }
            else
            {
                wrongAnswer();
            }
            Console.WriteLine("Votre score est : " + score);
            Thread.Sleep(3000);
            Console.Clear();
            Console.ReadKey();
        }
    }
}
