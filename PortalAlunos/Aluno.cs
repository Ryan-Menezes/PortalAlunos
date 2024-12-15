using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalAlunos
{
    [Table("alunos")]
    public class Aluno
    {
        [Key]
        [Column("id")]
        public int Id { get; private set; }
        [Column("nome")]
        public string Nome { get; private set; } = string.Empty;
        [Column("idade")]
        public int Idade { get; private set; }
        [Column("curso")]
        public string Curso { get; private set; } = string.Empty;

        public Aluno()
        {
        }

        public Aluno(string nome, string idade, string curso)
        {
            if (string.IsNullOrEmpty(nome)) throw new Exception("O nome é obrigatório!");
            if (string.IsNullOrEmpty(idade)) throw new Exception("A idade é obrigatória!");
            if (string.IsNullOrEmpty(curso)) throw new Exception("O curso é obrigatório!");

            Nome = nome;
            Idade = int.Parse(idade);
            Curso = curso;
        }
    }
}
