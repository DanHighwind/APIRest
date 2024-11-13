using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIRest
{
    internal class PesquisarCliente
    {
        string nome;
        public void pesquisar()
        {

            Console.Write("\nDigite o nome do cliente: ");
            nome = Console.ReadLine();



            for(int i = 0;i < Dados.dadosClientes.Count();i++)
            {


                if (Convert.ToString(Dados.dadosClientes[i][1]) == nome)
                {
                    Console.WriteLine();

                    Console.WriteLine("ID: "+ Convert.ToString(Dados.dadosClientes[i][0]));
                    Console.WriteLine("Nome: " + Convert.ToString(Dados.dadosClientes[i][1]));
                    Console.WriteLine("Telefone: " + Convert.ToString(Dados.dadosClientes[i][2]));
                    Console.WriteLine("Email: " + Convert.ToString(Dados.dadosClientes[i][3]));
                    Console.WriteLine("Endereco: " + Convert.ToString(Dados.dadosClientes[i][4]));

                    

                }

            }

            Console.WriteLine();

        }

    }

}
