using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhirN_InfoTest
{
    public abstract class GhirN_Candidato
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
            ghirN_matricola = 0;
            ghirN_nome = null;

        }
        public GhirN_Candidato(string Nome)
        {
            ghirN_matricola = 0;
            ghirN_nome = Nome;

        }
        public GhirN_Candidato(int Matricola)
        {
            ghirN_matricola = Matricola;
            ghirN_nome = null;

        }
          public GhirN_Candidato(string Nome,int Matricola)
        {
            ghirN_matricola = Matricola;
            ghirN_nome = Nome;

        }
         abstract public bool Isidoneo();
         abstract public int punteggio();

    }
}
