﻿
namespace Ejercicio_parcial2
{
    partial class frmEjercicio02
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstPalabras = new System.Windows.Forms.ListBox();
            this.btnSaludar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la frase";
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(163, 15);
            this.txtFrase.Multiline = true;
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFrase.Size = new System.Drawing.Size(281, 60);
            this.txtFrase.TabIndex = 1;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(471, 78);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(119, 60);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resultado";
            // 
            // lstPalabras
            // 
            this.lstPalabras.FormattingEnabled = true;
            this.lstPalabras.Location = new System.Drawing.Point(34, 151);
            this.lstPalabras.Name = "lstPalabras";
            this.lstPalabras.Size = new System.Drawing.Size(396, 95);
            this.lstPalabras.TabIndex = 4;
            // 
            // btnSaludar
            // 
            this.btnSaludar.Location = new System.Drawing.Point(471, 161);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(119, 59);
            this.btnSaludar.TabIndex = 5;
            this.btnSaludar.Text = "Saludar";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEjercicio02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaludar);
            this.Controls.Add(this.lstPalabras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.label1);
            this.Name = "frmEjercicio02";
            this.Text = "Cuenta las palabras con su respectiva longitud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstPalabras;
        private System.Windows.Forms.Button btnSaludar;
    }
}

