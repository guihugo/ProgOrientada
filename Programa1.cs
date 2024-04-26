using System;
using System.Globalization;

namespace Program
{
    public class Estudo
    {
        static void Main()
        {
         Triangulo x,y;

         x = new Triangulo();
         y = new Triangulo();

         x.A = double.Parse(Console.ReadLine());
         x.B = double.Parse(Console.ReadLine());
         x.C = double.Parse(Console.ReadLine());

        double areaX =x.Area(); //Chamado de metodo
        Console.WriteLine(areaX);

         y.A = double.Parse(Console.ReadLine());
         y.B = double.Parse(Console.ReadLine());
         y.C = double.Parse(Console.ReadLine());
        
        double areaY =y.Area();
        Console.WriteLine(areaY);
        }
    } 
}   
