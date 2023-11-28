using System.ComponentModel;
using System.Data.Common;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using ExemploExplorando.Models;
using Newtonsoft.Json;

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " + 
                      $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm, ")}" +
                      $"Desconto: {venda.Desconto}");
}























// bool? desejaReceberEmail = null;



















// if(desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("O usuário deseja receber e-mail.");
// }
// else
// {
//     Console.WriteLine("O usuário não respondeu ou optou por não receber e-mail.");
// }

















// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " + 
//                       $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
// }



















// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de Escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);
























// int numero = 20;
// bool ehPar = false;

// ehPar = numero % 2 == 0;

// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "Ímpar")");













// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O número é par!");
// }
// else
// {
//     Console.WriteLine($"O número é impar!");
// }
















// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {   
//     Console.WriteLine("Quantidade linhas do arquivo: " + quantidadeLinhas);
//     foreach(string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo.");
// }



















// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Diogo", "Busto", 1.80M);

// Console.WriteLine(tupla.Id);
// Console.WriteLine(tupla.Nome);
// Console.WriteLine(tupla.Sobrenome);
// Console.WriteLine(tupla.Altura);











// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
// }













// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}"); 




















// new ExemploExececao().Metodo1();

























// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach(string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// } 
// catch(Exception ex)
// {
//     Console.Write($"Ocorreu uma execeção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui.");
// }















// DateTime data = DateTime.Now;

// Console.WriteLine(data.ToString("dd/MM/yyyy"));





















// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;

// //:C no final da variável significa Currecy (de moeda).
// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));













// int numero1 = 10;
// int numero2 = 20;

// int resultado = numero1 + numero2;

// Console.WriteLine(resultado);

















// Pessoa p1 = new Pessoa(nome: "Diogo", sobrenome: "Busto");
// Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>(); 

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);

// cursoDeIngles.ListarAlunos();























// Pessoa p1 = new Pessoa();
// p1.Nome = "Diogo";
// p1.Sobrenome = "Busto";
// p1.Idade = 20;
// p1.Apresentar();

