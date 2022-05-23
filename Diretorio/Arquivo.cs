using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOF.Diretorio
{
    internal class Arquivo
    {
        public static void Ler(int numeroArquivo)
        {
            string arquivoComCaminho = @"C:\arquivos\arquivo" + numeroArquivo + ".txt";

            if (File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    Console.WriteLine("============= Arquivo " + numeroArquivo + " ===============");
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            string arquivoComCaminho2 = @"C:\arquivos\arquivo" + numeroArquivo + ".txt";
            if (File.Exists(arquivoComCaminho2))
            {
                Ler(numeroArquivo + 1);
            }
        }
    }
}
