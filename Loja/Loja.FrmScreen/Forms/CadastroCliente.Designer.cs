
namespace Loja.Forms
{
    partial class CadastroCliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtSobrenome = new System.Windows.Forms.TextBox();
            this.BtnCadastrarCliente = new System.Windows.Forms.Button();
            this.LblButtonLogin = new System.Windows.Forms.Label();
            this.TxtDateTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.LblVoltar = new System.Windows.Forms.Label();
            this.TxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(238, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Se cadastre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sobrenome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cpf";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(106, 149);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(100, 20);
            this.TxtNome.TabIndex = 5;
            // 
            // TxtSobrenome
            // 
            this.TxtSobrenome.Location = new System.Drawing.Point(381, 149);
            this.TxtSobrenome.Name = "TxtSobrenome";
            this.TxtSobrenome.Size = new System.Drawing.Size(100, 20);
            this.TxtSobrenome.TabIndex = 8;
            // 
            // BtnCadastrarCliente
            // 
            this.BtnCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrarCliente.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnCadastrarCliente.Location = new System.Drawing.Point(253, 321);
            this.BtnCadastrarCliente.Name = "BtnCadastrarCliente";
            this.BtnCadastrarCliente.Size = new System.Drawing.Size(105, 36);
            this.BtnCadastrarCliente.TabIndex = 9;
            this.BtnCadastrarCliente.Text = "Cadastrar";
            this.BtnCadastrarCliente.UseVisualStyleBackColor = true;
            this.BtnCadastrarCliente.Click += new System.EventHandler(this.BtnCadastrarCliente_Click);
            // 
            // LblButtonLogin
            // 
            this.LblButtonLogin.AutoSize = true;
            this.LblButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblButtonLogin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblButtonLogin.Location = new System.Drawing.Point(250, 360);
            this.LblButtonLogin.Name = "LblButtonLogin";
            this.LblButtonLogin.Size = new System.Drawing.Size(175, 13);
            this.LblButtonLogin.TabIndex = 10;
            this.LblButtonLogin.Text = "Já possui um cadastro? entre agora";
            this.LblButtonLogin.Click += new System.EventHandler(this.LblButtonLogin_Click);
            // 
            // TxtDateTime
            // 
            this.TxtDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TxtDateTime.Location = new System.Drawing.Point(106, 253);
            this.TxtDateTime.Name = "TxtDateTime";
            this.TxtDateTime.Size = new System.Drawing.Size(100, 20);
            this.TxtDateTime.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(558, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // LblVoltar
            // 
            this.LblVoltar.AutoSize = true;
            this.LblVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVoltar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblVoltar.Location = new System.Drawing.Point(543, 433);
            this.LblVoltar.Name = "LblVoltar";
            this.LblVoltar.Size = new System.Drawing.Size(40, 13);
            this.LblVoltar.TabIndex = 19;
            this.LblVoltar.Text = "Voltar";
            this.LblVoltar.Click += new System.EventHandler(this.LblVoltar_Click);
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(381, 253);
            this.TxtCpf.Mask = "000.000.000-00";
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(100, 20);
            this.TxtCpf.TabIndex = 20;
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(609, 468);
            this.Controls.Add(this.TxtCpf);
            this.Controls.Add(this.LblVoltar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtDateTime);
            this.Controls.Add(this.LblButtonLogin);
            this.Controls.Add(this.BtnCadastrarCliente);
            this.Controls.Add(this.TxtSobrenome);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroCliente";
            this.Load += new System.EventHandler(this.CadastroCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtSobrenome;
        private System.Windows.Forms.Button BtnCadastrarCliente;
        private System.Windows.Forms.Label LblButtonLogin;
        private System.Windows.Forms.DateTimePicker TxtDateTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblVoltar;
        private System.Windows.Forms.MaskedTextBox TxtCpf;
    }
}