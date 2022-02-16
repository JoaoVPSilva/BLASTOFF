//Faça um algoritmo que converta a temperatura de C para F. Utilize a fórmula  C = 5/9(F-32)

using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args){
            float tempC = 10;

            double Conv = tempC * 1.8 + 32;

            Console.Write("O valor em Fahrenheit: " +Conv );

        }
    }
}
