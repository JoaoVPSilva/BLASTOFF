//Faça um algoritmo que recebe uma palavra e retorne se a palavra é palíndromo.
//(Palavra que se pode ler, indiferentemente, da esquerda para direita ou vice-versa. Ex: osso,
//Ana e etc).

using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args){
         
            string texto = "arara";
           
            string textoInvertido = new string(texto.Reverse().ToArray());
     
            Console.WriteLine($"{(texto == textoInvertido ? "\n***É palindromo***" : "***Não é palindromo.***")}\n");
        }
    }
}
