using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AED_2
{
    class Multas
    {
        private DateTime data; //Recebe data da multa efetuada.
        private string cnh; //CNH do condutor responsável.
        //private string placa; //Placa do veículo conduzido.
        

        public Multas()
        {
            
        }
        public Multas(DateTime data, string cnh)
        {
            this.data = data;
            this.cnh = cnh;
            //this.placa = placa;
        }

        
        public string Cnh { get => cnh; set => cnh = value; }
        // public string Placa { get => placa; set => placa = value; }
        public DateTime Data { get => data; set => data = value; }
        
        //public Multas Proximo { get => proximo; set => proximo = value; }
    }
}
