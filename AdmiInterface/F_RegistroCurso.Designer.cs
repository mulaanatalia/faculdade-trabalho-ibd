namespace AdmiInterface
{
    partial class F_RegistroCurso
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
            this.txbCurso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rcDescricao = new System.Windows.Forms.RichTextBox();
            this.btn_criar = new System.Windows.Forms.Button();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.upDuracao = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.upDuracao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 14F);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Criar Cruso";
            // 
            // txbCurso
            // 
            this.txbCurso.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCurso.Location = new System.Drawing.Point(64, 110);
            this.txbCurso.Name = "txbCurso";
            this.txbCurso.Size = new System.Drawing.Size(270, 29);
            this.txbCurso.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 14F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(59, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nome Do Curso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 14F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(60, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "Duração";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 14F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(60, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "Discrição";
            // 
            // rcDescricao
            // 
            this.rcDescricao.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rcDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rcDescricao.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcDescricao.Location = new System.Drawing.Point(65, 293);
            this.rcDescricao.MaxLength = 200;
            this.rcDescricao.Name = "rcDescricao";
            this.rcDescricao.Size = new System.Drawing.Size(502, 152);
            this.rcDescricao.TabIndex = 49;
            this.rcDescricao.Text = "";
            // 
            // btn_criar
            // 
            this.btn_criar.BackColor = System.Drawing.Color.Red;
            this.btn_criar.FlatAppearance.BorderSize = 0;
            this.btn_criar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_criar.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_criar.ForeColor = System.Drawing.Color.White;
            this.btn_criar.Location = new System.Drawing.Point(444, 451);
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.Size = new System.Drawing.Size(123, 38);
            this.btn_criar.TabIndex = 50;
            this.btn_criar.Text = "Criar";
            this.btn_criar.UseVisualStyleBackColor = false;
            this.btn_criar.Click += new System.EventHandler(this.Btn_criar_Click);
            // 
            // txbCodigo
            // 
            this.txbCodigo.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodigo.Location = new System.Drawing.Point(395, 107);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(135, 29);
            this.txbCodigo.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 14F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(390, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 60;
            this.label6.Text = "Codigo";
            // 
            // upDuracao
            // 
            this.upDuracao.Font = new System.Drawing.Font("Leelawadee UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDuracao.Location = new System.Drawing.Point(65, 183);
            this.upDuracao.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.upDuracao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDuracao.Name = "upDuracao";
            this.upDuracao.Size = new System.Drawing.Size(120, 32);
            this.upDuracao.TabIndex = 62;
            this.upDuracao.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // F_RegistroCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(653, 514);
            this.Controls.Add(this.upDuracao);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_criar);
            this.Controls.Add(this.rcDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_RegistroCurso";
            this.Text = "Novo Curso";
            ((System.ComponentModel.ISupportInitialize)(this.upDuracao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rcDescricao;
        private System.Windows.Forms.Button btn_criar;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown upDuracao;
    }
}