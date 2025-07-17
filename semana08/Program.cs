using System;

class Program
{
    static void Main(string[] args)
    {
        // Creo una instancia de la atracción
        Atraccion montañaRusa = new Atraccion();

        // Simulo la llegada de 32 personas para ver qué pasa al exceder la capacidad
        for (int i = 1; i <= 32; i++)
        {
            // Creo cada persona con un nombre identificador
            Persona persona = new Persona($"Persona {i}");

            // Intento agregarla a la fila
            montañaRusa.AgregarPersona(persona);
        }

        // Comienzo la atracción y dejo que las personas suban en orden
        montañaRusa.IniciarAtraccion();
    }
}