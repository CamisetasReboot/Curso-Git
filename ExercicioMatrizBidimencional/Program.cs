using System;

namespace ExercicioMatrizBidimencional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com a quantidade de linhas da matriz quadratica: ");
            int numLinhas = int.Parse(Console.ReadLine());
            int numColunas = numLinhas;
            int[,] mat = new int[numLinhas, numColunas];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                Console.Write($"\nLinha {i} ----> \t" );
                for (int j = 0; j < numLinhas;j++)
                {
                    Console.Write($"Valor {j} : \t");
                    mat[i,j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < numLinhas; i++)
            {
                for (int j = 0; j < numColunas; j++)
                {
                    Console.Write($"{mat[i,j]}\t");
                }
                Console.WriteLine();
            }


            Console.WriteLine("Numeros na diagonal");
            for (int i = 0; i < numLinhas; i++)
            {
                Console.Write($"{mat[i,i]}\t");
            }

            Console.WriteLine();
            Console.WriteLine("Numeros negativos ");
            int contador=0;
            for (int i = 0; i < numLinhas; i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] < 0)
                    {
                        contador++;
                        Console.Write($"{mat[i,j]}\t");

                    }
                }
            }
            Console.WriteLine($"Quantidade de numeros negativos : {contador}");

           
        }
    }
}
