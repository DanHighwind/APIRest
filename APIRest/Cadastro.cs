using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIRest
{
    internal class Cadastro
    {
        
        int id;
        public void Cadastrar(string nome, string telefone, string email, string endereco)
        {

            Object[] dadosUsuario = new Object[5];
            id = Dados.dadosClientes.Count+1;

            dadosUsuario = [id, nome, telefone, email, endereco];

            Dados.dadosClientes.Add(dadosUsuario);


            using (var arquivoCSV = File.CreateText(@"..\..\..\test.csv"))
            {

                for (int j=0; j<Dados.dadosClientes.Count(); j++)
                {

                    arquivoCSV.WriteLine(string.Join(";",Dados.dadosClientes[j]));

                }

            }

            Console.WriteLine("\nCliente cadastrado!\n");

        }

    }

}
