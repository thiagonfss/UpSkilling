namespace WindowsFormsUPSKILLINGGAMA
{
    partial class frm_menu
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
            this.pic_menu_estac = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cdt_clientes = new System.Windows.Forms.Button();
            this.btn_cdt_veiculos = new System.Windows.Forms.Button();
            this.btn_hist_venda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_menu_estac)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_menu_estac
            // 
            this.pic_menu_estac.Image = global::WindowsFormsUPSKILLINGGAMA.Properties.Resources.Vaga;
            this.pic_menu_estac.Location = new System.Drawing.Point(-9, 30);
            this.pic_menu_estac.Name = "pic_menu_estac";
            this.pic_menu_estac.Size = new System.Drawing.Size(508, 279);
            this.pic_menu_estac.TabIndex = 0;
            this.pic_menu_estac.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(492, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.veículosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // veículosToolStripMenuItem
            // 
            this.veículosToolStripMenuItem.Name = "veículosToolStripMenuItem";
            this.veículosToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.veículosToolStripMenuItem.Text = "Veículos";
            this.veículosToolStripMenuItem.Click += new System.EventHandler(this.veiculosToolStripMenuItem_Click);
            // 
            // btn_cdt_clientes
            // 
            this.btn_cdt_clientes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_cdt_clientes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_cdt_clientes.Location = new System.Drawing.Point(12, 42);
            this.btn_cdt_clientes.Name = "btn_cdt_clientes";
            this.btn_cdt_clientes.Size = new System.Drawing.Size(75, 55);
            this.btn_cdt_clientes.TabIndex = 2;
            this.btn_cdt_clientes.Text = "Cadastrar Clientes";
            this.btn_cdt_clientes.UseVisualStyleBackColor = false;
            this.btn_cdt_clientes.Click += new System.EventHandler(this.btn_cdt_clientes_Click);
            // 
            // btn_cdt_veiculos
            // 
            this.btn_cdt_veiculos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_cdt_veiculos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_cdt_veiculos.Location = new System.Drawing.Point(104, 42);
            this.btn_cdt_veiculos.Name = "btn_cdt_veiculos";
            this.btn_cdt_veiculos.Size = new System.Drawing.Size(75, 55);
            this.btn_cdt_veiculos.TabIndex = 3;
            this.btn_cdt_veiculos.Text = "Cadastrar Veículos";
            this.btn_cdt_veiculos.UseVisualStyleBackColor = false;
            this.btn_cdt_veiculos.Click += new System.EventHandler(this.btn_cdt_veiculos_Click);
            // 
            // btn_hist_venda
            // 
            this.btn_hist_venda.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_hist_venda.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_hist_venda.Location = new System.Drawing.Point(194, 42);
            this.btn_hist_venda.Name = "btn_hist_venda";
            this.btn_hist_venda.Size = new System.Drawing.Size(75, 55);
            this.btn_hist_venda.TabIndex = 4;
            this.btn_hist_venda.Text = "Histórico de venda";
            this.btn_hist_venda.UseVisualStyleBackColor = false;
            this.btn_hist_venda.Click += new System.EventHandler(this.btn_hist_vendas_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 300);
            this.Controls.Add(this.btn_hist_venda);
            this.Controls.Add(this.btn_cdt_veiculos);
            this.Controls.Add(this.btn_cdt_clientes);
            this.Controls.Add(this.pic_menu_estac);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_menu";
            this.Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pic_menu_estac)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_menu_estac;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículosToolStripMenuItem;
        private System.Windows.Forms.Button btn_cdt_clientes;
        private System.Windows.Forms.Button btn_cdt_veiculos;
        private System.Windows.Forms.Button btn_hist_venda;
    }
}

