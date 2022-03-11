using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celulares73A.Model.Entidades
{
    public class Pedido
    {
        private Int64 id_Pedido;
        private Aparelho? aparelho;
        private int quantidade;
        private DateTime datapedido;
        private string? observacao;

        public Int64 Id_Pedido
        {
            get { return id_Pedido; }
            set { id_Pedido = value; }
        }

        public Aparelho? Aparelho
        {
            get { return aparelho; }
            set { aparelho = value; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public DateTime DataPedido
        {
            get { return datapedido; }
            set { datapedido = value; }
        }

        public string? Observacao
        {
            get
            {
                return observacao;
            }
            set
            {
                observacao = value;
            }

        }
    }
}
