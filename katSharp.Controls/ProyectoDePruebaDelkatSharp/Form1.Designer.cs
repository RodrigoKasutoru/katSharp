﻿namespace ProyectoDePruebaDelkatSharp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.katnumberBox1 = new katSharp.Controls.katnumberBox();
            this.katnumberBox2 = new katSharp.Controls.katnumberBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "sumar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // katnumberBox1
            // 
            this.katnumberBox1.Location = new System.Drawing.Point(63, 43);
            this.katnumberBox1.Name = "katnumberBox1";
            this.katnumberBox1.Size = new System.Drawing.Size(100, 20);
            this.katnumberBox1.TabIndex = 3;
            // 
            // katnumberBox2
            // 
            this.katnumberBox2.Location = new System.Drawing.Point(63, 70);
            this.katnumberBox2.Name = "katnumberBox2";
            this.katnumberBox2.Size = new System.Drawing.Size(100, 20);
            this.katnumberBox2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.katnumberBox2);
            this.Controls.Add(this.katnumberBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        
        private katSharp.Controls.katnumberBox katnumberBox2;
    }
}

