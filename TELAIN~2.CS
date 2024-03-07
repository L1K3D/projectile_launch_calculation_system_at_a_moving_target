
namespace PPL_Main.Telas
{
    partial class TelaInicio
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
            this.EntrarButton = new System.Windows.Forms.Button();
            this.SairButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cadastrarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EntrarButton
            // 
            this.EntrarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.EntrarButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntrarButton.Location = new System.Drawing.Point(12, 142);
            this.EntrarButton.Name = "EntrarButton";
            this.EntrarButton.Size = new System.Drawing.Size(165, 41);
            this.EntrarButton.TabIndex = 0;
            this.EntrarButton.Text = "Entrar ➡️🙍‍♂️\r\n";
            this.EntrarButton.UseVisualStyleBackColor = false;
            this.EntrarButton.Click += new System.EventHandler(this.EntrarButton_Click);
            // 
            // SairButton
            // 
            this.SairButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SairButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SairButton.ForeColor = System.Drawing.Color.White;
            this.SairButton.Location = new System.Drawing.Point(12, 205);
            this.SairButton.Name = "SairButton";
            this.SairButton.Size = new System.Drawing.Size(338, 41);
            this.SairButton.TabIndex = 1;
            this.SairButton.Text = "Sair ❌🚪";
            this.SairButton.UseVisualStyleBackColor = false;
            this.SairButton.Click += new System.EventHandler(this.SairButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 90);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sistema de Cálculo e \r\nSimulação de um Lançamento \r\nBalístico com Alvo Móvel";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cadastrarButton
            // 
            this.cadastrarButton.BackColor = System.Drawing.Color.White;
            this.cadastrarButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarButton.Location = new System.Drawing.Point(185, 142);
            this.cadastrarButton.Name = "cadastrarButton";
            this.cadastrarButton.Size = new System.Drawing.Size(165, 41);
            this.cadastrarButton.TabIndex = 9;
            this.cadastrarButton.Text = "Cadastrar 🙍‍♂️➕";
            this.cadastrarButton.UseVisualStyleBackColor = false;
            this.cadastrarButton.Click += new System.EventHandler(this.cadastrarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Caso você não tenha um login, cadastre-se\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TelaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cadastrarButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SairButton);
            this.Controls.Add(this.EntrarButton);
            this.Name = "TelaInicio";
            this.Text = "Inicio - Sistema de Calculo e Simulação de um Lançamento Balistico com Alvo Movel" +
    "";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EntrarButton;
        private System.Windows.Forms.Button SairButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cadastrarButton;
        private System.Windows.Forms.Label label1;
    }
}