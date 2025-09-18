using System;
using System.Windows.Forms;
using CadastroCidadao.Services;

namespace CadastroCidadao.UI
{
    public partial class FormMain : Form
    {
        private CadastroService _service = new CadastroService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string mensagem = _service.Cadastrar(txtNome.Text, txtCPF.Text);
            MessageBox.Show(mensagem);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var cpf = txtBuscarCPF.Text;
            var nome = txtBuscarNome.Text;

            var cidadao = !string.IsNullOrEmpty(cpf)
                ? _service.BuscarPorCPF(cpf)
                : _service.BuscarPorNome(nome);

            if (cidadao == null)
                MessageBox.Show("Cidadão não encontrado!");
            else
                MessageBox.Show($"Nome: {cidadao.Nome}\nCPF: {cidadao.CPF}");
        }
    }
}
