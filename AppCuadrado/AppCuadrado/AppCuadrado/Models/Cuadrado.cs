using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace AppCuadrado.Models
{
    public class Cuadrado
    {
        public double lado {get ;set;}
        public double area { get ;set;}
        public double perimetro { get ;set;}

        public Cuadrado(double L)
        {
            this.lado = L;
            calcularArea();
            calcularPerimetro();
        }

        public void calcularArea()
        {
            area = Math.Pow(lado, 2);
        }

        public void calcularPerimetro()
        {
            perimetro = lado * 4;
            
        }

        public override string ToString()
        {
            return $" Area: {area} -  Perimetro: {perimetro} ";
        }
    }
}
