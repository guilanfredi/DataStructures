using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    internal static class ArrayUtils
    {
        /// <summary>
        /// Encontra o valor da posição do meio do vetor. Caso o vetor tenha tamanho par, considera o indice arredondado para baixo.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int FindMiddleValue(int[] array)
        {
            int tamanho = array.Length;
            if (tamanho != 0)
            {
                int metaDinha = tamanho / 2;
                if (tamanho % 2 != 0) //Se for impar
                {
                    return array[metaDinha]; 
                }
                else
                {
                    return array[metaDinha -1];
                }
            }
            else
            {
                //throw new Exception("O vetor está vazio.");
                return -1;
            }
        }

        /// <summary>
        /// Encontra no vetor a primeira ocorrência do valor suprido como parâmetro e retorna o índice desse valor.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int FindFirst(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target) 
                { 
                    return i; 
                }
            }
            //throw new Exception("O valor não foi encontrado no vetor");
            return -1;
        }

        /// <summary>
        /// Encontra no vetor a última ocorrência do valor suprido como parâmetro e retorna o índice desse valor.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int FindLast(int[] array, int target)
        {
            for (int i = array.Length -1; i >= 0; i--)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Encontra o índice do menor valor dentro do vetor passado como parâmetro
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int Min(int[] array)
        {
            int min = int.MaxValue;
            int iMin = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    iMin = i;
                }
            }
            return iMin;
        }

        /// <summary>
        /// Encontra o índice do maior valor dentro do vetor passado como parâmetro
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int Max(int[] array)
        {
            int max = int.MinValue;
            int iMax = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    iMax = i;
                }
            }
            return iMax;
        }

        /// <summary>
        /// Encontra a média entre os valores dentro do vetor
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static double Average(int[] array)
        {
            double total = 0;
            for (int i = 0; i < array.Length; i++) 
            {
                total += array[i];
            }
            return (total / array.Length);
        }

        /// <summary>
        /// Ordena o vetor passado como parâmetro
        /// </summary>
        /// <param name="array"></param>
        /// <exception cref="NotImplementedException"></exception>
        public static void Sort(int[] array)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Realiza busca binária no array e retorna o índice do valor encontrado
        /// </summary>
        /// <param name="array"></param>
        public static int Search(int[] array, int target)
        {
            throw new NotImplementedException();
        }


        //--------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------- DESAFIO ------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------


        /// <summary>
        /// Retorna o vetor que representa a união entre 2 vetores passados como parâmetro (Assume que os vetores estão ordenados)
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int[] Union(int[] array1, int[] array2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retorna o vetor que representa a intersecção entre 2 vetores passados como parâmetro (Assume que os vetores estão ordenados)
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int[] Intersection(int[] array1, int[] array2)
        {
            throw new NotImplementedException();
        }
    }
}
