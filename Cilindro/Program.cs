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
            // 1. pedir ao utilizador os dados
            Console.Write("Coloque a altura:");
            aString = Console.ReadLine();
            Console.Write("Coloque o raio:");
            rString = Console.ReadLine();
            // 2. converter input para float
            a = float.Parse(aString);
            r = Convert.ToSingle(rString);
            // 3. Fazer as contas 
            v = (float)Math.PI * (float)Math.Pow(r, 2) * a;
            surfArea = 2 * (float)Math.PI * r * (r + a);
            // 4. Apresentar resultados
            Console.WriteLine($"Volume    = {v}");
            Console.WriteLine($"surfArea    = {surfArea}");
        }
    }
}
