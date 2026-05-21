using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        Console.WriteLine("--- PRUEBAS CON LIST ---");
        CasoList gestorLista = new CasoList();

        Alumno a1 = new Alumno(1, "Ana", 8.5);
        Alumno a2 = new Alumno(2, "Carlos", 7.0);
        Alumno a3 = new Alumno(3, "Beatriz", 9.2);

        gestorLista.AgregarAlumno(a1);
        gestorLista.AgregarAlumno(a2);
        gestorLista.AgregarAlumno(a3);

        Console.WriteLine("\nLista inicial:");
        foreach (var alumno in gestorLista.ObtenerListaAlumnos())
        {
            Console.WriteLine(alumno.ToString());
        }

        Console.WriteLine("\nBuscando a 'Carlos':");
        Alumno encontrado = gestorLista.BuscarAlumnoPorNombre("Carlos");
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

        Console.WriteLine("\nBuscando a 'Pedro':");
        Alumno noEncontrado = gestorLista.BuscarAlumnoPorNombre("Pedro");
        if (noEncontrado == null)
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\nEliminando a Carlos...");
        gestorLista.EliminarAlumno(a2); 
        foreach (var alumno in gestorLista.ObtenerListaAlumnos())
        {
            Console.WriteLine(alumno.ToString());
        }

        Console.WriteLine("\nEliminando el primer elemento (Posición 0)...");
        gestorLista.EliminarAlumnoEnPosicion(0);
        foreach (var alumno in gestorLista.ObtenerListaAlumnos())
        {
            Console.WriteLine(alumno.ToString());
        }
        Console.WriteLine("------------------------\n");
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        Console.WriteLine("--- PRUEBAS CON DICTIONARY ---");
        CasoDictionary gestorDict = new CasoDictionary();

        Alumno a1 = new Alumno(101, "Daniel", 6.5);
        Alumno a2 = new Alumno(102, "Elena", 8.8);
        Alumno a3 = new Alumno(103, "Fernando", 7.4);

        gestorDict.AgregarAlumno(a1);
        gestorDict.AgregarAlumno(a2);
        gestorDict.AgregarAlumno(a3);

        Console.WriteLine("\nDiccionario inicial:");
        foreach (var kvp in gestorDict.ObtenerDiccionario())
        {
            Console.WriteLine(kvp.Value.ToString());
        }

        Console.WriteLine("\nBuscando legajo 102:");
        Alumno encontrado = gestorDict.BuscarAlumno(102);
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

        Console.WriteLine("\nBuscando legajo 999:");
        Alumno noEncontrado = gestorDict.BuscarAlumno(999);
        if (noEncontrado == null)
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\nEliminando legajo 101...");
        gestorDict.EliminarAlumno(101);
        foreach (var kvp in gestorDict.ObtenerDiccionario())
        {
            Console.WriteLine(kvp.Value.ToString());
        }
        Console.WriteLine("------------------------------\n");
    }

    public static void EjemploLinq()
    {
        Console.WriteLine("--- PRUEBAS CON LINQ ---");
        CasoLinq gestorLinq = new CasoLinq();

        Console.WriteLine("\n1. Primer libro:");
        Console.WriteLine(gestorLinq.GetPrimero()?.Titulo);

        Console.WriteLine("\n2. Último libro:");
        Console.WriteLine(gestorLinq.GetUltimo()?.Titulo);

        Console.WriteLine("\n3. Suma total de precios:");
        Console.WriteLine($"{gestorLinq.GetTotalPrecios():C}");

        Console.WriteLine("\n4. Promedio de precios:");
        Console.WriteLine($"{gestorLinq.GetPromedioPrecios():C}");

        Console.WriteLine("\n5. Libros con ID > 15:");
        foreach (var libro in gestorLinq.GetListById())
        {
            Console.WriteLine($"- {libro.Titulo}");
        }

        Console.WriteLine("\n6. Lista de Títulos y Precios:");
        foreach (var texto in gestorLinq.GetLibros())
        {
            Console.WriteLine(texto);
        }

        Console.WriteLine("\n7. Libro más caro:");
        var masCaro = gestorLinq.GetMayorPrecio();
        Console.WriteLine($"{masCaro?.Titulo} ({masCaro?.Precio:C})");

        Console.WriteLine("\n8. Libro más barato:");
        var masBarato = gestorLinq.GetMenorPrecio();
        Console.WriteLine($"{masBarato?.Titulo} ({masBarato?.Precio:C})");

        Console.WriteLine("\n9. Libros con precio mayor al promedio:");
        foreach (var libro in gestorLinq.GetMayorPromedio())
        {
            Console.WriteLine($"- {libro.Titulo} ({libro.Precio:C})");
        }

        Console.WriteLine("\n10. Libros ordenados alfabéticamente (Z-A):");
        foreach (var libro in gestorLinq.GetLibrosOrdenadosPorTituloDesc())
        {
            Console.WriteLine($"- {libro.Titulo}");
        }
        Console.WriteLine("------------------------\n");
    }
}
    