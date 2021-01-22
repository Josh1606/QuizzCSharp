using System;

namespace QuestionMax
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            int score = 0;
            Console.WriteLine("Pourquoi le nom C# (C Sharp) ? \r\n");
            Console.WriteLine("Réponse A : Car c'est un C tranchant");
            Console.WriteLine("Réponse B : Pour profiter de la popularité des hashtag");
            Console.WriteLine("Réponse C : Ca serait l'ajout de ++ du langage C++");
            Console.WriteLine("Réponse D : La réponse D");
            answer = Console.ReadLine();
            if(answer == "c" || answer == "C")
            {
                score++;
                Console.WriteLine("Bonne réponse !");
            }
            else
            {
                Console.WriteLine("Dommage la réponse était la réponse C");
            }
            Console.WriteLine("Pourquoi dit-on que le C# est fortement typé ? \r\n");
            Console.WriteLine("Réponse A : Car il faut préciser le type de la variable quand on la déclare");
            Console.WriteLine("Réponse B : Car il n'accepte pas les caractères spéciaux");
            Console.WriteLine("Réponse C : Car c'est un langage orienté objet");
            Console.WriteLine("Réponse D : Car son type est trop fort pour les autres langages");
            answer = Console.ReadLine();
            if (answer == "a" || answer == "A")
            {
                score++;
                Console.WriteLine("Bonne réponse !");
            }
            else
            {
                Console.WriteLine("Dommage la réponse était la réponse A");
            }
            Console.WriteLine("Bravo votre score est : " + score);
        }
    }
}
