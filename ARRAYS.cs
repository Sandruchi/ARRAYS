using System;

public class Estudiante
{
    // Propiedades del estudiante
    public int Id { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public string Direccion { get; set; }
    public string[] Telefonos { get; set; }

    // Constructor de la clase
    public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
    {
        Id = id;
        Nombres = nombres;
        Apellidos = apellidos;
        Direccion = direccion;
        Telefonos = telefonos;
    }

    // Método para mostrar información del estudiante
    public void MostrarInformacion()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombre: {Nombres} {Apellidos}");
        Console.WriteLine($"Dirección: {Direccion}");
        Console.WriteLine("Teléfonos:");
        foreach (var tel in Telefonos)
        {
            Console.WriteLine($"- {tel}");
        }
    }
}

class Program
{
    static void Main()
    {
        // Creamos un array de teléfonos
        string[] telefonos = { "5551234567", "5559876543", "5551122334" };

        // Instanciamos un objeto de tipo Estudiante
        Estudiante estudiante = new Estudiante(
            1,
            "Andrea",
            "López Martínez",
            "Av. Siempre Viva 742",
            telefonos
        );

        // Mostramos la información del estudiante
        estudiante.MostrarInformacion();
    }
}
