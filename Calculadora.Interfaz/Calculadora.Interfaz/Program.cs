using System;
using Calculadora.Librería;

namespace Calculadora.doubleerfaz
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string continuar = "";
            do
            {
                Console.WriteLine("\nBienvenido a su calculadora");
                double numeroA = ValidadorInput.pedirNumero("Primer numero= ");
                double numeroB = ValidadorInput.pedirNumero("Segundo numero= ");
                string operacion = ValidadorInput.pedirOperacion("(ingrese /help para ver las operaciones disponibles) \nOperacion = ");
                if (!ValidadorInput.divisionValida(operacion, numeroB))
                { 
                    continue;
                }
                Operacion objOperacion = new Operacion(operacion, numeroA, numeroB);
                Console.WriteLine("El resultado es: " + objOperacion.getResultado() +
                                    "\nPara salir ingrese 'x'");
                continuar = Console.ReadLine();
                if(continuar != "x")
                {
                    continuar = "";
                }
                
            } while (continuar == "");
        }
    }
}
