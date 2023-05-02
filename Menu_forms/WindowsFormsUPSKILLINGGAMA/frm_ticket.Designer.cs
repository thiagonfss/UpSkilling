namespace WindowsFormsUPSKILLINGGAMA
{
    partial class frm_ticket
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dat_tme_ent = new System.Windows.Forms.DateTimePicker();
            this.lbl_dat_hora = new System.Windows.Forms.Label();
            this.btn_reg_entrada = new System.Windows.Forms.Button();
            this.cb_tpo_servico = new System.Windows.Forms.ComboBox();
            this.lbl_tpo_servico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsUPSKILLINGGAMA.Properties.Resources.Ticket_entrada___;
            this.pictureBox1.Location = new System.Drawing.Point(-10, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 350);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dat_tme_ent
            // 
            this.dat_tme_ent.Location = new System.Drawing.Point(204, 126);
            this.dat_tme_ent.Name = "dat_tme_ent";
            this.dat_tme_ent.Size = new System.Drawing.Size(104, 20);
            this.dat_tme_ent.TabIndex = 1;
            this.dat_tme_ent.Value = new System.DateTime(2023, 4, 28, 18, 32, 11, 0);
            this.dat_tme_ent.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbl_dat_hora
            // 
            this.lbl_dat_hora.AutoSize = true;
            this.lbl_dat_hora.Location = new System.Drawing.Point(47, 148);
            this.lbl_dat_hora.Name = "lbl_dat_hora";
            this.lbl_dat_hora.Size = new System.Drawing.Size(119, 13);
            this.lbl_dat_hora.TabIndex = 2;
            this.lbl_dat_hora.Text = "Data e Hora da entrada";
            this.lbl_dat_hora.Click += new System.EventHandler(this.lbl_dat_hora_Click);
            // 
            // btn_reg_entrada
            // 
            this.btn_reg_entrada.Location = new System.Drawing.Point(204, 205);
            this.btn_reg_entrada.Name = "btn_reg_entrada";
            this.btn_reg_entrada.Size = new System.Drawing.Size(104, 23);
            this.btn_reg_entrada.TabIndex = 3;
            this.btn_reg_entrada.Text = "Registrar Entrada";
            this.btn_reg_entrada.UseVisualStyleBackColor = true;
            this.btn_reg_entrada.Click += new System.EventHandler(this.btn_reg_entrada_Click);
            // 
            // cb_tpo_servico
            // 
            this.cb_tpo_servico.FormattingEnabled = true;
            this.cb_tpo_servico.Location = new System.Drawing.Point(204, 166);
            this.cb_tpo_servico.Name = "cb_tpo_servico";
            this.cb_tpo_servico.Size = new System.Drawing.Size(104, 21);
            this.cb_tpo_servico.TabIndex = 4;
            this.cb_tpo_servico.SelectedIndexChanged += new System.EventHandler(this.cb_tpo_entrada_SelectedIndexChanged);
            // 
            // lbl_tpo_servico
            // 
            this.lbl_tpo_servico.AutoSize = true;
            this.lbl_tpo_servico.Location = new System.Drawing.Point(47, 169);
            this.lbl_tpo_servico.Name = "lbl_tpo_servico";
            this.lbl_tpo_servico.Size = new System.Drawing.Size(82, 13);
            this.lbl_tpo_servico.TabIndex = 5;
            this.lbl_tpo_servico.Text = "Tipo de Serviço";
            this.lbl_tpo_servico.Click += new System.EventHandler(this.lbl_tpo_servico_Click);
            // 
            // frm_ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 349);
            this.Controls.Add(this.lbl_tpo_servico);
            this.Controls.Add(this.cb_tpo_servico);
            this.Controls.Add(this.btn_reg_entrada);
            this.Controls.Add(this.lbl_dat_hora);
            this.Controls.Add(this.dat_tme_ent);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_ticket";
            this.Text = "Cadastro de Ticket";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dat_tme_ent;
        private System.Windows.Forms.Label lbl_dat_hora;
        private System.Windows.Forms.Button btn_reg_entrada;
        private System.Windows.Forms.ComboBox cb_tpo_servico;
        private System.Windows.Forms.Label lbl_tpo_servico;
    }
}