using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            if(Alunos.Any())
            {
                Console.WriteLine($"Os alunos matriculados no curso {Nome} são: ");
                foreach(Pessoa aluno in Alunos)
                {
                    Console.WriteLine($"{aluno.NomeCompleto}");
                } 
            } else {
                Console.WriteLine("Não há alunos cadastrados.");
            }
        }
    }
}