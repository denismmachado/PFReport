
namespace PFReport
{
    partial class frmCadastroRelatorio
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
            this.cboGrupoRelatorio = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboGrupoRelatorio
            // 
            this.cboGrupoRelatorio.FormattingEnabled = true;
            this.cboGrupoRelatorio.Location = new System.Drawing.Point(0, 0);
            this.cboGrupoRelatorio.Name = "cboGrupoRelatorio";
            this.cboGrupoRelatorio.Size = new System.Drawing.Size(788, 21);
            this.cboGrupoRelatorio.TabIndex = 0;
            this.cboGrupoRelatorio.SelectedIndexChanged += new System.EventHandler(this.cboGrupoRelatorio_SelectedIndexChanged);
            // 
            // frmCadastroRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboGrupoRelatorio);
            this.Name = "frmCadastroRelatorio";
            this.Text = "Cadastro de Relatórios";
            this.Load += new System.EventHandler(this.frmCadastroRelatorio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboGrupoRelatorio;
    }
}