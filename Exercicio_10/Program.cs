    using System;

    namespace teste
    {
        class Program
        {
            static void Main(string[] args){
            
                int num = 0; 
                int fatorial, cont;
                fatorial =1;
                
                Console.WriteLine("Digite um número qualquer maior que zero:");
                num = int.Parse(Console.ReadLine());
                    
                    for(cont =num; cont >=1; cont --){

                        fatorial *= cont;
                    }
                Console.WriteLine("O fatorial é: " +fatorial);

            }  
        }

    }
            


                
                
            
        

    