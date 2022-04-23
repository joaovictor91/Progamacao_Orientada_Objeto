using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Alunos q = new Alunos();

            Alunos a1 = new Alunos("Maria de Fátima");
            a1.MostrarAtributos();
            Alunos a2 = new Alunos(30);
            a2.MostrarAtributos();
            Alunos a3 = new Alunos("João Victor Amaro Franco", 21);
            a3.MostrarAtributos();
            Alunos a4 = new Alunos("José",50);
            a4.MostrarAtributos();
            Alunos a5 = new Alunos("Carlos Eduardo");
            a5.MostrarAtributos();
            
            q.MostrarQuantidadeAlunos();

            Console.ReadKey();
        }
    }
}
