
namespace Trabalho2
{
    partial class MainWindow
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
            this.CampoEditor = new ScintillaNET.Scintilla();
            this.CampoResultado = new System.Windows.Forms.TextBox();
            this.BotaoAnalisar = new System.Windows.Forms.Button();
            this.BotaoLimpar = new System.Windows.Forms.Button();
            this.BotaoEquipe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CampoEditor
            // 
            this.CampoEditor.Location = new System.Drawing.Point(-1, 1);
            this.CampoEditor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CampoEditor.Name = "CampoEditor";
            this.CampoEditor.Size = new System.Drawing.Size(885, 300);
            this.CampoEditor.TabIndex = 0;
            // 
            // CampoResultado
            // 
            this.CampoResultado.Location = new System.Drawing.Point(-1, 340);
            this.CampoResultado.Margin = new System.Windows.Forms.Padding(4);
            this.CampoResultado.Multiline = true;
            this.CampoResultado.Name = "CampoResultado";
            this.CampoResultado.Size = new System.Drawing.Size(885, 150);
            this.CampoResultado.TabIndex = 1;
            // 
            // BotaoAnalisar
            // 
            this.BotaoAnalisar.Location = new System.Drawing.Point(-1, 306);
            this.BotaoAnalisar.Margin = new System.Windows.Forms.Padding(4);
            this.BotaoAnalisar.Name = "BotaoAnalisar";
            this.BotaoAnalisar.Size = new System.Drawing.Size(290, 30);
            this.BotaoAnalisar.TabIndex = 2;
            this.BotaoAnalisar.Text = "analisar";
            this.BotaoAnalisar.UseVisualStyleBackColor = true;
            // 
            // BotaoLimpar
            // 
            this.BotaoLimpar.Location = new System.Drawing.Point(297, 306);
            this.BotaoLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.BotaoLimpar.Name = "BotaoLimpar";
            this.BotaoLimpar.Size = new System.Drawing.Size(290, 30);
            this.BotaoLimpar.TabIndex = 3;
            this.BotaoLimpar.Text = "limpar";
            this.BotaoLimpar.UseVisualStyleBackColor = true;
            // 
            // BotaoEquipe
            // 
            this.BotaoEquipe.Location = new System.Drawing.Point(593, 306);
            this.BotaoEquipe.Margin = new System.Windows.Forms.Padding(4);
            this.BotaoEquipe.Name = "BotaoEquipe";
            this.BotaoEquipe.Size = new System.Drawing.Size(290, 30);
            this.BotaoEquipe.TabIndex = 4;
            this.BotaoEquipe.Text = "equipe";
            this.BotaoEquipe.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 491);
            this.Controls.Add(this.BotaoEquipe);
            this.Controls.Add(this.BotaoLimpar);
            this.Controls.Add(this.BotaoAnalisar);
            this.Controls.Add(this.CampoResultado);
            this.Controls.Add(this.CampoEditor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScintillaNET.Scintilla CampoEditor;
        private System.Windows.Forms.TextBox CampoResultado;
        private System.Windows.Forms.Button BotaoAnalisar;
        private System.Windows.Forms.Button BotaoLimpar;
        private System.Windows.Forms.Button BotaoEquipe;
    }
}