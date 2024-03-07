
namespace PPL_Main.Telas
{
    partial class TelaSimulacao
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
            this.components = new System.ComponentModel.Container();
            this.labelDadosParaAlvo = new System.Windows.Forms.Label();
            this.labelDadosAlvoAlturaInicial = new System.Windows.Forms.Label();
            this.textBoxDadosAlvoAlturaInicial = new System.Windows.Forms.TextBox();
            this.labelDadosAlvoMetrosAlturaInicial = new System.Windows.Forms.Label();
            this.labelDadosAlvoDistanciaCanhao = new System.Windows.Forms.Label();
            this.labelDadosAlvoMetrosDistanciaCanhao = new System.Windows.Forms.Label();
            this.textBoxDadosAlvoDistanciaDoCanhao = new System.Windows.Forms.TextBox();
            this.labelDadosProjetilGrausAnguloTrajetoria = new System.Windows.Forms.Label();
            this.textBoxDadosProjetilAnguloTrajetoria = new System.Windows.Forms.TextBox();
            this.labelDadosProjetilAnguloTrajetoria = new System.Windows.Forms.Label();
            this.buttonSimularTelaSimulacao = new System.Windows.Forms.Button();
            this.pBLDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pBLDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDadosVelocidadeInicialAlvo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonObterAnguloIdeal = new System.Windows.Forms.Button();
            this.pBLDBDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pBLDBDataSetDefinitivo = new PPL_Main.PBLDBDataSetDefinitivo();
            this.pBLDBDataSetDefinitivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSairTelaSimulacao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBLDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLDBDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLDBDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLDBDataSetDefinitivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLDBDataSetDefinitivoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDadosParaAlvo
            // 
            this.labelDadosParaAlvo.AutoSize = true;
            this.labelDadosParaAlvo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDadosParaAlvo.Location = new System.Drawing.Point(38, 80);
            this.labelDadosParaAlvo.Name = "labelDadosParaAlvo";
            this.labelDadosParaAlvo.Size = new System.Drawing.Size(260, 30);
            this.labelDadosParaAlvo.TabIndex = 0;
            this.labelDadosParaAlvo.Text = "🔴 Dados para o alvo 🔴";
            // 
            // labelDadosAlvoAlturaInicial
            // 
            this.labelDadosAlvoAlturaInicial.AutoSize = true;
            this.labelDadosAlvoAlturaInicial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDadosAlvoAlturaInicial.Location = new System.Drawing.Point(15, 122);
            this.labelDadosAlvoAlturaInicial.Name = "labelDadosAlvoAlturaInicial";
            this.labelDadosAlvoAlturaInicial.Size = new System.Drawing.Size(98, 21);
            this.labelDadosAlvoAlturaInicial.TabIndex = 1;
            this.labelDadosAlvoAlturaInicial.Text = "Altura inicial";
            this.labelDadosAlvoAlturaInicial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDadosAlvoAlturaInicial
            // 
            this.textBoxDadosAlvoAlturaInicial.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDadosAlvoAlturaInicial.Location = new System.Drawing.Point(117, 122);
            this.textBoxDadosAlvoAlturaInicial.Name = "textBoxDadosAlvoAlturaInicial";
            this.textBoxDadosAlvoAlturaInicial.Size = new System.Drawing.Size(100, 22);
            this.textBoxDadosAlvoAlturaInicial.TabIndex = 2;
            // 
            // labelDadosAlvoMetrosAlturaInicial
            // 
            this.labelDadosAlvoMetrosAlturaInicial.AutoSize = true;
            this.labelDadosAlvoMetrosAlturaInicial.BackColor = System.Drawing.SystemColors.Control;
            this.labelDadosAlvoMetrosAlturaInicial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDadosAlvoMetrosAlturaInicial.Location = new System.Drawing.Point(219, 122);
            this.labelDadosAlvoMetrosAlturaInicial.Name = "labelDadosAlvoMetrosAlturaInicial";
            this.labelDadosAlvoMetrosAlturaInicial.Size = new System.Drawing.Size(82, 21);
            this.labelDadosAlvoMetrosAlturaInicial.TabIndex = 3;
            this.labelDadosAlvoMetrosAlturaInicial.Text = "metros(m)";
            // 
            // labelDadosAlvoDistanciaCanhao
            // 
            this.labelDadosAlvoDistanciaCanhao.AutoSize = true;
            this.labelDadosAlvoDistanciaCanhao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDadosAlvoDistanciaCanhao.Location = new System.Drawing.Point(20, 153);
            this.labelDadosAlvoDistanciaCanhao.Name = "labelDadosAlvoDistanciaCanhao";
            this.labelDadosAlvoDistanciaCanhao.Size = new System.Drawing.Size(84, 42);
            this.labelDadosAlvoDistanciaCanhao.TabIndex = 4;
            this.labelDadosAlvoDistanciaCanhao.Text = "Distância \r\ndo canhão";
            this.labelDadosAlvoDistanciaCanhao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDadosAlvoMetrosDistanciaCanhao
            // 
            this.labelDadosAlvoMetrosDistanciaCanhao.AutoSize = true;
            this.labelDadosAlvoMetrosDistanciaCanhao.BackColor = System.Drawing.SystemColors.Control;
            this.labelDadosAlvoMetrosDistanciaCanhao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDadosAlvoMetrosDistanciaCanhao.Location = new System.Drawing.Point(219, 165);
            this.labelDadosAlvoMetrosDistanciaCanhao.Name = "labelDadosAlvoMetrosDistanciaCanhao";
            this.labelDadosAlvoMetrosDistanciaCanhao.Size = new System.Drawing.Size(82, 21);
            this.labelDadosAlvoMetrosDistanciaCanhao.TabIndex = 6;
            this.labelDadosAlvoMetrosDistanciaCanhao.Text = "metros(m)";
            // 
            // textBoxDadosAlvoDistanciaDoCanhao
            // 
            this.textBoxDadosAlvoDistanciaDoCanhao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDadosAlvoDistanciaDoCanhao.Location = new System.Drawing.Point(117, 166);
            this.textBoxDadosAlvoDistanciaDoCanhao.Name = "textBoxDadosAlvoDistanciaDoCanhao";
            this.textBoxDadosAlvoDistanciaDoCanhao.Size = new System.Drawing.Size(100, 22);
            this.textBoxDadosAlvoDistanciaDoCanhao.TabIndex = 5;
            // 
            // labelDadosProjetilGrausAnguloTrajetoria
            // 
            this.labelDadosProjetilGrausAnguloTrajetoria.AutoSize = true;
            this.labelDadosProjetilGrausAnguloTrajetoria.BackColor = System.Drawing.SystemColors.Control;
            this.labelDadosProjetilGrausAnguloTrajetoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDadosProjetilGrausAnguloTrajetoria.Location = new System.Drawing.Point(226, 402);
            this.labelDadosProjetilGrausAnguloTrajetoria.Name = "labelDadosProjetilGrausAnguloTrajetoria";
            this.labelDadosProjetilGrausAnguloTrajetoria.Size = new System.Drawing.Size(59, 21);
            this.labelDadosProjetilGrausAnguloTrajetoria.TabIndex = 13;
            this.labelDadosProjetilGrausAnguloTrajetoria.Text = "° graus";
            // 
            // textBoxDadosProjetilAnguloTrajetoria
            // 
            this.textBoxDadosProjetilAnguloTrajetoria.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDadosProjetilAnguloTrajetoria.Location = new System.Drawing.Point(124, 402);
            this.textBoxDadosProjetilAnguloTrajetoria.Name = "textBoxDadosProjetilAnguloTrajetoria";
            this.textBoxDadosProjetilAnguloTrajetoria.Size = new System.Drawing.Size(100, 22);
            this.textBoxDadosProjetilAnguloTrajetoria.TabIndex = 12;
            // 
            // labelDadosProjetilAnguloTrajetoria
            // 
            this.labelDadosProjetilAnguloTrajetoria.AutoSize = true;
            this.labelDadosProjetilAnguloTrajetoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDadosProjetilAnguloTrajetoria.Location = new System.Drawing.Point(32, 389);
            this.labelDadosProjetilAnguloTrajetoria.Name = "labelDadosProjetilAnguloTrajetoria";
            this.labelDadosProjetilAnguloTrajetoria.Size = new System.Drawing.Size(86, 42);
            this.labelDadosProjetilAnguloTrajetoria.TabIndex = 11;
            this.labelDadosProjetilAnguloTrajetoria.Text = "Angulo da \r\nTrajetoria";
            // 
            // buttonSimularTelaSimulacao
            // 
            this.buttonSimularTelaSimulacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSimularTelaSimulacao.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimularTelaSimulacao.ForeColor = System.Drawing.Color.White;
            this.buttonSimularTelaSimulacao.Location = new System.Drawing.Point(92, 479);
            this.buttonSimularTelaSimulacao.Name = "buttonSimularTelaSimulacao";
            this.buttonSimularTelaSimulacao.Size = new System.Drawing.Size(152, 46);
            this.buttonSimularTelaSimulacao.TabIndex = 21;
            this.buttonSimularTelaSimulacao.Text = "Simular! 💥";
            this.buttonSimularTelaSimulacao.UseVisualStyleBackColor = false;
            this.buttonSimularTelaSimulacao.Click += new System.EventHandler(this.buttonSimularTelaSimulacao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 42);
            this.label1.TabIndex = 22;
            this.label1.Text = "Velocidade \r\nInicial";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDadosVelocidadeInicialAlvo
            // 
            this.textBoxDadosVelocidadeInicialAlvo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDadosVelocidadeInicialAlvo.Location = new System.Drawing.Point(117, 221);
            this.textBoxDadosVelocidadeInicialAlvo.Name = "textBoxDadosVelocidadeInicialAlvo";
            this.textBoxDadosVelocidadeInicialAlvo.Size = new System.Drawing.Size(100, 22);
            this.textBoxDadosVelocidadeInicialAlvo.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 42);
            this.label2.TabIndex = 24;
            this.label2.Text = "metros por\r\nsegundo (m/s)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 30);
            this.label7.TabIndex = 20;
            this.label7.Text = "Dados para o projétil 🚀";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // buttonObterAnguloIdeal
            // 
            this.buttonObterAnguloIdeal.BackColor = System.Drawing.SystemColors.Window;
            this.buttonObterAnguloIdeal.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObterAnguloIdeal.Location = new System.Drawing.Point(30, 280);
            this.buttonObterAnguloIdeal.Name = "buttonObterAnguloIdeal";
            this.buttonObterAnguloIdeal.Size = new System.Drawing.Size(274, 46);
            this.buttonObterAnguloIdeal.TabIndex = 25;
            this.buttonObterAnguloIdeal.Text = "Obter o ângulo ideal 🎯";
            this.buttonObterAnguloIdeal.UseVisualStyleBackColor = false;
            this.buttonObterAnguloIdeal.Click += new System.EventHandler(this.buttonObterAnguloIdeal_Click);
            // 
            // pBLDBDataSetDefinitivo
            // 
            this.pBLDBDataSetDefinitivo.DataSetName = "PBLDBDataSetDefinitivo";
            this.pBLDBDataSetDefinitivo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pBLDBDataSetDefinitivoBindingSource
            // 
            this.pBLDBDataSetDefinitivoBindingSource.DataSource = this.pBLDBDataSetDefinitivo;
            this.pBLDBDataSetDefinitivoBindingSource.Position = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 45);
            this.label3.TabIndex = 26;
            this.label3.Text = "Realizar simulacao";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Para valores decimais, utilize virgulas | Exemplo: 75,01";
            // 
            // buttonSairTelaSimulacao
            // 
            this.buttonSairTelaSimulacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSairTelaSimulacao.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSairTelaSimulacao.ForeColor = System.Drawing.Color.White;
            this.buttonSairTelaSimulacao.Location = new System.Drawing.Point(92, 543);
            this.buttonSairTelaSimulacao.Name = "buttonSairTelaSimulacao";
            this.buttonSairTelaSimulacao.Size = new System.Drawing.Size(152, 46);
            this.buttonSairTelaSimulacao.TabIndex = 28;
            this.buttonSairTelaSimulacao.Text = "Sair 🚪⬅️";
            this.buttonSairTelaSimulacao.UseVisualStyleBackColor = false;
            this.buttonSairTelaSimulacao.Click += new System.EventHandler(this.buttonSairTelaSimulacao_Click);
            // 
            // TelaSimulacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 601);
            this.Controls.Add(this.buttonSairTelaSimulacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonObterAnguloIdeal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDadosVelocidadeInicialAlvo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSimularTelaSimulacao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelDadosProjetilGrausAnguloTrajetoria);
            this.Controls.Add(this.textBoxDadosProjetilAnguloTrajetoria);
            this.Controls.Add(this.labelDadosProjetilAnguloTrajetoria);
            this.Controls.Add(this.labelDadosAlvoMetrosDistanciaCanhao);
            this.Controls.Add(this.textBoxDadosAlvoDistanciaDoCanhao);
            this.Controls.Add(this.labelDadosAlvoDistanciaCanhao);
            this.Controls.Add(this.labelDadosAlvoMetrosAlturaInicial);
            this.Controls.Add(this.textBoxDadosAlvoAlturaInicial);
            this.Controls.Add(this.labelDadosAlvoAlturaInicial);
            this.Controls.Add(this.labelDadosParaAlvo);
            this.Name = "TelaSimulacao";
            this.Text = "Simulacao - Sistema de calculo e simulação de um lançamento balistico com alvo mo" +
    "vel";
            this.Load += new System.EventHandler(this.TelaSimulacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBLDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLDBDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLDBDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLDBDataSetDefinitivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLDBDataSetDefinitivoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDadosParaAlvo;
        private System.Windows.Forms.Label labelDadosAlvoAlturaInicial;
        private System.Windows.Forms.TextBox textBoxDadosAlvoAlturaInicial;
        private System.Windows.Forms.Label labelDadosAlvoMetrosAlturaInicial;
        private System.Windows.Forms.Label labelDadosAlvoDistanciaCanhao;
        private System.Windows.Forms.Label labelDadosAlvoMetrosDistanciaCanhao;
        private System.Windows.Forms.TextBox textBoxDadosAlvoDistanciaDoCanhao;
        private System.Windows.Forms.Label labelDadosProjetilGrausAnguloTrajetoria;
        private System.Windows.Forms.TextBox textBoxDadosProjetilAnguloTrajetoria;
        private System.Windows.Forms.Label labelDadosProjetilAnguloTrajetoria;
        private System.Windows.Forms.Button buttonSimularTelaSimulacao;
        private System.Windows.Forms.BindingSource pBLDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource pBLDBDataSetBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDadosVelocidadeInicialAlvo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonObterAnguloIdeal;
        private System.Windows.Forms.BindingSource pBLDBDataSetBindingSource2;
        private PBLDBDataSetDefinitivo pBLDBDataSetDefinitivo;
        private System.Windows.Forms.BindingSource pBLDBDataSetDefinitivoBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSairTelaSimulacao;
    }
}