using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhirN_InfoTest
{
    public class GhirN_Disoccupato : GhirN_Candidato
    {
        int GhirN_voto;
        bool GhirN_lode;
        public int ghirN_voto
        {
            get { return GhirN_voto; }
            private set { 
                if(value < 111)
                GhirN_voto = value;
                else
                {
                    throw new Exception("Il Voto massimo è 110");
                }
            }

        }
        public bool ghirN_lode
        {
            get { return GhirN_lode; }
            set
            {
                if(ghirN_voto==110)
                GhirN_lode = value;
                else
                {
                    GhirN_lode = false;
                    throw new Exception("è possibile avere la lode solo con 110 come voto");
                }
             
            }

        }
         public GhirN_Disoccupato():base()
        {
            ghirN_lode=false;
            ghirN_voto = 0;
        }
        public GhirN_Disoccupato(int voto , bool lode , int matricola , string nome) : base(nome,matricola)
        {
            ghirN_lode = lode;
            ghirN_voto =voto;
        }
        public override int punteggio()
        {
            int temp = ghirN_voto * 100;
            temp = temp / 110;

            if (ghirN_lode == true)
            {
                return temp + 5;
            }
            return temp;
        }
        public override bool Isidoneo()
        {
            if(this.punteggio()>=72)
                return true;
            else
             return false;
        }
    }
}
