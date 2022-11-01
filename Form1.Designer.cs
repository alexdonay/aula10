namespace aula10
{
    partial class FrmCadEmpregado
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblNome = new System.Windows.Forms.Label();
            this.LblSobrenome = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtSobrenome = new System.Windows.Forms.TextBox();
            this.TxtSalario = new System.Windows.Forms.TextBox();
            this.LblSalario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdComissionado = new System.Windows.Forms.RadioButton();
            this.RdHorista = new System.Windows.Forms.RadioButton();
            this.BtnCadastra = new System.Windows.Forms.Button();
            this.LblHoras = new System.Windows.Forms.Label();
            this.TxtHoras = new System.Windows.Forms.TextBox();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.Lblquantidade = new System.Windows.Forms.Label();
            this.BtnExibe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(31, 36);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(40, 15);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome";
            // 
            // LblSobrenome
            // 
            this.LblSobrenome.AutoSize = true;
            this.LblSobrenome.Location = new System.Drawing.Point(31, 113);
            this.LblSobrenome.Name = "LblSobrenome";
            this.LblSobrenome.Size = new System.Drawing.Size(68, 15);
            this.LblSobrenome.TabIndex = 1;
            this.LblSobrenome.Text = "Sobrenome";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(31, 67);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(215, 23);
            this.TxtNome.TabIndex = 2;
            // 
            // TxtSobrenome
            // 
            this.TxtSobrenome.Location = new System.Drawing.Point(31, 150);
            this.TxtSobrenome.Name = "TxtSobrenome";
            this.TxtSobrenome.Size = new System.Drawing.Size(215, 23);
            this.TxtSobrenome.TabIndex = 3;
            // 
            // TxtSalario
            // 
            this.TxtSalario.Location = new System.Drawing.Point(31, 241);
            this.TxtSalario.Name = "TxtSalario";
            this.TxtSalario.Size = new System.Drawing.Size(215, 23);
            this.TxtSalario.TabIndex = 5;
            // 
            // LblSalario
            // 
            this.LblSalario.AutoSize = true;
            this.LblSalario.Location = new System.Drawing.Point(31, 204);
            this.LblSalario.Name = "LblSalario";
            this.LblSalario.Size = new System.Drawing.Size(42, 15);
            this.LblSalario.TabIndex = 4;
            this.LblSalario.Text = "Salario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdComissionado);
            this.groupBox1.Controls.Add(this.RdHorista);
            this.groupBox1.Location = new System.Drawing.Point(292, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 116);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Empregado";
            // 
            // RdComissionado
            // 
            this.RdComissionado.AutoSize = true;
            this.RdComissionado.Location = new System.Drawing.Point(43, 71);
            this.RdComissionado.Name = "RdComissionado";
            this.RdComissionado.Size = new System.Drawing.Size(101, 19);
            this.RdComissionado.TabIndex = 1;
            this.RdComissionado.Text = "Comissionado";
            this.RdComissionado.UseVisualStyleBackColor = true;
            // 
            // RdHorista
            // 
            this.RdHorista.AutoSize = true;
            this.RdHorista.Checked = true;
            this.RdHorista.Location = new System.Drawing.Point(43, 37);
            this.RdHorista.Name = "RdHorista";
            this.RdHorista.Size = new System.Drawing.Size(63, 19);
            this.RdHorista.TabIndex = 0;
            this.RdHorista.TabStop = true;
            this.RdHorista.Text = "Horista";
            this.RdHorista.UseVisualStyleBackColor = true;
            // 
            // BtnCadastra
            // 
            this.BtnCadastra.Location = new System.Drawing.Point(21, 296);
            this.BtnCadastra.Name = "BtnCadastra";
            this.BtnCadastra.Size = new System.Drawing.Size(98, 49);
            this.BtnCadastra.TabIndex = 7;
            this.BtnCadastra.Text = "Cadastra";
            this.BtnCadastra.UseVisualStyleBackColor = true;
            this.BtnCadastra.Click += new System.EventHandler(this.BtnCadastra_Click);
            // 
            // LblHoras
            // 
            this.LblHoras.AutoSize = true;
            this.LblHoras.Location = new System.Drawing.Point(297, 205);
            this.LblHoras.Name = "LblHoras";
            this.LblHoras.Size = new System.Drawing.Size(103, 15);
            this.LblHoras.TabIndex = 8;
            this.LblHoras.Text = "Horas Trabalhadas";
            // 
            // TxtHoras
            // 
            this.TxtHoras.Location = new System.Drawing.Point(292, 241);
            this.TxtHoras.Name = "TxtHoras";
            this.TxtHoras.Size = new System.Drawing.Size(178, 23);
            this.TxtHoras.TabIndex = 9;
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.Location = new System.Drawing.Point(292, 322);
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(178, 23);
            this.TxtQuantidade.TabIndex = 11;
            // 
            // Lblquantidade
            // 
            this.Lblquantidade.AutoSize = true;
            this.Lblquantidade.Location = new System.Drawing.Point(297, 286);
            this.Lblquantidade.Name = "Lblquantidade";
            this.Lblquantidade.Size = new System.Drawing.Size(114, 15);
            this.Lblquantidade.TabIndex = 10;
            this.Lblquantidade.Text = "Quantidade Vendida";
            // 
            // BtnExibe
            // 
            this.BtnExibe.Location = new System.Drawing.Point(145, 296);
            this.BtnExibe.Name = "BtnExibe";
            this.BtnExibe.Size = new System.Drawing.Size(92, 49);
            this.BtnExibe.TabIndex = 12;
            this.BtnExibe.Text = "Exibir Dados";
            this.BtnExibe.UseVisualStyleBackColor = true;
            this.BtnExibe.Click += new System.EventHandler(this.BtnExibe_Click);
            // 
            // FrmCadEmpregado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 392);
            this.Controls.Add(this.BtnExibe);
            this.Controls.Add(this.TxtQuantidade);
            this.Controls.Add(this.Lblquantidade);
            this.Controls.Add(this.TxtHoras);
            this.Controls.Add(this.LblHoras);
            this.Controls.Add(this.BtnCadastra);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtSalario);
            this.Controls.Add(this.LblSalario);
            this.Controls.Add(this.TxtSobrenome);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblSobrenome);
            this.Controls.Add(this.LblNome);
            this.Name = "FrmCadEmpregado";
            this.Text = "Cadastro de Empregados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblNome;
        private Label LblSobrenome;
        private TextBox TxtNome;
        private TextBox TxtSobrenome;
        private TextBox TxtSalario;
        private Label LblSalario;
        private GroupBox groupBox1;
        private RadioButton RdComissionado;
        private RadioButton RdHorista;
        private Button BtnCadastra;
        private Label LblHoras;
        private TextBox TxtHoras;
        private TextBox TxtQuantidade;
        private Label Lblquantidade;
        private Button BtnExibe;
    }
}