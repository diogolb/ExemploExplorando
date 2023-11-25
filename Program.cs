using System.ComponentModel;
using System.Data.Common;
using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Diogo", sobrenome: "Busto");
Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>(); 

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);

cursoDeIngles.ListarAlunos();























// Pessoa p1 = new Pessoa();
// p1.Nome = "Diogo";
// p1.Sobrenome = "Busto";
// p1.Idade = 20;
// p1.Apresentar();

