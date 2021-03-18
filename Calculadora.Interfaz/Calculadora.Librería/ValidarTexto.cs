using System;
namespace Calculadora.Librería
{
    public class ValidadorInput
    {
        public ValidadorInput()
        {
        }

        public static double pedirNumero(string mensaje)
        {
            string entrada = "";
            double resultado;
            do
            {
                Console.Write(mensaje);
                entrada = Console.ReadLine();
                if(!double.TryParse(entrada, out resultado)){
                    Console.WriteLine("No se ingreso un numero");
                    entrada = "";
                }
            } while (entrada == "");
            return resultado;
        }

        public static string pedirOperacion(string mensaje)
        {
            Console.Write(mensaje);
            string entrada = "";
            do
            {
                entrada = Console.ReadLine();
                if (entrada == "/help")
                {
                    Console.WriteLine("Multiplicacion => * \nDivision => / \n" +
                                      "Suma => + \nResta => -");
                    entrada = "";
                } else if (!(entrada == "*" || entrada == "-" || entrada == "+" || entrada == "/"))
                {
                    Console.WriteLine("No se ingreso una operacion matematica");
                    entrada = "";
                }
            } while (entrada == "");
            return entrada;

        }

        public static bool divisionValida(string operacion, double numeroB)
        {
            if(operacion == "/" && numeroB == 0)
            {
                Console.WriteLine("No puedes dividir por 0");
                return false;
            }
            return true;
        }
    }
}
