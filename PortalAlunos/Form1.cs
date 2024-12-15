using PortalAlunos.Infrastructure;

namespace PortalAlunos
{
    public partial class form1 : Form
    {
        public List<Aluno> Alunos {  get; set; } = new List<Aluno>();
        private AlunoRepositoryORM _repository { get; set; }

        public form1()
        {
            _repository = new AlunoRepositoryORM();

            InitializeComponent();
            ObterAlunos();
        }

        private void ObterAlunos()
        {
            Alunos = _repository.List();

            foreach (var aluno in Alunos)
            {
                lv_alunos.Items.Add(new ListViewItem(
                    new string[] { aluno.Nome, aluno.Idade.ToString(), aluno.Curso }
                ));
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                var nome = txt_nome.Text;
                var idade = txt_idade.Text;
                var curso = txt_curso.Text;

                // var alunosRepetidos = from a in Alunos where a.Nome == nome select a;
                var alunosRepetidos = Alunos.Where(a => a.Nome == nome);

                if (alunosRepetidos.Any())
                {
                    MessageBox.Show(nome + " já está cadastrado no sistema!");
                    return;
                }

                var aluno = new Aluno(nome, idade, curso);

                Alunos.Add(aluno);
                _repository.Add(aluno);

                lv_alunos.Items.Add(new ListViewItem(
                    new string[] { nome, idade, curso }
                ));

                txt_nome.Text = string.Empty;
                txt_idade.Text = string.Empty;
                txt_curso.Text = string.Empty;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
