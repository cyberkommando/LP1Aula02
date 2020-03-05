using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar variáveis
            string aString, rString;
            float a, r, v, surfArea;
            const float pi = 3.1415926f;
            // 1. pedir ao utilizador os dados
            Console.Write("Coloque a altura:");
            aString = Console.ReadLine();
            Console.Write("Coloque o raio:");
            rString = Console.ReadLine();
            // 2. converter input para float
            a = float.Parse(aString);
            r = Convert.ToSingle(rString);
            // 3. Fazer as contas 
            v = pi * r * r * a;
            surfArea = 2 * pi * r * (r + a);
            // 4. Apresentar resultados
            Console.WriteLine($"Volume    = {v}");
            Console.WriteLine($"surfArea    = {surfArea}");
        }
    }
}
