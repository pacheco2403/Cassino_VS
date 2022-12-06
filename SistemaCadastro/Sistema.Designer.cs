using System;

namespace SistemaCadastro
{
    partial class Sistema
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

         #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema));
            this.panel1 = new System.Windows.Forms.Panel();
            this.marcador = new System.Windows.Forms.Panel();
            this.btnBusca = new System.Windows.Forms.Button();
            this.btnCadastra = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCadastrar = new System.Windows.Forms.TabPage();
            this.bntAddJogo = new System.Windows.Forms.Button();
            this.cbJogo = new System.Windows.Forms.ComboBox();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnConfirmaCadastro = new System.Windows.Forms.Button();
            this.txtpagamento = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabBuscar = new System.Windows.Forms.TabPage();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnRemoveAposta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dgAposta = new System.Windows.Forms.DataGridView();
            this.tabAlterar = new System.Windows.Forms.TabPage();
            this.lblmsgerro = new System.Windows.Forms.Label();
            this.cbAlteraJogo = new System.Windows.Forms.ComboBox();
            this.txtAlteracliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConfirmaAlteracao = new System.Windows.Forms.Button();
            this.txtAlterapagamento = new System.Windows.Forms.TextBox();
            this.txtAlteraValor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabCadastrar.SuspendLayout();
            this.tabBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAposta)).BeginInit();
            this.tabAlterar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.marcador);
            this.panel1.Controls.Add(this.btnBusca);
            this.panel1.Controls.Add(this.btnCadastra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 502);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // marcador
            // 
            this.marcador.BackColor = System.Drawing.Color.Maroon;
            this.marcador.Location = new System.Drawing.Point(4, 240);
            this.marcador.Margin = new System.Windows.Forms.Padding(4);
            this.marcador.Name = "marcador";
            this.marcador.Size = new System.Drawing.Size(11, 41);
            this.marcador.TabIndex = 8;
            // 
            // btnBusca
            // 
            this.btnBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBusca.FlatAppearance.BorderSize = 0;
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBusca.ForeColor = System.Drawing.Color.White;
            this.btnBusca.Image = ((System.Drawing.Image)(resources.GetObject("btnBusca.Image")));
            this.btnBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusca.Location = new System.Drawing.Point(23, 311);
            this.btnBusca.Margin = new System.Windows.Forms.Padding(4);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(126, 56);
            this.btnBusca.TabIndex = 5;
            this.btnBusca.Text = "&Buscar";
            this.btnBusca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBusca.UseVisualStyleBackColor = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // btnCadastra
            // 
            this.btnCadastra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCadastra.FlatAppearance.BorderSize = 0;
            this.btnCadastra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastra.ForeColor = System.Drawing.Color.White;
            this.btnCadastra.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastra.Image")));
            this.btnCadastra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastra.Location = new System.Drawing.Point(23, 225);
            this.btnCadastra.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastra.Name = "btnCadastra";
            this.btnCadastra.Size = new System.Drawing.Size(126, 56);
            this.btnCadastra.TabIndex = 3;
            this.btnCadastra.Text = "&Cadastrar";
            this.btnCadastra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastra.UseVisualStyleBackColor = false;
            this.btnCadastra.Click += new System.EventHandler(this.btnCadastra_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(966, 173);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(230, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(528, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::SistemaCadastro.Properties.Resources.close;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(868, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 49);
            this.button2.TabIndex = 8;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCadastrar);
            this.tabControl1.Controls.Add(this.tabBuscar);
            this.tabControl1.Controls.Add(this.tabAlterar);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(155, 181);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 321);
            this.tabControl1.TabIndex = 9;
            // 
            // tabCadastrar
            // 
            this.tabCadastrar.BackColor = System.Drawing.Color.Silver;
            this.tabCadastrar.Controls.Add(this.bntAddJogo);
            this.tabCadastrar.Controls.Add(this.cbJogo);
            this.tabCadastrar.Controls.Add(this.txtcliente);
            this.tabCadastrar.Controls.Add(this.label6);
            this.tabCadastrar.Controls.Add(this.BtnConfirmaCadastro);
            this.tabCadastrar.Controls.Add(this.txtpagamento);
            this.tabCadastrar.Controls.Add(this.txtvalor);
            this.tabCadastrar.Controls.Add(this.label3);
            this.tabCadastrar.Controls.Add(this.label2);
            this.tabCadastrar.Controls.Add(this.label4);
            this.tabCadastrar.Location = new System.Drawing.Point(4, 26);
            this.tabCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.tabCadastrar.Name = "tabCadastrar";
            this.tabCadastrar.Padding = new System.Windows.Forms.Padding(4);
            this.tabCadastrar.Size = new System.Drawing.Size(777, 291);
            this.tabCadastrar.TabIndex = 0;
            this.tabCadastrar.Text = "Cadastrar";
            this.tabCadastrar.Click += new System.EventHandler(this.tabCadastrar_Click);
            // 
            // bntAddJogo
            // 
            this.bntAddJogo.FlatAppearance.BorderSize = 0;
            this.bntAddJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAddJogo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntAddJogo.ForeColor = System.Drawing.Color.DimGray;
            this.bntAddJogo.Image = ((System.Drawing.Image)(resources.GetObject("bntAddJogo.Image")));
            this.bntAddJogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntAddJogo.Location = new System.Drawing.Point(693, 128);
            this.bntAddJogo.Margin = new System.Windows.Forms.Padding(4);
            this.bntAddJogo.Name = "bntAddJogo";
            this.bntAddJogo.Size = new System.Drawing.Size(26, 33);
            this.bntAddJogo.TabIndex = 15;
            this.bntAddJogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntAddJogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntAddJogo.UseVisualStyleBackColor = true;
            this.bntAddJogo.Click += new System.EventHandler(this.bntAddJogo_Click_1);
            // 
            // cbJogo
            // 
            this.cbJogo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbJogo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbJogo.FormattingEnabled = true;
            this.cbJogo.Location = new System.Drawing.Point(142, 131);
            this.cbJogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbJogo.Name = "cbJogo";
            this.cbJogo.Size = new System.Drawing.Size(540, 29);
            this.cbJogo.TabIndex = 10;
            this.cbJogo.SelectedIndexChanged += new System.EventHandler(this.cbJogo_SelectedIndexChanged);
            // 
            // txtcliente
            // 
            this.txtcliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcliente.Location = new System.Drawing.Point(142, 193);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(540, 27);
            this.txtcliente.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(51, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cliente:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // BtnConfirmaCadastro
            // 
            this.BtnConfirmaCadastro.FlatAppearance.BorderSize = 0;
            this.BtnConfirmaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmaCadastro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConfirmaCadastro.ForeColor = System.Drawing.Color.DimGray;
            this.BtnConfirmaCadastro.Image = ((System.Drawing.Image)(resources.GetObject("BtnConfirmaCadastro.Image")));
            this.BtnConfirmaCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmaCadastro.Location = new System.Drawing.Point(355, 227);
            this.BtnConfirmaCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConfirmaCadastro.Name = "BtnConfirmaCadastro";
            this.BtnConfirmaCadastro.Size = new System.Drawing.Size(128, 56);
            this.BtnConfirmaCadastro.TabIndex = 13;
            this.BtnConfirmaCadastro.Text = "Confirmar";
            this.BtnConfirmaCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmaCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfirmaCadastro.UseVisualStyleBackColor = true;
            this.BtnConfirmaCadastro.Click += new System.EventHandler(this.BtnConfirmaCadastro_Click_1);
            // 
            // txtpagamento
            // 
            this.txtpagamento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtpagamento.Location = new System.Drawing.Point(458, 65);
            this.txtpagamento.Margin = new System.Windows.Forms.Padding(4);
            this.txtpagamento.Name = "txtpagamento";
            this.txtpagamento.Size = new System.Drawing.Size(224, 27);
            this.txtpagamento.TabIndex = 11;
            this.txtpagamento.TextChanged += new System.EventHandler(this.txtpagamento_TextChanged);
            // 
            // txtvalor
            // 
            this.txtvalor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtvalor.Location = new System.Drawing.Point(142, 65);
            this.txtvalor.Margin = new System.Windows.Forms.Padding(4);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(137, 29);
            this.txtvalor.TabIndex = 9;
            this.txtvalor.TextChanged += new System.EventHandler(this.txtvalor_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(319, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pagamento:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(74, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Jogo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(66, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tabBuscar
            // 
            this.tabBuscar.BackColor = System.Drawing.Color.Silver;
            this.tabBuscar.Controls.Add(this.btnAlterar);
            this.tabBuscar.Controls.Add(this.btnRemoveAposta);
            this.tabBuscar.Controls.Add(this.label5);
            this.tabBuscar.Controls.Add(this.txtBusca);
            this.tabBuscar.Controls.Add(this.dgAposta);
            this.tabBuscar.Location = new System.Drawing.Point(4, 26);
            this.tabBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.tabBuscar.Name = "tabBuscar";
            this.tabBuscar.Padding = new System.Windows.Forms.Padding(4);
            this.tabBuscar.Size = new System.Drawing.Size(777, 291);
            this.tabBuscar.TabIndex = 1;
            this.tabBuscar.Text = "Buscar";
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlterar.ForeColor = System.Drawing.Color.DimGray;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(564, 4);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(122, 38);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnRemoveAposta
            // 
            this.btnRemoveAposta.FlatAppearance.BorderSize = 0;
            this.btnRemoveAposta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAposta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveAposta.ForeColor = System.Drawing.Color.DimGray;
            this.btnRemoveAposta.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveAposta.Image")));
            this.btnRemoveAposta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveAposta.Location = new System.Drawing.Point(423, 1);
            this.btnRemoveAposta.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveAposta.Name = "btnRemoveAposta";
            this.btnRemoveAposta.Size = new System.Drawing.Size(122, 41);
            this.btnRemoveAposta.TabIndex = 14;
            this.btnRemoveAposta.Text = "Remover";
            this.btnRemoveAposta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveAposta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveAposta.UseVisualStyleBackColor = true;
            this.btnRemoveAposta.Click += new System.EventHandler(this.btnRemoveAposta_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Aposta:";
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBusca.Location = new System.Drawing.Point(95, 11);
            this.txtBusca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(304, 27);
            this.txtBusca.TabIndex = 1;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // dgAposta
            // 
            this.dgAposta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAposta.BackgroundColor = System.Drawing.Color.White;
            this.dgAposta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAposta.Location = new System.Drawing.Point(31, 44);
            this.dgAposta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgAposta.Name = "dgAposta";
            this.dgAposta.ReadOnly = true;
            this.dgAposta.RowHeadersWidth = 51;
            this.dgAposta.RowTemplate.Height = 29;
            this.dgAposta.Size = new System.Drawing.Size(697, 218);
            this.dgAposta.TabIndex = 0;
            this.dgAposta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgJogo_CellContentClick);
            // 
            // tabAlterar
            // 
            this.tabAlterar.BackColor = System.Drawing.Color.Silver;
            this.tabAlterar.Controls.Add(this.lblmsgerro);
            this.tabAlterar.Controls.Add(this.cbAlteraJogo);
            this.tabAlterar.Controls.Add(this.txtAlteracliente);
            this.tabAlterar.Controls.Add(this.label7);
            this.tabAlterar.Controls.Add(this.btnConfirmaAlteracao);
            this.tabAlterar.Controls.Add(this.txtAlterapagamento);
            this.tabAlterar.Controls.Add(this.txtAlteraValor);
            this.tabAlterar.Controls.Add(this.label8);
            this.tabAlterar.Controls.Add(this.label9);
            this.tabAlterar.Controls.Add(this.label10);
            this.tabAlterar.Location = new System.Drawing.Point(4, 26);
            this.tabAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAlterar.Name = "tabAlterar";
            this.tabAlterar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAlterar.Size = new System.Drawing.Size(777, 291);
            this.tabAlterar.TabIndex = 2;
            this.tabAlterar.Text = "Alterar";
            // 
            // lblmsgerro
            // 
            this.lblmsgerro.AutoSize = true;
            this.lblmsgerro.ForeColor = System.Drawing.Color.Red;
            this.lblmsgerro.Location = new System.Drawing.Point(0, 2);
            this.lblmsgerro.Name = "lblmsgerro";
            this.lblmsgerro.Size = new System.Drawing.Size(14, 17);
            this.lblmsgerro.TabIndex = 10;
            this.lblmsgerro.Text = "*";
            // 
            // cbAlteraJogo
            // 
            this.cbAlteraJogo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbAlteraJogo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAlteraJogo.FormattingEnabled = true;
            this.cbAlteraJogo.Location = new System.Drawing.Point(137, 104);
            this.cbAlteraJogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAlteraJogo.Name = "cbAlteraJogo";
            this.cbAlteraJogo.Size = new System.Drawing.Size(572, 29);
            this.cbAlteraJogo.TabIndex = 23;
            this.cbAlteraJogo.SelectedIndexChanged += new System.EventHandler(this.cbAlteraJogo_SelectedIndexChanged);
            // 
            // txtAlteracliente
            // 
            this.txtAlteracliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAlteracliente.Location = new System.Drawing.Point(137, 176);
            this.txtAlteracliente.Name = "txtAlteracliente";
            this.txtAlteracliente.Size = new System.Drawing.Size(572, 27);
            this.txtAlteracliente.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(44, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Cliente:";
            // 
            // btnConfirmaAlteracao
            // 
            this.btnConfirmaAlteracao.FlatAppearance.BorderSize = 0;
            this.btnConfirmaAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmaAlteracao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmaAlteracao.ForeColor = System.Drawing.Color.DimGray;
            this.btnConfirmaAlteracao.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmaAlteracao.Image")));
            this.btnConfirmaAlteracao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmaAlteracao.Location = new System.Drawing.Point(345, 221);
            this.btnConfirmaAlteracao.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmaAlteracao.Name = "btnConfirmaAlteracao";
            this.btnConfirmaAlteracao.Size = new System.Drawing.Size(142, 61);
            this.btnConfirmaAlteracao.TabIndex = 22;
            this.btnConfirmaAlteracao.Text = "Confirmar Alteração";
            this.btnConfirmaAlteracao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmaAlteracao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmaAlteracao.UseVisualStyleBackColor = true;
            this.btnConfirmaAlteracao.Click += new System.EventHandler(this.btnConfirmaAlteracao_Click);
            // 
            // txtAlterapagamento
            // 
            this.txtAlterapagamento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAlterapagamento.Location = new System.Drawing.Point(468, 47);
            this.txtAlterapagamento.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlterapagamento.Name = "txtAlterapagamento";
            this.txtAlterapagamento.Size = new System.Drawing.Size(241, 27);
            this.txtAlterapagamento.TabIndex = 19;
            this.txtAlterapagamento.TextChanged += new System.EventHandler(this.txtAlterapagamento_TextChanged);
            // 
            // txtAlteraValor
            // 
            this.txtAlteraValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAlteraValor.Location = new System.Drawing.Point(137, 47);
            this.txtAlteraValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlteraValor.Name = "txtAlteraValor";
            this.txtAlteraValor.Size = new System.Drawing.Size(138, 29);
            this.txtAlteraValor.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(330, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Pagamento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(68, 110);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "Jogo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(59, 53);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 23);
            this.label10.TabIndex = 14;
            this.label10.Text = "Valor:";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.ForeColor = System.Drawing.Color.Red;
            this.lblMensagem.Location = new System.Drawing.Point(635, 30);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 15);
            this.lblMensagem.TabIndex = 1;
            // 
            // Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(921, 502);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Sistema_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabCadastrar.ResumeLayout(false);
            this.tabCadastrar.PerformLayout();
            this.tabBuscar.ResumeLayout(false);
            this.tabBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAposta)).EndInit();
            this.tabAlterar.ResumeLayout(false);
            this.tabAlterar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCadastra;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCadastrar;
        private System.Windows.Forms.TabPage tabBuscar;
        private System.Windows.Forms.Button BtnConfirmaCadastro;
        private System.Windows.Forms.TextBox txtpagamento;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel marcador;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgAposta;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnRemoveAposta;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TabPage tabAlterar;
        private System.Windows.Forms.TextBox txtAlteracliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConfirmaAlteracao;
        private System.Windows.Forms.TextBox txtAlterapagamento;
        private System.Windows.Forms.TextBox txtAlteraValor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbJogo;
        private System.Windows.Forms.Button bntAddJogo;
        private System.Windows.Forms.ComboBox cbAlteraJogo;
        private System.Windows.Forms.Label lblmsgerro;
        private readonly EventHandler bntAddJogo_Click;
    }
}