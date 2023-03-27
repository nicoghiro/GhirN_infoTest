using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhirN_InfoTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<GhirN_Candidato> lista;
        private void Form1_Load(object sender, EventArgs e)
        {
         lista = new List<GhirN_Candidato>();
           
          
        }
        public void add(string nome , int matricola,int epserienze )
        {
            GhirN_Lavoratore nuovo=new GhirN_Lavoratore(epserienze, matricola,nome);
            lista.Add(nuovo);
        }
        public string[] Ottieni(List<GhirN_Candidato> lista1)
        {    
            string[] temp=new string[lista1.Count];
            if (lista1 != null)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    temp[i]=lista1[i].ToString();
                }
                return temp;
            }
            return null;



        }
        public void modifica(int matricola,string nuovonome)
        {
           for(int i=0;i<lista.Count;i++)
            {
                if (lista[i].ghirN_matricola == matricola)
                {
                    lista[i].ghirN_nome = nuovonome;
                }
            } 
            MessageBox.Show("matricola non trovata");
        }
        public void Delete(int matricola)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].ghirN_matricola == matricola)
                {
                    lista.RemoveAt(i);
                    return;
                }
            }
           
        }
        public string[] idonei(List<GhirN_Candidato> lista1)
        {
            string[] temp = new string[lista1.Count];
            if (lista1 != null)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if(lista1[i].Isidoneo())
                    temp[i] = lista1[i].ToString();
                }
                return temp;
            }
            return null;

        }
        public void ordina(List<GhirN_Candidato> lista1)
        {
            lista.Sort();
            lista.Reverse();
        }
    }
}
