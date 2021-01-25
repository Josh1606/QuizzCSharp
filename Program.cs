using System;
using System.Threading;

namespace Projet_1_Quizz
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
                Console.WriteLine();
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
                Console.WriteLine();
            }

            /* Voici le Projet Quizz C# de :
               Cédric
               Ludivine
               Maxime
               Josh

            On va choisir nos 10 questions concernant la connaissances de C#.

            Une agence de recrutement souhaite réaliser de nouveaux tests pour ses candidats afin de vérifier leur connaissance en C# et principalement en application console. Pour cela, elle missionne votre équipe de réaliser un quiz qui répondra à ses besoins.  
            Le quiz devra comporter 10 questions portant sur le langage C#.  
            Les candidats auront le choix entre 4 réponses, 1 seule étant correcte.  
            L'agence de recrutement vous demande de réaliser ce quiz avec une application console qui sera stylisée avec des couleurs, des espacements de texte... tout ce qui pourrait améliorer l'expérience utilisateur. 
            A la fin du quiz, vous devrez afficher un récapitulatif en donnant le score du candidat et les bonnes réponses.  
            Votre équipe pourra faire une proposition plus complète à l'agence de recrutement si vous le souhaitez. Celle-ci tiendra compte de vos efforts.*/
            {
                // Question 1 : Pourquoi le nom C# ? (C Sharp)

                String Question;
                int score = 0;

                Console.WriteLine("Pourquoi le nom C# ? (C Sharp) \r\n\r\n" +
                    "A) Car c'est un C tranchant. \r\n" +
                    "B) Pour profiter de la popularité des hashtags \r\n" +
                    "C) Ca serais l'ajout de ++ au langage C++ \r\n" +
                    "D) La réponse D ");
                Question = Console.ReadLine();

                if (Question == "A" || Question == "a" || Question == "Reponse A" || Question == "reponse a")
                {
                    wrongAnswer();
                    Console.WriteLine("Mauvaise reponse. Tu as des envies de meurtre ? (; ");
                }
                else if (Question == "B" || Question == "b" || Question == "Reponse C" || Question == "reponse c")
                {
                    wrongAnswer();
                    Console.WriteLine("Et des doubles côtes pendant que tu y es ? Mauvaise reponse !");
                }
                else if (Question == "C" || Question == "c" || Question == "Reponse C" || Question == "reponse c")
                {
                    score++;
                    goodAnswer();
                    Console.WriteLine("Bonne réponse, car ''C Hashtag'' ça le faisais pas.");
                }
                else 
                {
                    wrongAnswer();
                    Console.WriteLine("Quel est la couleur du cheval blanc d'Henry IV (: ");
                }
                Thread.Sleep(4000);
                Console.Clear();

                // Question 2 : Quel est l'IDE pour coder C# ?

                

                Console.WriteLine("Quel est l'IDE pour coder C#? \r\n\r\n" +
                    "A) Atom \r\n" +
                    "B) Visual Studio \r\n" +
                    "C) Visual Studio Code \r\n" +
                    "D) Dictée magique ");
                Question = Console.ReadLine();

                if (Question == "A" || Question == "a" || Question == "Reponse A" || Question == "reponse a")
                {
                    wrongAnswer();
                    Console.WriteLine("Presque bon mais tu as oublié que ce n'est pas de l'HTML !!!");
                }
                else if (Question == "C" || Question == "c" || Question == "Reponse C" || Question == "reponse d")
                {
                    wrongAnswer();
                    Console.WriteLine("et l'histoire de compileur???");
                }
                else if (Question == "D" || Question == "d" || Question == "Reponse D" || Question == "reponse d")
                {
                    wrongAnswer();
                    Console.WriteLine("Alors on manque de maternelle ?");
                }
                else if (Question == "B" || Question == "b" || Question == "Reponse B" || Question == "reponse b")
                {
                    score++;
                    goodAnswer();
                    Console.WriteLine("C'est bien, tu as bien suivi les cours de Jo.");
                }
                else
                {
                    wrongAnswer();
                    Console.WriteLine("Mauvaise reponse !");
                }
                Thread.Sleep(4000);
                Console.Clear();

                // Question 3 : Pourquoi dit-on que le C# est fortement typé ?

                
                Console.WriteLine("Pourquoi dit-on que le C# est fortement typé ? \r\n\r\n" +
                    "A) Car il faut préciser le type de variable quand on la déclare \r\n" +
                    "B) Car il n'accepte pas les caractères spéciaux \r\n" +
                    "C) Car c'est un langage orienté objet \r\n" +
                    "D) Car son type est trop fort ");
                Question = Console.ReadLine();

                if (Question == "B" || Question == "b" || Question == "Reponse B" || Question == "reponse b")
                {
                    wrongAnswer();
                    Console.WriteLine("Tu vas être jugé pour discrimination.");
                }
                else if (Question == "C" || Question == "c" || Question == "Reponse C" || Question == "reponse c")
                {
                    wrongAnswer();
                    Console.WriteLine("Attention aux briques.");
                }
                else if (Question == "D" || Question == "d" || Question == "Reponse D" || Question == "reponse d")
                {
                    wrongAnswer();
                    Console.WriteLine("Pas assez de lait dans ton café ?");
                }
                else if (Question == "A" || Question == "a" || Question == "Reponse A" || Question == "reponse a")
                {
                    score++;
                    goodAnswer();
                    Console.WriteLine("Bonne réponse, rien à déclarer.");
                }
                else
                {
                    wrongAnswer();
                    Console.WriteLine("Mauvaise reponse !");
                }
                Thread.Sleep(4000);
                Console.Clear();

                // Question 4 : Quelles sont les bonnes boucles en C# ?

                

                Console.WriteLine("Quelles sont les bonnes boucles en C# ? \r\n\r\n" +
                    "A) do...while; while; for; etc... \r\n" +
                    "B) if...else; switch; else if; etc... \r\n" +
                    "C) Console.WriteLine(); Console.ReadLine(); Console.Readkey(); ect... \r\n" +
                    "D) //; /*; */; etc... ");
                Question = Console.ReadLine();

                if (Question == "B" || Question == "b" || Question == "Reponse B" || Question == "reponse b")
                {
                    wrongAnswer();
                    Console.WriteLine("Avec des si, on referai le monde.");
                }
                else if (Question == "C" || Question == "c" || Question == "Reponse C" || Question == "reponse c")
                {
                    wrongAnswer();
                    Console.WriteLine("On manque de PS5, d'xBox, de GameCube ???");
                }
                else if (Question == "D" || Question == "d" || Question == "Reponse D" || Question == "reponse d")
                {
                    wrongAnswer();
                    Console.WriteLine("ké ke ta vou lu aicrir ?");
                }
                else if (Question == "A" || Question == "a" || Question == "Reponse A" || Question == "reponse a")
                {
                    score++;
                    goodAnswer();
                    Console.WriteLine("Bonne réponse, dou dou di dou");
                }
                else
                {
                    wrongAnswer();
                    Console.WriteLine("Mauvaise reponse !");
                }
                Thread.Sleep(4000);
                Console.Clear();

                // Question 5 : A quoi servent les parse ?

                
                Console.WriteLine("A quoi servent les parse ? \r\n\r\n" +
                    "A) C'est quoi déjà Parse ? \r\n" +
                    "B) A nous casser la tête pour rien \r\n" +
                    "C) A parsemer des graines de marguerites \r\n" +
                    "D) A traduire en langage string. ");
                Question = Console.ReadLine();

                if (Question == "A" || Question == "a" || Question == "Reponse A" || Question == "reponse a")
                {
                    wrongAnswer();
                    Console.WriteLine("Avais-tu enlever ton casque lors de la formation ?");
                }
                else if (Question == "B" || Question == "b" || Question == "Reponse B" || Question == "reponse b")
                {
                    wrongAnswer();
                    Console.WriteLine("Bah biensur...");
                }
                else if (Question == "C" || Question == "c" || Question == "Reponse C" || Question == "reponse c")
                {
                    wrongAnswer();
                    Console.WriteLine("On est pas encore au Printemps.");
                }
                else if (Question == "D" || Question == "d" || Question == "Reponse D" || Question == "reponse d")
                {
                    score++;
                    goodAnswer();
                    Console.WriteLine("Bonne réponse, ce ne sont pas des culottes.");
                }
                else
                {
                    wrongAnswer();
                    Console.WriteLine("Mauvaise Reponse !");
                }
                Thread.Sleep(4000);
                Console.Clear();

                // Question 6 : Comment stocker les reponses données par l'utilisateurs ?

                
                Console.WriteLine("Comment stocker les reponses données par les utilisateurs? \r\n\r\n" +
                    "A) Avec un Console.readLine(); \r\n" +
                    "B) Avec HTML \r\n" +
                    "C) En faisant un Ctrl+S \r\n" +
                    "D) Je sais pas moua.... ");
                Question = Console.ReadLine();

                if (Question == "B" || Question == "b" || Question == "Reponse B" || Question == "reponse b")
                {
                    wrongAnswer();
                    Console.WriteLine("Ze suis inzénieur informatichien.");
                }
                else if (Question == "C" || Question == "c" || Question == "Reponse C" || Question == "reponse c")
                {
                    wrongAnswer();
                    Console.WriteLine("Ton écran ne serait pas plein de blanco ?");
                }
                else if (Question == "D" || Question == "d" || Question == "Reponse D" || Question == "reponse d")
                {
                    wrongAnswer();
                    Console.WriteLine("Tu ne sais pas ? Mouaaa non pluuuus.");
                }
                else if (Question == "A" || Question == "a" || Question == "Reponse A" || Question == "reponse a")
                {
                    score++;
                    goodAnswer();
                    Console.WriteLine("Bonne réponse, Tu commences à devenir un pro dis donc...");
                }
                else
                {
                    wrongAnswer();
                    Console.WriteLine("Mauvaise reponse !");
                }
                Thread.Sleep(4000);
                Console.Clear();

                // Question 7 : Comment déclarer une énumération sur C# ?

                

                Console.WriteLine("Comment déclarer une énumération sur C# ? \r\n\r\n" +
                    "A) Console.ReadLine(); \r\n" +
                    "B) Enumeration \r\n" +
                    "C) enum \r\n" +
                    "D) Console.EnumLine(); ");
                Question = Console.ReadLine();

                if (Question == "A" || Question == "a" || Question == "Reponse A" || Question == "reponse a")
                {
                    wrongAnswer();
                    Console.WriteLine("A ton avis? tu enum ton propre commentaire ?");
                }
                else if (Question == "B" || Question == "b" || Question == "Reponse B" || Question == "reponse b")
                {
                    wrongAnswer();
                    Console.WriteLine("Dommage, il y a quelques lettres en trop...");
                }
                else if (Question == "D" || Question == "d" || Question == "Reponse D" || Question == "reponse d")
                {
                    wrongAnswer();
                    Console.WriteLine("Le père de toto a 3 enfants. Pim, Pam et ???");
                }
                else if (Question == "C" || Question == "c" || Question == "Reponse C" || Question == "reponse c")
                {
                    score++;
                    goodAnswer();
                    Console.WriteLine("Bonne réponse, c'est bien. Tu écoutes bien en cours :) ");
                }
                else
                {
                    wrongAnswer();
                    Console.WriteLine("Mauvaise reponse !");
                }
                Thread.Sleep(4000);
                Console.Clear();

                // Question 8 : Pourquoi les développeurs C# sont-ils les plus demandés ?

                

                Console.WriteLine("Pourquoi les développeurs C# sont ils les plus demandés ? \r\n\r\n" +
                    "A) Parce que le c# est basé sur le C et a un accès à un grand répertoire de fonctionnalité. \r\n" +
                    "B) Parce que c# est le logiciel de codage le plus puissant et que l'on peux absolument tout programmer. \r\n" +
                    "C) Parce que c# permet de programmer les sites internet a l'aide d'une base de données et ainsi pouvoir faire des applications basé avec l'aide d'Internet \r\n" +
                    "D) La mer Noire ");
                Question = Console.ReadLine();

                if (Question == "B" || Question == "b" || Question == "Reponse B" || Question == "reponse b")
                {
                    wrongAnswer();
                    Console.WriteLine("Tu as un super PC de 2025 ?");
                }
                else if (Question == "C" || Question == "c" || Question == "Reponse C" || Question == "Reponse c")
                {
                    wrongAnswer();
                    Console.WriteLine("Mais biensur...");
                }
                else if (Question == "D" || Question == "d" || Question == "Reponse D" || Question == "reponse d")
                {
                    wrongAnswer();
                    Console.WriteLine("On manque de Julien Lepers ?");
                }
                else if (Question == "A" || Question == "a" || Question == "Reponse A" || Question == "reponse a")
                {
                    score++;
                    goodAnswer();
                    Console.WriteLine("Bonne réponse, prêt à attaquer les bibliothèques ?");
                }
                else
                {
                    wrongAnswer();
                    Console.WriteLine("Mauvaise reponse !");
                }
                Thread.Sleep(4000);
                Console.Clear();

                // Question 9 : Pourquoi Microsoft a t-il crée C# ?

                
                Console.WriteLine("Pourquoi Microsoft a t-il crée C# ? \r\n\r\n" +
                    "A) Parce que Java n'est pas multi-plateforme. \r\n" +
                    "B) Pour pouvoir développer des programmes et applications et des jeux grâce à .NET Framework. \r\n" +
                    "C) Parce que Java était devenu trop limités dans la fonctionnalité de ses programmes. \r\n" +
                    "D) Parce que le C et le C++ devenaient trop compliqué pour programmer les applications. ");
                Question = Console.ReadLine();

                if (Question == "A" || Question == "a" || Question == "Reponse A" || Question == "Reponse a")
                {
                    wrongAnswer();
                    Console.WriteLine("Quand on fais la Java, le samedi à Broadway....");
                }
                else if (Question == "C" || Question == "c" || Question == "Reponse C" || Question == "reponse c")
                {
                    wrongAnswer();
                    Console.WriteLine("Bien tenté, mais ce n'est pas la bonne réponse.");
                }
                else if (Question == "D" || Question == "d" || Question == "Reponse D" || Question == "reponse d")
                {
                    wrongAnswer();
                    Console.WriteLine("On en est pas encore au C+++++++");
                }
                else if (Question == "B" || Question == "b" || Question == "Reponse B" || Question == "reponse b")
                {
                    score++;
                    goodAnswer();
                    Console.WriteLine("Bonne réponse, ça se voit que tu fais de la DOTNET");
                }
                else
                {
                    wrongAnswer();
                    Console.WriteLine("Mauvaise reponse !");
                }
                Thread.Sleep(4000);
                Console.Clear();

                // Question 10 : Quelle est la différence entre un Tableau et une List ?

                
                Console.WriteLine("Quelle est la différence entre un Tableau et une List ? \r\n\r\n" +
                    "A) Une liste contient des objets mais pas le tableau. \r\n" +
                    "B) Une liste est l'autre nom donné au nombre totale de ligne du tableau. \r\n" +
                    "C) Le tableau est de taille fixe, mais la List est un tableau de taille dynamique. \r\n" +
                    "D) Ah bon ? Il y a une différence ? ");
                Question = Console.ReadLine();

                if (Question == "A" || Question == "a" || Question == "Reponse A" || Question == "Reponse a")
                {
                    wrongAnswer();
                    Console.WriteLine("Va chercher des cubes de construction.");
                }
                else if (Question == "B" || Question == "b" || Question == "Reponse B" || Question == "reponse b")
                {
                    wrongAnswer();
                    Console.WriteLine("C'est pas Excel non plus.");
                }
                else if (Question == "D" || Question == "d" || Question == "Reponse D" || Question == "reponse d")
                {
                    wrongAnswer();
                    Console.WriteLine("Bah un peu, QUAND MÊME.");
                }
                else if (Question == "C" || Question == "c" || Question == "Reponse C" || Question == "reponse c")
                {
                    score++;
                    goodAnswer();
                    Console.WriteLine("Bonne réponse, ça tombe bien, j'ai des tables SQL à faire.");
                }
                else
                {
                    wrongAnswer();
                    Console.WriteLine("Mauvaise reponse !");
                }
                Thread.Sleep(4000);
                Console.Clear();

                // Question Bonus : 

                String doYouLoveTheBoss;

                Console.WriteLine("Que pensez vous de votre chef de projet? \r\n\r\n" +
                    "A) Au top! tellement bon qu'il a tout fait tout seul \r\n" +
                    "B) Mouaip, ca va , mais peut mieux faire \r\n " +
                    "C) A Eviter \r\n" +
                    "D) AU SECOURS!!!!! A L'AIDE!!!!!!!!!");
                doYouLoveTheBoss = Console.ReadLine();

                if (doYouLoveTheBoss == "A")
                {
                    Console.WriteLine("Faut pas rêver non plus...");
                }
                else if (doYouLoveTheBoss == "C")
                {
                    Console.WriteLine("Pas tout à fait, il nous a bien fait rigolé quand même");
                }
                else if (doYouLoveTheBoss == "D")
                {
                    Console.WriteLine("Josh a de la chance , j'ai pensé aux autres classes sinon.... ARGGGRRRRR");
                }
                else
                {
                    Console.WriteLine("On l'aime bien quand même Josh Boss The Gloss");
                }
                Console.WriteLine("Votre score est :  " + score);
                Thread.Sleep(3000);
                Console.Clear();
                Console.ReadKey();
            }
        }
    }
}
