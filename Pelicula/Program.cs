using System;
using System.Collections.Generic;

namespace Pelicula
{
   
    public class Pelicula
    {
        //Campos
        private List<Actor> actores = new List<Actor>();
        public string Título;
        public int Año;
        public string Director;
        public string País;

        //Constructores
     
        //Métodos
     
        public void Imprime()
        {
     //       Console.WriteLine($"{titulo} ({año})");

        }


    }

    public class Actor
    {
        //Propiedades

        //Constructores


        //Métodos 
        public void Imprime()
        {
            Console.WriteLine($"{Nombre} ({Año})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        }
    }
}
