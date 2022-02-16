using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args){
        int[] Lista_Num = {1,2,3,4,5};
            int x = 0;

            for (int i = 0; i < Lista_Num.Length; i++){
                if (Lista_Num[i]%2 == 0){
                    continue;
                } else {
                    Lista_Num = Lista_Num.Where((source, index) =>index != x).ToArray();
                }
                x++;
            }
            Console.WriteLine("\nNúmeros pares:");
            for (int i = 0; i< Lista_Num.Length; i++){
                Console.WriteLine(Lista_Num[i]);
            }
        }
    }
}
     

