using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorAluno
{
    class Alunos
    {
        private static int qdta = 0;
        private static long ra = 1570482121001;
        private string nome;
        private int idade;
        
        public static long Ra
        {
            get
            {
                return ra;
            }
        }
        public static int Qtda
        {
            get
            {
                return qdta;
            }
        }

        static Alunos()
        {
             
        }


        //declaração dos metodos
        public Alunos()
        {

        }

        public Alunos(string nome)
        {
            qdta++;
            ra++;
            this.nome = nome;
            
        }

        public Alunos( int idade)
        {
            ra++;
            qdta++;
            this.idade = idade;
        }

        public Alunos(string nome, int idade)
        {
            qdta++;
            ra++;
            this.nome = nome;
            this.idade = idade;
        }
        



        ////declaração das funções
        public void MostrarAtributos()
        {
            Console.WriteLine("RA: " + ra + "\tNome: " + nome +
                "\tIdade: " + idade);

        }

        public void MostrarQuantidadeAlunos()
        {
            Console.WriteLine("Quantidade de alunos: " + qdta);

        }
    }
}
