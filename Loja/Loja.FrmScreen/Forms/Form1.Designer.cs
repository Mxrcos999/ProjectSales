
namespace Loja
{
    partial class FrmVendedorDashBord
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlLateral = new System.Windows.Forms.Panel();
            this.BtnDeslogar = new System.Windows.Forms.Button();
            this.LblExit = new System.Windows.Forms.Label();
            this.BtnVerClientes = new System.Windows.Forms.Button();
            this.BtnVisualizaVenda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnVisualizarProdutos = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pnlLoad = new System.Windows.Forms.Panel();
            this.PnlLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlLateral
            // 
            this.PnlLateral.BackColor = System.Drawing.Color.White;
            this.PnlLateral.Controls.Add(this.BtnDeslogar);
            this.PnlLateral.Controls.Add(this.LblExit);
            this.PnlLateral.Controls.Add(this.BtnVerClientes);
            this.PnlLateral.Controls.Add(this.BtnVisualizaVenda);
            this.PnlLateral.Controls.Add(this.pictureBox1);
            this.PnlLateral.Controls.Add(this.BtnVisualizarProdutos);
            this.PnlLateral.Controls.Add(this.btnCadastrar);
            this.PnlLateral.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlLateral.Location = new System.Drawing.Point(0, 0);
            this.PnlLateral.Name = "PnlLateral";
            this.PnlLateral.Size = new System.Drawing.Size(768, 87);
            this.PnlLateral.TabIndex = 0;
            // 
            // BtnDeslogar
            // 
            this.BtnDeslogar.BackColor = System.Drawing.Color.Transparent;
            this.BtnDeslogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeslogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeslogar.ForeColor = System.Drawing.Color.Red;
            this.BtnDeslogar.Location = new System.Drawing.Point(712, 33);
            this.BtnDeslogar.Name = "BtnDeslogar";
            this.BtnDeslogar.Size = new System.Drawing.Size(53, 31);
            this.BtnDeslogar.TabIndex = 8;
            this.BtnDeslogar.Text = "Sair";
            this.BtnDeslogar.UseVisualStyleBackColor = false;
            this.BtnDeslogar.Click += new System.EventHandler(this.BtnDeslogar_Click);
            // 
            // LblExit
            // 
            this.LblExit.AutoSize = true;
            this.LblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblExit.Location = new System.Drawing.Point(742, 9);
            this.LblExit.Name = "LblExit";
            this.LblExit.Size = new System.Drawing.Size(17, 16);
            this.LblExit.TabIndex = 7;
            this.LblExit.Text = "X";
            this.LblExit.Click += new System.EventHandler(this.LblExit_Click);
            // 
            // BtnVerClientes
            // 
            this.BtnVerClientes.BackColor = System.Drawing.Color.Transparent;
            this.BtnVerClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerClientes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnVerClientes.Location = new System.Drawing.Point(560, 33);
            this.BtnVerClientes.Name = "BtnVerClientes";
            this.BtnVerClientes.Size = new System.Drawing.Size(148, 31);
            this.BtnVerClientes.TabIndex = 6;
            this.BtnVerClientes.Text = "Visualizar clientes";
            this.BtnVerClientes.UseVisualStyleBackColor = false;
            this.BtnVerClientes.Click += new System.EventHandler(this.BtnVerClientes_Click);
            // 
            // BtnVisualizaVenda
            // 
            this.BtnVisualizaVenda.BackColor = System.Drawing.Color.Transparent;
            this.BtnVisualizaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVisualizaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVisualizaVenda.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnVisualizaVenda.Location = new System.Drawing.Point(252, 33);
            this.BtnVisualizaVenda.Name = "BtnVisualizaVenda";
            this.BtnVisualizaVenda.Size = new System.Drawing.Size(148, 31);
            this.BtnVisualizaVenda.TabIndex = 5;
            this.BtnVisualizaVenda.Text = "Visualizar vendas";
            this.BtnVisualizaVenda.UseVisualStyleBackColor = false;
            this.BtnVisualizaVenda.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BtnVisualizarProdutos
            // 
            this.BtnVisualizarProdutos.BackColor = System.Drawing.Color.Transparent;
            this.BtnVisualizarProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVisualizarProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVisualizarProdutos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnVisualizarProdutos.Location = new System.Drawing.Point(98, 33);
            this.BtnVisualizarProdutos.Name = "BtnVisualizarProdutos";
            this.BtnVisualizarProdutos.Size = new System.Drawing.Size(148, 31);
            this.BtnVisualizarProdutos.TabIndex = 1;
            this.BtnVisualizarProdutos.Text = "Visualizar produtos";
            this.BtnVisualizarProdutos.UseVisualStyleBackColor = false;
            this.BtnVisualizarProdutos.Click += new System.EventHandler(this.BtnVisualizarVenda_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCadastrar.Location = new System.Drawing.Point(406, 33);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(148, 31);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar produto";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pnlLoad
            // 
            this.pnlLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoad.Location = new System.Drawing.Point(0, 87);
            this.pnlLoad.Name = "pnlLoad";
            this.pnlLoad.Size = new System.Drawing.Size(768, 359);
            this.pnlLoad.TabIndex = 1;
            this.pnlLoad.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLoad_Paint);
            // 
            // FrmVendedorDashBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 446);
            this.Controls.Add(this.pnlLoad);
            this.Controls.Add(this.PnlLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVendedorDashBord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendedor";
            this.PnlLateral.ResumeLayout(false);
            this.PnlLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlLateral;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnVisualizarProdutos;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel pnlLoad;
        private System.Windows.Forms.Button BtnVisualizaVenda;
        private System.Windows.Forms.Button BtnVerClientes;
        private System.Windows.Forms.Label LblExit;
        private System.Windows.Forms.Button BtnDeslogar;
    }
}

