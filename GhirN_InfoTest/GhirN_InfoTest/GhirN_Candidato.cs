using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhirN_InfoTest
{
    public abstract class GhirN_Candidato : IEquatable<GhirN_Candidato>
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
        public override string ToString()
        {
            return ghirN_matricola + " " + ghirN_nome;
        }
        public  virtual bool Equals(GhirN_Candidato candi)
        {
           if(candi == null)
                return false;
            if (candi.ghirN_nome == this.ghirN_nome && candi.ghirN_matricola == this.ghirN_matricola)
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (ghirN_nome+ GhirN_matricola).GetHashCode();
        }

    }
}
