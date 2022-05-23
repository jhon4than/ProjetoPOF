using ProjetoPOF.Calculo;
using ProjetoPOF.Diretorio;
using ProjetoPOF.Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOF.Tela
{
    internal class Menu
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVO = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        public const int LIMPAR_TELA = 4;
        public static void Criar()
        {
            while (true)
            {
                string mensagem = "Olá usuário, bem vindo ao programa\n" +
                    "\n  Ultilizando programação funcional" +
                    "\n\n\n" +
                    "\n      Digite uma das opções abaixo:" +
                    "\n      0 - Sair do programa" +
                    "\n      1 - Para Ler arquivos" +
                    "\n      2 - Para executar a tabuada" +
                    "\n      3 - Calcular média de alunos" +
                    "\n      4 - Limpar Tela";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == SAIDA_PROGRAMA)
                {
                    break;
                }
                else if (valor == LER_ARQUIVO)
                {
                    Console.WriteLine("========= Opção Ler Arquivos ==========");
                    Arquivo.Ler(1);
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("========== Opção Tabuada ============");
                    Console.WriteLine("Digite o número da tabuada que deseja:");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(numero);
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Console.WriteLine("======== Opção Calcular Média =========");
                    Media.Aluno();
                }
                else if (valor == LIMPAR_TELA)
                {
                    Console.Clear();
                }
            }
        }
    }
}
