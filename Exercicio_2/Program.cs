//Dada a distância A e o combustível gasto B, faça um algoritmo para calcular o consumo
//médio.

using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args){
            float A = 100;
            float B = 10;
            
            double mediaCombustivel = ((A)/(B));
            
            Console.WriteLine(mediaCombustivel);
        }
    }
}
