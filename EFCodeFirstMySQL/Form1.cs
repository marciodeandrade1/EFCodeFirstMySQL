using EFCodeFirstMySQL.Model;

namespace EFCodeFirstMySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            using (var context = new MeuContexto())
            {
                dataGridView1.DataSource = context.Clientes.ToList();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (var context = new MeuContexto())
            {
                var cliente = new Cliente
                {
                    Nome = txtNome.Text,
                    Email = txtEmail.Text,
                    DataCadastro = DateTime.Now,
                    Ativo = true
                };
                context.Clientes.Add(cliente);
                context.SaveChanges();

                MessageBox.Show("Cliente salvo com sucesso ");

            }
        }
    }
}
