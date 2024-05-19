# Hola Mundo en .NET 👋🌍

Este proyecto es un simple "Hola, Mundo" en .NET, con un ejemplo adicional de cómo usar la biblioteca `Newtonsoft.Json` para serializar y deserializar un objeto JSON. 🌟

## Descripción

El proyecto consiste en una aplicación de consola que:

1. Imprime un mensaje de "Hola, Mundo 😊".
2. Crea un objeto anónimo.
3. Serializa el objeto a formato JSON usando `Newtonsoft.Json`.
4. Deserializa el JSON de vuelta a un objeto dinámico.
5. Imprime el JSON y el objeto deserializado en la consola.

### Código Principal

```csharp
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
```

## Instalación 🛠️

### Prerrequisitos

- Tener instalado el [SDK de .NET](https://dotnet.microsoft.com/download).
- Tener instalado [Visual Studio Code](https://code.visualstudio.com/) o cualquier otro editor de tu preferencia.

### Clonar el Repositorio

Puedes clonar este repositorio usando el siguiente comando:

```bash
git clone https://github.com/Irina-Ichim/Hola-Mundo-.Net-.git
```

### Crear un Proyecto de Consola en .NET

1. Abrir una terminal.
2. Navegar al directorio donde deseas crear tu proyecto.
3. Ejecutar el siguiente comando para crear un nuevo proyecto de consola:
    
```bash
    dotnet new console -o MiPrimerProyecto
    ```

1. Navegar a la carpeta del proyecto:
   
    ```bash
    cd MiPrimerProyecto
    ```

### Restaurar Paquetes NuGet

1. Para restaurar los paquetes NuGet necesarios, ejecutar:

    ```bash
    dotnet restore
    ```

### Compilar el Proyecto

1. Para compilar el proyecto, ejecutar:

    ```bash
    dotnet build
    ```

### Ejecutar el Proyecto

1. Para ejecutar el proyecto, ejecutar:

    ```bash
    dotnet run
    ```

## Uso de NuGet 📦

NuGet es el administrador de paquetes para la plataforma de desarrollo .NET. Permite a los desarrolladores compartir y consumir código en forma de paquetes.

### Instalar un Paquete NuGet

1. Para agregar un paquete NuGet, como `Newtonsoft.Json`, ejecutar:

    ```bash
    dotnet add package Newtonsoft.Json
    ```

## Comandos Útiles de .NET 🚀

### Crear un Nuevo Proyecto

```bash
dotnet new console -o NombreDelProyecto
```

### Restaurar Paquetes NuGet

```bash
dotnet restore
```

### Compilar el Proyecto

```bash
dotnet build
```

### Ejecutar el Proyecto

```bash
dotnet run
```

### Agregar un Paquete NuGet

```bash
dotnet add package NombreDelPaquete
```

## Enlaces Útiles 🔗

- [Documentación de .NET](https://docs.microsoft.com/en-us/dotnet/)
- [Documentación de NuGet](https://docs.microsoft.com/en-us/nuget/)
- [Tutorial: Crear una aplicación de consola con .NET](https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial/intro)
```
