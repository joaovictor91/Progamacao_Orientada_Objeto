using System;
using System.Collections.Generic;
using System.Linq;

namespace Joao_Victor
{
    abstract class Funcionario
    {
        public int Codigo { get; set; }//forma compacta de realizar o encapsulamento
        public string Nome { get; set; }
        public double Salario { get; set; }
        public List<Dependentes> VetFD { get; set; }

        protected Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
            
        }

        public abstract double CalcularSalario(int diasUteis);//métodos abstrato só tem a assinatura
        //dele, se o método é abstrato as subclassees são OBRIGADAS A IMPLEMENTÁ-LOS
        //Você programador NÃO É OBRIGADO A TER um método abstrato,  É OPCIONAL


        public virtual void Mostrar()//método com polimorfismo
        {
            Console.WriteLine("Código: " + Codigo +
                    "\tNome: " + Nome + "\tSálario: R$" + Salario);
        }

        public virtual void AdicionarDependente(Dependentes dp)
        {
            VetFD.Add(dp);
        }

        public virtual void ListarDependentes()
        {
            Console.WriteLine("\nRelãção " +
                "dos Dependentes dos Funcionários " + Nome);
            if (VetFD.Count == 0)
            {
                Console.WriteLine("Não possui Dependentes");
            }
            else
            {
                for (int i = 0; i < VetFD.Count; i++)//Count = qtde de elementos do vetor
                {
                    Console.WriteLine("Código: " + VetFD[i].Codigo +
                        "\tNome: " + VetFD[i].Nome + "\tIdade: " + VetFD[i].Idade);

                }
            }
            
        }

        public virtual void RemoverDependentesMaioridade()
        {
            Console.WriteLine("O Funcionário(a) " + Nome + " e seus os dependetes:");
            
            
            for (int i = 0; i < VetFD.Count; i++)//Count = qtde de elementos do vetor
            {
                Dependentes dp = VetFD.ElementAt<Dependentes>(i);

                if (VetFD[i].VerificarMaiorIdade() == true)
                {
                    Console.WriteLine("O Dependente foi Removido: " + VetFD[i].Nome);
                    VetFD.Remove(dp);
                    i = i - 1;
                }
                

            }
        }

        public void RemoverDependenteCodigo(int codigo_pesquisa)
        {
            Console.WriteLine("O Funcionário(a) " + Nome+" e seus os dependetes:");
            for (int i = 0; i < VetFD.Count; i++)
            {//generalizado
                Dependentes dp = VetFD.ElementAt<Dependentes>(i);
                if (codigo_pesquisa == dp.Codigo)
                {
                    Console.WriteLine("O Dependente foi Removido: " + VetFD[i].Nome);
                    VetFD.Remove(dp);
                }
                    
            }
        }

        public int CalcularTotalDependente()
        {
            int count = 0;
            for (int i = 0; i < VetFD.Count; i++)//Count = qtde de elementos do vetor
            {
                count ++;


            }
            return count;
        }

        public virtual void Remover()
        {
            
        }

        
    }
}
