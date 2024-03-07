
namespace PPL_Main.Telas
{
    partial class TelaCadastrar
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
            this.textBoxCadastrarSenhaUsuario = new System.Windows.Forms.TextBox();
            this.textBoxCadastrarNomeUsuario = new System.Windows.Forms.TextBox();
            this.cadastrarButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.voltarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite seu usuário";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxCadastrarSenhaUsuario
            // 
            this.textBoxCadastrarSenhaUsuario.Location = new System.Drawing.Point(148, 124);
            this.textBoxCadastrarSenhaUsuario.Name = "textBoxCadastrarSenhaUsuario";
            this.textBoxCadastrarSenhaUsuario.Size = new System.Drawing.Size(226, 20);
            this.textBoxCadastrarSenhaUsuario.TabIndex = 2;
            this.textBoxCadastrarSenhaUsuario.TextChanged += new System.EventHandler(this.senhaTextBox_TextChanged);
            // 
            // textBoxCadastrarNomeUsuario
            // 
            this.textBoxCadastrarNomeUsuario.Location = new System.Drawing.Point(148, 61);
            this.textBoxCadastrarNomeUsuario.Name = "textBoxCadastrarNomeUsuario";
            this.textBoxCadastrarNomeUsuario.Size = new System.Drawing.Size(226, 20);
            this.textBoxCadastrarNomeUsuario.TabIndex = 3;
            // 
            // cadastrarButton
            // 
            this.cadastrarButton.BackColor = System.Drawing.Color.ForestGreen;
            this.cadastrarButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cadastrarButton.Location = new System.Drawing.Point(110, 180);
            this.cadastrarButton.Name = "cadastrarButton";
            this.cadastrarButton.Size = new System.Drawing.Size(155, 39);
            this.cadastrarButton.TabIndex = 4;
            this.cadastrarButton.Text = "Cadastrar 🙍‍♂️➕";
            this.cadastrarButton.UseVisualStyleBackColor = false;
            this.cadastrarButton.Click += new System.EventHandler(this.cadastrarButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cadastre-se";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Digite sua senha\r\n";
            // 
            // voltarButton
            // 
            this.voltarButton.BackColor = System.Drawing.Color.White;
            this.voltarButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltarButton.Location = new System.Drawing.Point(110, 225);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(155, 39);
            this.voltarButton.TabIndex = 11;
            this.voltarButton.Text = "Voltar 🚪⬅️";
            this.voltarButton.UseVisualStyleBackColor = false;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nome de usuario não deve conter caracteres especiais \"ç\" ou números";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Senha não devem conter caracteres especiais ou \"ç\"\r\n";
            // 
            // TelaCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 275);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cadastrarButton);
            this.Controls.Add(this.textBoxCadastrarNomeUsuario);
            this.Controls.Add(this.textBoxCadastrarSenhaUsuario);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadastrar";
            this.Text = "Cadastrar - Sistema de Calculo e Simulação de um Lançamento Balistico com Alvo Mo" +
    "vel";
            this.Load += new System.EventHandler(this.TelaCadastrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCadastrarSenhaUsuario;
        private System.Windows.Forms.TextBox textBoxCadastrarNomeUsuario;
        private System.Windows.Forms.Button cadastrarButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button voltarButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}