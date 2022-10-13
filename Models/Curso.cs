using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string NomeDoCurso{ get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa alunoDoCurso) {
            Alunos.Add(alunoDoCurso);
        }

        public int ObterQuantidadeDeAlunos() {
            return Alunos.Count;
        }

        public bool RemoverAluno(Pessoa alunoDoCurso) {
            return Alunos.Remove(alunoDoCurso);
        }

        public void ListarAlunos() { 

            foreach(Pessoa aluno in Alunos){
                Console.WriteLine(aluno.NomeCompleto);
            }  
        }
    }
}