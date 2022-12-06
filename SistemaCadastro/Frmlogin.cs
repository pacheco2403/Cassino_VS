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
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnllogin_Click(object sender, EventArgs e)
        {
           Cassino_2 conecta = new Cassino_2();
            if (conecta.verifica(txtusuario.Text, txtsenha.Text) == true)

            {
                Sistema sistema = new Sistema();
                this.Hide();
                sistema.ShowDialog();
                this.Close();
            }
            else 
                MessageBox.Show("Usuário ou senha incorreta!");
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
