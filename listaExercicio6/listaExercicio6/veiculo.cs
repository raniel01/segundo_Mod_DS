using System;
using System.Collections.Generic;
using System.Text;

namespace listaExercicio6
{
    abstract class Veiculo
    {
        //ATRIBUTOS DA CLASSE
        private string modelo;
        private string fabricante;
        private int ano;
        private string cor;
        private int numero_portas;

        // CONSTRUTOR SEM PARÂMETROS
        public Veiculo()
        {
            this.modelo = null;
            this.fabricante = null;
            this.ano = 0;
            this.cor = null;
            this.numero_portas = 0;
        }


        // CONSTRUTOR COM PARÂMETROS
        public Veiculo(string modelo, string fabricante, int ano, string cor, int numero_portas)
        {
            this.modelo = modelo;
            this.fabricante = fabricante;
            this.ano = ano;
            this.cor = cor;
            this.numero_portas = numero_portas;
        }

        //PROPRIEDADES DO CAMPO PARA ACESSO AO SEU CONTEÚDO
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public string Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }
        public int Ano
        {
            get { return ano; }
            set {ano = value; }
        }
        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        public int Numero_portas
        {
            get { return numero_portas; }
            set { numero_portas = value; }
        }

        //MÉTODO PARA RETORNAR UMA STRING CONTENDO AS INFORMAÇÕES DO VEICULO

        public override string ToString()
        {
            return (String.Format(" Modelo: {0} \n Fabricante: {1} \n Ano: {2} \n Cor: {3} \n Número de Portas: {4} \n", modelo, fabricante, ano, cor, numero_portas));
        }
    }
}
