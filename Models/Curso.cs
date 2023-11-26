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

                for (int count = 0; count < Alunos.Count; count++)
                {
                    string texto = $"Número {count + 1} - {Alunos[count].NomeCompleto}";
                    Console.WriteLine(texto);
                }
               
            } else {
                Console.WriteLine("Não há alunos cadastrados.");
            }
        }
    }
}