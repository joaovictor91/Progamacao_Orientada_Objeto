using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joao_Victor
{
    class Departamento
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public List<Funcionario> VetF { get; set; }

        public Departamento(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public void Admitir(Funcionario f)
        {
            VetF.Add(f);
        }

        public void Listar()
        {
            Console.WriteLine("\nRelãção " +
                "dos Funcionarios do departamento: " + Nome);
            foreach (Funcionario f in VetF)
            {
                f.Mostrar();
            }

        }

        public double CalcularFolha(int diasUteis)
        {
            Console.WriteLine("\nFolha de Pagamento" +
                " dos Funcionários do departamento " + Nome);
            double folha = 0;
            for (int i = 0; i < VetF.Count; i++)//Count = qtde de elementos do vetor
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                folha = folha + f.CalcularSalario(diasUteis);
            }
            return folha;
        }
        public virtual void Demitir(int codigo_pesquisa)
        {
            for (int i = 0; i < VetF.Count; i++)
            {//generalizado
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                if (codigo_pesquisa == f.Codigo)
                {
                    Console.WriteLine("Foi Demitido(a): " +VetF[i].Nome);
                    VetF.Remove(f);
                }
                    
            }
        }
        

        public  virtual void MostrarQtdeDependentesFuncionario()
        {
            int aux;

            
            for (int i = 0; i < VetF.Count; i++)//Count = qtde de elementos do vetor
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                aux=f.CalcularTotalDependente();
                Console.WriteLine("\nQuantidade de Dependentes: " + f.Nome);
                Console.WriteLine(aux);
            }
            
        }


    }
}
