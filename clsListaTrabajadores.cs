using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyetolista 
{
  public class clsListaTrabajadores: ListaDatos<String>
    {
      
     public void  ClsListaTrabajadores()
     {
         ListaDatos<String> L = new ListaDatos<String>();
         
     }
      
      public void Agregar()
      {
          ListaDatos<String> L = new ListaDatos<String>();
          L.Agregar("Cristhian Calero Gazo");
          L.Agregar("Salvador Diaz");
          L.Agregar("Juan Jose Quezada");
          L.Agregar("Wilmer Funez");
          L.Agregar("Brian Davila");
          Console.WriteLine("Creando lista de Trabajadores");
          for (int I = 0; I < L.lista.Count; I++)
          {
              Console.WriteLine(I+1);

          }
          
          Console.WriteLine("Mostrando lista de Trabajadores");
          
          for (int I = 0; I < L.lista.Count; I++)
          {
              Console.WriteLine(I+" "+L.lista[I]);

           }
      }
  }

}   
