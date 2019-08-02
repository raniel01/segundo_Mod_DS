using System;
using System.Collections.Generic;
using System.Text;

namespace listaExercicio6
{
    class Caminhao : Veiculo
    {
        //ATRIBUTOS DA CLASSE
        private int numero_eixos;
        private double peso_maximo_carga;
        private string tipo_caminhao;


        // CONSTRUTOR SEM PARÂMETROS
        public Caminhao()
        : base ()
        {
            numero_eixos = 0;
            peso_maximo_carga = 0.0;
            tipo_caminhao = null;
        }

        // CONSTRUTOR COM PARÂMETROS
        public Caminhao (string modelo, string fabricante, int ano, string cor, int numero_portas, string placa, int numero_eixos, double peso_maximo_carga, string tipo_caminhao)
            : base(modelo, fabricante, ano, cor, numero_portas, placa)
        {
            this.numero_eixos = numero_eixos;
            this.peso_maximo_carga = peso_maximo_carga;
            this.tipo_caminhao = tipo_caminhao;
        }

        //PROPRIEDADES DO CAMPO PARA ACESSO AO SEU CONTEÚDO
        public int Numero_eixos
        {
            get { return numero_eixos; }
            set { numero_eixos = value; }
        }
        public double Peso_maximo_carga
        { 
            get { return peso_maximo_carga; }
            set { peso_maximo_carga = value; }
        }
        public string Tipo_caminhao
        {
            get { return tipo_caminhao; }
            set {tipo_caminhao = value; }
        }

        //MÉTODO PARA RETORNAR UMA STRING CONTENDO AS INFORMAÇÕES DO VEICULO
        public override string ToString()
        {
            return (String.Format(" Numero de eixos: {0} \n Peso máximo da Carga: {1} \n Tipo de caminão: {2} \n", base.ToString(), numero_eixos, peso_maximo_carga, tipo_caminhao));
        }
    }
}
