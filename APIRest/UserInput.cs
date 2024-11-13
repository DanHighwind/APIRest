using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIRest
{
    internal class UserInput
    {
        string nome;
        string telefone;
        string email;
        string endereco;


        Cadastro cadastro = new Cadastro();

        public void CadastrarUsuario()
        {

            Console.Write("Digite o nome completo: ");
            nome = Console.ReadLine();

            Console.Write("Digite o telefone: ");
            telefone = Console.ReadLine();

            Console.Write("Digite o email: ");
            email = Console.ReadLine();

            Console.Write("Digite o endereço: ");
            endereco = Console.ReadLine();


            cadastro.Cadastrar(nome,telefone,email,endereco);

        }

    }

}
