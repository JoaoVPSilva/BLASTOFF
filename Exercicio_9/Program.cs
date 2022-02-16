//Faça um algoritmo que receba um número e retorne a tabuada desse número.

using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args){
         
         Console.WriteLine("Digite um número qualquer:");
         int num = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("\n");
            for (int i = 0; i < 10; i++){
                Console.WriteLine(num + " x " + (i+1) + " = " + num*(i+1));
            }
            
        }

         
         
            
            
        }
    }

