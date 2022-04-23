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
    public class NCliente
    {
        public static string Inserir(string nome, string endereco, string cidade)
        {
            DCliente objDadosc = new DCliente();
            objDadosc.Nomecliente = nome;
            objDadosc.Enderecocliente = endereco;
            objDadosc.Cidadecliente = cidade;
            return objDadosc.Inserir(objDadosc);
        }

        public static string Editar(int idcliente,string nome, string endereco, string cidade)
        {
            DCliente objDadosc = new DCliente();
            objDadosc.Idcliente = idcliente;
            objDadosc.Nomecliente = nome;
            objDadosc.Enderecocliente = endereco;
            objDadosc.Cidadecliente = cidade;
            return objDadosc.Editar(objDadosc);
        }

        public static string Excluir(int idcliente)
        {
            DCliente Obj = new DCliente();
            Obj.Idcliente = idcliente;
            return Obj.Excluir(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DCliente().Mostrar();
        }


    }
}
