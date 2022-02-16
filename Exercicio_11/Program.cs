//- Dada duas lista de números A[1,2,3,4] e B[1,2,5,8], faça um algoritmo que retorne a
//intersecção das listas

using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args){
         
            int[] vetor1 = new int[] {1, 2, 3, 4};
            int[] vetor2 = new int[] {1, 2, 5, 8};

            int[] intersecao = new int[4];

           Console.WriteLine("A intersecção das 2 Listas é: ");
            for (int i = 0; i < intersecao.Length; i++)
            {
                var iguais = (from b in vetor1 where vetor1[i] == vetor2[i] select vetor1[i]).FirstOrDefault();
                
                if (iguais > 0)
                {
                    intersecao[i] = iguais;
                    Console.WriteLine(intersecao[i]);
                }
            }
     
        }
    }
}
