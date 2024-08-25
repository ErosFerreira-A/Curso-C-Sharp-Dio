using System;

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
                Console.WriteLine($"Devido ao segundo número ser igual a {num2}, o retorno é zero");
            } else {
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            }
        }

        public void Multiplicar(double num1, double num2) {
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        }

        public void Potencia(double num1, double num2) {
            double resultado = Math.Pow(num1, num2);
            Console.WriteLine($"{num1}^{num2} = {resultado}");
        }

        public void Seno(double angulo) {
            double radiano = angulo * (Math.PI / 180);
            double seno = Math.Sin(radiano);
            Console.WriteLine($"O Valor do Seno de {angulo}° = {Math.Round(seno, 4)}");
        }

        public void Coseno(double angulo) {
            double radiano = angulo * (Math.PI / 180);
            double cos = Math.Cos(radiano);
            Console.WriteLine($"O Valor do Coseno de {angulo}° = {Math.Round(cos, 4)}");
        }

        public void Tangente(double angulo) {
            double radiano = angulo * (Math.PI / 180);
            double tan = Math.Tan(radiano);
            Console.WriteLine($"O Valor da Tangente de {angulo}° = {Math.Round(tan, 4)}");
        }

        public void RaizQuadrada(double num1) {
            double raiz = Math.Sqrt(num1);
            Console.WriteLine($"A raiz quadrada do número {num1} é igual a {raiz}");
        }
    }

    public class Inicialização {
        public static void Executar() {
            var calc = new Calcular();
            calc.Somar(10.0, 5.0);
            calc.Subtrair(10.0, 5.0);
            calc.Multiplicar(10.0, 5.0);
            calc.Dividir(10.0, 2.0);
            calc.Dividir(10, 0);
            calc.Potencia(10, 10);
            calc.Seno(30);
            calc.Coseno(30);
            calc.Tangente(30);
            calc.RaizQuadrada(9);
        }
    }
}