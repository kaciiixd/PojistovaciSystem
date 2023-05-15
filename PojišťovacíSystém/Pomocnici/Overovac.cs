using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace PojistovaciSystem.Pomocnici
{
    public static class Overovac
    {
        /// <summary>
        /// Metoda pro ověření věku
        /// </summary>
        /// <returns></returns>
        public static int OverVek()
        {
            int vek;
            bool isValidVek = false;

            do
            {
                VypisTextu.VypisText("Zadejte věk: ", ConsoleColor.DarkCyan, ConsoleColor.Cyan);    //Vyžádání uživatelského inputu - věk pojištěné osoby
                VypisTextu.VypisText(" ", ConsoleColor.DarkCyan, ConsoleColor.Black);

                if (!int.TryParse(Console.ReadLine(), out vek) || vek <= 0) //Ověření, že bylo zadáno kladné číslo
                {
                    AnimatorTextu.AnimujText("Chybně zadaný věk. Zadejte prosím platný věk.", ConsoleColor.DarkRed);    //Zobrazení chybové hlášky pro nevalidní input
                    Console.WriteLine();
                }
                else
                {
                    if (vek > 99)   //Ověření, zda zadaný věk není příliš vysoký
                    {
                        AnimatorTextu.AnimujText("Tento věk se zdá být příliš vysoký. Je to správně?", ConsoleColor.DarkRed);   //Ověření, zda je zadané číslo validní
                        AnimatorTextu.AnimujText("Ano/Ne: ", ConsoleColor.DarkRed);
                        string confirmation = Console.ReadLine();
                        if (confirmation.ToLower() != "ano")    //Pokud odpověď na ověření věku není "ano", pokračování cyklu pro znovuzadání věku
                        {
                            continue;
                        }
                    }

                    isValidVek = true;  //Věk je validní, vyskočit z cyklu
                }
            } while (!isValidVek);

            return vek; //Vrácení validovaného věku
        }

        /// <summary>
        /// Metoda pro ověření telefonního čísla
        /// </summary>
        /// <returns></returns>
        public static int OverTelefonniCislo()
        {
            int telefonniCislo;
            bool isValidTelefonniCislo = false;

            do
            {
                VypisTextu.VypisText("Zadejte telefonní číslo: ", ConsoleColor.DarkCyan, ConsoleColor.Cyan);    //Vyžádání uživatelského inputu - telefonní číslo pojištěné osoby
                VypisTextu.VypisText(" +420 ", ConsoleColor.DarkCyan, ConsoleColor.Black);
                if (!int.TryParse(Console.ReadLine(), out telefonniCislo) || telefonniCislo.ToString().Length != 9) //Ověření, zda je číslo validní (9místné)
                {
                    AnimatorTextu.AnimujText("Chybně zadané telefonní číslo. Zadejte prosím platné telefonní číslo.", ConsoleColor.DarkRed);    //Zobrazení chybové hlášky pro nevalidní input
                    Console.WriteLine();
                }
                else
                {
                    isValidTelefonniCislo = true;   //Telefonní číslo je validní, vyskočit z cyklu
                }
            } while (!isValidTelefonniCislo);

            return telefonniCislo;  //Vrácení validovaného čísla
        }
    }
}

