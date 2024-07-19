using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas4
{
    internal class MasyvaiEXTRA
    {
        public static void Main(string[] args)
        {
            //PirmojiUzduotis();

            //AntrojiUzduotis();

            //TreciojiUzduotis();

            //KetvirtojiUzduotis();

            //PenktojiUzduotis();

            //SestojiUzduotis();

            //SeptintojiUzduotis();

            //AstuntojiUzduotis();

            //DevintojiUzduotis();

            //DesimtojiUzduotis();
        }

        /// <summary>
        /// Nuskaitomas 4 skaitmenu masyvas ir tikrinama ar elementu suma yra lygine
        /// </summary>
        public static void PirmojiUzduotis()
        {
            int[] Masyvas = new int[4];
            int Index = 0;

            Console.WriteLine("Iveskite keturis sveikuosius skaicius:");
            AddToArray(ref Masyvas, ref Index);
            Index = 0;
            int Suma = 0;
            ArraySum(ref Masyvas, ref Index, ref Suma);

            if (Suma % 2 == 0)
                Console.WriteLine($"Suma yra lygine: {Suma}");
            else 
                Console.WriteLine($"Suma yra nelygine: {Suma}");
        }

        /// <summary>
        /// Masyvo elementu nuskaitymas
        /// </summary>
        /// <param name="Masyvas"></param>
        /// <param name="Index"></param>
        public static void AddToArray(ref int[] Masyvas, ref int Index)
        {
            if (!int.TryParse(Console.ReadLine(), out int Input))
            {
                Console.WriteLine("Neteisinga ivestis!");
                return;
            }
            Masyvas[Index] = Input;
            ++Index;
            CheckIfShouldAddMore(ref Masyvas, ref Index);
        }

        /// <summary>
        /// Tikrinama ar reikia testi elementu nuskaityma
        /// </summary>
        /// <param name="Masyvas"></param>
        /// <param name="Index"></param>
        public static void CheckIfShouldAddMore(ref int[] Masyvas, ref int Index)
        {
            if (Index < Masyvas.Length)
                AddToArray(ref Masyvas, ref Index);
        }

        /// <summary>
        /// Masyvo elementu sudetis
        /// </summary>
        /// <param name="Masyvas"></param>
        /// <param name="Index"></param>
        /// <param name="Suma"></param>
        public static void ArraySum(ref int[] Masyvas, ref int Index, ref int Suma)
        {
            Suma += Masyvas[Index];
            ++Index;
            CheckIfShouldSumMore(ref Masyvas, ref Index, ref Suma);
        }

        /// <summary>
        /// Tikrinama ar reikia testi masyvo elementu sudeti
        /// </summary>
        /// <param name="Masyvas"></param>
        /// <param name="Index"></param>
        /// <param name="Suma"></param>
        public static void CheckIfShouldSumMore(ref int[] Masyvas, ref int Index, ref int Suma)
        {
            if (Index < Masyvas.Length)
                ArraySum(ref Masyvas, ref Index, ref Suma);
        }

        /// <summary>
        /// Nuskaitomas 3 skaitmenu masyvas ir tikrinama ar pirmas elementas yra tarp antro ir trecio
        /// </summary>
        public static void AntrojiUzduotis()
        {
            int[] Masyvas = new int[3];
            int Index = 0;

            Console.WriteLine("Iveskite tris sveikuosius skaicius:");
            AddToArray(ref Masyvas, ref Index);

            if (Masyvas[0] > Masyvas[1] && Masyvas[0] < Masyvas[2])
                Console.WriteLine("Pirmas elementas yra tarp antro ir trecio");
            else
                Console.WriteLine("Pirmas elementas nera tarp antro ir trecio");
        }

        /// <summary>
        /// Nuskaitomas 5 skaitmenu masyvas ir tikrinama ar pirmas elementas yra nelyginis, o paskutinis yra lyginis
        /// </summary>
        public static void TreciojiUzduotis()
        {
            int[] Masyvas = new int[5];
            int Index = 0;

            Console.WriteLine("Iveskite penkis sveikuosius skaicius:");
            AddToArray(ref Masyvas, ref Index);

            if (Masyvas[0] % 2 == 1 && Masyvas[Masyvas.Length-1] % 2 == 0)
                Console.WriteLine("Pirmas elementas yra nelyginis, o paskutinis yra lyginis");
            else
                Console.WriteLine("Salyga neatitinka");
        }

        /// <summary>
        /// Nuskaitomas 2 skaitmenu masyvas ir tikrinama ar vienas elementas yra neigiamas, o kitas yra teigiamas
        /// </summary>
        public static void KetvirtojiUzduotis()
        {
            int[] Masyvas = new int[2];
            int Index = 0;

            Console.WriteLine("Iveskite du sveikuosius skaicius:");
            AddToArray(ref Masyvas, ref Index);

            if (Masyvas[0] < 0 && Masyvas[1] > 0)
                Console.WriteLine("Vienas elementas yra neigiamas, o kitas yra teigiamas");
            else if (Masyvas[0] > 0 && Masyvas[1] < 0)
                Console.WriteLine("Vienas elementas yra neigiamas, o kitas yra teigiamas");
            else
                Console.WriteLine("Abu elementai yra teigiami arba neigiami");
        }

        /// <summary>
        /// Nuskaitomas 4 skaitmenu masyvas ir tikrinama ar antras elementas yra lygus pirmo ir trecio vidurkiui
        /// </summary>
        public static void PenktojiUzduotis()
        {
            int[] Masyvas = new int[4];
            int Index = 0;

            Console.WriteLine("Iveskite keturis sveikuosius skaicius:");
            AddToArray(ref Masyvas, ref Index);

            if( Convert.ToDouble(Masyvas[1]) == (Convert.ToDouble(Masyvas[0]) + Convert.ToDouble(Masyvas[2])) * 0.5 )
                Console.WriteLine("Antras elementas yra lygus pirmo ir trecio vidurkiui");
            else
                Console.WriteLine("Antras elementas nera lygus pirmo ir trecio vidurkiui");
        }

        /// <summary>
        /// Nuskaitomas 3 skaitmenu masyvas ir tikrinama ar visi elementai yra skirtingi
        /// </summary>
        public static void SestojiUzduotis()
        {
            int[] Masyvas = new int[3];
            int Index = 0;

            Console.WriteLine("Iveskite tris sveikuosius skaicius:");
            AddToArray(ref Masyvas, ref Index);

            if (Masyvas[0] != Masyvas[1] && Masyvas[1] != Masyvas[2] && Masyvas[0] != Masyvas[2])
                Console.WriteLine("Visi elementai yra skirtingi");
            else
                Console.WriteLine("Yra bent du vienodi elementai");
        }

        /// <summary>
        /// Nuskaitomas 4 skaitmenu masyvas ir tikrinama ar bent du elementai yra didesni uz 50
        /// </summary>
        public static void SeptintojiUzduotis()
        {
            int[] Masyvas = new int[4];
            int Index = 0;

            Console.WriteLine("Iveskite keturis sveikuosius skaicius:");
            AddToArray(ref Masyvas, ref Index);

            Index = 0;
            if (Masyvas[0] > 50)
                ++Index;
            if (Masyvas[1] > 50)
                ++Index;
            if (Masyvas[2] > 50)
                ++Index;
            if (Masyvas[3] > 50)
                ++Index;

            if (Index > 1)
                Console.WriteLine("Bent du elementai yra didesni uz 50");
            else
                Console.WriteLine("Maziau nei du elementai yra didesni uz 50");
        }

        /// <summary>
        /// Nuskaitomas 2 skaitmenu masyvas ir tikrinama ar yra tobulas kvadratas
        /// </summary>
        public static void AstuntojiUzduotis()
        {
            int[] Masyvas = new int[2];
            int Index = 0;

            Console.WriteLine("Iveskite du sveikuosius skaicius:");
            AddToArray(ref Masyvas, ref Index);

            if (   (Masyvas[0] >= 0 && Convert.ToInt32(Math.Sqrt(Masyvas[0])) == Math.Sqrt(Masyvas[0])) || (Masyvas[1] >= 0 && Convert.ToInt32(Math.Sqrt(Masyvas[1])) == Math.Sqrt(Masyvas[1])))
                Console.WriteLine("Yra tobulas kvadratas");
            else
                Console.WriteLine("Nera tobulo kvadrato");
        }

        /// <summary>
        /// Nuskaitomas 3 skaitmenu masyvas ir tikrinama ar elementai sudaro aritmetine progresija
        /// </summary>
        public static void DevintojiUzduotis()
        {
            int[] Masyvas = new int[3];
            int Index = 0;

            Console.WriteLine("Iveskite tris sveikuosius skaicius:");
            AddToArray(ref Masyvas, ref Index);

            if (Masyvas[0] - Masyvas[1] == Masyvas[1] - Masyvas[2])
                Console.WriteLine("Elementai sudaro aritmetine progresija");
            else
                Console.WriteLine("Elementai nesudaro aritmetines progresijos");
        }

        /// <summary>
        /// Nuskaitomas 4 skaitmenu masyvas ir tikrinama ar pirmo ir ketvirto elementu sandauga yra lygi trecio elemento kvadratui
        /// </summary>
        public static void DesimtojiUzduotis()
        {
            int[] Masyvas = new int[4];
            int Index = 0;

            Console.WriteLine("Iveskite keturis sveikuosius skaicius:");
            AddToArray(ref Masyvas, ref Index);

            if (Masyvas[0] * Masyvas[3] == Masyvas[2] * Masyvas[2])
                Console.WriteLine("Sandauga lygi kvadratui");
            else
                Console.WriteLine("Sandauga nelygi kvadratui");
        }
    }
}
