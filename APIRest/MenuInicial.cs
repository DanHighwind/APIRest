using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIRest
{
    internal class MenuInicial
    {

        int opcao;
        public void Menu()
        {

            UserInput userInput = new UserInput();
            ListarClientes listarClientes = new ListarClientes();
            PesquisarCliente pesquisarCliente = new PesquisarCliente();


            Console.WriteLine("Digite a opção que deseja:");
            Console.WriteLine("1 - Cadastrar cliente");
            Console.WriteLine("2 - Listar clientes");
            Console.WriteLine("3 - Pesquisar por cliente");
            Console.WriteLine("4 - Sair");

            opcao = Convert.ToInt32(Console.ReadLine());


            if (opcao == 1)
            {

                userInput.CadastrarUsuario();


            }

            else if(opcao == 2)
            {

                listarClientes.listar();

            }

            else if(opcao == 3)
            {

                pesquisarCliente.pesquisar();

            }

            else if(opcao == 4)
            {

                System.Environment.Exit(0);

            }

            else
            {

                Console.WriteLine("Valor inválido!\n");
                Menu();

            }

        }

    }

}
