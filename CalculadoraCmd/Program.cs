using System;
using System.Globalization;

namespace CalculadoraCmd
{
    class Program
    {
        /* ENUM - Tipo de valor usado para representar uma lista de constantes inteiras nomeadas
        Criado usando a palavra-chave "enum" dentro de uma classe, estrutura ou namespace */

        enum Menu { Soma = 1, Subtracao = 2, Divisao = 3, Multiplacao = 4, Potencia = 5, Raiz = 6, Sair = 7 }


        /* void pois não retorna nada, enum criado fora da Main pois podemos acessar dentro de todas as 
        classes no programa princal */

        static void Main(string[] args) 
        {

            bool escolheuSair = false;

            while (!escolheuSair) // Enquanto o usuário NÃO(!) escolher a opção SAIR(7), exiba o Menu
            {

                Console.WriteLine("Seja bem vindo ao CALC, selecione uma das opções: ");

                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação" +
                    "\n5-Potência\n6-Raiz\n7-Sair"); //-> Nos mostra na tela do CMD o Menu de opções

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                /* Casting: Menu opção veio de uma variável do tipo STRING, convertermos para inteiro com
                INT.PARSE, depois armazenamos os valores no (MENU) */

                /*Console.WriteLine(opcao);*/

                switch (opcao) // Switch para chamarmos as funções definidas nas próximas classes
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplacao:
                        Multiplicacao();
                        break;
                    case Menu.Potencia:
                        Potencia();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheuSair = true; // Caso a opção escolhida seja SAIR(7), fecha o programa
                        break;
                }
                Console.Clear(); // Limpa o console quando selecionamos uma opção no Menu da CALC após exbibir
            }
        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois números: ");

            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());

            int resultado = a + b;
            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar ao Menu");
            Console.ReadLine();

        }

        static void Subtracao()
        {
            Console.WriteLine("Subtração de dois números: ");

            Console.WriteLine("Digite o primeiro número: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int d = int.Parse(Console.ReadLine());

            int resultado = c - d;
            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar ao Menu");
            Console.ReadLine();
        }

        static void Divisao()
        {
            Console.WriteLine("Divisão de dois números: ");

            Console.WriteLine("Digite o primeiro número: ");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int f = int.Parse(Console.ReadLine());

            float resultado = (float)e / (float)f;
            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar ao Menu");
            Console.ReadLine();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicação de dois números: ");

            Console.WriteLine("Digite o primeiro número: ");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int f = int.Parse(Console.ReadLine());

            int resultado = e * f;
            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar ao Menu");
            Console.ReadLine();
        }

        static void Potencia()
        {
            Console.WriteLine("Potencia um números: ");

            Console.WriteLine("Digite o número: ");
            int baseNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Expoente: ");
            int expo = int.Parse(Console.ReadLine());

            int resultado = (int)Math.Pow(baseNum, expo);
            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar ao Menu");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("Raiz um números: ");

            Console.WriteLine("Digite o número: ");
            int raiz = int.Parse(Console.ReadLine());

            double resultado = Math.Sqrt(raiz);
            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar ao Menu");
            Console.ReadLine();
        }
    }
}