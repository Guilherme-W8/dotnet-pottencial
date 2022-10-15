using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Guilherme", sobrenome: "Correia");
Pessoa p2 = new Pessoa(nome: "Lais", sobrenome: "Araujo");

Curso cursoDeIngles = new Curso();
cursoDeIngles.NomeDoCurso = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);

Console.WriteLine($"Quantidade de alunos: {cursoDeIngles.ObterQuantidadeDeAlunos()}");

cursoDeIngles.ListarAlunos();
