//Estudo de vetores criando um sistema de hotel


using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vect = new Estudante[10];


            Console.Write("How many rooms will be rented? ");

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {

                Console.Write($"Rent #", i," : ");
                Console.WriteLine("Name: ");
                string  nome = Console.ReadLine();
                Console.WriteLine("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for(int i = 0;i < 10;i++) 
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }

}
