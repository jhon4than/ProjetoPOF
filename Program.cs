using Classes;
using ProjetoPOF.Tela;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Menu.Criar();
            
            Cliente c1 = new Cliente { Nome = "Jhdedeon" , Telefone = "1232de13123", CPF = "2313123331313"};
            c1.Gravar();

            //var cliente = new Cliente();
            //cliente.nome = "jhonathan";
            //cliente.telefone = "32256589525";
            //cliente.cpf = "15151545245";
            //cliente.gravar();

            //var cliente2 = new Cliente();
            //cliente.nome = "yasmin";
            //cliente.telefone = "1521545464654";
            //cliente.cpf = "12154854541";
            //cliente.gravar();

            var clientes = Cliente.LerClientes();
            foreach (Cliente c in clientes)
            {
                Console.WriteLine(c.Nome);
            }
            Console.ReadLine();
        }
    }
}
