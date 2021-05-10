namespace Atividade_6
{
    partial class FrmExercicio1
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
            this.rtxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnLetraR = new System.Windows.Forms.Button();
            this.btnPares = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtTexto
            // 
            this.rtxtTexto.Location = new System.Drawing.Point(159, 42);
            this.rtxtTexto.Name = "rtxtTexto";
            this.rtxtTexto.Size = new System.Drawing.Size(489, 151);
            this.rtxtTexto.TabIndex = 0;
            this.rtxtTexto.Text = "";
            // 
            // btnBranco
            // 
            this.btnBranco.FlatAppearance.BorderSize = 3;
            this.btnBranco.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnBranco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBranco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBranco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBranco.Location = new System.Drawing.Point(159, 254);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(144, 73);
            this.btnBranco.TabIndex = 1;
            this.btnBranco.Text = "Conta Espaços Brancos";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnLetraR
            // 
            this.btnLetraR.FlatAppearance.BorderSize = 3;
            this.btnLetraR.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnLetraR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLetraR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetraR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetraR.Location = new System.Drawing.Point(331, 254);
            this.btnLetraR.Name = "btnLetraR";
            this.btnLetraR.Size = new System.Drawing.Size(144, 73);
            this.btnLetraR.TabIndex = 2;
            this.btnLetraR.Text = "Conta Letra \"R\"";
            this.btnLetraR.UseVisualStyleBackColor = true;
            this.btnLetraR.Click += new System.EventHandler(this.btnLetraR_Click);
            // 
            // btnPares
            // 
            this.btnPares.FlatAppearance.BorderSize = 3;
            this.btnPares.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnPares.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPares.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPares.Location = new System.Drawing.Point(504, 254);
            this.btnPares.Name = "btnPares";
            this.btnPares.Size = new System.Drawing.Size(144, 73);
            this.btnPares.TabIndex = 3;
            this.btnPares.Text = "Conta Pares de Letras";
            this.btnPares.UseVisualStyleBackColor = true;
            this.btnPares.Click += new System.EventHandler(this.btnPares_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnApagar.FlatAppearance.BorderSize = 3;
            this.btnApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.Red;
            this.btnApagar.Location = new System.Drawing.Point(654, 84);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(116, 55);
            this.btnApagar.TabIndex = 4;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // FrmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnPares);
            this.Controls.Add(this.btnLetraR);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.rtxtTexto);
            this.Name = "FrmExercicio1";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmExercicio1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtTexto;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnLetraR;
        private System.Windows.Forms.Button btnPares;
        private System.Windows.Forms.Button btnApagar;
    }
}