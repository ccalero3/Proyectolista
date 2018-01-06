using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyetolista
{
    class clsListaCliente : ListaDatos<String>

    {
        public void ClsListaCliente()
        {
            ListaDatos<String> L = new ListaDatos<String>();
       
        }

        public void Agregar()
        {
            ListaDatos<String> L = new ListaDatos<String>();
            L.Agregar("Jorge Salvador Diaz cliente 1");
            L.Agregar("Francis Salvador Corea");
            L.Agregar("Julio Calero");
            Console.WriteLine("Creando lista de Clientes");
            for (int I = 0; I < L.lista.Count; I++)
            {
                Console.WriteLine(I + 1);

            }

            Console.WriteLine("Mostrando lista de Cliente");

            for (int I = 0; I < L.lista.Count; I++)
            {
                Console.WriteLine(I + " " + L.lista[I]);

            }
            
        }



    }
}
