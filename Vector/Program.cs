using System;
using System.Globalization;

//Study of vector and lists
namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees? ");
            int n = int .Parse(Console.ReadLine());

            List<Company>list = new List<Company>();

            for (int i  = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #",i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string Name = Console.ReadLine();
                Console.Write("Salary ");
                double Salary = int.Parse(Console.ReadLine());

                list.Add(new Company(id, Name, Salary));
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int find_id = int.Parse(Console.ReadLine());

            Company emp = list.Find(x => x.Id == find_id);

            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.Add(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
        }

    }

}
