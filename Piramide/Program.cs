using System;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number of rows:");
            string userlog = Console.ReadLine();
            //Converter o numero de linhas
            int n = Convert.ToInt32(userlog);
            //Criar um ciclo das linhas criadas
            for(int i = 0; i < n; i++)
            {
                //ciclo dos espaços
                for(int k = 0; k < n - i; k++)
                {
                    Console.Write(" ");
                }
                //Ciclo dos asteriscos
                for(int j = 0; j <= i * 2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
