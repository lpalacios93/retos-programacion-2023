﻿/*
 * Escribe un programa que muestre por consola (con un print) los
 * números de 1 a 100 (ambos incluidos y con un salto de línea entre
 * cada impresión), sustituyendo los siguientes:
 * - Múltiplos de 3 por la palabra "fizz".
 * - Múltiplos de 5 por la palabra "buzz".
 * - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".

    .NET SDK 6 - dotnet run
 */

for (int number = 1; number <= 100; number++)
{

    if (number % 3 == 0 && number % 5 == 0)
    {
        Console.WriteLine("fizzbuzz");
    }
    else if (number % 3 == 0)
    {
        Console.WriteLine("fizz");
    }
    else if (number % 5 == 0)
    {
        Console.WriteLine("buzz");
    }
    else
    {
        Console.WriteLine(number);
    }
}