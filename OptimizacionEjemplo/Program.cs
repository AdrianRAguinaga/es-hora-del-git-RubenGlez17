using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // Crear una tabla de hash para almacenar registros de alumnos
        Hashtable alumnos = new Hashtable();

        // Capturar los datos de registro de alumnos
        Console.Write("Ingrese el número de alumnos que desea registrar: ");
        int numAlumnos = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        // Medir el tiempo de ejecución del programa
        var watch = System.Diagnostics.Stopwatch.StartNew();

        for (int i = 0; i < numAlumnos; i++)
        {
            Console.WriteLine("Registro de alumno {0}", i + 1);

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Número de identificación: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Carrera: ");
            string carrera = Console.ReadLine();

            Console.WriteLine();

            // Almacenar los datos de registro en la tabla de hash
            alumnos.Add(id, new Alumno(nombre, carrera));
        }

        // Leer los datos de registro de los alumnos
        Console.WriteLine("Alumnos registrados:");
        Console.WriteLine("ID \t Nombre \t\t Carrera");

        foreach (DictionaryEntry alumno in alumnos)
        {
            Console.WriteLine("{0} \t {1,-20} \t {2}", alumno.Key, ((Alumno)alumno.Value).Nombre, ((Alumno)alumno.Value).Carrera);
        }

        // Detener el temporizador y mostrar el tiempo de ejecución
        watch.Stop();
        Console.WriteLine("\nTiempo de ejecución del programa: {0} ms", watch.ElapsedMilliseconds);

        Console.ReadKey();
    }
}

class Alumno
{
    public string Nombre { get; set; }
    public string Carrera { get; set; }

    public Alumno(string nombre, string carrera)
    {
        Nombre = nombre;
        Carrera = carrera;
    }
}


