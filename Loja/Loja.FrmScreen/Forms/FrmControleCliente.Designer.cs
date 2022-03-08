
namespace Loja.Forms
{
    partial class FrmControleCliente
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
            this.BtnCliente = new System.Windows.Forms.Button();
            this.BtnVendedor = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(117, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quem é você?";
            // 
            // BtnCliente
            // 
            this.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnCliente.Location = new System.Drawing.Point(133, 103);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(108, 32);
            this.BtnCliente.TabIndex = 1;
            this.BtnCliente.Text = "Cliente";
            this.BtnCliente.UseVisualStyleBackColor = true;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // BtnVendedor
            // 
            this.BtnVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVendedor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnVendedor.Location = new System.Drawing.Point(133, 199);
            this.BtnVendedor.Name = "BtnVendedor";
            this.BtnVendedor.Size = new System.Drawing.Size(108, 32);
            this.BtnVendedor.TabIndex = 3;
            this.BtnVendedor.Text = "Vendedor";
            this.BtnVendedor.UseVisualStyleBackColor = true;
            this.BtnVendedor.Click += new System.EventHandler(this.BtnVendedor_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.AutoSize = true;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnExit.Location = new System.Drawing.Point(320, 13);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(24, 24);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "X";
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmControleCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 338);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnVendedor);
            this.Controls.Add(this.BtnCliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmControleCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmControleCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Button BtnVendedor;
        private System.Windows.Forms.Label BtnExit;
    }
}