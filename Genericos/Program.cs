using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            //ColectorObjetos<Libro> co=new ColectorObjetos<Libro>(3);
            //var l = new Libro() {Titulo = "La hoguera de las vanidades"};
            //co[0] = new Libro();
            //co[0].Titulo = "El padrino";
            ////{Titulo = "El padrino"};
            //co[1] = l;
            //co.Borrar(co[0] );
            var al = new ArrayList();
            al.Add("C#");
           //var a= ((Libro)al[0]).Titulo;

            var lista = new List<Libro>();
            var textos = new List<string>()
            {
                "uNO",
                "dOS",
                "Tres",
                "Cuatro"

            };
            var canciones = new List<Cancion>()
            {
                new Cancion(),
                new Cancion(),
                new Cancion()

            };
            lista.Add(new Libro(){Titulo = "Lo que sea"});
            lista.Add(new Libro() { Titulo = "Lo que sea" });
            lista.Add(new Libro() { Titulo = "Lo que sea" });
            

            Console.WriteLine(lista[2].Titulo);

           // lista.RemoveAt(3);

            Console.WriteLine(lista.Count);

            foreach (var l in lista)
            {
                Console.WriteLine(l.Titulo);
            }
            //Diccionario

            Dictionary<String,Libro> tablaLibros=
                new Dictionary<String, Libro>();

            tablaLibros.Add("A",new Libro(){Titulo = "Uno"});
            tablaLibros.Add("B", new Libro() { Titulo = "Uno" });
            tablaLibros.Add("C", new Libro() { Titulo = "Dos",
                                                    Autor = "Yo"});
            tablaLibros.Add("D", new Libro() { Titulo = "Tres" });
            tablaLibros.Add("E", new Libro() { Titulo = "Cuatro" });

            Console.WriteLine(tablaLibros["C"].Titulo+" "+
                tablaLibros["C"].Autor);

            if(tablaLibros.ContainsKey("Z"))
                Console.WriteLine("Z existe");

            tablaLibros.Remove("A");

            Console.WriteLine(tablaLibros.Count);

            var lib = lista.
                Where(o => o.Titulo == "Programar con c# es facil")
                .OrderBy(o=>o.Titulo);
            var lib2 = from o in lista
                where o.Titulo == "Programar con c# es facil"
                orderby o.Titulo
                select o;

            if(lib.Any())
                Console.WriteLine("Lo tengo");
            else
                Console.WriteLine("No lo tengo");

            Console.ReadLine();
        }
    }
}














