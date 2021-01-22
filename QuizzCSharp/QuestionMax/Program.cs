using System;
using System.Threading;

namespace QuestionMax
{
    class Program
    {
        static void Main(string[] args)
        {
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
                Console.WriteLine("Bonne réponse !");
            }
            else
            {
                Console.WriteLine("Mauvaise réponse...");
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
                Console.WriteLine("Bonne réponse !");
            }
            else
            {
                Console.WriteLine("Mauvaise réponse...");
            }
            Console.WriteLine("Votre score est : " + score);
            Thread.Sleep(3000);
            Console.Clear();
        }
    }
}
