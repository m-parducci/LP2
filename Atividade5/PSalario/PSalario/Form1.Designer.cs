namespace PSalario
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
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskbxSalarioBruto = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ckbxEstadoCivil = new System.Windows.Forms.CheckBox();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnMasc = new System.Windows.Forms.RadioButton();
            this.rbtnFem = new System.Windows.Forms.RadioButton();
            this.lblSaida = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cbxNumeroFilhos = new System.Windows.Forms.ComboBox();
            this.mskbxAliqINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskbxAliqIRPF = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSalFam = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSalLiq = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDescIRPF = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDescINSS = new System.Windows.Forms.MaskedTextBox();
            this.gbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFunc.Location = new System.Drawing.Point(342, 65);
            this.txtNomeFunc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(354, 44);
            this.txtNomeFunc.TabIndex = 0;
            this.txtNomeFunc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNomeFunc_KeyPress);
            this.txtNomeFunc.Validated += new System.EventHandler(this.TxtNomeFunc_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do funcionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salário bruto";
            // 
            // mskbxSalarioBruto
            // 
            this.mskbxSalarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxSalarioBruto.Location = new System.Drawing.Point(342, 132);
            this.mskbxSalarioBruto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskbxSalarioBruto.Mask = "99999.99";
            this.mskbxSalarioBruto.Name = "mskbxSalarioBruto";
            this.mskbxSalarioBruto.Size = new System.Drawing.Size(354, 43);
            this.mskbxSalarioBruto.TabIndex = 3;
            this.mskbxSalarioBruto.Validated += new System.EventHandler(this.mskbxSalarioBruto_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Número de filhos";
            // 
            // btnValidar
            // 
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(26, 286);
            this.btnValidar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(238, 49);
            this.btnValidar.TabIndex = 6;
            this.btnValidar.Text = "Validar dados";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 420);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alíquota INSS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 493);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "Alíquota IRPF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 569);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 37);
            this.label6.TabIndex = 9;
            this.label6.Text = "Salário família";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(630, 560);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 37);
            this.label7.TabIndex = 10;
            this.label7.Text = "Salário líquido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(630, 503);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 37);
            this.label8.TabIndex = 16;
            this.label8.Text = "Desconto IRPF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(628, 429);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 37);
            this.label9.TabIndex = 15;
            this.label9.Text = "Desconto INSS";
            // 
            // ckbxEstadoCivil
            // 
            this.ckbxEstadoCivil.AutoSize = true;
            this.ckbxEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbxEstadoCivil.Location = new System.Drawing.Point(800, 208);
            this.ckbxEstadoCivil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckbxEstadoCivil.Name = "ckbxEstadoCivil";
            this.ckbxEstadoCivil.Size = new System.Drawing.Size(203, 41);
            this.ckbxEstadoCivil.TabIndex = 24;
            this.ckbxEstadoCivil.Text = "Casado (a)";
            this.ckbxEstadoCivil.UseVisualStyleBackColor = true;
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnMasc);
            this.gbxSexo.Controls.Add(this.rbtnFem);
            this.gbxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSexo.Location = new System.Drawing.Point(777, 63);
            this.gbxSexo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxSexo.Size = new System.Drawing.Size(375, 117);
            this.gbxSexo.TabIndex = 25;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbtnMasc
            // 
            this.rbtnMasc.AutoSize = true;
            this.rbtnMasc.Location = new System.Drawing.Point(177, 54);
            this.rbtnMasc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnMasc.Name = "rbtnMasc";
            this.rbtnMasc.Size = new System.Drawing.Size(68, 41);
            this.rbtnMasc.TabIndex = 1;
            this.rbtnMasc.TabStop = true;
            this.rbtnMasc.Text = "M";
            this.rbtnMasc.UseVisualStyleBackColor = true;
            // 
            // rbtnFem
            // 
            this.rbtnFem.AutoSize = true;
            this.rbtnFem.Checked = true;
            this.rbtnFem.Location = new System.Drawing.Point(22, 54);
            this.rbtnFem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnFem.Name = "rbtnFem";
            this.rbtnFem.Size = new System.Drawing.Size(62, 41);
            this.rbtnFem.TabIndex = 0;
            this.rbtnFem.TabStop = true;
            this.rbtnFem.Text = "F";
            this.rbtnFem.UseVisualStyleBackColor = true;
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaida.Location = new System.Drawing.Point(41, 367);
            this.lblSaida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(75, 29);
            this.lblSaida.TabIndex = 27;
            this.lblSaida.Text = "Saída";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(921, 621);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(213, 43);
            this.btnLimpar.TabIndex = 28;
            this.btnLimpar.Text = "Limpar dados";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // cbxNumeroFilhos
            // 
            this.cbxNumeroFilhos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNumeroFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNumeroFilhos.FormattingEnabled = true;
            this.cbxNumeroFilhos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxNumeroFilhos.Location = new System.Drawing.Point(342, 206);
            this.cbxNumeroFilhos.Name = "cbxNumeroFilhos";
            this.cbxNumeroFilhos.Size = new System.Drawing.Size(354, 45);
            this.cbxNumeroFilhos.TabIndex = 29;
            // 
            // mskbxAliqINSS
            // 
            this.mskbxAliqINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxAliqINSS.Location = new System.Drawing.Point(303, 413);
            this.mskbxAliqINSS.Name = "mskbxAliqINSS";
            this.mskbxAliqINSS.Size = new System.Drawing.Size(264, 44);
            this.mskbxAliqINSS.TabIndex = 30;
            // 
            // mskbxAliqIRPF
            // 
            this.mskbxAliqIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxAliqIRPF.Location = new System.Drawing.Point(303, 486);
            this.mskbxAliqIRPF.Name = "mskbxAliqIRPF";
            this.mskbxAliqIRPF.Size = new System.Drawing.Size(264, 44);
            this.mskbxAliqIRPF.TabIndex = 31;
            // 
            // mskbxSalFam
            // 
            this.mskbxSalFam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxSalFam.Location = new System.Drawing.Point(303, 559);
            this.mskbxSalFam.Name = "mskbxSalFam";
            this.mskbxSalFam.Size = new System.Drawing.Size(264, 44);
            this.mskbxSalFam.TabIndex = 32;
            // 
            // mskbxSalLiq
            // 
            this.mskbxSalLiq.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxSalLiq.Location = new System.Drawing.Point(870, 559);
            this.mskbxSalLiq.Name = "mskbxSalLiq";
            this.mskbxSalLiq.Size = new System.Drawing.Size(264, 44);
            this.mskbxSalLiq.TabIndex = 35;
            // 
            // mskbxDescIRPF
            // 
            this.mskbxDescIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxDescIRPF.Location = new System.Drawing.Point(870, 486);
            this.mskbxDescIRPF.Name = "mskbxDescIRPF";
            this.mskbxDescIRPF.Size = new System.Drawing.Size(264, 44);
            this.mskbxDescIRPF.TabIndex = 34;
            // 
            // mskbxDescINSS
            // 
            this.mskbxDescINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxDescINSS.Location = new System.Drawing.Point(870, 413);
            this.mskbxDescINSS.Name = "mskbxDescINSS";
            this.mskbxDescINSS.Size = new System.Drawing.Size(264, 44);
            this.mskbxDescINSS.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 678);
            this.Controls.Add(this.mskbxSalLiq);
            this.Controls.Add(this.mskbxDescIRPF);
            this.Controls.Add(this.mskbxDescINSS);
            this.Controls.Add(this.mskbxSalFam);
            this.Controls.Add(this.mskbxAliqIRPF);
            this.Controls.Add(this.mskbxAliqINSS);
            this.Controls.Add(this.cbxNumeroFilhos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblSaida);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.ckbxEstadoCivil);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskbxSalarioBruto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeFunc);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskbxSalarioBruto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ckbxEstadoCivil;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbtnMasc;
        private System.Windows.Forms.RadioButton rbtnFem;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cbxNumeroFilhos;
        private System.Windows.Forms.MaskedTextBox mskbxAliqINSS;
        private System.Windows.Forms.MaskedTextBox mskbxAliqIRPF;
        private System.Windows.Forms.MaskedTextBox mskbxSalFam;
        private System.Windows.Forms.MaskedTextBox mskbxSalLiq;
        private System.Windows.Forms.MaskedTextBox mskbxDescIRPF;
        private System.Windows.Forms.MaskedTextBox mskbxDescINSS;
    }
}

