using System;

public class Persona
{
    // Declaro una propiedad para almacenar el nombre de la persona
    public string Nombre { get; set; }

    // Constructor: cuando creo una nueva persona, asigno su nombre
    public Persona(string nombre)
    {
        Nombre = nombre;
    }
}