using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celulares73A.Model.Entidades
{
    public class Aparelho
    {
        private Int64 id_Aparelho;
        private Fabricante? fabricante;
        private string? modelo;
        private decimal altura;
        private decimal largura;
        private decimal espessura;
        private decimal peso;
        private decimal preco;
        private Int32 quantidade;
        private decimal desconto;

        // Propriedades Aparelho
        public Int64 Id_Aparelho
        {
            get { return id_Aparelho; }
            set { id_Aparelho = value; }
        }

        public Fabricante? Fabricante
        {
            get { return fabricante; }
            set
            {
                fabricante = value;
            }
        }

        public string? Modelo
        {
            get { return modelo; }
            set { modelo = value; }

        }

        public decimal Altura
        {
            get { return altura; }
            set
            {
                if (value < 0)
                    throw new ApplicationException("O valor da altura nao pode ser menor que zero!");
                else
                    altura = value;
            }
        }

        public decimal Largura
        {
            get { return largura; }
            set { largura = value; }
        }

        public decimal Espessura
        {
            get { return espessura; }
            set { espessura = value; }
        }

        public decimal Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }


        public Int32 Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public decimal Desconto
        {
            get { return desconto; }
            set { desconto = value; }
        }

        public override string ToString()
        {
            return Fabricante.Nome + "   -    " + Modelo +
                    "  \t\t   " + Preco.ToString("C") +
                    "  \t(" + Quantidade + " em estoque)";
        }
    }
}
