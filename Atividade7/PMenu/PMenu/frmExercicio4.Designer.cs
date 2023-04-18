namespace PMenu
{
    partial class frmExercicio4
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
            this.rtxTexto1 = new System.Windows.Forms.RichTextBox();
            this.btnCaracterNum = new System.Windows.Forms.Button();
            this.btnPrimeiroBr = new System.Windows.Forms.Button();
            this.btnCaractAlfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxTexto1
            // 
            this.rtxTexto1.Location = new System.Drawing.Point(99, 51);
            this.rtxTexto1.Name = "rtxTexto1";
            this.rtxTexto1.Size = new System.Drawing.Size(314, 126);
            this.rtxTexto1.TabIndex = 0;
            this.rtxTexto1.Text = "";
            // 
            // btnCaracterNum
            // 
            this.btnCaracterNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaracterNum.Location = new System.Drawing.Point(99, 225);
            this.btnCaracterNum.Name = "btnCaracterNum";
            this.btnCaracterNum.Size = new System.Drawing.Size(165, 83);
            this.btnCaracterNum.TabIndex = 1;
            this.btnCaracterNum.Text = "Caracteres numéricos";
            this.btnCaracterNum.UseVisualStyleBackColor = true;
            this.btnCaracterNum.Click += new System.EventHandler(this.btnCaracterNum_Click);
            // 
            // btnPrimeiroBr
            // 
            this.btnPrimeiroBr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeiroBr.Location = new System.Drawing.Point(270, 225);
            this.btnPrimeiroBr.Name = "btnPrimeiroBr";
            this.btnPrimeiroBr.Size = new System.Drawing.Size(165, 83);
            this.btnPrimeiroBr.TabIndex = 2;
            this.btnPrimeiroBr.Text = "Primeiro Branco";
            this.btnPrimeiroBr.UseVisualStyleBackColor = true;
            this.btnPrimeiroBr.Click += new System.EventHandler(this.btnPrimeiroBr_Click);
            // 
            // btnCaractAlfa
            // 
            this.btnCaractAlfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaractAlfa.Location = new System.Drawing.Point(441, 225);
            this.btnCaractAlfa.Name = "btnCaractAlfa";
            this.btnCaractAlfa.Size = new System.Drawing.Size(174, 83);
            this.btnCaractAlfa.TabIndex = 3;
            this.btnCaractAlfa.Text = "Caracteres alfabéticos";
            this.btnCaractAlfa.UseVisualStyleBackColor = true;
            this.btnCaractAlfa.Click += new System.EventHandler(this.btnCaractAlfa_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCaractAlfa);
            this.Controls.Add(this.btnPrimeiroBr);
            this.Controls.Add(this.btnCaracterNum);
            this.Controls.Add(this.rtxTexto1);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxTexto1;
        private System.Windows.Forms.Button btnCaracterNum;
        private System.Windows.Forms.Button btnPrimeiroBr;
        private System.Windows.Forms.Button btnCaractAlfa;
    }
}