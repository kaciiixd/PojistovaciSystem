using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojistovaciSystem.Pomocnici
{
    internal class VypisTextu
    {
        /// <summary>
        /// Metoda pro vypsání textu
        /// </summary>
        /// <param name="text"></param>
        /// <param name="foregroundColor"></param>
        /// <param name="backgroundColor"></param>
        public static void VypisText(string text, ConsoleColor foregroundColor, ConsoleColor backgroundColor)
        {
            ConsoleColor originalForegroundColor = Console.ForegroundColor;  //Uchování původní foreground barvy
            ConsoleColor originalBackgroundColor = Console.BackgroundColor;  //Uchování původní background barvy

            Console.ForegroundColor = foregroundColor;  //Nastavení foreground barvy na specifikovanou barvu
            Console.BackgroundColor = backgroundColor;  //Nastavení background barvy na specifikovanou barvu

            Console.Write(text);    //Vypsání specifikovaného textu za použití modifikovaných barev

            Console.ForegroundColor = originalForegroundColor;  //Obnovení původní foreground barvy
            Console.BackgroundColor = originalBackgroundColor;  //Obnovení původní background barvy

        }
    }
}
