using System;

namespace Calcularfigurasbasicas
{
    // creamos una clase de un circulo con propiedades y metodos 
    public class Circulo {
        public double Radio { get; set; }

        //metodo para calcular la area  del circulo utilizando la formula
        public double CalcularArea()
        {
            return Math.PI * Radio;

        }
        // el metodo para calcular el perimetro del circulo que utilizamos 
        public double CalcularrPerimetro()
        {
            return 2 * Math.PI * Radio;
        }

    }

    public class Cuadrado
    {
        public double Lado { get; set; }

        //metodo para calcular la area  del cuadrado utilizando la formula
        public double CalcularArea()
        {
            return Lado * Lado;

        }
        // el metodo para calcular el perimetro del cuadrado que utilizamos 
        public double CalcularPerimetro()
        {
            return 4 * Lado;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            // Se crea un objeto de la clase Circulo

            Circulo circulo = new Circulo();

            // Se solicita al usuario el valor del radio 

            Console.WriteLine("Ingrese el radio del circulo: ");
            circulo.Radio = Convert.ToDouble(Console.ReadLine());

            // Calcula y muestra el área y el perímetro del círculo con dos decimales.
            Console.WriteLine($"Área del círculo: {circulo.CalcularArea():F2}");
            Console.WriteLine($"Perímetro del círculo: {circulo.CalcularrPerimetro():F2}");

            // Se crea un objeto de la clase Cuadrado.
            Cuadrado cuadrado = new Cuadrado();

            // Solicita al usuario el valor del lado del cuadrado.
            Console.Write("\nIngrese el lado del cuadrado: ");
            cuadrado.Lado = Convert.ToDouble(Console.ReadLine());


            // Calcula y muestra el área y el perímetro del cuadrado con dos decimales.
            Console.WriteLine($"Área del cuadrado: {cuadrado.CalcularArea():F2}");
            Console.WriteLine($"Perímetro del cuadrado: {cuadrado.CalcularPerimetro():F2}");
        }
    }

}

