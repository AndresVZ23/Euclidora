
namespace PresentationLayer
{
    partial class Operacion1
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
            this.CkbMCD = new System.Windows.Forms.CheckBox();
            this.CkbMCM = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxbPrimerNumero = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CkbMCD
            // 
            this.CkbMCD.AutoSize = true;
            this.CkbMCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkbMCD.Location = new System.Drawing.Point(215, 115);
            this.CkbMCD.Name = "CkbMCD";
            this.CkbMCD.Size = new System.Drawing.Size(80, 29);
            this.CkbMCD.TabIndex = 11;
            this.CkbMCD.Text = "MCD";
            this.CkbMCD.UseVisualStyleBackColor = true;
            this.CkbMCD.CheckedChanged += new System.EventHandler(this.CkbMCD_CheckedChanged);
            // 
            // CkbMCM
            // 
            this.CkbMCM.AutoSize = true;
            this.CkbMCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkbMCM.Location = new System.Drawing.Point(331, 115);
            this.CkbMCM.Name = "CkbMCM";
            this.CkbMCM.Size = new System.Drawing.Size(83, 29);
            this.CkbMCM.TabIndex = 10;
            this.CkbMCM.Text = "MCM";
            this.CkbMCM.UseVisualStyleBackColor = true;
            this.CkbMCM.CheckedChanged += new System.EventHandler(this.CkbMCM_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Primer numero:";
            // 
            // TxbPrimerNumero
            // 
            this.TxbPrimerNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbPrimerNumero.Location = new System.Drawing.Point(35, 49);
            this.TxbPrimerNumero.Name = "TxbPrimerNumero";
            this.TxbPrimerNumero.Size = new System.Drawing.Size(214, 30);
            this.TxbPrimerNumero.TabIndex = 8;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(35, 95);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(125, 49);
            this.BtnCalcular.TabIndex = 7;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // Operacion1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 183);
            this.Controls.Add(this.CkbMCD);
            this.Controls.Add(this.CkbMCM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbPrimerNumero);
            this.Controls.Add(this.BtnCalcular);
            this.MaximizeBox = false;
            this.Name = "Operacion1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operacion1";
            this.Load += new System.EventHandler(this.Operacion1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CkbMCD;
        private System.Windows.Forms.CheckBox CkbMCM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbPrimerNumero;
        private System.Windows.Forms.Button BtnCalcular;
    }
}