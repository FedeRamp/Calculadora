using System;
namespace Calculadora.Librería
{
    public class Operacion
    {
        private double numeroA;
        private double numeroB;
        private string tipoOperacion;
        public Operacion(string tipoOperacion, double numeroA, double numeroB)
        {
            this.numeroA = numeroA;
            this.numeroB = numeroB;
            this.tipoOperacion = tipoOperacion;
        }

        public double getResultado()
        {
            switch (tipoOperacion)
            {
                case "*":
                    return numeroA * numeroB;
                    break;
                case "-":
                    return numeroA - numeroB;
                    break;
                case "+":
                    return numeroA + numeroB;
                    break;
                case "/":
                    return numeroA / numeroB;
                    break;
            }
            return 0;
        }
    }
}
