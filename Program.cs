using Newtonsoft.Json;
using System;

public class Program
{
    public static void Main()
    {
        // Mensaje inicial
        Console.WriteLine("Hola, Mundo😊!");

        // Crear y serializar objeto
        var objeto = new { Nombre = "Irina", Edad = 40 };
        string json = JsonConvert.SerializeObject(objeto);
        Console.WriteLine("Objeto serializado a JSON:");
        Console.WriteLine(json);

        // Deserializar el JSON de vuelta a un objeto dinámico
        var deserializado = JsonConvert.DeserializeObject(json);
        Console.WriteLine("Objeto deserializado desde JSON:");
        Console.WriteLine(deserializado?.ToString());
    }
}
