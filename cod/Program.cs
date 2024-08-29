using System;
using System.Collections.Generic;
using Calculadora.App;
using CursoCSharp;
using cod.EstruturaDeControle;

class Program {
    static void Main(string[] args) {
        var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Calculadora - Fundamentos", Inicialização.Executar},
                {"Estruturas de Repetição e de Controle - Estrutura de Controle", EstruturaDeRepetição.Executar},
                
            });

        central.SelecionarEExecutar();
 
    }
}
