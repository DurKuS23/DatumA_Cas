using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Knih
    {
        public static int CalculateAge(DateTime birthday, out int pocetdni)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - birthday.Year;

            if (now < birthday.AddYears(age))
            {
                age--;
            }

            pocetdni = (now - birthday).Days;
            return age;
        }

        public static bool jeDatum(string datum, out DateTime birthday, out string zprava)
        {
            zprava = "Správné datum narození";

            birthday = DateTime.Now;

            string den = datum.Substring(0, 2);
            string mesic = datum.Substring(3, 2);
            string rok = datum.Substring(6, 4);

            int rokc = Int32.Parse(rok);
            int mesc = Int32.Parse(mesic);
            int denc = Int32.Parse(den);

            if (mesc < 1 || mesc > 12) { zprava = "Špatné datum"; return false; }
            int pocetdni = DateTime.DaysInMonth(rokc, mesc);
            if (denc < 1 || denc > pocetdni) { zprava = "Špatný den"; return false; }
            birthday = Convert.ToDateTime(datum);

            return true;
        }

        static public int PocetDni(DateTime birthday, int roku)
        {
            int PocetDnu = 0;

            DateTime Today = DateTime.Today;

            //7.11. 311 dni  - od mych narozenin 288

            // Birthday = 23.01.2005
            // Today = 7.11.2022
            // roku = 17
            DateTime BirthdayAge = birthday.AddYears(roku);

            if (Today > BirthdayAge)
            {
                PocetDnu = ((Today.DayOfYear) - (BirthdayAge.DayOfYear));
            }

            return PocetDnu;
        }
    }
}
