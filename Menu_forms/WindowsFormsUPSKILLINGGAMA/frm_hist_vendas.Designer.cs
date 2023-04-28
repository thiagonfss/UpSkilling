namespace WindowsFormsUPSKILLINGGAMA
{
    partial class frm_hist_vendas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_fil_data = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_fil_servico = new System.Windows.Forms.Label();
            this.cb_fil_servico = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(468, 209);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbl_fil_data
            // 
            this.lbl_fil_data.AutoSize = true;
            this.lbl_fil_data.Location = new System.Drawing.Point(12, 14);
            this.lbl_fil_data.Name = "lbl_fil_data";
            this.lbl_fil_data.Size = new System.Drawing.Size(73, 13);
            this.lbl_fil_data.TabIndex = 2;
            this.lbl_fil_data.Text = "Filtrar Período";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(91, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(257, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // lbl_fil_servico
            // 
            this.lbl_fil_servico.AutoSize = true;
            this.lbl_fil_servico.Location = new System.Drawing.Point(12, 50);
            this.lbl_fil_servico.Name = "lbl_fil_servico";
            this.lbl_fil_servico.Size = new System.Drawing.Size(71, 13);
            this.lbl_fil_servico.TabIndex = 4;
            this.lbl_fil_servico.Text = "Filtrar Serviço";
            this.lbl_fil_servico.Click += new System.EventHandler(this.label1_Click);
            // 
            // cb_fil_servico
            // 
            this.cb_fil_servico.FormattingEnabled = true;
            this.cb_fil_servico.Location = new System.Drawing.Point(91, 50);
            this.cb_fil_servico.Name = "cb_fil_servico";
            this.cb_fil_servico.Size = new System.Drawing.Size(121, 21);
            this.cb_fil_servico.TabIndex = 5;
            // 
            // frm_hist_vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 300);
            this.Controls.Add(this.cb_fil_servico);
            this.Controls.Add(this.lbl_fil_servico);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_fil_data);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_hist_vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico de vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_fil_data;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_fil_servico;
        private System.Windows.Forms.ComboBox cb_fil_servico;
    }
}