using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhirN_InfoTest
{
    abstract class GhirN_Candidato
    {
        private int GhirN_matricola;
        private string GhirN_nome;
       
     public int ghirN_matricola {
           get
            {
                return GhirN_matricola;
            }
          private  set
            {
                ghirN_matricola = value;
            }
        }
        public string ghirN_nome
        {
            get
            {
                return GhirN_nome;
            }
            private set
            {
                ghirN_nome = value;
            }
        }

        public GhirN_Candidato()
        {
            GhirN_matricola = 0;
            GhirN_nome = "";

        }
        public GhirN_Candidato(string Nome)
        {
            GhirN_matricola = 0;
            GhirN_nome = Nome;

        }
        public GhirN_Candidato(int Matricola)
        {
            ghirN_matricola = Matricola;
            ghirN_nome = "";

        }
          public GhirN_Candidato(string Nome,int Matricola)
        {
            ghirN_matricola = Matricola;
            ghirN_nome = Nome;

        }
    }
}
