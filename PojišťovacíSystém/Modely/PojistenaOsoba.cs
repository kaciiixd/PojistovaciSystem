using PojistovaciSystem.Pomocnici;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojistovaciSystem.Modely
{
    public class PojistenaOsoba
    {
        public string Jmeno { get; set; }   //Vlastnost pro uchování jména pojištěné osoby
        public string Prijmeni { get; set; }    //Vlastnost pro uchování příjmení pojištěné osoby
        public int Vek { get; set; }    //Vlastnost pro uchování věku pojištěné osoby
        public int TelefonniCislo { get; set; }     //Vlastnost pro uchování telefonního čísla pojištěné osoby


        /// <summary>
        /// Konstruktor pro vytvoření nové instance třídy
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <param name="vek"></param>
        /// <param name="telefonniCislo"></param>
        public PojistenaOsoba(string jmeno, string prijmeni, int vek, int telefonniCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            TelefonniCislo = telefonniCislo;
        }

        public override string ToString()
        {
            //Přepisuje ToString metodu pro vypsání textové reprezentace objektu
            return $"{Jmeno} {Prijmeni} {Vek} {TelefonniCislo}";
        }
    }
}
