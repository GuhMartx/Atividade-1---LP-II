namespace Atividade_6
{
    partial class FrmExercicio4
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblNInscricao = new System.Windows.Forms.Label();
            this.lblProducao = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblGratificacao = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.txtSalBruto = new System.Windows.Forms.TextBox();
            this.btnCalcSalBruto = new System.Windows.Forms.Button();
            this.txtNInscricao = new System.Windows.Forms.MaskedTextBox();
            this.txtProducao = new System.Windows.Forms.MaskedTextBox();
            this.txtSalario = new System.Windows.Forms.MaskedTextBox();
            this.txtGratificacao = new System.Windows.Forms.MaskedTextBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(14, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(14, 68);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(38, 13);
            this.lblCargo.TabIndex = 1;
            this.lblCargo.Text = "Cargo:";
            // 
            // lblNInscricao
            // 
            this.lblNInscricao.AutoSize = true;
            this.lblNInscricao.Location = new System.Drawing.Point(14, 101);
            this.lblNInscricao.Name = "lblNInscricao";
            this.lblNInscricao.Size = new System.Drawing.Size(83, 13);
            this.lblNInscricao.TabIndex = 2;
            this.lblNInscricao.Text = "Nº de Inscrição:";
            // 
            // lblProducao
            // 
            this.lblProducao.AutoSize = true;
            this.lblProducao.Location = new System.Drawing.Point(14, 133);
            this.lblProducao.Name = "lblProducao";
            this.lblProducao.Size = new System.Drawing.Size(56, 13);
            this.lblProducao.TabIndex = 3;
            this.lblProducao.Text = "Produção:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(14, 165);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(42, 13);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "Salário:";
            // 
            // lblGratificacao
            // 
            this.lblGratificacao.AutoSize = true;
            this.lblGratificacao.Location = new System.Drawing.Point(14, 198);
            this.lblGratificacao.Name = "lblGratificacao";
            this.lblGratificacao.Size = new System.Drawing.Size(67, 13);
            this.lblGratificacao.TabIndex = 5;
            this.lblGratificacao.Text = "Gratificação:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(58, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(180, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(58, 65);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(180, 20);
            this.txtCargo.TabIndex = 2;
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Location = new System.Drawing.Point(14, 264);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(70, 13);
            this.lblSalBruto.TabIndex = 12;
            this.lblSalBruto.Text = "Salário Bruto:";
            // 
            // txtSalBruto
            // 
            this.txtSalBruto.Enabled = false;
            this.txtSalBruto.Location = new System.Drawing.Point(87, 261);
            this.txtSalBruto.Name = "txtSalBruto";
            this.txtSalBruto.Size = new System.Drawing.Size(151, 20);
            this.txtSalBruto.TabIndex = 8;
            // 
            // btnCalcSalBruto
            // 
            this.btnCalcSalBruto.FlatAppearance.BorderSize = 3;
            this.btnCalcSalBruto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCalcSalBruto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcSalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcSalBruto.Location = new System.Drawing.Point(244, 255);
            this.btnCalcSalBruto.Name = "btnCalcSalBruto";
            this.btnCalcSalBruto.Size = new System.Drawing.Size(155, 30);
            this.btnCalcSalBruto.TabIndex = 7;
            this.btnCalcSalBruto.Text = "Calcular Salário Bruto";
            this.btnCalcSalBruto.UseVisualStyleBackColor = true;
            this.btnCalcSalBruto.Click += new System.EventHandler(this.btnCalcSalBruto_Click);
            // 
            // txtNInscricao
            // 
            this.txtNInscricao.Location = new System.Drawing.Point(103, 98);
            this.txtNInscricao.Mask = "0000000000000000000000000000000000000000000000000000000000000";
            this.txtNInscricao.Name = "txtNInscricao";
            this.txtNInscricao.Size = new System.Drawing.Size(135, 20);
            this.txtNInscricao.TabIndex = 3;
            // 
            // txtProducao
            // 
            this.txtProducao.Location = new System.Drawing.Point(76, 130);
            this.txtProducao.Mask = "0000000000000000000000000000000000000000000000000000000";
            this.txtProducao.Name = "txtProducao";
            this.txtProducao.Size = new System.Drawing.Size(162, 20);
            this.txtProducao.TabIndex = 4;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(62, 162);
            this.txtSalario.Mask = "0000000000000000000000000000000000000000000000000000";
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(176, 20);
            this.txtSalario.TabIndex = 5;
            // 
            // txtGratificacao
            // 
            this.txtGratificacao.Location = new System.Drawing.Point(87, 195);
            this.txtGratificacao.Mask = "0000000000000000000000000000000000000000000000000000000";
            this.txtGratificacao.Name = "txtGratificacao";
            this.txtGratificacao.Size = new System.Drawing.Size(151, 20);
            this.txtGratificacao.TabIndex = 6;
            // 
            // btnApagar
            // 
            this.btnApagar.FlatAppearance.BorderSize = 3;
            this.btnApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.Red;
            this.btnApagar.Location = new System.Drawing.Point(273, 116);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(124, 47);
            this.btnApagar.TabIndex = 13;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.txtGratificacao);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtProducao);
            this.Controls.Add(this.txtNInscricao);
            this.Controls.Add(this.btnCalcSalBruto);
            this.Controls.Add(this.txtSalBruto);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblGratificacao);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblProducao);
            this.Controls.Add(this.lblNInscricao);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmExercicio4";
            this.Text = "FrmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblNInscricao;
        private System.Windows.Forms.Label lblProducao;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblGratificacao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.TextBox txtSalBruto;
        private System.Windows.Forms.Button btnCalcSalBruto;
        private System.Windows.Forms.MaskedTextBox txtNInscricao;
        private System.Windows.Forms.MaskedTextBox txtProducao;
        private System.Windows.Forms.MaskedTextBox txtSalario;
        private System.Windows.Forms.MaskedTextBox txtGratificacao;
        private System.Windows.Forms.Button btnApagar;
    }
}