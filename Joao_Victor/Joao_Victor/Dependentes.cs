using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joao_Victor
{
    class Dependentes 
    {
       

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Dependentes(int codigo, string nome, int idade)
        {
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
        }

        public bool VerificarMaiorIdade()
        {
            bool aux;
            if (Idade >= 18)
                aux = true;
            else
                aux = false;

            return aux;
        }
    }
}
