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

            var clientes = Cliente.LerClientes();

            /*
            var cliente = new cliente();
            cliente.nome = "jhonathan";
            cliente.telefone = "32256589525";
            cliente.cpf = "15151545245";
            cliente.gravar();

            var cliente2 = new cliente();
            cliente.nome = "yasmin";
            cliente.telefone = "1521545464654";
            cliente.cpf = "12154854541";
            cliente.gravar();
            */
        }
    }
}
