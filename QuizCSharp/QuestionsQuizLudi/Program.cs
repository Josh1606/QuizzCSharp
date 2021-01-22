using System;

namespace QuestionsQuizLudi
{
    class Program
    {

        /*Une agence de recrutement souhaite réaliser de nouveaux tests pour ses candidats afin de vérifier leur connaissance en C# et principalement en application console. Pour cela, elle missionne votre équipe de réaliser un quiz qui répondra à ses besoins.  

Le quiz devra comporter 10 questions portant sur le langage C#.  
Les candidats auront le choix entre 4 réponses, 1 seule étant correcte.  
L'agence de recrutement vous demande de réaliser ce quiz avec une application console qui sera stylisée avec des couleurs, des espacements de texte... tout ce qui pourrait améliorer l'expérience utilisateur. 
A la fin du quiz, vous devrez afficher un récapitulatif en donnant le score du candidat et les bonnes réponses.  
Votre équipe pourra faire une proposition plus complète à l'agence de recrutement si vous le souhaitez. Celle-ci tiendra compte de vos efforts.*/
        static void Main(string[] args)
        {
            string IDEAnswer;
            int goodAnswers = 0;


            Console.WriteLine("Quel est l'IDE pour coder C#? \r\n "+
                "A) Atom \r\n" +
                "B) Visual Studio \r\n" +
                "C) Visual Studio Code \r\n " +
                "D) Dictée magique");
            IDEAnswer = Console.ReadLine();

            if (IDEAnswer == "A")
            {
                Console.WriteLine("Presque bon mais tu as oublié qu'on code du CSharp !!!");
            }
            else if (IDEAnswer == "C")
            {
                Console.WriteLine("et l'histoire de compileur???");
            }
            else if (IDEAnswer == "D")
            {
                Console.WriteLine("Alors, en mal de maternelle?");
            }
            else
            {
                goodAnswers++;
                Console.WriteLine("C'est bien, tu as bien suivi le cours de Jo! ");
               
            };

            String doYouLoveTheBoss;
            Console.WriteLine("Que pensez vous de votre chef de projet?\r\n" +
                " A) Au top! tellement bon qu'il a tout fait tout seul\r\n" +
                " b) Mouaip, ca va , mais peut mieux faire \r\n" +
                "C) A Eviter\r\n" +
                " D) AU SECOURS!!!!! A L'AIDE!!!!!!!!!");
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
                Console.WriteLine("On l'aime bien quand même JoshBoss The Gloss");
            };

            string howSaveUsersAnswers;
            Console.WriteLine("Comment stocker les reponses données par les utilisateurs?\r\n" +
                " A) avec un Console.readLine();\r\n" +
                " B) avec HTML \r\n" +
                "C)en faisant un Ctrl+S\r\n" +
                " D) sais pas moua....");

            howSaveUsersAnswers = Console.ReadLine();

            if (howSaveUsersAnswers == "B")
            {
                Console.WriteLine("Mouahhhahh!!!");
            }
            else if (howSaveUsersAnswers == "C")
            {
                Console.WriteLine("ca serait trop beau");
            }
            else if (howSaveUsersAnswers == "D")
            {
                Console.WriteLine("tu t'es trompé de salle, tu n'es pas dans une auto-école");
            }
            else
            {
                Console.WriteLine("good answer");
            };

        }
    }
            
}
