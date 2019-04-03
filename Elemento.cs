using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AED_2
{
    class Elemento
    {
        Multas dado;
        Elemento prox;

        public Elemento()
        {
            this.Dado = null;
            this.Prox = null;
        }
        
        public Elemento(Multas d)
        {
            this.Dado = d;

        }
        
        internal Multas Dado
        {
            get
            {
                return dado;
            }

            set
            {
                dado = value;
            }
        }

        internal Elemento Prox
        {
            get
            {
                return prox;
            }

            set
            {
                prox = value;
            }
        }
    }
}
