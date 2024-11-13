
namespace APIRest
{ 
    class Program
    {

        
        public static void Main(string[] args)
        {
            
            ReadCSV readCSV = new ReadCSV();
            MenuInicial menuInicial = new MenuInicial();

            readCSV.Read();


            while (true)
            {

                menuInicial.Menu();

            }

        }

    }

}

