using System;

namespace PracticaConsstructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno("Juanito", "12345");

            Console.WriteLine("Alumno 1:");
            Console.WriteLine("Nombre: " + alumno1.Nombre);
            Console.WriteLine("Matricula: " + alumno1.Matricula);

            Console.WriteLine("Alumno 2:");
            Console.WriteLine("Nombre: " + alumno2.Nombre);
            Console.WriteLine("Matricula: " + alumno2.Matricula);

            alumno2.Nombre = "Rominice";
            alumno2.Matricula = "100718";

            Alumno alumno3 = new Alumno();
            alumno3.Nombre = "Lupita";
            alumno3.Matricula = "050518";

            Console.WriteLine("Alumno 3:");
            Console.WriteLine("Nombre: " + alumno3.Nombre);
            Console.WriteLine("Matricula: " + alumno3.Matricula);

            Console.Read();
        }
    }
}
