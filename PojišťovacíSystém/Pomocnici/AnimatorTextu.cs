using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojistovaciSystem.Pomocnici
{
    internal class AnimatorTextu
    {
        public static void AnimujText(string text, ConsoleColor foregroundColor)
        {
            ConsoleColor originalColor = Console.ForegroundColor;   //Uchování původní foreground barvy
            Console.ForegroundColor = foregroundColor;  //Nastavení foreground barvy na specifikovanou barvu

            foreach (char c in text)    //Iterace každého znaku v textu
            {
                Console.Write(c);   //Vypsání znaku do konzole
                Thread.Sleep(30);   //Krátká pauza pro vytvoření efektu animace 
            }

            Console.ForegroundColor = originalColor;    //Obnovení původní foreground barvy 
        }
    }
}
