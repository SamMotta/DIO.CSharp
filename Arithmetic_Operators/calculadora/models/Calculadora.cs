using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculadora.models
{
    public class Calculadora
    {
        private double firstNumber;
        private double secondNumber;
        private double result;

        public void setNumbers(double a, double b)
        {
            this.firstNumber = a;
            this.secondNumber = b;
        }

        public double getResult()
        {
            return this.result;
        }

        public void Somar()
        {
            this.result = this.firstNumber + this.secondNumber;
        }

        public void Subtrair()
        {
            this.result = this.firstNumber - this.secondNumber;
        }

        public void Multiplicar()
        {
            this.result = this.firstNumber * this.secondNumber;
        }

        public void Dividir()
        {
            this.result = this.firstNumber / this.secondNumber;
        }

        public void Modulus()
        {
            this.result = this.firstNumber % this.secondNumber;
        }

        public void Potenciação()
        {
            this.result = Math.Pow(this.firstNumber, this.secondNumber);
        }

        public void Radiciação()
        {
            this.result = Math.Round(Math.Sqrt(this.firstNumber), 4);
        }

        public void Trucamento()
        {
            this.result = Math.Round(Math.Truncate(this.firstNumber), 4);
        }
    }
}