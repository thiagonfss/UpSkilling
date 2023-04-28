namespace WindowsFormsUPSKILLINGGAMA
{
    partial class frm_veiculos
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.txt_nome_carro = new System.Windows.Forms.TextBox();
            this.lbl_nome_carro = new System.Windows.Forms.Label();
            this.lbl_placa = new System.Windows.Forms.Label();
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_tpo_servico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(404, 10);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 17;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(465, 194);
            this.dataGridView1.TabIndex = 16;
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(404, 68);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 15;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(404, 39);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 14;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(279, 64);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar.TabIndex = 13;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Location = new System.Drawing.Point(30, 41);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(37, 13);
            this.lbl_marca.TabIndex = 12;
            this.lbl_marca.Text = "Marca";
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(73, 38);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(145, 20);
            this.txt_marca.TabIndex = 11;
            // 
            // txt_nome_carro
            // 
            this.txt_nome_carro.Location = new System.Drawing.Point(73, 12);
            this.txt_nome_carro.Name = "txt_nome_carro";
            this.txt_nome_carro.Size = new System.Drawing.Size(145, 20);
            this.txt_nome_carro.TabIndex = 10;
            // 
            // lbl_nome_carro
            // 
            this.lbl_nome_carro.AutoSize = true;
            this.lbl_nome_carro.Location = new System.Drawing.Point(25, 15);
            this.lbl_nome_carro.Name = "lbl_nome_carro";
            this.lbl_nome_carro.Size = new System.Drawing.Size(42, 13);
            this.lbl_nome_carro.TabIndex = 9;
            this.lbl_nome_carro.Text = "Modelo";
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Location = new System.Drawing.Point(33, 64);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(34, 13);
            this.lbl_placa.TabIndex = 18;
            this.lbl_placa.Text = "Placa";
            // 
            // txt_placa
            // 
            this.txt_placa.Location = new System.Drawing.Point(73, 64);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(145, 20);
            this.txt_placa.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(255, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_tpo_servico
            // 
            this.lbl_tpo_servico.AutoSize = true;
            this.lbl_tpo_servico.Location = new System.Drawing.Point(274, 15);
            this.lbl_tpo_servico.Name = "lbl_tpo_servico";
            this.lbl_tpo_servico.Size = new System.Drawing.Size(80, 13);
            this.lbl_tpo_servico.TabIndex = 21;
            this.lbl_tpo_servico.Text = "Tipo de serviço";
            this.lbl_tpo_servico.Click += new System.EventHandler(this.label1_Click);
            // 
            // frm_veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 300);
            this.Controls.Add(this.lbl_tpo_servico);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_placa);
            this.Controls.Add(this.lbl_placa);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.lbl_marca);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.txt_nome_carro);
            this.Controls.Add(this.lbl_nome_carro);
            this.Name = "frm_veiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veículos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.TextBox txt_nome_carro;
        private System.Windows.Forms.Label lbl_nome_carro;
        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_tpo_servico;
    }
}