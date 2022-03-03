
namespace Loja.Forms
{
    partial class FrmVisualizarClientes
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
            this.PnlVerCliente = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ListClientes = new System.Windows.Forms.ListBox();
            this.PnlVerCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlVerCliente
            // 
            this.PnlVerCliente.Controls.Add(this.label1);
            this.PnlVerCliente.Controls.Add(this.ListClientes);
            this.PnlVerCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlVerCliente.Location = new System.Drawing.Point(0, 0);
            this.PnlVerCliente.Name = "PnlVerCliente";
            this.PnlVerCliente.Size = new System.Drawing.Size(768, 382);
            this.PnlVerCliente.TabIndex = 0;
            this.PnlVerCliente.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlVerCliente_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(297, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Clientes cadastrados";
            // 
            // ListClientes
            // 
            this.ListClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListClientes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ListClientes.FormattingEnabled = true;
            this.ListClientes.ItemHeight = 20;
            this.ListClientes.Location = new System.Drawing.Point(12, 33);
            this.ListClientes.Name = "ListClientes";
            this.ListClientes.Size = new System.Drawing.Size(744, 304);
            this.ListClientes.TabIndex = 3;
            // 
            // FrmVisualizarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 382);
            this.Controls.Add(this.PnlVerCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVisualizarClientes";
            this.Text = "FrmVisualizarClientes";
            this.Load += new System.EventHandler(this.FrmVisualizarClientes_Load);
            this.PnlVerCliente.ResumeLayout(false);
            this.PnlVerCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlVerCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListClientes;
    }
}