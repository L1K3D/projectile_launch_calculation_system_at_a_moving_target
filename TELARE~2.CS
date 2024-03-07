
namespace PPL_Main.Telas
{
    partial class TelaResultadosAnteriores
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
            this.dataGridViewTabelaSimulacoes = new System.Windows.Forms.DataGridView();
            this.labelDadosParaAlvo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTabelaProjetil = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTabelaAlvo = new System.Windows.Forms.DataGridView();
            this.voltarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabelaSimulacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabelaProjetil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabelaAlvo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTabelaSimulacoes
            // 
            this.dataGridViewTabelaSimulacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabelaSimulacoes.Location = new System.Drawing.Point(12, 66);
            this.dataGridViewTabelaSimulacoes.Name = "dataGridViewTabelaSimulacoes";
            this.dataGridViewTabelaSimulacoes.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewTabelaSimulacoes.TabIndex = 0;
            // 
            // labelDadosParaAlvo
            // 
            this.labelDadosParaAlvo.AutoSize = true;
            this.labelDadosParaAlvo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDadosParaAlvo.Location = new System.Drawing.Point(12, 33);
            this.labelDadosParaAlvo.Name = "labelDadosParaAlvo";
            this.labelDadosParaAlvo.Size = new System.Drawing.Size(160, 30);
            this.labelDadosParaAlvo.TabIndex = 1;
            this.labelDadosParaAlvo.Text = "Simulações 🖥️:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Projeteis 🚀:";
            // 
            // dataGridViewTabelaProjetil
            // 
            this.dataGridViewTabelaProjetil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabelaProjetil.Location = new System.Drawing.Point(12, 277);
            this.dataGridViewTabelaProjetil.Name = "dataGridViewTabelaProjetil";
            this.dataGridViewTabelaProjetil.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewTabelaProjetil.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alvos 🎯:";
            // 
            // dataGridViewTabelaAlvo
            // 
            this.dataGridViewTabelaAlvo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabelaAlvo.Location = new System.Drawing.Point(12, 495);
            this.dataGridViewTabelaAlvo.Name = "dataGridViewTabelaAlvo";
            this.dataGridViewTabelaAlvo.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewTabelaAlvo.TabIndex = 4;
            // 
            // voltarButton
            // 
            this.voltarButton.BackColor = System.Drawing.Color.White;
            this.voltarButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltarButton.Location = new System.Drawing.Point(620, 12);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(155, 39);
            this.voltarButton.TabIndex = 12;
            this.voltarButton.Text = "Voltar 🚪⬅️";
            this.voltarButton.UseVisualStyleBackColor = false;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // TelaResultadosAnteriores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 658);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewTabelaAlvo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTabelaProjetil);
            this.Controls.Add(this.labelDadosParaAlvo);
            this.Controls.Add(this.dataGridViewTabelaSimulacoes);
            this.Name = "TelaResultadosAnteriores";
            this.Text = "Resultados Anteriores - Sistema de calculo e simulação de um lançamento balistico" +
    " com alvo movel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabelaSimulacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabelaProjetil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabelaAlvo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTabelaSimulacoes;
        private System.Windows.Forms.Label labelDadosParaAlvo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTabelaProjetil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewTabelaAlvo;
        private System.Windows.Forms.Button voltarButton;
    }
}