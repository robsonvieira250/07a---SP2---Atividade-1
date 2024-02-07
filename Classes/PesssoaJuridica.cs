using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodificaçãoBackEnd.Classes
{
    public class PesssoaJuridica : Pessoas
    {
       public string CNPJ { get; set; }
       
        public void Inserir(PesssoaJuridica pj)
        {
            using(StreamWriter sw = new StreamWriter(pj.Nome+".txt"))
            {
                sw.WriteLine($"{pj.Nome};{pj.Rendimento};{pj.CNPJ}");
            }
        }
    }
}