using System;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
        string question = "";
        do
        {
            // Variáveis auxiliares

            // Colocar questão ao utilizador
            Console.Write("Place your question? ");
            question = Console.ReadLine();

            // Verificar se se trata de uma questão conhecida e determinar uma
            // resposta adequada
            switch (question)
            {
                case "who are you?":
                    Console.WriteLine("I'm your father.");
                    break;
                case "how old are you?":
                    Console.WriteLine("40 years old.");
                    break;
                case "what's your job?":
                    Console.WriteLine("I'm a programer.");
                    break;
                default:
                    Console.WriteLine("You got me, I'm not THAT smart!");
                    break;
            }

            // Responder adequadamente
        } while (question != "EXIT");
        }
    }
}
