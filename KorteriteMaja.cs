using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_Hoone_loomine
{
    public class KorteriteMaja : Hoone
    {
        public int sissepaasarv;
        public int korrusarv;
        public KorteriteMaja( int korterarv, bool kelder, int sissepaasarv, int korrusarv) : base(korterarv, kelder)
        {
            this.sissepaasarv = sissepaasarv;
            this.korrusarv = korrusarv;
        }
        public string Korgus 
        {
            set 
            {
                if (korrusarv <= 3)
                {
                    Korgus = "madal maja";
                }
                else if (korrusarv <= 5)
                {
                    Korgus = "keskmine maja";
                }
                else if (korrusarv <= 9)
                {
                    Korgus = "kõrge maja";
                }
                else if (korrusarv > 9) 
                {
                    Korgus = "väga kõrge maja";
                }
                else 
                {
                    Korgus = "Ma ei ole olemasolev maja";
                }
                
            }
            get { return Korgus; }
        }

        public override void NaitaInfo()
        {
            if (Kelder==true)
            {
                Console.WriteLine($"Mina olen korterite maja, mul on {sissepaasarv} sissepääsud, mul on {Korterarv} korter, mul on kedler. Ma olen {Korgus}");
            }
            else if (Kelder==false)
            {
                Console.WriteLine($"Mina olen korterite maja, mul on {sissepaasarv} sissepääsud, mul on {Korterarv} korter. Ma olen {Korgus}");
            }
            else if (Kelder == true && Korgus == "Ma ei ole olemasolev maja")
            {
                Console.WriteLine($"Mina olen korterite maja, mul on {sissepaasarv} sissepääsud, mul on {Korterarv} korter, mul on kedler. {Korgus}");
            }
            else if (Kelder == false && Korgus == "Ma ei ole olemasolev maja")
            {
                Console.WriteLine($"Mina olen korterite maja, mul on {sissepaasarv} sissepääsud, mul on {Korterarv} korter. {Korgus}");
            }

        }
    }
}
