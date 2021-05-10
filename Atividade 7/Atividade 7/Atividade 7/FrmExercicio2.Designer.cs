namespace Atividade_6
{
    partial class FrmExercicio2
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
            this.lblN = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lblH = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(46, 51);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(18, 13);
            this.lblN.TabIndex = 0;
            this.lblN.Text = "N:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(70, 48);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(56, 20);
            this.txtN.TabIndex = 1;
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(46, 83);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(18, 13);
            this.lblH.TabIndex = 2;
            this.lblH.Text = "H:";
            // 
            // txtH
            // 
            this.txtH.Enabled = false;
            this.txtH.Location = new System.Drawing.Point(70, 83);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(56, 20);
            this.txtH.TabIndex = 3;
            // 
            // btnGerar
            // 
            this.btnGerar.FlatAppearance.BorderSize = 3;
            this.btnGerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(49, 128);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(93, 27);
            this.btnGerar.TabIndex = 4;
            this.btnGerar.Text = "GERAR H";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnApagar.FlatAppearance.BorderSize = 3;
            this.btnApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.Red;
            this.btnApagar.Location = new System.Drawing.Point(49, 161);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(93, 27);
            this.btnApagar.TabIndex = 5;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // FrmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 236);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.lblN);
            this.Name = "FrmExercicio2";
            this.Text = "FrmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnApagar;
    }
}