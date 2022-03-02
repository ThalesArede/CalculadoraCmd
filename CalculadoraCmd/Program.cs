using System;

namespace CalculadoraCmd
{
    class Program
    {

        enum Menu { Soma = 1, Subtracao = 2, Divisao = 3, Multiplacao = 4, Potencia= 5, Raiz = 6, Sair =7 }
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo ao CALC, selecione uma das opções: ");
            
            Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação" +
                "\n5-Potência\n6-Raiz\n7-Sair"); // Nos mostra na tela do CMD o Menu de opções

            Menu opcao = (Menu)int.Parse(Console.ReadLine());

            /* Casting --> Menu opção veio de uma variável do tipo STRING, convertermos para inteiro com
            INT.PARSE, depois armazenamos os valores no (MENU) */

            Console.WriteLine(opcao);

            Console.ReadLine(); 

        }
    }
}