# MusicLyrics
Una libreria para C# que te permite traer la letra de una canción

Search in the nuget package:  [MusicLyrics](https://www.nuget.org/packages/MusicLyrics/)

***DOCUMENTACIÓN PARA MUSICLYRICS 1.0.2***

## Importante: Esta librera puede ser asincrona o sincrona.

Una vez instales el paquete, tienes que saber que solo hay una clase con dos metodos:

-LyricsFinder

## LyricsFinder
Es una clase estatica y tiene dos funciones, una asincrona y otra sincrona:

```C#
using System;
using System.Threading.Tasks;
using MusicLrics;

namespace MusicLyrics
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Esta es la función sincrona
            string lyricsSync = LyricsFinder.GetLyrics("Author","Song");
            
            //Esta es la asincrona
            string lyricsAsync = await LyricsFinder.GetLyricsAsync("Author","Song");
            
            //Importante: Si llega a salir algo mal se devuelve un string indicando el error
        }
    }
}
```

Eso es todo por la 1.0.2

Gracias por descargar este paquete

Author: Santiago Mendoza

```C#
using System;

namespace MatrixMa
{
    class Principal
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Muchas gracias😎");
            return Task.End;
        }
    }
}
```
