//- Uma partida de futebol iniciou na hora A e terminou na hora B. Faça um algoritmo que
//calcule o tempo que durou a partida.

using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args){
            int HorA = 2;
            int minA = 40;
            int HorB = 3;
            int minB = 36;
            int hora = 0;

            int dif = ( ((HorB*60)+minB) - ((HorA*60)+minA));
            
            while(dif>=60){
                dif -= 60;
                hora += 1;
            }

            Console.WriteLine(+ hora + " e " + dif + " minutos");
        }
    }
}

