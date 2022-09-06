
namespace PFReport
{
    partial class frmTelaInicial
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
            this.btnCadastroFiltro = new System.Windows.Forms.Button();
            this.btnCadastroRelatorio = new System.Windows.Forms.Button();
            this.btnGerarScript = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroFiltro
            // 
            this.btnCadastroFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroFiltro.Location = new System.Drawing.Point(140, 86);
            this.btnCadastroFiltro.Name = "btnCadastroFiltro";
            this.btnCadastroFiltro.Size = new System.Drawing.Size(187, 88);
            this.btnCadastroFiltro.TabIndex = 0;
            this.btnCadastroFiltro.Text = "Cadatro de Filtros";
            this.btnCadastroFiltro.UseVisualStyleBackColor = true;
            // 
            // btnCadastroRelatorio
            // 
            this.btnCadastroRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroRelatorio.Location = new System.Drawing.Point(406, 86);
            this.btnCadastroRelatorio.Name = "btnCadastroRelatorio";
            this.btnCadastroRelatorio.Size = new System.Drawing.Size(187, 88);
            this.btnCadastroRelatorio.TabIndex = 1;
            this.btnCadastroRelatorio.Text = "Cadastro de Relatórios";
            this.btnCadastroRelatorio.UseVisualStyleBackColor = true;
            this.btnCadastroRelatorio.Click += new System.EventHandler(this.btnCadastroRelatorio_Click);
            // 
            // btnGerarScript
            // 
            this.btnGerarScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarScript.Location = new System.Drawing.Point(140, 202);
            this.btnGerarScript.Name = "btnGerarScript";
            this.btnGerarScript.Size = new System.Drawing.Size(453, 65);
            this.btnGerarScript.TabIndex = 2;
            this.btnGerarScript.Text = "Gerar Script de Atualização";
            this.btnGerarScript.UseVisualStyleBackColor = true;
            // 
            // frmTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGerarScript);
            this.Controls.Add(this.btnCadastroRelatorio);
            this.Controls.Add(this.btnCadastroFiltro);
            this.Name = "frmTelaInicial";
            this.Text = "PFReport";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroFiltro;
        private System.Windows.Forms.Button btnCadastroRelatorio;
        private System.Windows.Forms.Button btnGerarScript;
    }
}