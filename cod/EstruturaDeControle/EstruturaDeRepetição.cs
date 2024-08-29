using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cod.EstruturaDeControle {
    internal class EstruturaDeRepetição {
        public static void Executar() {
            //Laço For
            int cont = 1;
            int num = 10;
            Console.WriteLine("Laço For");
            for (int i = 0; i <= num; i++) {
                Console.WriteLine($"{num} X {i} = {num * i}");
            }
            // Estrutura de repetição While
            Console.WriteLine("Estrutura de repetição While");

            int contador = 0;
            while (contador <= num) {
                Console.WriteLine($"{contador + 1}° Execução : {num} X {contador} = {num * contador}");
                contador++;

                //break; Também para a o laço.

                // Estrutura de repetição Do...While
                Console.WriteLine("Estrutura Do...While");
                if (contador > num) {
                    do {

                        Console.WriteLine($"Contador: {cont}");
                        cont++;
                    } while (cont <= num);
                }
            }
        }
    }
}
