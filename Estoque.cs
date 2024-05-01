using System;
using System.Globalization;

namespace Program
{
    public class Estudo
    {
        static void Main()
        {
            Produto p = new Produto();
            
            Console.WriteLine("Entre o nome do Produto");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());
        
            Console.WriteLine($"Dados do Produto: "+ p);

            Console.Write("Quantidade a ser adicionada: ");

            int qte = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p.AdicionarQuantidade(qte);

            Console.WriteLine("Dados atualizados" + p);

            Console.Write("Quantidade a ser retirada: ");

            int qt = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p.RetirarQuantidade(qt);

            Console.WriteLine("Dados atualizados" + p);

        }
    } 
}   
