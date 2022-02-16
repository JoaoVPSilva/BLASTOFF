//Dada duas lista de números A[1,2,3,4] e B[1,2,5,8], faça um algoritmo que retorne a
//concatenação das listas.

using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args){
         
            int[] vetor1 = new int[] {1, 2, 3, 4};
            int[] vetor2 = new int[] {1, 2, 5, 8};

            int[] uniao = new int[4];

           Console.WriteLine("A união das Litas é: ");
            for (int i = 0; i < uniao.Length; i++)
            {
                uniao[i] = Convert.ToInt32(vetor1[i].ToString() + vetor2[i].ToString());
                Console.WriteLine(uniao[i]);
            }
     
        }
    }
}