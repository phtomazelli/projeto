using s6exer;
using System;
using System.Globalization;

namespace course
{
    class Program
    
    {
     static void Main(string[] args) {

            Quartos[] vect = new Quartos[10];
 

            Console.Write("Quantos quartos serão alugados? ");
          int N =  int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {

                Console.WriteLine();
                Console.Write($"Aluguel #{i}:");

                Console.Write("Nome: ");
                string Nome = Console.ReadLine();

                Console.Write("Email: ");
                string Email = Console.ReadLine();

                Console.Write("Quarto: ");
                int Quarto = int.Parse(Console.ReadLine());

                vect [Quarto] = new Quartos(Nome, Email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos Ocupados: ");
            for (int i = 0;i <= 10; i++)
            {
                if (vect[i] != null )
                {
                    Console.WriteLine(i + ": " + vect[i]);


                }

            }







        }
    }
}