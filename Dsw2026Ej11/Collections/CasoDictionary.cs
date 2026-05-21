namespace Dsw2026Ej11.Collections;

using Dsw2026Ej11.Domain; // Necesario para poder usar la clase Alumno
using System;
using System.Collections.Generic;
using global::Dsw2026Ej11.Domain;


//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave

public class CasoDictionary
{
    
    private Dictionary<int, Alumno> diccionarioAlumnos;

    
    public CasoDictionary()
    {
        diccionarioAlumnos = new Dictionary<int, Alumno>();
    }

    
    public void AgregarAlumno(Alumno alumno)
    {
        
        if (alumno != null && !diccionarioAlumnos.ContainsKey(alumno.Id))
        {
            diccionarioAlumnos.Add(alumno.Id, alumno);
        }
        else
        {
            Console.WriteLine($"No se pudo agregar: El legajo {alumno?.Id} ya existe o el alumno es invalido.");
        }
    }

    
    public Alumno BuscarAlumno(int legajo)
    {
       
        if (diccionarioAlumnos.TryGetValue(legajo, out Alumno alumnoEncontrado))
        {
            return alumnoEncontrado;
        }

        return null;
    }

    
    public Dictionary<int, Alumno> ObtenerDiccionario()
    {
        return diccionarioAlumnos;
    }

   
    public void EliminarAlumno(int legajo)
    { 
        bool eliminado = diccionarioAlumnos.Remove(legajo);

        if (!eliminado)
        {
            Console.WriteLine($"No se pudo eliminar: El legajo {legajo} no se encontro en el diccionario.");
        }
    }
}
