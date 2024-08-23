using System;
using Calculadora.App;

class Program {
     static void Main(string[] args) {
        Calcular calc = new Calcular();

        calc.Somar(10.0, 5.0);
        calc.Subtrair(10.0, 5.0);
        calc.Multiplicar(10.0, 5.0);
        calc.Dividir(10.0, 2.0);
        calc.Dividir(10, 0);
        calc.Potencia(10, 10);
    }
}
