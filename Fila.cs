using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AED_2
{
    class Fila
    {
        private Elemento _sentinela, _cauda;
        string todasMultas = "";
        private List<Multas> listaMultas;

        public Fila()
        {
            this._sentinela = new Elemento();
            this._cauda = this._sentinela;
        }
        
        internal Elemento Sentinela { get => _sentinela; set => _sentinela = value; }

        public void Inserir(List<Multas> lista)
        {
            listaMultas = lista;
            if (_cauda.Prox == null)
            {

                Elemento novo = new Elemento(lista[0]);
                _sentinela.Prox = novo;
                _cauda = novo;
            }

                for (int i = 1; i < lista.Count; i++ )
                {
                    Elemento novo = new Elemento(lista[i]);
                    _cauda.Prox = novo;
                    _cauda = novo;
                }
        }

        public string ListarMultas(Elemento atual)
        {

            todasMultas += "CNH = " + atual.Prox.Dado.Cnh + " || DATA = " + atual.Prox.Dado.Data.ToString("dd/MM/yyyy") + "\n";
            atual = atual.Prox;

            if (atual.Prox == null)
            {
                return todasMultas;
            }

            else
            {
                ListarMultas(atual);
            }

            return todasMultas;
        }

    }
}
