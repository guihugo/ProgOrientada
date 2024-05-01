using System;

//Calcula area de um piramide
///Define o método para calculo
namespace Program
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A * B * C) / 2;
            return Math.Sqrt(p * (p-A) * (p-B) * (p-C));
        }
    }
}
