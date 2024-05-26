
namespace PresentationLayer
{
    partial class Operacion2
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxbPrimerNumero = new System.Windows.Forms.TextBox();
            this.TxbSegundoNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CkbMCM = new System.Windows.Forms.CheckBox();
            this.CkbMCD = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(71, 133);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(125, 49);
            this.BtnCalcular.TabIndex = 0;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // TxbPrimerNumero
            // 
            this.TxbPrimerNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbPrimerNumero.Location = new System.Drawing.Point(40, 78);
            this.TxbPrimerNumero.Name = "TxbPrimerNumero";
            this.TxbPrimerNumero.Size = new System.Drawing.Size(214, 30);
            this.TxbPrimerNumero.TabIndex = 1;
            // 
            // TxbSegundoNumero
            // 
            this.TxbSegundoNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbSegundoNumero.Location = new System.Drawing.Point(377, 78);
            this.TxbSegundoNumero.Name = "TxbSegundoNumero";
            this.TxbSegundoNumero.Size = new System.Drawing.Size(214, 30);
            this.TxbSegundoNumero.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Primer numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Segundo numero:";
            // 
            // CkbMCM
            // 
            this.CkbMCM.AutoSize = true;
            this.CkbMCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkbMCM.Location = new System.Drawing.Point(499, 133);
            this.CkbMCM.Name = "CkbMCM";
            this.CkbMCM.Size = new System.Drawing.Size(83, 29);
            this.CkbMCM.TabIndex = 5;
            this.CkbMCM.Text = "MCM";
            this.CkbMCM.UseVisualStyleBackColor = true;
            this.CkbMCM.CheckedChanged += new System.EventHandler(this.CkbMCM_CheckedChanged);
            // 
            // CkbMCD
            // 
            this.CkbMCD.AutoSize = true;
            this.CkbMCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkbMCD.Location = new System.Drawing.Point(390, 133);
            this.CkbMCD.Name = "CkbMCD";
            this.CkbMCD.Size = new System.Drawing.Size(80, 29);
            this.CkbMCD.TabIndex = 6;
            this.CkbMCD.Text = "MCD";
            this.CkbMCD.UseVisualStyleBackColor = true;
            this.CkbMCD.CheckedChanged += new System.EventHandler(this.CkbMCD_CheckedChanged);
            // 
            // Operacion2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 218);
            this.Controls.Add(this.CkbMCD);
            this.Controls.Add(this.CkbMCM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbSegundoNumero);
            this.Controls.Add(this.TxbPrimerNumero);
            this.Controls.Add(this.BtnCalcular);
            this.Name = "Operacion2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones - 2 digitos";
            this.Load += new System.EventHandler(this.Operacion2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxbPrimerNumero;
        private System.Windows.Forms.TextBox TxbSegundoNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CkbMCM;
        private System.Windows.Forms.CheckBox CkbMCD;
    }
}

