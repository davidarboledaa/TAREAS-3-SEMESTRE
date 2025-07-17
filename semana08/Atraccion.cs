using System;
using System.Collections.Generic;

public class Atraccion
{
    // Defino la capacidad total de la atracción: 30 asientos
    private const int CAPACIDAD = 30;

    // Mantengo una lista para llevar el orden de las personas asignadas
    private Queue<Persona> fila = new Queue<Persona>();

    // Método para añadir una persona a la cola, si hay espacio
    public void AgregarPersona(Persona persona)
    {
        // Me aseguro de que aún hay asientos disponibles
        if (fila.Count < CAPACIDAD)
        {
            fila.Enqueue(persona); // Añado a la persona en la cola
            Console.WriteLine($"Asiento asignado a: {persona.Nombre}");
        }
        else
        {
            Console.WriteLine($"Lo siento {persona.Nombre}, los asientos ya están todos ocupados.");
        }
    }

    // Método para iniciar el acceso a la atracción en orden
    public void IniciarAtraccion()
    {
        Console.WriteLine("\n🔔 La atracción ha comenzado:");
        int contador = 1;

        // Voy sacando a las personas de la fila en orden
        while (fila.Count > 0)
        {
            Persona p = fila.Dequeue();
            Console.WriteLine($"Asiento #{contador}: {p.Nombre} subió a la atracción.");
            contador++;
        }
    }
}