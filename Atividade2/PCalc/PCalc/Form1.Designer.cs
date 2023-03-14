namespace PCalc
{
    partial class Form1
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.botao_soma = new System.Windows.Forms.Button();
            this.botao_limpar = new System.Windows.Forms.Button();
            this.botao_sub = new System.Windows.Forms.Button();
            this.botao_mult = new System.Windows.Forms.Button();
            this.botao_div = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.botao_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(176, 36);
            this.txtNum1.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(132, 20);
            this.txtNum1.TabIndex = 13;
            this.txtNum1.Validated += new System.EventHandler(this.TxtNum1_Validated);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(176, 86);
            this.txtNum2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(132, 20);
            this.txtNum2.TabIndex = 14;
            this.txtNum2.TextChanged += new System.EventHandler(this.TxtNum2_TextChanged);
            this.txtNum2.Validated += new System.EventHandler(this.TxtNum2_Validated);
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(176, 133);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(132, 20);
            this.txtResult.TabIndex = 15;
            // 
            // botao_soma
            // 
            this.botao_soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_soma.Location = new System.Drawing.Point(78, 190);
            this.botao_soma.Name = "botao_soma";
            this.botao_soma.Size = new System.Drawing.Size(47, 47);
            this.botao_soma.TabIndex = 16;
            this.botao_soma.Text = "+";
            this.botao_soma.UseVisualStyleBackColor = true;
            this.botao_soma.Click += new System.EventHandler(this.Botao_soma_Click);
            // 
            // botao_limpar
            // 
            this.botao_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_limpar.Location = new System.Drawing.Point(365, 36);
            this.botao_limpar.Name = "botao_limpar";
            this.botao_limpar.Size = new System.Drawing.Size(111, 30);
            this.botao_limpar.TabIndex = 20;
            this.botao_limpar.Text = "Limpar";
            this.botao_limpar.UseVisualStyleBackColor = true;
            this.botao_limpar.Click += new System.EventHandler(this.Botao_limpar_Click);
            // 
            // botao_sub
            // 
            this.botao_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_sub.Location = new System.Drawing.Point(141, 190);
            this.botao_sub.Name = "botao_sub";
            this.botao_sub.Size = new System.Drawing.Size(47, 47);
            this.botao_sub.TabIndex = 22;
            this.botao_sub.TabStop = false;
            this.botao_sub.Text = "-";
            this.botao_sub.UseVisualStyleBackColor = true;
            this.botao_sub.Click += new System.EventHandler(this.Botao_sub_Click);
            // 
            // botao_mult
            // 
            this.botao_mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_mult.Location = new System.Drawing.Point(205, 190);
            this.botao_mult.Name = "botao_mult";
            this.botao_mult.Size = new System.Drawing.Size(47, 47);
            this.botao_mult.TabIndex = 23;
            this.botao_mult.Text = "*";
            this.botao_mult.UseVisualStyleBackColor = true;
            this.botao_mult.Click += new System.EventHandler(this.Botao_mult_Click);
            // 
            // botao_div
            // 
            this.botao_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_div.Location = new System.Drawing.Point(270, 190);
            this.botao_div.Name = "botao_div";
            this.botao_div.Size = new System.Drawing.Size(47, 47);
            this.botao_div.TabIndex = 24;
            this.botao_div.Text = "/";
            this.botao_div.UseVisualStyleBackColor = true;
            this.botao_div.Click += new System.EventHandler(this.Botao_div_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Número 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Número 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Resultado";
            // 
            // botao_sair
            // 
            this.botao_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_sair.Location = new System.Drawing.Point(365, 82);
            this.botao_sair.Name = "botao_sair";
            this.botao_sair.Size = new System.Drawing.Size(111, 30);
            this.botao_sair.TabIndex = 28;
            this.botao_sair.Text = "Sair";
            this.botao_sair.UseVisualStyleBackColor = true;
            this.botao_sair.Click += new System.EventHandler(this.Botao_sair_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botao_sair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botao_div);
            this.Controls.Add(this.botao_mult);
            this.Controls.Add(this.botao_sub);
            this.Controls.Add(this.botao_limpar);
            this.Controls.Add(this.botao_soma);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button botao_soma;
        private System.Windows.Forms.Button botao_limpar;
        private System.Windows.Forms.Button botao_sub;
        private System.Windows.Forms.Button botao_mult;
        private System.Windows.Forms.Button botao_div;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botao_sair;
    }
}

