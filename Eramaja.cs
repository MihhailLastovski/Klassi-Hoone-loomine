using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_Hoone_loomine
{
    public class EraMaja : Hoone
    {
        public double saitpindala;
        public string tara;
        public EraMaja(int pindala = 50, double saitpindala = 80) : base(pindala)
        {
            this.saitpindala = saitpindala;
        }
        public EraMaja(int pindala, int akenarv, bool korsten) : base(pindala,akenarv,korsten)
        {
        }
        public EraMaja(int pindala, int akenarv, bool korsten, int korterarv, string tara) : base(pindala, akenarv, korsten, korterarv)
        {
            this.tara = tara;
        }
        public string Suurus
        {
            set 
            {
 
                if (Pindala<=30)
                {
                    Suurus = "vaike maja";
                }
                else if (Pindala<=50)
                {
                    Suurus = "keskmine maja";
                }
                else if (Pindala<=80)
                {
                    Suurus = "suur maja";
                }
                else
                {
                    Suurus = "liiga suur maja";
                }
                
            }
        }
        public override void NaitaInfo()
        {
            if (Korsten == true && tara == "jah" && saitpindala == 0)
            {
                Console.WriteLine($"Mina olen maja, minu pindala on {Pindala} m2, mul on {Akenarv} akent, mul on kortsen, mul on tara, mul on {Korterarv} korterit.");

            }
            else if (Korsten == true && tara =="ei" && saitpindala == 0)
            {
                Console.WriteLine($"Mina olen maja, minu pindala on {Pindala} m2, mul on {Akenarv} akent, mul on kortsen, mul on {Korterarv} korterit");
            }
            else if (Korsten == false && tara == "jah" && saitpindala == 0)
            {
                Console.WriteLine($"Mina olen maja, minu pindala on {Pindala} m2, mul on {Akenarv} akent, mul on tara, mul on {Korterarv} korterit");
            }
            else if (Korsten == false && tara == "ei" && saitpindala == 0)
            {
                Console.WriteLine($"Mina olen maja, minu pindala on {Pindala} m2, mul on {Akenarv} akent, mul on {Korterarv} korterit");
            }
            else if (Korsten == false && saitpindala == 0)
            {
                Console.WriteLine($"Mina olen maja, minu pindala on {Pindala} m2, mul on {Akenarv} akent");
            }
            else if (Korsten == true && saitpindala == 0)
            {
                Console.WriteLine($"Mina olen maja, minu pindala on {Pindala} m2, mul on {Akenarv} akent, mul on kortsen");
            }
            else
            {
                Console.WriteLine($"Mina olen maja, minu pindala on {Pindala} m2, minu sait pindala on {saitpindala} m2");

            }
            Console.WriteLine();
        }
    }
}
