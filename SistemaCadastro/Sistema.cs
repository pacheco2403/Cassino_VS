using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class Sistema : Form
    {
        int idAlterar;

        public Sistema()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            marcador.Height = btnCadastra.Height;
            marcador.Top = btnCadastra.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[0];
        }


        private void btnBusca_Click(object sender, EventArgs e)
        {
            marcador.Height = btnBusca.Height;
            marcador.Top = btnBusca.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }



        void listaJogo()
        {
            Cassino_2 con = new Cassino_2();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaJogo();
            cbJogo.DataSource = tabelaDados;
            cbJogo.DisplayMember = "nome";
            cbJogo.ValueMember = "codJogo";

            cbAlteraJogo.DataSource = tabelaDados;
            cbAlteraJogo.DisplayMember = "nome";
            cbAlteraJogo.ValueMember = "codJogo";
            lblmsgerro.Text = con.mensagem;
            cbAlteraJogo.Text = "";
            cbJogo.Text = "";
        }

        void listaAposta()
        {
            Cassino_2 con = new Cassino_2();
            dgAposta.DataSource = con.listaAposta();

        }
        void limpaCampos()
        {
            txtvalor.Text = "";
            cbJogo.Text = "";
            txtpagamento.Text = "";
            txtcliente.Text = "";
            txtvalor.Focus();
        }

        private void Sistema_Load(object sender, EventArgs e)
        {
            listaJogo();
            listaAposta();
        }


        private void BtnConfirmaCadastro_Click_1(object sender, EventArgs e)
        {
            Aposta a = new Aposta();
            a.Valor = txtvalor.Text;
            a.Jogos_codJogo = Convert.ToInt32(cbJogo.SelectedValue.ToString());
            a.FormaPagamento = txtpagamento.Text;
            a.NomeCliente = txtcliente.Text;
            // enviar para o banco 
            Cassino_2 conecta = new Cassino_2();
            bool retorno = conecta.insereAposta(a);
            if (retorno == true)
            {
                MessageBox.Show("Aposta cadastrada!");
            }
            else
                lblmsgerro.Text = conecta.mensagem;

            listaAposta();
            limpaCampos();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            (dgAposta.DataSource as DataTable).
               DefaultView.RowFilter = String.Format("nomeCliente like'{0}%'", txtBusca.Text);
            limpaCampos();
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int linha = dgAposta.CurrentRow.Index;// pega a linha selecionada
            idAlterar = Convert.ToInt32(
              dgAposta.Rows[linha].Cells["codAposta"].Value.ToString());
            txtAlteraValor.Text =
                 dgAposta.Rows[linha].Cells["valor"].Value.ToString();
            txtAlterapagamento.Text =
                dgAposta.Rows[linha].Cells["formaPagamento"].Value.ToString();
            txtAlteracliente.Text =
               dgAposta.Rows[linha].Cells["nomeCliente"].Value.ToString();
            cbAlteraJogo.Text =
                dgAposta.Rows[linha].Cells["nome"].Value.ToString();
            tabControl1.SelectedTab = tabAlterar;// muda aba

        }

        private void btnConfirmaAlteracao_Click(object sender, EventArgs e)
        {
            Aposta a = new Aposta();
            a.Valor = txtAlteraValor.Text;
            a.FormaPagamento = txtAlterapagamento.Text;
            a.NomeCliente = txtAlteracliente.Text;
            a.Jogos_codJogo = Convert.ToInt32(cbAlteraJogo.SelectedValue.ToString());
            // Envia os dados para alterar
            Cassino_2 conecta = new Cassino_2();
            bool retorno = conecta.alteraAposta(a, idAlterar);
            if (retorno == true)
                MessageBox.Show("Dados alterados com sucesso");
            else
                lblmsgerro.Text = conecta.mensagem;

            listaAposta();


        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtvalor_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgJogo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cbJogo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtpagamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntAddJogo_Click_1(object sender, EventArgs e)
        {
            FrmAddJogo frmAddJogo = new FrmAddJogo();
            this.Hide();
            frmAddJogo.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveAposta_Click_1(object sender, EventArgs e)
        {
            int linha = dgAposta.CurrentRow.Index;// pega a linha selecionada
            int idRemover = Convert.ToInt32(dgAposta.Rows[linha].Cells["codAposta"].Value.ToString());
            DialogResult resp =
                 MessageBox.Show
                   ("Confirma exclusão?", "Remove aposta",
                            MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                Cassino_2 conecta = new Cassino_2();
                bool retorno = conecta.deletaAposta(idRemover);
                if (retorno == true)
                    MessageBox.Show("Aposta excluida");
                else
                    lblmsgerro.Text = conecta.mensagem;
                listaAposta();
            }// fim if ok
            else
                MessageBox.Show("Operação cancelada");


        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbAlteraJogo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAlterapagamento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

