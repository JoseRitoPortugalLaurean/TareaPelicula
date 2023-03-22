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
        public Pelicula(string titulo, int año, string director, string pais)
        {
            this.Título = titulo;
            this.Año = año;
            this.Director = director;
            this.País = pais;
        }
        //Métodos

        public void Imprime()
        {
             Console.WriteLine($"{Titulo} ({Año})");

        }


    }

    public class Actor
    {
        //Propiedades

        //Constructores


        //Métodos 
        public void Imprime()
        {
            Console.WriteLine($"{Titulo} ({Año})");
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
            Console.WriteLine("Hello");
            Console.WriteLine("{0} ({1})", p1.GetTitulo(), p1.GetAño());

        }
    }
}
