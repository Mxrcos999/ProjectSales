
namespace Loja.Forms
{
    partial class FrmLoginCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCpf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnLoginCliente = new System.Windows.Forms.Button();
            this.LblVoltar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(138, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Faça Login";
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(142, 102);
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(128, 20);
            this.TxtCpf.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CPF";
            // 
            // BtnLoginCliente
            // 
            this.BtnLoginCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoginCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoginCliente.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnLoginCliente.Location = new System.Drawing.Point(153, 169);
            this.BtnLoginCliente.Name = "BtnLoginCliente";
            this.BtnLoginCliente.Size = new System.Drawing.Size(95, 32);
            this.BtnLoginCliente.TabIndex = 10;
            this.BtnLoginCliente.Text = "Login";
            this.BtnLoginCliente.UseVisualStyleBackColor = true;
            this.BtnLoginCliente.Click += new System.EventHandler(this.BtnLoginCliente_Click);
            // 
            // LblVoltar
            // 
            this.LblVoltar.AutoSize = true;
            this.LblVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVoltar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblVoltar.Location = new System.Drawing.Point(364, 235);
            this.LblVoltar.Name = "LblVoltar";
            this.LblVoltar.Size = new System.Drawing.Size(40, 13);
            this.LblVoltar.TabIndex = 18;
            this.LblVoltar.Text = "Voltar";
            this.LblVoltar.Click += new System.EventHandler(this.LblVoltar_Click);
            // 
            // FrmLoginCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(418, 265);
            this.Controls.Add(this.LblVoltar);
            this.Controls.Add(this.BtnLoginCliente);
            this.Controls.Add(this.TxtCpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLoginCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLoginCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnLoginCliente;
        private System.Windows.Forms.Label LblVoltar;
    }
}