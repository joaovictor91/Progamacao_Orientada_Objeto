using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joao_Victor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Funcionario f = new Funcionario();
            Assalariado a1 = new Assalariado(1, "Bia", 1000);
            Comissionado c1 = new Comissionado(2, "Lia", 1000, 0.20);
            Assalariado a2 = new Assalariado(3, "Leo", 2000);
            Comissionado c2 = new Comissionado(4, "Ana", 2000, 0.20);
            a1.VetFD = new List<Dependentes>();
            a2.VetFD = new List<Dependentes>();
            c1.VetFD = new List<Dependentes>();
            c2.VetFD = new List<Dependentes>();
            Departamento d1 = new Departamento(10, "TI");
            Departamento d2 = new Departamento(11, "RH");
            d1.VetF = new List<Funcionario>();
            d2.VetF = new List<Funcionario>();
            d1.Admitir(a1);
            d1.Admitir(c1);
            d2.Admitir(a2);
            d2.Admitir(c2);



            d1.Listar();
            d2.Listar();
            Console.WriteLine(d1.CalcularFolha(30));
            Console.WriteLine(d2.CalcularFolha(30));
            Console.WriteLine();
            //Inserindo Dependetes
            Console.WriteLine("Exibindo os dependentes");
            
            Dependentes dp1 = new Dependentes(1, "Junior", 12);
            Dependentes dp2 = new Dependentes(2, "José", 19);
            Dependentes dp3 = new Dependentes(3, "Marcelo", 50);
            Dependentes dp4 = new Dependentes(4, "Sergio", 11);
            Dependentes dp5 = new Dependentes(5, "Sergio", 17);
            Dependentes dp6 = new Dependentes(6, "João", 1);
            Dependentes dp7 = new Dependentes(7, "Pedro", 17);
            Dependentes dp8 = new Dependentes(8, "Paulo", 6);
            Dependentes dp9 = new Dependentes(9, "Marcos", 19);

            a1.AdicionarDependente(dp1);
            a1.AdicionarDependente(dp6);
            a2.AdicionarDependente(dp2);
            a2.AdicionarDependente(dp9);
            c1.AdicionarDependente(dp3);
            c1.AdicionarDependente(dp5);
            c1.AdicionarDependente(dp7);
            a2.AdicionarDependente(dp4);
            c2.AdicionarDependente(dp8);

            //Exibindo os Dependentes
            a1.ListarDependentes();
            a2.ListarDependentes();
            c1.ListarDependentes();
            c2.ListarDependentes();

            a1.CalcularTotalDependente();
            a2.CalcularTotalDependente();
            c1.CalcularTotalDependente();
            c2.CalcularTotalDependente();

            //Mostrar Quantidade de Dependentes
            d1.MostrarQtdeDependentesFuncionario();
            d2.MostrarQtdeDependentesFuncionario();

            d2.Demitir(4);

            d1.Listar();
            d2.Listar();
            Console.WriteLine(d1.CalcularFolha(30));
            Console.WriteLine(d2.CalcularFolha(30));
            Console.WriteLine();
            
            

            

            //Removendo os Dependentes
            a1.RemoverDependenteCodigo(1);
            a1.RemoverDependenteCodigo(6);
            a2.RemoverDependentesMaioridade();
            c1.RemoverDependentesMaioridade();
            

            Console.WriteLine("Mostrando os Dependentes após as alterações");
            //Exibindo os Dependentes após as alterações
            a1.ListarDependentes();
            a2.ListarDependentes();
            c1.ListarDependentes();
            

            //Mostrar Quantidade de Dependentes após as alterações
            d1.MostrarQtdeDependentesFuncionario();
            d2.MostrarQtdeDependentesFuncionario();


            Console.ReadKey();
        }
    }
}
