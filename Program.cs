using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyetolista
{
    class Program 
    {
        static void Main(string[] args)
        {

            clsListaTrabajadores L = new clsListaTrabajadores();
            L.Agregar();
            Console.ReadKey();
            Console.WriteLine("***********************************************************");
            Console.WriteLine("**************Lista de Clientes****************************");
            clsListaCliente C = new clsListaCliente();
            C.Agregar();
            Console.ReadKey();
        }
        
    }
}
