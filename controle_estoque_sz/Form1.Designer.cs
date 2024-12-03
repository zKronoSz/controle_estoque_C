namespace controle_estoque_sz
{
    partial class Form1
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
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_exibir = new System.Windows.Forms.Button();
            this.btn_grafico = new System.Windows.Forms.Button();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.txt_valor_grupo = new System.Windows.Forms.TextBox();
            this.lbl_valor_grupo = new System.Windows.Forms.Label();
            this.txt_quantidade_grupo = new System.Windows.Forms.TextBox();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.lbl_quatidade_grupo = new System.Windows.Forms.Label();
            this.txt_codico_grupo = new System.Windows.Forms.TextBox();
            this.lbl_codigo_grupo = new System.Windows.Forms.Label();
            this.txt_descricaoGrande = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_excluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_codigo.Location = new System.Drawing.Point(12, 37);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(43, 13);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "Código ";
            this.lbl_codigo.Click += new System.EventHandler(this.lbl_codigo_Click);
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Location = new System.Drawing.Point(187, 37);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(55, 13);
            this.lbl_descricao.TabIndex = 1;
            this.lbl_descricao.Text = "Descrição";
            this.lbl_descricao.Click += new System.EventHandler(this.lbl_descricao_Click);
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Location = new System.Drawing.Point(502, 37);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(62, 13);
            this.lbl_quantidade.TabIndex = 2;
            this.lbl_quantidade.Text = "Quantidade";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(696, 37);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(31, 13);
            this.lbl_valor.TabIndex = 3;
            this.lbl_valor.Text = "Valor";
            this.lbl_valor.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(3, 60);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(90, 40);
            this.btn_novo.TabIndex = 4;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_exibir
            // 
            this.btn_exibir.Location = new System.Drawing.Point(99, 60);
            this.btn_exibir.Name = "btn_exibir";
            this.btn_exibir.Size = new System.Drawing.Size(90, 40);
            this.btn_exibir.TabIndex = 5;
            this.btn_exibir.Text = "Exibir";
            this.btn_exibir.UseVisualStyleBackColor = true;
            this.btn_exibir.Click += new System.EventHandler(this.btn_exibir_Click);
            // 
            // btn_grafico
            // 
            this.btn_grafico.Location = new System.Drawing.Point(99, 104);
            this.btn_grafico.Name = "btn_grafico";
            this.btn_grafico.Size = new System.Drawing.Size(90, 40);
            this.btn_grafico.TabIndex = 6;
            this.btn_grafico.Text = "Grafico";
            this.btn_grafico.UseVisualStyleBackColor = true;
            this.btn_grafico.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(61, 34);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 8;
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(248, 37);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(248, 20);
            this.txt_descricao.TabIndex = 9;
            this.txt_descricao.TextChanged += new System.EventHandler(this.txt_descricao_TextChanged);
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(733, 37);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(90, 20);
            this.txt_valor.TabIndex = 10;
            this.txt_valor.TextChanged += new System.EventHandler(this.txt_valor_TextChanged);
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(570, 37);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(120, 20);
            this.txt_quantidade.TabIndex = 11;
            this.txt_quantidade.TextChanged += new System.EventHandler(this.txt_quantidade_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(195, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(628, 396);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_confirmar);
            this.groupBox1.Controls.Add(this.txt_valor_grupo);
            this.groupBox1.Controls.Add(this.lbl_valor_grupo);
            this.groupBox1.Controls.Add(this.txt_quantidade_grupo);
            this.groupBox1.Controls.Add(this.btn_alterar);
            this.groupBox1.Controls.Add(this.lbl_quatidade_grupo);
            this.groupBox1.Controls.Add(this.txt_codico_grupo);
            this.groupBox1.Controls.Add(this.lbl_codigo_grupo);
            this.groupBox1.Controls.Add(this.txt_descricaoGrande);
            this.groupBox1.Location = new System.Drawing.Point(3, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 309);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "\"\"";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.White;
            this.btn_confirmar.Location = new System.Drawing.Point(33, 272);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(125, 31);
            this.btn_confirmar.TabIndex = 15;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // txt_valor_grupo
            // 
            this.txt_valor_grupo.Location = new System.Drawing.Point(68, 237);
            this.txt_valor_grupo.Name = "txt_valor_grupo";
            this.txt_valor_grupo.Size = new System.Drawing.Size(109, 20);
            this.txt_valor_grupo.TabIndex = 17;
            this.txt_valor_grupo.TextChanged += new System.EventHandler(this.txt_valor_grupo_TextChanged);
            // 
            // lbl_valor_grupo
            // 
            this.lbl_valor_grupo.AutoSize = true;
            this.lbl_valor_grupo.Location = new System.Drawing.Point(30, 237);
            this.lbl_valor_grupo.Name = "lbl_valor_grupo";
            this.lbl_valor_grupo.Size = new System.Drawing.Size(31, 13);
            this.lbl_valor_grupo.TabIndex = 16;
            this.lbl_valor_grupo.Text = "Valor";
            this.lbl_valor_grupo.Click += new System.EventHandler(this.lbl_valor_grupo_Click);
            // 
            // txt_quantidade_grupo
            // 
            this.txt_quantidade_grupo.Location = new System.Drawing.Point(68, 200);
            this.txt_quantidade_grupo.Name = "txt_quantidade_grupo";
            this.txt_quantidade_grupo.Size = new System.Drawing.Size(109, 20);
            this.txt_quantidade_grupo.TabIndex = 16;
            this.txt_quantidade_grupo.TextChanged += new System.EventHandler(this.txt_quantidade_grupo_TextChanged);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(6, 45);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(174, 28);
            this.btn_alterar.TabIndex = 15;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // lbl_quatidade_grupo
            // 
            this.lbl_quatidade_grupo.AutoSize = true;
            this.lbl_quatidade_grupo.Location = new System.Drawing.Point(3, 200);
            this.lbl_quatidade_grupo.Name = "lbl_quatidade_grupo";
            this.lbl_quatidade_grupo.Size = new System.Drawing.Size(62, 13);
            this.lbl_quatidade_grupo.TabIndex = 15;
            this.lbl_quatidade_grupo.Text = "Quantidade";
            this.lbl_quatidade_grupo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_codico_grupo
            // 
            this.txt_codico_grupo.Location = new System.Drawing.Point(58, 19);
            this.txt_codico_grupo.Name = "txt_codico_grupo";
            this.txt_codico_grupo.Size = new System.Drawing.Size(119, 20);
            this.txt_codico_grupo.TabIndex = 15;
            this.txt_codico_grupo.TextChanged += new System.EventHandler(this.txt_codico_grupo_TextChanged);
            // 
            // lbl_codigo_grupo
            // 
            this.lbl_codigo_grupo.AutoSize = true;
            this.lbl_codigo_grupo.Location = new System.Drawing.Point(9, 16);
            this.lbl_codigo_grupo.Name = "lbl_codigo_grupo";
            this.lbl_codigo_grupo.Size = new System.Drawing.Size(43, 13);
            this.lbl_codigo_grupo.TabIndex = 15;
            this.lbl_codigo_grupo.Text = "Código ";
            this.lbl_codigo_grupo.Click += new System.EventHandler(this.lbl_codigo_grupo_Click);
            // 
            // txt_descricaoGrande
            // 
            this.txt_descricaoGrande.Location = new System.Drawing.Point(6, 79);
            this.txt_descricaoGrande.Name = "txt_descricaoGrande";
            this.txt_descricaoGrande.Size = new System.Drawing.Size(174, 96);
            this.txt_descricaoGrande.TabIndex = 15;
            this.txt_descricaoGrande.Text = "";
            this.txt_descricaoGrande.TextChanged += new System.EventHandler(this.txt_descricaoGrande_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(835, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENuToolStripMenuItem
            // 
            this.mENuToolStripMenuItem.Name = "mENuToolStripMenuItem";
            this.mENuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.mENuToolStripMenuItem.Text = "MENU";
            this.mENuToolStripMenuItem.Click += new System.EventHandler(this.mENuToolStripMenuItem_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(3, 104);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(90, 40);
            this.btn_excluir.TabIndex = 7;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(835, 471);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_quantidade);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_grafico);
            this.Controls.Add(this.btn_exibir);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.lbl_quantidade);
            this.Controls.Add(this.lbl_descricao);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_exibir;
        private System.Windows.Forms.Button btn_grafico;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENuToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txt_descricaoGrande;
        private System.Windows.Forms.Label lbl_codigo_grupo;
        private System.Windows.Forms.TextBox txt_codico_grupo;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Label lbl_quatidade_grupo;
        private System.Windows.Forms.Label lbl_valor_grupo;
        private System.Windows.Forms.TextBox txt_quantidade_grupo;
        private System.Windows.Forms.TextBox txt_valor_grupo;
        private System.Windows.Forms.Button btn_confirmar;
    }
}

