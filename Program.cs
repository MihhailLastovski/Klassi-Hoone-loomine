using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_Hoone_loomine
{
    static class Program
    {
        static void Main(string[] args)
        {
            EraMaja majake = new EraMaja();
            EraMaja majake2 = new EraMaja(50, 4, true, 5, "jah");
            EraMaja majake3 = new EraMaja(70, 6, false);
            Inimene mees = new Inimene("Juku");
            Inimene mees2 = new Inimene("Mark");
            Inimene naine = new Inimene("Maša");
            majake2.uks = new Uks("punane");
            majake3.uks = new Uks("sinine");
            majake.uks = new Uks("must");
            mees2.hoone = majake2;
            mees.hoone = majake;
            naine.hoone = majake3;
            mees.NaitaInfo();
            mees2.NaitaInfo();
            naine.NaitaInfo();
            Console.ReadKey(true);
        }
    }
}
