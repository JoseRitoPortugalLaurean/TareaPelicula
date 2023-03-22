using System;
using System.Collections.Generic;

namespace Pelicula
{
   
    public class Pelicula
    {
        //Campos
        private List<Actor> actores = new List<Actor>();
        public string titulo;
        public int año;
        public string director;
        public string país;
        
        //Constructores
        public Pelicula()
        {
            
        }
        public Pelicula(string titulo, int año)
        {
            this.titulo = titulo;
            this.año = año;
        }
        //Métodos

        public void Imprime()
        {
             Console.WriteLine($"{titulo} ({año})");
        }


    }

    public class Actor
    {
        //Propiedades

        //Constructores


        //Métodos 
        public void Imprime()
        {

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
