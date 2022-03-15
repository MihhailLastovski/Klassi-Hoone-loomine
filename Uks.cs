using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_Hoone_loomine
{
    public class Uks : Hoone
    {
        public string Color { get; set; }

        public Uks(string color = "sinine")
        {
            Color = color;
        }

        public override void NaitaInfo()
        {
            Console.WriteLine($"Mina olen uks, minu värv on {Color}");
            for (int i = 0; i < 60; i++)
            {
                Console.Write("-");
            }
        }
    }
}
