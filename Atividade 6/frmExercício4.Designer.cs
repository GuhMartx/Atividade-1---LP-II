
namespace Atividade_6
{
    partial class frmExercício4
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
            this.btnVerificar1 = new System.Windows.Forms.Button();
            this.rtxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnVerificar3 = new System.Windows.Forms.Button();
            this.btnVerificar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerificar1
            // 
            this.btnVerificar1.Location = new System.Drawing.Point(106, 200);
            this.btnVerificar1.Name = "btnVerificar1";
            this.btnVerificar1.Size = new System.Drawing.Size(117, 61);
            this.btnVerificar1.TabIndex = 0;
            this.btnVerificar1.Text = "Verificar quantos números há no texto";
            this.btnVerificar1.UseVisualStyleBackColor = true;
            this.btnVerificar1.Click += new System.EventHandler(this.btnVerificar1_Click);
            // 
            // rtxtTexto
            // 
            this.rtxtTexto.Location = new System.Drawing.Point(106, 66);
            this.rtxtTexto.Name = "rtxtTexto";
            this.rtxtTexto.Size = new System.Drawing.Size(429, 96);
            this.rtxtTexto.TabIndex = 1;
            this.rtxtTexto.Text = "";
            // 
            // btnVerificar3
            // 
            this.btnVerificar3.Location = new System.Drawing.Point(418, 200);
            this.btnVerificar3.Name = "btnVerificar3";
            this.btnVerificar3.Size = new System.Drawing.Size(117, 61);
            this.btnVerificar3.TabIndex = 2;
            this.btnVerificar3.Text = "Verificar quantas letras há no texto";
            this.btnVerificar3.UseVisualStyleBackColor = true;
            this.btnVerificar3.Click += new System.EventHandler(this.btnVerificar3_Click);
            // 
            // btnVerificar2
            // 
            this.btnVerificar2.Location = new System.Drawing.Point(259, 200);
            this.btnVerificar2.Name = "btnVerificar2";
            this.btnVerificar2.Size = new System.Drawing.Size(117, 61);
            this.btnVerificar2.TabIndex = 3;
            this.btnVerificar2.Text = "Verificar quantos caracteres em branco há no texto";
            this.btnVerificar2.UseVisualStyleBackColor = true;
            this.btnVerificar2.Click += new System.EventHandler(this.btnVerificar2_Click);
            // 
            // frmExercício4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerificar2);
            this.Controls.Add(this.btnVerificar3);
            this.Controls.Add(this.rtxtTexto);
            this.Controls.Add(this.btnVerificar1);
            this.Name = "frmExercício4";
            this.Text = "frmExercício4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar1;
        private System.Windows.Forms.RichTextBox rtxtTexto;
        private System.Windows.Forms.Button btnVerificar3;
        private System.Windows.Forms.Button btnVerificar2;
    }
}