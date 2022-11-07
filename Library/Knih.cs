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
    }
}
