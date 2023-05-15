using PojistovaciSystem.Pomocnici;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojistovaciSystem.Logika
{
    public class Menu
    {
        /// <summary>
        /// Metoda pro výběr možnosti z hlavního menu
        /// </summary>
        /// <param name="spravcePojisteni"></param>
        public static void StartMenu(SpravcePojisteni spravcePojisteni)
        {
            //Cyklus pro zobrazení hlavního menu
            bool konec = false;
            
            while (!konec)
            {
                //Zavolání metody pro vypsání hlavního menu
                ZobrazitMenu();
                string volba = Console.ReadLine();

                //Switch pro výběr možnosti
                switch (volba)
                {
                    //Možnost "1" - Zavolání metody pro přidání pojištěného
                    case "1":
                        spravcePojisteni.PridatPojistenouOsobu();
                        break;

                    //Možnost "2" - Zavolání metody pro zobrazení seznamu pojištěných
                    case "2":
                        spravcePojisteni.SeznamVsechPojistenychOsob();
                        break;

                    //Možnost "3" - Zavolání metody pro vyhledání pojištěného podle jména a příjmení
                    case "3":
                        spravcePojisteni.VyhledatPodleJmenaPrijmeni();
                        break;

                    //Možnost "4" - Konec
                    case "4":
                        konec = true;
                        break;

                    //Defaultní možnost pro případ neplatného výběru možnosti
                    default:
                        Console.WriteLine();
                        AnimatorTextu.AnimujText("Neplatná volba. Zadejte prosím číslo od 1 do 4.", ConsoleColor.DarkRed);
                        Console.WriteLine();
                        break;
                }

                Console.WriteLine();
            }
            ///Ukončení programu
            ///Vymazání konzole
            Console.Clear();
            //Vypsání textu o ukončování programu
            AnimatorTextu.AnimujText("Program se ukončuje...", ConsoleColor.Green);
            //Ukončení programu
            Environment.Exit(0);
        }

        /// <summary>
        /// Metoda pro vyypsání hlavního menu
        /// </summary>
        public static void ZobrazitMenu()
        {
            //Vypsání nadpisu "Správa pojištění"
            VypisTextu.VypisText("  ____              __                           _ _ \\\\//_   \\\\//      __\r\n / ___| _ __  _ __ /_/___   ____ _   _ __   ___ (_|_)_\\/| |_  \\/ _ __ /_/\r\n \\___ \\| '_ \\| '__/ _` \\ \\ / / _` | | '_ \\ / _ \\| | / __| __/ _ \\ '_ \\| |\r\n  ___) | |_) | | | (_| |\\ V / (_| | | |_) | (_) | | \\__ \\ ||  __/ | | | |\r\n |____/| .__/|_|  \\__,_| \\_/ \\__,_| | .__/ \\___// |_|___/\\__\\___|_| |_|_|\r\n       |_|                          |_|       |__/                       ", ConsoleColor.Magenta, ConsoleColor.Black);
            Console.WriteLine();
            Console.WriteLine();

            //Vypsání nadpisu "Menu"
            VypisTextu.VypisText("░█▄█░█▀▀░█▀█░█░█\r\n░█░█░█▀▀░█░█░█░█\r\n░▀░▀░▀▀▀░▀░▀░▀▀▀", ConsoleColor.DarkMagenta, ConsoleColor.Black);
            Console.WriteLine();

            //Vypsání možností v hlavním menu
            VypisTextu.VypisText("1. Přidat pojištěnou osobu", ConsoleColor.DarkCyan, ConsoleColor.Black);
            Console.WriteLine();

            VypisTextu.VypisText("2. Seznam všech pojištěných osob", ConsoleColor.DarkGreen, ConsoleColor.Black);
            Console.WriteLine();

            VypisTextu.VypisText("3. Vyhledat podle jména a příjmení", ConsoleColor.DarkYellow, ConsoleColor.Black);
            Console.WriteLine();

            VypisTextu.VypisText("4. Ukončit", ConsoleColor.DarkGray, ConsoleColor.Black);
            Console.WriteLine();
            Console.WriteLine();

            Thread.Sleep(200);

            //Input - výběr z možností hlavního menu
            AnimatorTextu.AnimujText("Zadejte svůj výběr (1-4): ", ConsoleColor.Magenta);
        }

        /// <summary>
        /// Metoda pro vypsání pomocného menu - Zpět do hlavního menu/Konec
        /// </summary>
        /// <param name="spravcePojisteni"></param>
        public static void ZobrazitMoznosti(SpravcePojisteni spravcePojisteni)
        {
            //Skrytí kurzoru 
            Console.CursorVisible = false;

            int selectedOption = 1; //Momentálně zvolená možnost
            int cursorTop = Console.CursorTop;  //Uchování počáteční pozice kurzoru

            ConsoleKey key;
            do
            {
                Console.WriteLine();
                Console.WriteLine();

                //Zvýraznění vybrané možnosti
                Console.ForegroundColor = selectedOption == 1 ? ConsoleColor.Cyan : ConsoleColor.Gray;
                Console.WriteLine("Zpět na menu");

                Console.ForegroundColor = selectedOption == 2 ? ConsoleColor.Red : ConsoleColor.Gray;
                Console.WriteLine("Ukončit");

                Console.SetCursorPosition(0, cursorTop);    //Nastavení pozice kurzoru na počáteční pozici
                key = Console.ReadKey(true).Key;    //Přečtení vybrané možnosti

                //Aktualizace vybrané možnosti na základě uživatelského inputu
                if (key == ConsoleKey.UpArrow && selectedOption > 1)
                    selectedOption--;
                else if (key == ConsoleKey.DownArrow && selectedOption < 2)
                    selectedOption++;

            } while (key != ConsoleKey.Enter);  //Pokračování cyklu dokud uživatel nestiskne Enter

            Console.CursorVisible = true;   //Znovuzobrazení kurzoru

            if (selectedOption == 1)
            {
                Console.Clear();
                ZpetDoMenu(spravcePojisteni);   //Zpět do hlavního menu
            }
            else if (selectedOption == 2)
            {
                Console.Clear();
                AnimatorTextu.AnimujText("Program se ukončuje...", ConsoleColor.Green);
                Environment.Exit(0); //Ukončení programu
            }
        }

        /// <summary>
        /// Metoda pro návrat do hlavního menu
        /// </summary>
        /// <param name="spravcePojisteni"></param>
        private static void ZpetDoMenu(SpravcePojisteni spravcePojisteni)
        {
            Console.Clear();    //Vymazání konzole
            StartMenu(spravcePojisteni);    //Návrat do hlavního menu
        }


    }
}
