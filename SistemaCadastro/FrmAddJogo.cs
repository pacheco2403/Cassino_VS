using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class FrmAddJogo : Form
    {
        public FrmAddJogo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sistema sistema = new Sistema();
            this.Hide();
            sistema.ShowDialog();
            this.Close(); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtaddJogo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnaddJogo_Click(object sender, EventArgs e)
        {
            Cassino_2 conecta = new Cassino_2();
            bool retorno = conecta.insereJogo(txtaddJogo.Text);
            if (retorno == true)
            {
                MessageBox.Show("Novo jogo inserido com sucesso!");
                txtaddJogo.Text = "";
                txtaddJogo.Focus();
            }
            else
                MessageBox.Show(conecta.mensagem);
        }
    }
}
