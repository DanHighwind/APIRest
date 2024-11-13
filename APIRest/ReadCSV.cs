using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIRest
{
    internal class ReadCSV
    {

        public void Read()
        {

            using (var reader = new StreamReader(@"..\..\..\test.csv"))
            {

                while (!reader.EndOfStream)
                {

                    var line = reader.ReadLine();
                    var values = line.Split(';');


                    Dados.dadosClientes.Add(values);


                }

            }

        }

    }

}
