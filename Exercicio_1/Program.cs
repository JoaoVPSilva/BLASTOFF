// See https://aka.ms/new-console-template for more information
using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args){
            float I = 20;
            float J = 19;
            float K = 15;
            float X = 25;
            float Y = 17;
            double media = ((I+J+K+X+Y)/(5));
            media = Math.Round(media,2); //forças 2 casas decimais
            Console.WriteLine(media);
        }
    }
}
