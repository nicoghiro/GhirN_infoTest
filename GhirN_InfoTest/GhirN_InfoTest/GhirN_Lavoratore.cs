using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhirN_InfoTest
{
    public class GhirN_Lavoratore:GhirN_Candidato
    {
        int GhirN_esperienze;
        public int ghirN_esperienze
        {
            get { return GhirN_esperienze; }
            set { 
                if(0<=value&&value<=5)
                GhirN_esperienze = value;
                else
                {
                    GhirN_esperienze = 0;
                    throw new Exception("inserire un numero valido di esperienze 0 <= x <= 5 ");
                }

            }
        }
        public GhirN_Lavoratore() : base()
        {
            ghirN_esperienze = 0;
        }
        public GhirN_Lavoratore(int esperienze, int matricola ,string nome) : base(nome ,matricola)
        {
            ghirN_esperienze = esperienze;
        }
        public override int punteggio()
        {
            return ghirN_esperienze*20;
        }
        public override bool Isidoneo()
        {
            if (this.punteggio() >= 60)
                return true;
            else
                return false;
        }
    }
}
