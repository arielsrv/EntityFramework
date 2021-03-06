﻿using System;
using System.Collections.Generic;

namespace Yield
{
    public class Program
    {
        private static void Main(string[] args)
        {
            IEnumerable<string> messages = GetMessages();

            // Lazy Loading ó carga diferida
            foreach (string message in messages)
            {
                Console.WriteLine(message);
            }
        }

        private static IEnumerable<string> GetMessages()
        {
            yield return "hola";
            yield return "este";
            yield return "es";
            yield return "un ejemplo";
            yield return "del uso de ";
            yield return "la instruccion";
            yield return "yield";
        }

        /// <summary>
        /// Ejemplo de Mensajes cargados por completo en Memoria
        /// </summary>
        /// <returns></returns>
        //private static IEnumerable<string> GetMessages()
        //{
        //    return new List<string>
        //    {
        //        "hola",
        //        "este",
        //        "es",
        //        "un ejemplo",
        //        "del uso de ",
        //        "la instruccion",
        //        "yield"
        //    };
        //}
    }
}