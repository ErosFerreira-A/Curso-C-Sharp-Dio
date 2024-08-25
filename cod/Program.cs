using System;
using System.Collections.Generic;
using Calculadora.App;
using CursoCSharp;

class Program {
    static void Main(string[] args) {
        var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Calculadora - Fundamentos", Inicialização.Executar},
                
            });

        central.SelecionarEExecutar();
 
    }
}
