using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args){
            int resultado = 0;

            Console.WriteLine("Digite um valor para saber se ele é Primo ou não: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i=2;i<n/2; i++){
                if(n % i == 0 ) {
                    resultado++;
                    break;
                }
            } 

            if(resultado == 0){
                Console.WriteLine("É número primo.");
            }else {
                Console.WriteLine("Não é número primo");
            }

            
            

        }
    }
}

