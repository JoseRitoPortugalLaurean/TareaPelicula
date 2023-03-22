using System;
using System.Collections.Generic;

namespace Pelicula
{
   
    public class Pelicula
    {
        //Campos
        private List<Actor> actores = new List<Actor>();
        public string Título {get; set;}
        public int Año {get; set;}
        public string Director{get; set;}
        public string País{get; set;}
        
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
            Pelicula p1 = new Pelicula();
            p1.SetTitulo("Todo en Todas Partes al Mismo Tiempo");
            p1.SetAño(2022);
            
            Pelicula p2 = new Pelicula();
            p2.SetTitulo("Tár");
            p2.SetAño(2023);
            Console.WriteLine("Hello");
            Console.WriteLine("{0} ({1})", p1.GetTitulo(), p1.GetAño());

        }    
    }
}
