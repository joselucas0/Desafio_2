using System;

namespace estoque_Mercado
{
    public class Program
    {
        public static void Main()
        {
            //Get.Length 0,1,2 = Loja, Semanas, Dias
            int[,,] estoque = new int[5, 4, 7]
            {
                // Loja 1
                {
                    // Semana 1
                    { 100, 92, 89, 83, 81, 77, 73 },
                    // Semana 2
                    { 69, 67, 62, 59, 54, 51, 49 },
                    // Semana 3
                    { 46, 43, 37, 32, 29, 27, 23 },
                    // Semana 4
                    { 21, 17, 14, 11, 9, 7, 5 },
                },
                // Loja 2 
                {
                    // Semana 1
                    { 110, 102, 99, 93, 91, 87, 83 },
                    // Semana 2
                    { 79, 77, 72, 69, 64, 61, 59 },
                    // Semana 3
                    { 56, 53, 47, 42, 39, 37, 33 },
                    // Semana 4
                    { 31, 27, 24, 21, 19, 17, 15 },
                },
                // Loja 3 
                {
                    // Semana 1
                    { 120, 112, 109, 103, 101, 97, 93 },
                    // Semana 2
                    { 89, 87, 82, 79, 74, 71, 69 },
                    // Semana 3
                    { 66, 63, 57, 52, 49, 47, 43 },
                    // Semana 4
                    { 41, 37, 34, 31, 29, 27, 25 },
                },
                // Loja 4 
                {
                    // Semana 1
                    { 130, 122, 119, 113, 111, 107, 103 },
                    // Semana 2
                    { 99, 97, 92, 89, 84, 81, 79 },
                    // Semana 3
                    { 76, 73, 67, 62, 59, 57, 53 },
                    // Semana 4
                    { 51, 47, 44, 41, 39, 37, 35 },
                },
                // Loja 5 
                {
                    // Semana 1
                    { 140, 132, 129, 123, 121, 117, 113 },
                    // Semana 2
                    { 109, 107, 102, 99, 94, 91, 89 },
                    // Semana 3
                    { 86, 83, 77, 72, 69, 67, 63 },
                    // Semana 4
                    { 61, 57, 54, 51, 49, 47, 45 },
                },
            };

            //Imprimindo a matriz
            Console.WriteLine("Estoque do Mercado:");
            for (int i = 0; i < estoque.GetLength(0); i++)
            {
                Console.WriteLine($"Loja {i + 1}:");
                for (int j = 0; j < estoque.GetLength(1); j++)
                {
                    Console.WriteLine($"Semana {j + 1}:");
                    for (int k = 0; k < estoque.GetLength(2); k++)
                    {
                        Console.Write($"{estoque[i, j, k]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
