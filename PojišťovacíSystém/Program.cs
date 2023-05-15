using PojistovaciSystem.Logika;
using PojistovaciSystem.Pomocnici;
using System;

namespace PojistovaciSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Title = "Správa pojištění"; //Nastavení titulku okna konzole

                SpravcePojisteni spravcePojisteni = new SpravcePojisteni(); //Vytvoření instance třídy 'SpravcePojisteni'

                Menu.StartMenu(spravcePojisteni);   //Zavolání metody 'StartMenu' ze třídy 'Menu' a poskytnutí 'spravcePojisteni' jako argument
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  //Vypsání exception zprávy pokud nastane nějaká exception
            }
        }
    }
}
