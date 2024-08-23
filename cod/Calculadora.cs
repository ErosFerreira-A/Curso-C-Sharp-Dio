using System;
using System.ComponentModel.Design;

namespace Calculadora.App {
    public class Calcular {
        public void Somar(double num1, double num2) {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }

        public void Subtrair(double num1, double num2) {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }

        public void Dividir(double num1, double num2) {
            if (num2 == 0) {
                Console.WriteLine($"Devido ao segundo número ser igual a {num2} o retorno é zero");
        }else{
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
           }
        }

        public void Multiplicar(double num1, double num2) {
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        }

        public void Potencia(double num1, double num2) {
            double resultado = Math.Pow(num1, num2);
            Console.WriteLine($"{num1} * {num2} = {resultado}");
        }

    }
}
