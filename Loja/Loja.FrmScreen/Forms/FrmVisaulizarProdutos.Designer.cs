
namespace Loja.Forms
{
    partial class FrmVisaulizarProdutos
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
            this.ListProdutos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(297, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seus produtos";
            // 
            // ListProdutos
            // 
            this.ListProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListProdutos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ListProdutos.FormattingEnabled = true;
            this.ListProdutos.ItemHeight = 20;
            this.ListProdutos.Location = new System.Drawing.Point(12, 38);
            this.ListProdutos.Name = "ListProdutos";
            this.ListProdutos.Size = new System.Drawing.Size(744, 304);
            this.ListProdutos.TabIndex = 3;
            // 
            // FrmVisaulizarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVisaulizarProdutos";
            this.Text = "FrmVisaulizarVendas";
            this.Load += new System.EventHandler(this.FrmVisaulizarVendas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListProdutos;
    }
}