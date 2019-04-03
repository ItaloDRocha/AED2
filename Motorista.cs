using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AED_2
{
    class Motorista
    {

        //private string cpf; //Cpf do motorista
        private string cnh; //CNH do motorista
        private int nMultas;                  //private int nMultas; //Número de multas cometidas

        
        

        public Motorista(string cnh)
        {
            //this.nome = nome;
            // this.cpf = cpf;
            this.cnh = cnh;
        }

        //public string Nome { get => nome; set => nome = value; }
        //public string Cpf { get => cpf; set => cpf = value; }
        public string Cnh { get => cnh; set => cnh = value; }
        public int NMultas { get => nMultas; set => nMultas = value; }
        //public int NMultas { get => nMultas; set => nMultas = value; }

    }
}
