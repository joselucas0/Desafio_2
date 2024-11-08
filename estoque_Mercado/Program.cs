using System;

namespace estoque_Mercado
{
    public class Program
    {
        static void ImprimeEstoque(int[,,] matriz)
        {
            Console.WriteLine("\nEstoque dos Mercados:\n\n");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine($"Loja {i + 1}: \n");
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine($"Semana {j + 1}:");
                    for (int k = 0; k < matriz.GetLength(2); k++)
                    {
                        Console.Write($"{matriz[i, j, k]} ");
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine();
            }
        }

        static int ProdutosVendidos(int[,,] matriz, int loja)
        {
            int vendas = 0;
            
            Console.WriteLine($"\nProdutos vendidos na Loja {loja + 1}:\n");
            for (int i = 0; i < matriz.GetLength(1); i++)
            {   

                Console.WriteLine($"Semana {i + 1}:");
                int resultado = matriz[loja, i, 0] - matriz[loja, i, 6];
                Console.WriteLine($"Produtos vendidos: {resultado}");
                Console.WriteLine();
                vendas += resultado;
            }
            Console.WriteLine($"Total de produtos vendidos na Loja {loja + 1}: {vendas}\n");
            return vendas;

        }
        static void LojaMaiorVenda(int[,,] matriz){
            int maxVendas = int.MinValue;
            int lojaMaior = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                int vendas = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
            {   
                int resultado = matriz[i, j, 0] - matriz[i, j, 6];
                vendas += resultado;
            }
                if (vendas > maxVendas)
                {
                    maxVendas = vendas;
                    lojaMaior = i;
                }
            }
                Console.WriteLine($"\nLoja com maior venda: Loja {lojaMaior + 1}\nMaior vendas: {maxVendas}\n");
        }   

        public static void Main()
        {
            Console.Clear();
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
                    { 21, 17, 14, 11, 9, 7, 1 },
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
                    { 31, 27, 24, 21, 19, 17, 12 },
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
                    { 41, 37, 34, 31, 29, 27, 23 },
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
                    { 51, 47, 44, 41, 39, 37, 34 },
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
                    { 61, 57, 54, 51, 49, 47, 40 },
                },
            };

            
            Console.WriteLine("------------------\nInforme uma opção\n------------------");
            Console.WriteLine("\n1 - Imprimir estoque de todas as lojas\n2 - Total de produtos vendidos\n3 - Loja com mais vendas\n0 - Sair\n");
            int op = Convert.ToInt32(Console.ReadLine());

            while (op != 0)
            {
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        ImprimeEstoque(estoque);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\nInforme qual loja deseja saber o total de produtos vendidos. Lojas vão de 1 a 5 apenas");
                        int loja = Convert.ToInt32(Console.ReadLine());
                        ProdutosVendidos(estoque, loja - 1);
                        break;
                    case 3:
                        Console.Clear();
                        LojaMaiorVenda(estoque);
                        break;
                    default:
                        break;
                }


                Console.WriteLine("\n\nAperte qualquer tecla para continuar...\n");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("------------------\nInforme uma opção\n------------------");
                Console.WriteLine("\n1 - Imprimir estoque de todas as lojas\n2 - Total de produtos vendidos\n3 - Loja com mais vendas\n0 - Sair\n");
                op = Convert.ToInt32(Console.ReadLine());

                
            }

        }
    }
}
