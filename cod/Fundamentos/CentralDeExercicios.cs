using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp {
    public class CentralDeExercicios {
        Dictionary<string, Action> Exercicios;

        public CentralDeExercicios(Dictionary<string, Action> exercicios) {
            Exercicios = exercicios;
        }

        public void SelecionarEExecutar() {



            while (true) {
                Console.Clear();

                // Obtenha uma lista dos exercícios para usar índices
                var exerciciosLista = Exercicios.Keys.ToList();

                // Use o índice da lista para garantir números estáveis
                for (int i = 0; i < exerciciosLista.Count; i++) {
                    Console.WriteLine("{0}) {1}", i + 1, exerciciosLista[i]);
                }



                Console.Write("Digite o número (ou vazio para o último)? ");
                int.TryParse(Console.ReadLine(), out int num);
                bool numValido = num > 0 && num <= Exercicios.Count;
                num = numValido ? num - 1 : Exercicios.Count - 1;



                string nomeDoExercicio = Exercicios.ElementAt(num).Key;

                Console.Write("\nExecutando exercício ");
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(nomeDoExercicio);
                Console.ResetColor();

                Console.WriteLine(String.Concat(
                    Enumerable.Repeat("=", nomeDoExercicio.Length + 21)) + "\n");

                Action executar = Exercicios.ElementAt(num).Value;
                try {
                    executar();
                } catch (Exception e) {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Ocorreu um erro: {0}", e.Message);
                    Console.ResetColor();

                    Console.WriteLine(e.StackTrace);
                }

                //Lógica da Saída do programa:
                Console.WriteLine("Deseja sair do Programa ? Sim para sair || Para continuar pressione qualquer tecla...");
                string resposta = Console.ReadLine();
                if (resposta.ToLower() == "sim") {
                    Console.WriteLine($"Sua resposta foi {resposta}");
                    Console.WriteLine("O programa irá encerrar");
                    Environment.Exit(0);
                } else if (resposta.ToLower() == "não") {
                    Console.WriteLine($"Sua resposta foi {resposta}, o programa continuará a execução.");
                }
            }
        }
    }
}