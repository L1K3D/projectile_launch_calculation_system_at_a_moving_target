
namespace PPL_Main.Telas
{
    partial class TelaMenu
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
            this.sairButton = new System.Windows.Forms.Button();
            this.buttonAbreTelaSimular = new System.Windows.Forms.Button();
            this.buttonConferirResultadosAnteriores = new System.Windows.Forms.Button();
            this.buttonExibirRelatorioRepaginado = new System.Windows.Forms.Button();
            this.pBLDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pBLDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sairButton
            // 
            this.sairButton.BackColor = System.Drawing.Color.DarkRed;
            this.sairButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sairButton.Location = new System.Drawing.Point(126, 206);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(91, 38);
            this.sairButton.TabIndex = 2;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = false;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // buttonAbreTelaSimular
            // 
            this.buttonAbreTelaSimular.BackColor = System.Drawing.Color.White;
            this.buttonAbreTelaSimular.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbreTelaSimular.Location = new System.Drawing.Point(74, 22);
            this.buttonAbreTelaSimular.Name = "buttonAbreTelaSimular";
            this.buttonAbreTelaSimular.Size = new System.Drawing.Size(211, 45);
            this.buttonAbreTelaSimular.TabIndex = 22;
            this.buttonAbreTelaSimular.Text = "Nova Simulação 🕹️";
            this.buttonAbreTelaSimular.UseVisualStyleBackColor = false;
            this.buttonAbreTelaSimular.Click += new System.EventHandler(this.buttonAbreTelaSimular_Click);
            // 
            // buttonConferirResultadosAnteriores
            // 
            this.buttonConferirResultadosAnteriores.BackColor = System.Drawing.Color.White;
            this.buttonConferirResultadosAnteriores.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConferirResultadosAnteriores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonConferirResultadosAnteriores.Location = new System.Drawing.Point(18, 83);
            this.buttonConferirResultadosAnteriores.Name = "buttonConferirResultadosAnteriores";
            this.buttonConferirResultadosAnteriores.Size = new System.Drawing.Size(318, 41);
            this.buttonConferirResultadosAnteriores.TabIndex = 23;
            this.buttonConferirResultadosAnteriores.Text = "Conferir resultados anterioes 🔄\r\n\r\n";
            this.buttonConferirResultadosAnteriores.UseVisualStyleBackColor = false;
            this.buttonConferirResultadosAnteriores.Click += new System.EventHandler(this.buttonConferirResultadosAnteriores_Click);
            // 
            // buttonExibirRelatorioRepaginado
            // 
            this.buttonExibirRelatorioRepaginado.BackColor = System.Drawing.Color.White;
            this.buttonExibirRelatorioRepaginado.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExibirRelatorioRepaginado.Location = new System.Drawing.Point(18, 141);
            this.buttonExibirRelatorioRepaginado.Name = "buttonExibirRelatorioRepaginado";
            this.buttonExibirRelatorioRepaginado.Size = new System.Drawing.Size(318, 43);
            this.buttonExibirRelatorioRepaginado.TabIndex = 24;
            this.buttonExibirRelatorioRepaginado.Text = "Exibir relatório paginado 📊";
            this.buttonExibirRelatorioRepaginado.UseVisualStyleBackColor = false;
            this.buttonExibirRelatorioRepaginado.Click += new System.EventHandler(this.buttonExibirRelatorioRepaginado_Click);
            // 
            // TelaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 256);
            this.Controls.Add(this.buttonExibirRelatorioRepaginado);
            this.Controls.Add(this.buttonConferirResultadosAnteriores);
            this.Controls.Add(this.buttonAbreTelaSimular);
            this.Controls.Add(this.sairButton);
            this.Name = "TelaMenu";
            this.Text = "Menu Principal - Sistema de calculo e simulação de um lançamento balistico com al" +
    "vo movel";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBLDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.BindingSource pBLDBDataSetBindingSource;
        private System.Windows.Forms.Button buttonAbreTelaSimular;
        private System.Windows.Forms.Button buttonConferirResultadosAnteriores;
        private System.Windows.Forms.Button buttonExibirRelatorioRepaginado;
    }
}