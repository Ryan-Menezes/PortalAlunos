namespace PortalAlunos
{
    public class Aluno
    {
        public string Nome { get; private set; } = string.Empty;
        public int Idade { get; private set; }
        public string Curso { get; private set; } = string.Empty;

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
