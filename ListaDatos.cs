using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyetolista
{
    public  class ListaDatos <String>
    {
        public List<String> lista { get; set; }
        public ListaDatos()
        {
            this.lista = new List<String>();
        }

        public void Agregar(String item)
        {
            lista.Add(item);
            
        }
        
    }
}
