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
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.lbl_id_cliente = new System.Windows.Forms.Label();
            this.lbl_placa = new System.Windows.Forms.Label();
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_tpo_servico = new System.Windows.Forms.Label();
            this.cb_id_cliente = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(539, 12);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(100, 28);
            this.btn_cancelar.TabIndex = 17;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 119);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(620, 239);
            this.dataGridView1.TabIndex = 16;
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(539, 84);
            this.btn_sair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(100, 28);
            this.btn_sair.TabIndex = 15;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(539, 48);
            this.btn_excluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(100, 28);
            this.btn_excluir.TabIndex = 14;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(372, 79);
            this.btn_cadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(100, 28);
            this.btn_cadastrar.TabIndex = 13;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(40, 50);
            this.lbl_modelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(53, 16);
            this.lbl_modelo.TabIndex = 12;
            this.lbl_modelo.Text = "Modelo";
            this.lbl_modelo.Click += new System.EventHandler(this.lbl_marca_Click);
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(97, 47);
            this.txt_modelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(192, 22);
            this.txt_modelo.TabIndex = 11;
            // 
            // lbl_id_cliente
            // 
            this.lbl_id_cliente.AutoSize = true;
            this.lbl_id_cliente.Location = new System.Drawing.Point(33, 18);
            this.lbl_id_cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id_cliente.Name = "lbl_id_cliente";
            this.lbl_id_cliente.Size = new System.Drawing.Size(83, 16);
            this.lbl_id_cliente.TabIndex = 9;
            this.lbl_id_cliente.Text = "ID do Cliente";
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Location = new System.Drawing.Point(44, 79);
            this.lbl_placa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(42, 16);
            this.lbl_placa.TabIndex = 18;
            this.lbl_placa.Text = "Placa";
            // 
            // txt_placa
            // 
            this.txt_placa.Location = new System.Drawing.Point(97, 79);
            this.txt_placa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(192, 22);
            this.txt_placa.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(340, 46);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_tpo_servico
            // 
            this.lbl_tpo_servico.AutoSize = true;
            this.lbl_tpo_servico.Location = new System.Drawing.Point(365, 18);
            this.lbl_tpo_servico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tpo_servico.Name = "lbl_tpo_servico";
            this.lbl_tpo_servico.Size = new System.Drawing.Size(101, 16);
            this.lbl_tpo_servico.TabIndex = 21;
            this.lbl_tpo_servico.Text = "Tipo de serviço";
            this.lbl_tpo_servico.Click += new System.EventHandler(this.label1_Click);
            // 
            // cb_id_cliente
            // 
            this.cb_id_cliente.FormattingEnabled = true;
            this.cb_id_cliente.Location = new System.Drawing.Point(129, 14);
            this.cb_id_cliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_id_cliente.Name = "cb_id_cliente";
            this.cb_id_cliente.Size = new System.Drawing.Size(160, 24);
            this.cb_id_cliente.TabIndex = 22;
            // 
            // frm_veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 369);
            this.Controls.Add(this.cb_id_cliente);
            this.Controls.Add(this.lbl_tpo_servico);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_placa);
            this.Controls.Add(this.lbl_placa);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.lbl_modelo);
            this.Controls.Add(this.txt_modelo);
            this.Controls.Add(this.lbl_id_cliente);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.Label lbl_id_cliente;
        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_tpo_servico;
        private System.Windows.Forms.ComboBox cb_id_cliente;
    }
}