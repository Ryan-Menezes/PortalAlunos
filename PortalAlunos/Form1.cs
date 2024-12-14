namespace PortalAlunos
{
    public partial class form1 : Form
    {
        public List<Aluno> Alunos {  get; set; } = new List<Aluno>();

        public form1()
        {
            InitializeComponent();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                var nome = txt_nome.Text;
                var idade = txt_idade.Text;
                var curso = txt_curso.Text;

                foreach (var a in Alunos)
                {
                    if (a.Nome == nome)
                    {
                        MessageBox.Show(nome + " já está cadastrado no sistema!");
                        return;
                    }
                }

                var aluno = new Aluno(nome, idade, curso);
                Alunos.Add(aluno);

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
