using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AED_2
{
    class Program
    {
        
        static Multas multa;
        static Motorista motorista;
        static List<Motorista> ListaMotorista = new List<Motorista>();
        static List<Multas> ListaMultas = new List<Multas>();
        static Fila fila = new Fila();
        //static List <Veiculo> listaveiculo = new List <Veiculo>();
        //static List <Multas> filaMultas = new List<Multas>();
        static void Main(string[] args)
        {
            DateTime data;
            string linha = " ";
            StreamReader Leitura = new StreamReader("motoristas.txt"); //Lê o txt contendo o cnh dos motoristas
            while (linha != null) //adicionar os motoristas em uma lista com seus dados.
            {
                linha = Leitura.ReadLine();
                if (linha != null)
                    AdicionarMotoristas(linha);
            }
            Leitura.Close();

            Leitura = new StreamReader("multas.txt"); //Lê o txt contendo a data das multas e a qual cnh foi aplicada;
            linha = "";

            string dia;
            string mes;
            string ano;
            string cnh;
            string[] vetLeitura;
            while (linha != null) //adicionar as multas em uma lista com seus dados.
            {
                linha = Leitura.ReadLine();
                if (linha != null)
                {
                    vetLeitura = linha.Split('/');
                    dia = vetLeitura[0];
                    mes = vetLeitura[1];
                    ano = vetLeitura[2];
                    cnh = vetLeitura[3];
                    data = new DateTime(int.Parse(ano), int.Parse(mes), int.Parse(dia));
                    multa = new Multas(data, cnh); //Instancia a classe multa com os ultimos valores lidos
                    ListaMultas.Add(multa); //Insere o objeto Multa na lista.

                }
            }
            
            Leitura.Close();
            Console.WriteLine("Dados foram lidos do .txt;");
            ListaMultas = ListaMultas.OrderBy(c => c.Data).ToList();
            Console.WriteLine("Multas foram ordenadas por data; \n \n");
            fila.Inserir(ListaMultas); //Insera as multas na Fila de apontadores

            Console.WriteLine("Fila de todas as multas por ordem de data: \n");
            Console.Write(fila.ListarMultas(fila.Sentinela)); //Imprime todas as multas, já na fila de apontadores, organizadas em ordem de data crescente.
            
            /*  
            for(int i = 0; i < ListaMultas.Count; i++)
            {
                Console.WriteLine("CNH = " + ListaMultas[i].Cnh + " || DATA = " + ListaMultas[i].Data.ToString("dd/MM/yyyy"));
            }
           */
            

            //Console.WriteLine(fila.Cauda.Data);

            //Aplicar multa

            //Dados nescessarios para aplicar uma multa:
            //. Data da multa
            //. CNH do condutor
            //. Placa do carro
            //. CPF do condutor


            //Simulação: Aplicar multa para condutor 1:

            Console.ReadKey();
        }

        static void AdicionarMotoristas(string _cnh)
        {
            motorista = new Motorista(_cnh);
            ListaMotorista.Add(motorista);
        }


    }
}

