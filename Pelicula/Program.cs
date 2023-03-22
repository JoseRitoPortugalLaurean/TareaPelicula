using System;
using System.Collections.Generic;

namespace Pelicula
{
   
    public class Pelicula
    {
        //Campos
        private List<Actor> actores = new List<Actor>();
        public string titulo;
        public Int16 año;
        public string director;
        public string país;
        
        //Constructores
        public Pelicula()
        {
            
        }
        public Pelicula(string titulo, Int16 año)
        {
            this.titulo = titulo;
            this.año = año;
        }
        //Métodos
        public string GetTitulo()
        {
            return titulo;
        }
        public int GetAño()
        {
            return año;
        }
        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public void SetAño(Int16 año)
        {
            this.año = año;
        }
        public void Imprime()
        {
             Console.WriteLine($"{titulo} ({año})");
        }
        public void ImprimeActores()
        {
            foreach (Actor a in actores)
             {
               Console.WriteLine(a);
             }
        }
        public void AgregaActor(Actor actor)
        {
           actores.Add(actor);
        }


    }

    public class Actor
    {
        //Propiedades
        private string Nombre;
        private Int16 AñoActor; 

        //Constructores
        public Actor(string Nombre, Int16 AñoActor)
        {
            this.Nombre = Nombre;
            this.AñoActor = AñoActor;
        }

        //Métodos 
        public override string ToString(){
            return $"{Nombre} ({AñoActor})";
        }  
        public Int16 GetAñoActor()
        {
            return AñoActor;
        }
        public void SetAñoActor(Int16 a)
        {
            AñoActor = a;
        }
        public string GetNombre()
        {
            return Nombre;
        }
        public void SetNombre(string n)
        {
            Nombre = n;
        }
        public string nombre
        { 
            get {return Nombre;}
            set {Nombre = value;}
        }
        public Int16 añoActor
        { 
            get {return AñoActor;}
            set {AñoActor = value;}
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

        class prueh
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
}
