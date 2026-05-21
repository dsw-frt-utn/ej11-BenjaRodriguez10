using Dsw2026Ej11.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private List<Alumno> alumnos;
    public CasoList()
    {
        alumnos = new List<Alumno>();
    }
    public void AgregarAlumno(Alumno alumno)
    {
        alumnos.Add(alumno);
    }
    public List<Alumno> ObtenerListaAlumnos()
    {
        return alumnos;
    }

    public Alumno BuscarAlumnoPorNombre(string nombre)
    {
        return alumnos.FirstOrDefault(a => a.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
    }

    public void EliminarAlumno(Alumno alumno)
    {
        alumnos.Remove(alumno);
    }

    public void EliminarAlumnoEnPosicion(int posicion)
    {
        if (posicion >= 0 && posicion < alumnos.Count)
        {
            alumnos.RemoveAt(posicion);
        }
        else
        {
            Console.WriteLine("La posición ingresada no es válida.");
        }
    }
}
