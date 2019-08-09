using System;
using System.Collections.Generic;
using System.Text;

namespace listaExercicio6
{
    class Carro : Veiculo
    {
        //ATRIBUTOS DA CLASSE
        private int capacidadePortaMala;
        private bool bagageiro;
        private string carroceria;
        private string mcar;
        private string fcar;
        private int ano;
        private string cor;
        private int portas;
        private string placa;
        private int portaMalas;

        // CONSTRUTOR SEM PARÂMETROS
        public Carro ()
            : base()
        {
            capacidadePortaMala = 0;
            bagageiro = false;
            carroceria = null;
        }

        public Carro(string mcar, string fcar, int ano, string cor, int portas, string placa, int portaMalas, string carroceria)
        {
            this.mcar = mcar;
            this.fcar = fcar;
            this.ano = ano;
            this.cor = cor;
            this.portas = portas;
            this.placa = placa;
            this.portaMalas = portaMalas;
            this.carroceria = carroceria;
        }

        // CONSTRUTOR COM PARÂMETROS
        public Carro(string modelo, string fabricante, int ano, string cor, int numero_portas, string placa, int capacidadePortaMala, bool bagageiro, string carroceria)
            : base(modelo, fabricante, ano, cor, numero_portas, placa)
        {
            this.capacidadePortaMala = capacidadePortaMala;
            this.bagageiro = bagageiro;
            this.carroceria = carroceria;
        }
        //PROPRIEDADES DO CAMPO PARA ACESSO AO SEU CONTEÚDO
        public int CapacidadePotaMala
        {
            get { return capacidadePortaMala; }
            set { capacidadePortaMala = value; }
        }
        public bool Bagageiro
        {
            get { return bagageiro; }
            set { bagageiro = value; }
        }
        public string Carroceria
        {
            get { return carroceria; }
            set { carroceria = value; }
        }
        //MÉTODO PARA RETORNAR UMA STRING CONTENDO AS INFORMAÇÕES DO VEICULO

        public override string ToString()
        {
            return (String.Format("{0} Capacidade do porta mala: {1} \n Bagageiro: {2} \n Tipo: {3} \n", base.ToString(), capacidadePortaMala, bagageiro  == true ? "SIM" : "NÃO", carroceria));
        }
    }
}
