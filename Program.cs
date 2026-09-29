using System.Collections;
using System.Reflection;

namespace MeuProjeto
{
    // Exemplo didático procedural: dados simples e funções estáticas, sem classes de domínio.
    class Program
    {
        enum Opcao
        {
            Sair = 0,
            Somar = 1,
            Subtrair = 2,
            Multiplicar = 3,
            Dividir = 4,
            Potencia = 5,
            Raiz = 6
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=========================== Calculadora didática em C# ==============================");
            Console.WriteLine("===Procedural: as operações são funções separadas e os dados são variáveis locais.===");
            Console.WriteLine("Isso permite estudar lógica e funções sem introduzir objetos, propriedades ou herança.\n");

            // Tipos de dados e variáveis
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n1-Somar  2-Subtrair  3-Multiplicar  4-Dividir  5-Potência  6-Raiz  0-Sair");
                Console.Write("Escolha: ");
                string entrada = Console.ReadLine() ?? "";
                if (!int.TryParse(entrada, out int valorOpcao) || !Enum.IsDefined(typeof(Opcao), valorOpcao))
                {
                    Console.WriteLine("Opção inválida.");
                    continue;
                }

                Opcao opcao = (Opcao)valorOpcao;
                if (opcao == Opcao.Sair)
                {
                    continuar = false;
                    break;
                }

                        /* Digite o primeiro numero */

                int num1;

                while (true)
                {
                    Console.Write("Digite o primeiro número: ");
                    if (int.TryParse(Console.ReadLine(), out num1))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Digite um número.");
                    }
                }

                        /* Digite o segundo numero */

                int num2;

                while (true)
                {
                    Console.Write("Digite o segundo número: ");
                    if (int.TryParse(Console.ReadLine(), out num2))
                    {
                        if (num2 == 0 && opcao == Opcao.Dividir)
                        {
                            Console.WriteLine("Não é possível dividir por zero.");
                        }
                        else 
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Digite um número.");
                    }
                }

                        /* Calculos */
                
                double resultado = 0;
                bool erroDivisao = false;

                switch (opcao)
                {
                    case Opcao.Somar:
                        resultado = num1 + num2;
                        break;
                    case Opcao.Subtrair:
                        resultado = num1 - num2;
                        break;
                    case Opcao.Multiplicar:
                        resultado = num1 * num2;
                        break;
                    case Opcao.Dividir:
                            resultado = num1 / num2;
                        break;
                    case Opcao.Potencia:
                        resultado = Math.Pow(num1, num2);
                        break;
                    case Opcao.Raiz:
                        resultado = Math.Pow(num1, 1.0 / num2);
                        break;
                }
                Console.WriteLine("Resultado: " + resultado);
            }

        }
    }
}