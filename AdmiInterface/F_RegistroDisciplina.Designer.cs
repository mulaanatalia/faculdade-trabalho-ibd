namespace AdmiInterface
{
    partial class F_RegistroDisciplina
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
            this.label5 = new System.Windows.Forms.Label();
            this.txbDisciplina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEstatuto = new System.Windows.Forms.ComboBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.upCredito = new System.Windows.Forms.NumericUpDown();
            this.upCargaHoraria = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.upCredito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upCargaHoraria)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 14F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(39, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 51;
            this.label5.Text = "Carga horario";
            // 
            // txbDisciplina
            // 
            this.txbDisciplina.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDisciplina.Location = new System.Drawing.Point(44, 122);
            this.txbDisciplina.Name = "txbDisciplina";
            this.txbDisciplina.Size = new System.Drawing.Size(343, 29);
            this.txbDisciplina.TabIndex = 50;
            this.txbDisciplina.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 14F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 14F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Adicionar Disciplina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 14F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(236, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "Creditos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 14F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(39, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 55;
            this.label4.Text = "Estatuto";
            // 
            // cbEstatuto
            // 
            this.cbEstatuto.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstatuto.FormattingEnabled = true;
            this.cbEstatuto.Items.AddRange(new object[] {
            "Complemetar",
            "Nuclear"});
            this.cbEstatuto.Location = new System.Drawing.Point(44, 288);
            this.cbEstatuto.Name = "cbEstatuto";
            this.cbEstatuto.Size = new System.Drawing.Size(157, 29);
            this.cbEstatuto.TabIndex = 56;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.Red;
            this.btn_adicionar.FlatAppearance.BorderSize = 0;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.ForeColor = System.Drawing.Color.White;
            this.btn_adicionar.Location = new System.Drawing.Point(419, 398);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(123, 38);
            this.btn_adicionar.TabIndex = 57;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.Btn_adicionar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 14F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(402, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 58;
            this.label6.Text = "Codigo";
            // 
            // txbCodigo
            // 
            this.txbCodigo.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodigo.Location = new System.Drawing.Point(407, 122);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(135, 29);
            this.txbCodigo.TabIndex = 59;
            // 
            // upCredito
            // 
            this.upCredito.Font = new System.Drawing.Font("Leelawadee UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upCredito.Location = new System.Drawing.Point(241, 201);
            this.upCredito.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.upCredito.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.upCredito.Name = "upCredito";
            this.upCredito.Size = new System.Drawing.Size(120, 32);
            this.upCredito.TabIndex = 60;
            this.upCredito.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // upCargaHoraria
            // 
            this.upCargaHoraria.Font = new System.Drawing.Font("Leelawadee UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upCargaHoraria.Location = new System.Drawing.Point(48, 201);
            this.upCargaHoraria.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.upCargaHoraria.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.upCargaHoraria.Name = "upCargaHoraria";
            this.upCargaHoraria.Size = new System.Drawing.Size(120, 32);
            this.upCargaHoraria.TabIndex = 61;
            this.upCargaHoraria.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // F_RegistroDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 493);
            this.Controls.Add(this.upCargaHoraria);
            this.Controls.Add(this.upCredito);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.cbEstatuto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbDisciplina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_RegistroDisciplina";
            this.Text = "Cadastrar Disciplina";
            ((System.ComponentModel.ISupportInitialize)(this.upCredito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upCargaHoraria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbDisciplina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEstatuto;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.NumericUpDown upCredito;
        private System.Windows.Forms.NumericUpDown upCargaHoraria;
    }
}