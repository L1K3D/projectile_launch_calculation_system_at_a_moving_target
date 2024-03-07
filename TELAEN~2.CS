
namespace PPL_Main.Telas
{
    partial class TelaEntrar
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
            this.labelFazerLogin = new System.Windows.Forms.Label();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.labelDigiteSuaSenha = new System.Windows.Forms.Label();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.textBoxEntrarNomeUsuario = new System.Windows.Forms.TextBox();
            this.textBoxEntrarSenhaUsuario = new System.Windows.Forms.TextBox();
            this.labelDigiteSeuUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFazerLogin
            // 
            this.labelFazerLogin.AutoSize = true;
            this.labelFazerLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFazerLogin.Location = new System.Drawing.Point(137, 21);
            this.labelFazerLogin.Name = "labelFazerLogin";
            this.labelFazerLogin.Size = new System.Drawing.Size(117, 30);
            this.labelFazerLogin.TabIndex = 10;
            this.labelFazerLogin.Text = "Fazer login";
            this.labelFazerLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.BackColor = System.Drawing.Color.White;
            this.buttonVoltar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltar.Location = new System.Drawing.Point(145, 177);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(120, 39);
            this.buttonVoltar.TabIndex = 17;
            this.buttonVoltar.Text = "Voltar🚪⬅️";
            this.buttonVoltar.UseVisualStyleBackColor = false;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // labelDigiteSuaSenha
            // 
            this.labelDigiteSuaSenha.AutoSize = true;
            this.labelDigiteSuaSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDigiteSuaSenha.Location = new System.Drawing.Point(23, 94);
            this.labelDigiteSuaSenha.Name = "labelDigiteSuaSenha";
            this.labelDigiteSuaSenha.Size = new System.Drawing.Size(128, 21);
            this.labelDigiteSuaSenha.TabIndex = 16;
            this.labelDigiteSuaSenha.Text = "Digite sua senha\r\n";
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonEntrar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEntrar.Location = new System.Drawing.Point(145, 132);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(120, 39);
            this.buttonEntrar.TabIndex = 15;
            this.buttonEntrar.Text = "Entrar ➡️🚪";
            this.buttonEntrar.UseVisualStyleBackColor = false;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // textBoxEntrarNomeUsuario
            // 
            this.textBoxEntrarNomeUsuario.Location = new System.Drawing.Point(160, 69);
            this.textBoxEntrarNomeUsuario.Name = "textBoxEntrarNomeUsuario";
            this.textBoxEntrarNomeUsuario.Size = new System.Drawing.Size(226, 20);
            this.textBoxEntrarNomeUsuario.TabIndex = 14;
            // 
            // textBoxEntrarSenhaUsuario
            // 
            this.textBoxEntrarSenhaUsuario.Location = new System.Drawing.Point(160, 97);
            this.textBoxEntrarSenhaUsuario.Name = "textBoxEntrarSenhaUsuario";
            this.textBoxEntrarSenhaUsuario.Size = new System.Drawing.Size(226, 20);
            this.textBoxEntrarSenhaUsuario.TabIndex = 13;
            this.textBoxEntrarSenhaUsuario.TextChanged += new System.EventHandler(this.textBoxEntrarSenhaUsuario_TextChanged);
            // 
            // labelDigiteSeuUsuario
            // 
            this.labelDigiteSeuUsuario.AutoSize = true;
            this.labelDigiteSeuUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDigiteSeuUsuario.Location = new System.Drawing.Point(17, 68);
            this.labelDigiteSeuUsuario.Name = "labelDigiteSeuUsuario";
            this.labelDigiteSeuUsuario.Size = new System.Drawing.Size(140, 21);
            this.labelDigiteSeuUsuario.TabIndex = 12;
            this.labelDigiteSeuUsuario.Text = "Digite seu usuário";
            // 
            // TelaEntrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 234);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.labelDigiteSuaSenha);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.textBoxEntrarNomeUsuario);
            this.Controls.Add(this.textBoxEntrarSenhaUsuario);
            this.Controls.Add(this.labelDigiteSeuUsuario);
            this.Controls.Add(this.labelFazerLogin);
            this.Name = "TelaEntrar";
            this.Text = "Entrar - Sistema de Calculo e Simulação de um Lançamento Balistico com Alvo Movel" +
    "";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFazerLogin;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Label labelDigiteSuaSenha;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.TextBox textBoxEntrarNomeUsuario;
        private System.Windows.Forms.TextBox textBoxEntrarSenhaUsuario;
        private System.Windows.Forms.Label labelDigiteSeuUsuario;
    }
}