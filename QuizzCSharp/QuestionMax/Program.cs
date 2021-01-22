using System;
using System.Threading;

namespace QuestionMax
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
            Console.WriteLine("Pourquoi le nom C# (C Sharp) ? \r\n\r\n" +
                "Réponse A : Car c'est un C tranchant\r\n" +
                "Réponse B : Pour profiter de la popularité des hashtag\r\n" +
                "Réponse C : Ca serait l'ajout de ++ du langage C++\r\n" +
                "Réponse D : La réponse D");
            answer = Console.ReadLine();
            if(answer == "c" || answer == "C")
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
            Console.WriteLine("Pourquoi dit-on que le C# est fortement typé ? \r\n\r\n" +
                "Réponse A : Car il faut préciser le type de la variable quand on la déclare\r\n" +
                "Réponse B : Car il n'accepte pas les caractères spéciaux\r\n" +
                "Réponse C : Car c'est un langage orienté objet\r\n" +
                "Réponse D : Car son type est trop fort pour les autres langages");
            answer = Console.ReadLine();
            if (answer == "a" || answer == "A")
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
        }
    }
}
