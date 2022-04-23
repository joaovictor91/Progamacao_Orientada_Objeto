using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//carrega a Camada de Dados
using CamadaDados;
using System.Data;//referente ao objeto DataGridView

namespace CamadaNegocio
{
    public class NProduto
    {
        public static string Inserir(string nome, double preco, int qtde)
        {
            DProduto objDados = new DProduto();
            objDados.Nomeproduto = nome;
            objDados.Precounitario = preco;
            objDados.QtdeEstoque = qtde;
            return objDados.Inserir(objDados);
        }
        public static string Editar(int idProduto, string nome, double preco, int qtdeEstoque)
        {
            DProduto Obj = new DProduto();
            Obj.Idproduto = idProduto;
            Obj.Nomeproduto = nome;
            Obj.Precounitario = preco;
            Obj.QtdeEstoque = qtdeEstoque;
            return Obj.Editar(Obj);
        }

        public static string Excluir(int idproduto)
        {
            DProduto Obj = new DProduto();
            Obj.Idproduto = idproduto;
            return Obj.Excluir(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DProduto().Mostrar();
        }
    }
}
