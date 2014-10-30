using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
   public class ColectorObjetos <Tipo> where  Tipo: IEnumerable
   {

       private Tipo[] datos;

       public ColectorObjetos(int elementos)
       {
           datos=new Tipo[elementos];
       }

       public Tipo this[int i]
       {
           get { return datos[i]; }
           set { datos[i] = value; }
       }

       public void Borrar(Tipo t)
       {
           for(int i=0;i<datos.Length;i++)
           {

               if (datos[i]!=null && datos[i].Equals(t))
               {
                   datos[i] = default(Tipo);
               }
           }
       }
      

   }
}
