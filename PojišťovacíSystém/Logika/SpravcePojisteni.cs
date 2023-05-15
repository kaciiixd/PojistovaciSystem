using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using PojistovaciSystem.Modely;
using PojistovaciSystem.Pomocnici;

namespace PojistovaciSystem.Logika
{
    public class SpravcePojisteni
    {
        /// <summary>
        /// List pro uchovávání pojištěných osob
        /// </summary>
        private List<PojistenaOsoba> pojisteneOsoby = new List<PojistenaOsoba>();


        /// <summary>
        /// Metoda pro přidání pojištěné osoby
        /// </summary>
        public void PridatPojistenouOsobu()
        {
            Console.WriteLine();
            Console.WriteLine();

            //Zadání jména
            VypisTextu.VypisText("Zadejte jméno:", ConsoleColor.DarkCyan, ConsoleColor.Cyan);
            VypisTextu.VypisText(" ", ConsoleColor.DarkCyan, ConsoleColor.Black);
            string jmeno = Console.ReadLine();  //Uložení inputu jako jméno

            //Zadání příjmení
            VypisTextu.VypisText("Zadejte příjmení: ", ConsoleColor.DarkCyan, ConsoleColor.Cyan);
            VypisTextu.VypisText(" ", ConsoleColor.DarkCyan, ConsoleColor.Black);
            string prijmeni = Console.ReadLine();   //Uložení inputu jako příjmení

            //Ověření správnosti a získání inputu
            int vek = Overovac.OverVek();

            //Ověření správnosti a získání inputu
            int telefonniCislo = Overovac.OverTelefonniCislo();

            //Přidání pojištěné osoby do Listu
            PojistenaOsoba osoba = new PojistenaOsoba(jmeno, prijmeni, vek, telefonniCislo);    //Vytvoření nové instance PojistenaOsoba
            pojisteneOsoby.Add(osoba);

            //Potvrzení o úspěšném vytvoření a uložení pojištěné osoby
            Console.WriteLine();
            AnimatorTextu.AnimujText("Pojištěná osoba byla úspěšně přidána!", ConsoleColor.Green);

            //Zobrazení možností Návrat do menu/Konec
            Menu.ZobrazitMoznosti(this);

        }


        /// <summary>
        /// Metoda pro zobrazení seznamu pojištěných osob
        /// </summary>
        public void SeznamVsechPojistenychOsob()
        {
            Console.WriteLine();
            Console.WriteLine();

            //Ošetření možnosti existence 0 záznamů v kolekci
            if (pojisteneOsoby.Count == 0)
            {
                Console.WriteLine();
                AnimatorTextu.AnimujText("Nebyly nalezeny žádné pojištěné osoby.", ConsoleColor.DarkRed);
                Console.WriteLine();
            }
            
            //Ošetření možnosti existence více než 0 záznamů v kolekci
            else
            {
                Console.WriteLine();
                VypisTextu.VypisText("Seznam všech pojištěných osob:", ConsoleColor.White, ConsoleColor.DarkGreen);
                Console.WriteLine();
                Console.WriteLine();

                //Vypsání seznamu pojištěných osob
                foreach (var osoba in pojisteneOsoby)
                {
                    Thread.Sleep(300);

                    //Vypsání jména
                    VypisTextu.VypisText("Jméno: ", ConsoleColor.DarkGreen, ConsoleColor.Black);
                    VypisTextu.VypisText(osoba.Jmeno + "    ", ConsoleColor.White, ConsoleColor.Black);
                    
                    //Vypsání příjmení
                    VypisTextu.VypisText("Příjmení: ", ConsoleColor.DarkGreen, ConsoleColor.Black);
                    VypisTextu.VypisText(osoba.Prijmeni + "    ", ConsoleColor.White, ConsoleColor.Black);
                    
                    //Vypsání věku
                    VypisTextu.VypisText("Věk: ", ConsoleColor.DarkGreen, ConsoleColor.Black);
                    VypisTextu.VypisText(osoba.Vek.ToString() + "    ", ConsoleColor.White, ConsoleColor.Black);
                    
                    //Vypsání telefonního čísla
                    VypisTextu.VypisText("Telefonní číslo: +420 ", ConsoleColor.DarkGreen, ConsoleColor.Black);
                    VypisTextu.VypisText(osoba.TelefonniCislo.ToString() + "    ", ConsoleColor.White, ConsoleColor.Black);

                    Console.WriteLine();
                }
            }

            Thread.Sleep(1000);

            //Zobrazení možností Návrat do menu/Konec
            Menu.ZobrazitMoznosti(this);
        }


        /// <summary>
        /// Metoda pro vyhledání pojištěné osoby podle jména a příjmení
        /// </summary>
        public void VyhledatPodleJmenaPrijmeni()
        {
            Console.WriteLine();
            Console.WriteLine();

            //Vyžádání inputu
            VypisTextu.VypisText("Zadejte jméno a příjmení(ve formátu [Jméno Příjmení]): ", ConsoleColor.DarkYellow, ConsoleColor.Yellow);
            VypisTextu.VypisText(" ", ConsoleColor.DarkYellow, ConsoleColor.Black);
            string jmenoPrijmeni = Console.ReadLine();  //uložení proměnné

            //Hledání pojištěné osoby
            bool nalezeno = false;

            //Cyklus pro hledání v kolekci
            foreach (var osoba in pojisteneOsoby)
            {
                //V případě nalezení v kolekci vypsání dat
                if (string.Equals($"{osoba.Jmeno} {osoba.Prijmeni}", jmenoPrijmeni, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine();

                    //Vypsání jména
                    VypisTextu.VypisText("Jméno: ", ConsoleColor.DarkYellow, ConsoleColor.Black);
                    VypisTextu.VypisText(osoba.Jmeno + "    ", ConsoleColor.White, ConsoleColor.Black);
                    
                    //Vypsání příjmení
                    VypisTextu.VypisText("Příjmení: ", ConsoleColor.DarkYellow, ConsoleColor.Black);
                    VypisTextu.VypisText(osoba.Prijmeni + "    ", ConsoleColor.White, ConsoleColor.Black);
                    
                    //Vypsání věku
                    VypisTextu.VypisText("Věk: ", ConsoleColor.DarkYellow, ConsoleColor.Black);
                    VypisTextu.VypisText(osoba.Vek.ToString() + "    ", ConsoleColor.White, ConsoleColor.Black);
                    
                    //Vypsání telefonního čísla
                    VypisTextu.VypisText("Telefonní číslo: +420 ", ConsoleColor.DarkYellow, ConsoleColor.Black);
                    VypisTextu.VypisText(osoba.TelefonniCislo.ToString() + "    ", ConsoleColor.White, ConsoleColor.Black);

                    Console.WriteLine();

                    nalezeno = true;
                }
            }
            Console.WriteLine();

            //Podmínka pro případ nenalezení v kolekci
            if (!nalezeno)
            {
                Console.WriteLine();
                AnimatorTextu.AnimujText("Pojištěná osoba nebyla nalezena.", ConsoleColor.DarkRed);

            }

            Thread.Sleep(1000);

            //Zobrazení možností Návrat do menu/Konec
            Menu.ZobrazitMoznosti(this);
        }
    }
}
