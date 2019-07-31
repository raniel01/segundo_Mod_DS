using System;
using System.Collections.Generic;
using System.Text;

namespace Aula6_Exemplo1
{
    class Pessoa
    {
        // ATRIBUTOS DA CLASSE

        private string nome;
        private int idade;
        private double altura;
        private string sexo;

        // CONSTRUTOR SEM PARÂMETRO

        public Pessoa() {
            this.nome = null;
            this.idade = 0;
            this.altura = 0.0;
            sexo = null;
        }

        //CONSTRUTOR COM PARÂMETRO

        public Pessoa(string nome, int idade, double altura, char sexo) {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            Sexo = sexo.ToString();
        }

        // PROPRIEDADA DO CAMPO NOME PARA ACESSO AO SEU CONTEÚDO

        public string Nome
        {
            get { return nome; } // retornar o valor armazenado em um campo.
            set { nome = value; } // armazenar o valor no campo
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public string Sexo
        {
            get { return sexo; } // retornar o valor armazenado no campo sexo
            set { sexo = value.ToUpper() == "M" ? "MASCULINO" : "FEMININO"; }
        }

        // METODO PARA CALCULAR O PESO IDEAL DE UMA PESSOA

        public double calcularPesoIdeal()
        {
            if (sexo.Equals("MASCULINO"))
                return (72.7 * altura) - 58;
            else
                return (62.1 * altura) - 44.7;
        }
        // METODO QUE RETORNA UMA STRING  CONTENSO INFORMAÇÕES DA PESSOA

        public override string ToString()
        {
            return (String.Format("Nome: {0} \n Idade: {1} \n Altura: {2} \n Sexo: {3} \n", nome, idade, altura, sexo));
        }

    }
}
