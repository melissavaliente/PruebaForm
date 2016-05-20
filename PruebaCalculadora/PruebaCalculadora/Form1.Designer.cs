using System;

namespace PruebaCalculadora
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
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form1";
            NewMethod();
            this.ResumeLayout(false);

        }

        private void NewMethod()
        {
            Load += new System.EventHandler(this.Form1_Load);
        }

        #endregion

        private System.Windows.Forms.TextBox Pantalla;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button Punto;
        private System.Windows.Forms.Button Suma;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button Multiplicacion;
        private System.Windows.Forms.Button Resta;
        private System.Windows.Forms.Button Igual;
        private System.Windows.Forms.Button Retroceso;

        public EventHandler Form1_Load { get; private set; }
    }
}

