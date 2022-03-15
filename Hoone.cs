using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_Hoone_loomine
{
    public abstract class Hoone
    {
        public int Pindala { get; set; }
        public int Akenarv { get; set; }
        public bool Korsten { get; set; }
        public int Korterarv { get; set; }
        public bool Kelder { get; set; }

        public Uks uks;
        public Hoone(int pindala = 200)
        {
            Pindala = pindala;

        }
        public Hoone(int pindala, int akenarv, bool korsten)
        {
            Pindala = pindala;
            Akenarv = akenarv;
            Korsten = korsten;
        }
        public Hoone(int pindala, int akenarv, bool korsten, int korterarv)
        {
            Pindala = pindala;
            Akenarv = akenarv;
            Korsten = korsten;
            Korterarv = korterarv;
        }
        public Hoone(int pindala, bool kelder)
        {
            Pindala= pindala;
            Kelder= kelder;
        }
        public Uks GetUks()
        {
            return uks;
        }
        public abstract void NaitaInfo();
    }
}
