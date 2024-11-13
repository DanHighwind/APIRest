using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIRest
{
    internal class ListarClientes
    {

        public void listar()
        {

            for (int j = 0; j < Dados.dadosClientes.Count(); j++)
            {

                Console.WriteLine(string.Join(" ; ", Dados.dadosClientes[j]));


            }

            Console.WriteLine();

        }

    }
}
