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
    }
}
