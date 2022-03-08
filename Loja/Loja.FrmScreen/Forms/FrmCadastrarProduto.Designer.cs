
namespace Loja.Forms
{
    partial class FrmCadastrarProduto
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
            this.TxtQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtValorDoProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNomeProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCadastra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtQuantidadeProduto
            // 
            this.TxtQuantidadeProduto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtQuantidadeProduto.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TxtQuantidadeProduto.Location = new System.Drawing.Point(582, 150);
            this.TxtQuantidadeProduto.Name = "TxtQuantidadeProduto";
            this.TxtQuantidadeProduto.Size = new System.Drawing.Size(110, 20);
            this.TxtQuantidadeProduto.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(579, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Quantidade de produtos";
            // 
            // TxtValorDoProduto
            // 
            this.TxtValorDoProduto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtValorDoProduto.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TxtValorDoProduto.Location = new System.Drawing.Point(333, 150);
            this.TxtValorDoProduto.Name = "TxtValorDoProduto";
            this.TxtValorDoProduto.Size = new System.Drawing.Size(110, 20);
            this.TxtValorDoProduto.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(335, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Valor do produto";
            // 
            // TxtNomeProduto
            // 
            this.TxtNomeProduto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtNomeProduto.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TxtNomeProduto.Location = new System.Drawing.Point(88, 150);
            this.TxtNomeProduto.Name = "TxtNomeProduto";
            this.TxtNomeProduto.Size = new System.Drawing.Size(110, 20);
            this.TxtNomeProduto.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(85, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome do produto";
            // 
            // BtnCadastra
            // 
            this.BtnCadastra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastra.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnCadastra.Location = new System.Drawing.Point(324, 263);
            this.BtnCadastra.Name = "BtnCadastra";
            this.BtnCadastra.Size = new System.Drawing.Size(142, 27);
            this.BtnCadastra.TabIndex = 16;
            this.BtnCadastra.Text = "Cadastrar Produto";
            this.BtnCadastra.UseVisualStyleBackColor = true;
            this.BtnCadastra.Click += new System.EventHandler(this.BtnCadastra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(306, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cadastrar produto";
            // 
            // FrmCadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(768, 359);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCadastra);
            this.Controls.Add(this.TxtQuantidadeProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtValorDoProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNomeProduto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastrarProduto";
            this.Text = "FrmCadastrarProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtQuantidadeProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtValorDoProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNomeProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCadastra;
        private System.Windows.Forms.Label label2;
    }
}