using System;
using System.Threading.Tasks;

namespace Matematica.AppConsola
{
    internal class Calculadora
    {
        internal int[,] Multiplicar(int[,] matrizA, int[,] matrizB)
        {
            int filas = matrizA.GetLength(0);
            int columnas = matrizB.GetLength(1);
            int[,] matrizAxB = new int[filas, columnas];
            int columnasA = matrizA.GetLength(1);

            Parallel.For(0, filas, i =>
            {
                for (int j = 0; j < columnas; j++)
                {
                    //Columnas de la matriz A
                    int acumulador = 0;
                    for (int k = 0; k < columnasA; k++)
                    {
                        //multiplicando y sumando
                        acumulador += matrizA[i, k] * matrizB[k, j];
                    }
                    matrizAxB[i, j] = acumulador;
                }
            });
            return matrizAxB;
        }

        internal int[,] CrearMatriz(int fila, int columna)
        {
            var generador = new Random();
            int[,] matriz = new int[fila, columna];

            Parallel.For(0, fila, i =>
            {
                for (int j = 0; j < columna; j++)
                {
                    matriz[i, j] = generador.Next(10, 99);
                }
            });
            return matriz;
        }
    }
}