using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Celulares73A.Model.Entidades;
using Celulares73A.Model.Suporte;

namespace Celulares73A.Model
{
    public static class Servico
    {
        //Metodos que criam os objetos que representam as entidades utilizadas
        //no projeto

        public static Fabricante objFabricante(ref NpgsqlDataReader dtr)
        {
            Fabricante fab = new Fabricante();
            fab.Id_Fabricante = Convert.ToInt64(dtr["id_fabricante"]);
            fab.Nome = dtr["nome"].ToString();

            return fab;
        }

        public static Aparelho objAparelho(ref NpgsqlDataReader dtr)
        {
            Aparelho ap = new Aparelho();
            ap.Id_Aparelho = Convert.ToInt64(dtr["id_aparelho"]);

            ap.Fabricante = objFabricante(ref dtr);

            ap.Modelo = dtr["modelo"].ToString();
            ap.Largura = Convert.ToDecimal(dtr["largura"]);
            ap.Altura = Convert.ToDecimal(dtr["altura"]);
            ap.Espessura = Convert.ToDecimal(dtr["espessura"]);
            ap.Peso = Convert.ToDecimal(dtr["peso"]);
            ap.Preco = Convert.ToDecimal(dtr["preco"]);
            ap.Quantidade = Convert.ToInt32(dtr["quantidade"]);
            ap.Desconto = Convert.ToDecimal(dtr["desconto"]);

            return ap;

        }

        private static Pedido objPedido (ref NpgsqlDataReader dtr)
        {
            Pedido ped = new Pedido();
            ped.Id_Pedido = Convert.ToInt64(dtr["id_pedido"]);

            ped.Aparelho = objAparelho(ref dtr);

            ped.Quantidade = Convert.ToInt32(dtr["quantidade"]);
            ped.DataPedido = Convert.ToDateTime(dtr["datapedido"]);
            ped.Observacao = dtr["observacao"].ToString();

            return ped;
        }

        private static void Salvar(Aparelho ap)
        {
            string sql;

            List<object> param = new List<object>();

            param.Add(ap.Fabricante.Id_Fabricante);
            param.Add(ap.Modelo);
            param.Add(ap.Altura);
            param.Add(ap.Largura);
            param.Add(ap.Espessura);
            param.Add(ap.Peso);
            param.Add(ap.Preco);
            param.Add(ap.Quantidade);
            param.Add(ap.Desconto);


            if (ap.Id_Aparelho == 0)
            {
                sql = "insert into apaelho (";
                sql += "modelo, ";
                sql += "altura, ";
                sql += "largura, ";
                sql += "espessura, ";
                sql += "peso, ";
                sql += "preco, ";
                sql += "quantidade, ";
                sql += "desconto) values (";
                sql += "@1, @2, @3, @4, @5, @6, @7, @8, @9)";
            }
            else
            {
                param.Add(ap.Id_Aparelho);
                sql = "update aparelho set ";
                sql +=      "id_fabricante = @1, ";
                sql +=      "modelo = @2, ";
                sql +=      "altura = @3, ";
                sql +=      "largura = @4, ";
                sql +=      "espessura = @5, ";
                sql +=      "peso = @6, ";
                sql +=      "preco = @7, ";
                sql +=      "quantidade = @8, ";
                sql +=      "desconto = @9 ";
                sql += "where id_aparelho = @10";
           
            }

            ConexaoBanco.executar(sql, param);
        }
            
    }
}
