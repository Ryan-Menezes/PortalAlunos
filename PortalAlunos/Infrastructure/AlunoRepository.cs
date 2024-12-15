using Dapper;

namespace PortalAlunos.Infrastructure
{
    public class AlunoRepository
    {
        public List<Aluno> List()
        {
            using var conn = new DbConnection();

            string query = @"SELECT id, nome, idade, curso FROM alunos";

            var alunos = conn.Connection.Query<Aluno>(sql: query);

            return alunos.ToList();
        }

        public bool Add(Aluno aluno)
        {
            using var conn = new DbConnection();

            string query = @"INSERT INTO alunos(nome, idade, curso)
                             VALUES (@nome, @idade, @curso)";

            var result = conn.Connection.Execute(sql: query, param: aluno);

            return result == 1;
        }
    }
}
