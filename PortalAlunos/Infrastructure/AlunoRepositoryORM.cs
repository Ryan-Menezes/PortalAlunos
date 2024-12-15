namespace PortalAlunos.Infrastructure
{
    public class AlunoRepositoryORM
    {
        private readonly PortalDbContext _context = new PortalDbContext();

        public List<Aluno> List()
        {
            return _context.Alunos.ToList();
        }

        public void Add(Aluno aluno)
        {
            _context.Add(aluno);
            _context.SaveChanges();
        }
    }
}
