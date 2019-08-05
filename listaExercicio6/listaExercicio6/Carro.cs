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

        // CONSTRUTOR SEM PARÂMETROS
        public Carro ()
            : base()
        {
            capacidadePortaMala = 0;
            bagageiro = false;
            carroceria = null;
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
            set { bagageiro = value.ToUpper() == "TRUE" ? "SIM" : "NÃO"; }
        }
        public string Carroceria
        {
            get { return carroceria; }
            set { carroceria = value; }
        }
        //MÉTODO PARA RETORNAR UMA STRING CONTENDO AS INFORMAÇÕES DO VEICULO

        public override string ToString()
        {
            return (String.Format(" Capacidade do porta mala: {0} \n Bagageiro: {1} \n Carroceria: {2} \n", base.ToString(), capacidadePortaMala, bagageiro, carroceria));
        }
    }
}
