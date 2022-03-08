
namespace Loja.Forms
{
    partial class FrmLoginVendedor
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
            this.BtnLoginVendedor = new System.Windows.Forms.Button();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblVoltar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLoginVendedor
            // 
            this.BtnLoginVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoginVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoginVendedor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnLoginVendedor.Location = new System.Drawing.Point(179, 273);
            this.BtnLoginVendedor.Name = "BtnLoginVendedor";
            this.BtnLoginVendedor.Size = new System.Drawing.Size(95, 32);
            this.BtnLoginVendedor.TabIndex = 16;
            this.BtnLoginVendedor.Text = "Login";
            this.BtnLoginVendedor.UseVisualStyleBackColor = true;
            this.BtnLoginVendedor.Click += new System.EventHandler(this.BtnLoginVendedor_Click);
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(168, 206);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(128, 20);
            this.TxtSenha.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Senha";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(164, 127);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(132, 20);
            this.TxtNome.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(160, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Faça Login";
            // 
            // LblVoltar
            // 
            this.LblVoltar.AutoSize = true;
            this.LblVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVoltar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblVoltar.Location = new System.Drawing.Point(388, 377);
            this.LblVoltar.Name = "LblVoltar";
            this.LblVoltar.Size = new System.Drawing.Size(40, 13);
            this.LblVoltar.TabIndex = 17;
            this.LblVoltar.Text = "Voltar";
            this.LblVoltar.Click += new System.EventHandler(this.LblVoltar_Click);
            // 
            // FrmLoginVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 408);
            this.Controls.Add(this.LblVoltar);
            this.Controls.Add(this.BtnLoginVendedor);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLoginVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLoginVendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLoginVendedor;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblVoltar;
    }
}