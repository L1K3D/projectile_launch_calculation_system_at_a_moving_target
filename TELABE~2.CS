
namespace PPL_Main.Telas
{
    partial class TelaBemVindo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaBemVindo));
            this.label3 = new System.Windows.Forms.Label();
            this.buttonComecar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonObterAjuda = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(124, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 75);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sistema de Cálculo e \r\nSimulação de um Lançamento \r\nBalístico com Alvo Móvel";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonComecar
            // 
            this.buttonComecar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonComecar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComecar.ForeColor = System.Drawing.Color.Black;
            this.buttonComecar.Location = new System.Drawing.Point(174, 354);
            this.buttonComecar.Name = "buttonComecar";
            this.buttonComecar.Size = new System.Drawing.Size(153, 33);
            this.buttonComecar.TabIndex = 10;
            this.buttonComecar.Text = "Começar! ➡️🚪";
            this.buttonComecar.UseVisualStyleBackColor = false;
            this.buttonComecar.Click += new System.EventHandler(this.buttonComecar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 260);
            this.label1.TabIndex = 11;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 221);
            this.label2.TabIndex = 12;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // buttonObterAjuda
            // 
            this.buttonObterAjuda.BackColor = System.Drawing.Color.White;
            this.buttonObterAjuda.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObterAjuda.Location = new System.Drawing.Point(386, 397);
            this.buttonObterAjuda.Name = "buttonObterAjuda";
            this.buttonObterAjuda.Size = new System.Drawing.Size(119, 85);
            this.buttonObterAjuda.TabIndex = 13;
            this.buttonObterAjuda.Text = "Obter Ajuda ⁉️";
            this.buttonObterAjuda.UseVisualStyleBackColor = false;
            this.buttonObterAjuda.Click += new System.EventHandler(this.buttonObterAjuda_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.Maroon;
            this.buttonSair.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSair.Location = new System.Drawing.Point(386, 504);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(119, 85);
            this.buttonSair.TabIndex = 14;
            this.buttonSair.Text = "Sair 🚪⬅️";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // TelaBemVindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 628);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonObterAjuda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonComecar);
            this.Controls.Add(this.label3);
            this.Name = "TelaBemVindo";
            this.Text = "Bem-Vindo - Sistema de Calculo e Simulação de um Lançamento Balistico com Alvo Mo" +
    "vel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonComecar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonObterAjuda;
        private System.Windows.Forms.Button buttonSair;
    }
}