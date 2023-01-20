using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lanchonete02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vlTotal = 0;
            int op, opLanches, opBebidas, qtdLanches, qtdBebidas;
            int cpl1 = 0, cpl2 = 0, cpl3 = 0, cpl4 = 0;
            int cpb1 = 0, cpb2 = 0, cpb3 = 0, cpb4 = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("╔═════════════════════╗");
                Console.WriteLine("║  LANCHONETE DA FRAN ║");
                Console.WriteLine("╠═════════════════════╣");
                Console.WriteLine("║ 1-LANCHES           ║");
                Console.WriteLine("║ 2-BEBIDAS           ║");
                Console.WriteLine("║ 3-CONTA             ║");
                Console.WriteLine("║ 0-FECHAR            ║");
                Console.WriteLine("╚═════════════════════╝");
                Console.Write("\nEscolha uma opção: ");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    // Caso o usuario deseja encerrar o programa
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("PROGRAMA ENCERRADO.");
                        Console.ForegroundColor = ConsoleColor.White;
                        // Função Responsavel por parar o programa
                        Environment.Exit(0);
                        break;
                    // Painel de Laches                    
                    case 1:
                        Console.WriteLine("╔═════════════════════════╗");
                        Console.WriteLine("║          LANCHES        ║");
                        Console.WriteLine("╠═════════════════════════╣");
                        Console.WriteLine("║ 1-X-TUDO    ║ R$ 10,00  ║");
                        Console.WriteLine("╠-------------------------╣");
                        Console.WriteLine("║ 2-X-EGG     ║ R$  7,00  ║");
                        Console.WriteLine("╠-------------------------╣");
                        Console.WriteLine("║ 3-X-SALADA  ║ R$  6,00  ║");
                        Console.WriteLine("╠-------------------------╣"); ;
                        Console.WriteLine("║ 4-BAURU     ║ R$  5,00  ║");
                        Console.WriteLine("╠-------------------------╣");
                        Console.WriteLine("║ 0-VOLTAR    ║           ║");
                        Console.WriteLine("╚═════════════════════════╝");
                        Console.Write("Escolha uma opção de Lanche: ");
                        // Lendo valor na opção do lacnhe escolhida
                        opLanches = Convert.ToInt32(Console.ReadLine());
                        // Verificando se o valor corresponde ao menu de lanches
                        if (opLanches > 0 && opLanches < 5)
                        {
                            // Lendo valor da quantidade de lanche
                            Console.Write("Escolha a quantidade de Lanche: ");
                            qtdLanches = Convert.ToInt32(Console.ReadLine());
                            switch (opLanches)
                            {   // Atribuindo e somando o valor da conta com o valor do lanche escolhido ex: CONTA = CONTA + (VALOR PRODUTO) * (QUANTIDADE)
                                case 1: vlTotal += 10 * qtdLanches; cpl1 += qtdLanches; break;
                                case 2: vlTotal += 7 * qtdLanches; cpl2 += qtdLanches; break;
                                case 3: vlTotal += 6 * qtdLanches; cpl3 += qtdLanches; break;
                                case 4: vlTotal += 5 * qtdLanches; cpl4 += qtdLanches; break;
                            }
                            // Exibindo de uma mensagem de Sucesso para o usuario
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Produto {0} adicionado com Sucesso.", opLanches);
                            Console.ForegroundColor = ConsoleColor.White;
                            // Depois de 1 segundo essa mensagem some chamando o menu principal novamente
                            Thread.Sleep(1000);
                            op = 4;
                        }
                        // Verificando se a opção escolhida foi 0 para chamar o menu principal novamente
                        else if (opLanches == 0)
                        {
                            op = 4;
                        }
                        break;
                    case 2:
                        Console.WriteLine("╔════════════════════════╗");
                        Console.WriteLine("║          BEBIDAS       ║");
                        Console.WriteLine("╠════════════════════════╣");
                        Console.WriteLine("║ 1-COCA-COLA  ║ R$ 8,00 ║");
                        Console.WriteLine("╠------------------------╣");
                        Console.WriteLine("║ 2-GUARANÁ    ║ R$ 7,00 ║");
                        Console.WriteLine("╠------------------------╣");
                        Console.WriteLine("║ 3-SODA       ║ R$ 6,00 ║");
                        Console.WriteLine("╠------------------------╣");
                        Console.WriteLine("║ 4-FANTA      ║ R$ 6,00 ║");
                        Console.WriteLine("╠------------------------╣");
                        Console.WriteLine("║ 0-VOLTAR     ║         ║");
                        Console.WriteLine("╚════════════════════════╝");
                        Console.Write("Escolha uma opção: ");
                        opBebidas = Convert.ToInt32(Console.ReadLine());
                        if (opBebidas > 0 && opBebidas < 5)
                        {
                            Console.Write("Escolha a quantidade: ");
                            qtdBebidas = Convert.ToInt32(Console.ReadLine());
                            switch (opBebidas)
                            {
                                case 1: vlTotal += 8 * qtdBebidas; cpb1 += qtdBebidas; break;
                                case 2: vlTotal += 7 * qtdBebidas; cpb2 += qtdBebidas; break;
                                case 3: vlTotal += 6 * qtdBebidas; cpb3 += qtdBebidas; break;
                                case 4: vlTotal += 6 * qtdBebidas; cpb4 += qtdBebidas; break;
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Produto {0} adicionado com com Sucesso.", opBebidas);
                            Console.ResetColor();
                            Thread.Sleep(1000);
                            op = 4;
                        }
                        else if (opBebidas == 0)
                        {
                            op = 4;
                        }
                        break;
                    case 3:
                        Console.WriteLine("╔═════════════════════════════════╗");
                        Console.WriteLine("║  PRODUTO     ║ QTD  ║    VALOR  ║");
                        if (cpl1 > 0)
                        {
                            Console.WriteLine("╠---------------------------------╣");
                            Console.WriteLine("║ X-TUDO       ║ {0}    ║   R${1}    ║", cpl1, cpl1 * 10);
                            Console.WriteLine("╠---------------------------------╣");
                        }
                        if (cpl2 > 0)
                        {
                            Console.WriteLine("╠---------------------------------╣");
                            Console.WriteLine("║ X-EGG        ║ {0}    ║   R${1}    ║", cpl2, cpl2 * 7);
                            Console.WriteLine("╠---------------------------------╣");
                        }
                        if (cpl3 > 0)
                        {
                            Console.WriteLine("╠---------------------------------╣");
                            Console.WriteLine("║ X-SALADA     ║ {0}    ║   R${1}    ║", cpl3, cpl3 * 6);
                            Console.WriteLine("╠---------------------------------╣");
                        }
                        if (cpl4 > 0)
                        {
                            Console.WriteLine("╠---------------------------------╣");
                            Console.WriteLine("║ BAURU        ║ {0}    ║   R${1}    ║", cpl4, cpl4 * 5);
                            Console.WriteLine("╠---------------------------------╣");
                        }
                        if (cpb1 > 0)
                        {
                            Console.WriteLine("╠---------------------------------╣");
                            Console.WriteLine("║ COCA-COLA    ║ {0}    ║   R${1}    ║", cpb1, cpb1 * 8);
                            Console.WriteLine("╠---------------------------------╣");
                        }
                        if (cpb2 > 0)
                        {
                            Console.WriteLine("╠---------------------------------╣");
                            Console.WriteLine("║ GUARANÁ      ║ {0}    ║   R${1}    ║", cpb2, cpb2 * 7);
                            Console.WriteLine("╠---------------------------------╣");
                        }
                        if (cpb3 > 0)
                        {
                            Console.WriteLine("╠---------------------------------╣");
                            Console.WriteLine("║ SODA         ║ {0}    ║   R${1}    ║", cpb3, cpb3 * 6);
                            Console.WriteLine("╠---------------------------------╣");
                        }
                        if (cpb4 > 0)
                        {
                            Console.WriteLine("╠---------------------------------╣");
                            Console.WriteLine("║ FANTA        ║ {0}    ║   R${1}    ║", cpb4, cpb4 * 6);
                            Console.WriteLine("╠---------------------------------╣");
                        }
                        Console.WriteLine("╠═════════════════════════════════╣");
                        Console.WriteLine("║ TOTAL                   R${0}    ║", vlTotal);
                        Console.WriteLine("╚═════════════════════════════════╝");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("INSIRA UMA OPÇÃO VALIDA !!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            } while (op < 0 || op > 3);
            Console.ReadKey();
        }
    }
}
