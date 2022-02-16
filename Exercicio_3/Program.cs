using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args){
            int A=1;
            int B=2;
            int C=3;

            int[] valor = {A,B,C};
            int MenorValor = 10000;

            for (int i=0; i<3; i++){
                if(MenorValor > valor[i]){
                    MenorValor = valor[i];
                    Console.WriteLine("O menor valor é: " +MenorValor);
                }

            }
            
            
        }
    }
}
