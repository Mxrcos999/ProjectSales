
namespace Loja.Forms
{
    partial class FrmClienteDashbord
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
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.BtnSair = new System.Windows.Forms.Label();
            this.BtnDeslogar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlLoad = new System.Windows.Forms.Panel();
            this.PnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.Controls.Add(this.BtnSair);
            this.PnlMenu.Controls.Add(this.BtnDeslogar);
            this.PnlMenu.Controls.Add(this.button1);
            this.PnlMenu.Controls.Add(this.btnComprar);
            this.PnlMenu.Controls.Add(this.pictureBox1);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(700, 100);
            this.PnlMenu.TabIndex = 0;
            // 
            // BtnSair
            // 
            this.BtnSair.AutoSize = true;
            this.BtnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnSair.Location = new System.Drawing.Point(664, 9);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(16, 15);
            this.BtnSair.TabIndex = 4;
            this.BtnSair.Text = "X";
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnDeslogar
            // 
            this.BtnDeslogar.BackColor = System.Drawing.Color.Transparent;
            this.BtnDeslogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeslogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeslogar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnDeslogar.Location = new System.Drawing.Point(577, 38);
            this.BtnDeslogar.Name = "BtnDeslogar";
            this.BtnDeslogar.Size = new System.Drawing.Size(111, 31);
            this.BtnDeslogar.TabIndex = 3;
            this.BtnDeslogar.Text = "Sair";
            this.BtnDeslogar.UseVisualStyleBackColor = false;
            this.BtnDeslogar.Click += new System.EventHandler(this.BtnDeslogar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(229, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Minhas compras";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.Transparent;
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnComprar.Location = new System.Drawing.Point(401, 38);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(148, 31);
            this.btnComprar.TabIndex = 1;
            this.btnComprar.Text = "Fazer compra";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Loja.FrmScreen.Properties.Resources.do_utilizador;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PnlLoad
            // 
            this.PnlLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlLoad.Location = new System.Drawing.Point(0, 100);
            this.PnlLoad.Name = "PnlLoad";
            this.PnlLoad.Size = new System.Drawing.Size(700, 346);
            this.PnlLoad.TabIndex = 1;
            this.PnlLoad.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlLoad_Paint);
            // 
            // FrmClienteDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 446);
            this.Controls.Add(this.PnlLoad);
            this.Controls.Add(this.PnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClienteDashbord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmClienteDashbord";
            this.Load += new System.EventHandler(this.FrmClienteDashbord_Load);
            this.PnlMenu.ResumeLayout(false);
            this.PnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PnlLoad;
        private System.Windows.Forms.Button BtnDeslogar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label BtnSair;
    }
}