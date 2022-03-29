using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a quantidade de números que deseja inserir: ");
            int n = int.Parse(Console.ReadLine());  
            int[] valores = new int[n];
            int a = 0;
            int count = 0;
            do{
                a = int.Parse(Console.ReadLine());
                if (valores.Contains(a)  )
                {
                   Console.WriteLine("Este número já foi adicionado! Insira outro número:"); 
                }
                else
                {
                    valores[count] = a;
                    count++;
                }
            }while(count < n);
            Console.WriteLine("Organizando os valores: ");
            valores.OrderBy(i => i).ToArray();
            foreach (int i in valores)
            {
                valores.OrderBy(i => i).ToArray();
                Console.Write(+i);
            }
            

        }
    }
}
