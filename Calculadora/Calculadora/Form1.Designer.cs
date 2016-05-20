namespace Calculadora
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pantalla = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.Punto = new System.Windows.Forms.Button();
            this.Suma = new System.Windows.Forms.Button();
            this.Resta = new System.Windows.Forms.Button();
            this.Multiplicacion = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.Igual = new System.Windows.Forms.Button();
            this.Retroceder = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(401, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // Pantalla
            // 
            this.Pantalla.Location = new System.Drawing.Point(79, 40);
            this.Pantalla.Multiline = true;
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.Size = new System.Drawing.Size(219, 31);
            this.Pantalla.TabIndex = 1;
            this.Pantalla.Text = "0";
            this.Pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(79, 204);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(50, 37);
            this.num1.TabIndex = 2;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(135, 204);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(50, 37);
            this.num2.TabIndex = 3;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(191, 204);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(50, 37);
            this.num3.TabIndex = 4;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(79, 161);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(50, 37);
            this.num4.TabIndex = 5;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(135, 161);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(50, 37);
            this.num5.TabIndex = 6;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(191, 161);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(50, 37);
            this.num6.TabIndex = 7;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num7
            // 
            this.num7.Location = new System.Drawing.Point(79, 118);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(50, 37);
            this.num7.TabIndex = 8;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num8
            // 
            this.num8.Location = new System.Drawing.Point(135, 118);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(50, 37);
            this.num8.TabIndex = 9;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num9
            // 
            this.num9.Location = new System.Drawing.Point(191, 118);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(50, 37);
            this.num9.TabIndex = 10;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num0
            // 
            this.num0.Location = new System.Drawing.Point(79, 247);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(106, 37);
            this.num0.TabIndex = 11;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // Punto
            // 
            this.Punto.Location = new System.Drawing.Point(191, 247);
            this.Punto.Name = "Punto";
            this.Punto.Size = new System.Drawing.Size(50, 37);
            this.Punto.TabIndex = 12;
            this.Punto.Text = ".";
            this.Punto.UseVisualStyleBackColor = true;
            // 
            // Suma
            // 
            this.Suma.Location = new System.Drawing.Point(247, 204);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(50, 80);
            this.Suma.TabIndex = 13;
            this.Suma.Text = "+";
            this.Suma.UseVisualStyleBackColor = true;
            // 
            // Resta
            // 
            this.Resta.Location = new System.Drawing.Point(248, 161);
            this.Resta.Name = "Resta";
            this.Resta.Size = new System.Drawing.Size(50, 37);
            this.Resta.TabIndex = 14;
            this.Resta.Text = "-";
            this.Resta.UseVisualStyleBackColor = true;
            // 
            // Multiplicacion
            // 
            this.Multiplicacion.Location = new System.Drawing.Point(247, 118);
            this.Multiplicacion.Name = "Multiplicacion";
            this.Multiplicacion.Size = new System.Drawing.Size(50, 37);
            this.Multiplicacion.TabIndex = 15;
            this.Multiplicacion.Text = "*";
            this.Multiplicacion.UseVisualStyleBackColor = true;
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(304, 161);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(50, 37);
            this.Division.TabIndex = 16;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(303, 118);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(50, 37);
            this.Borrar.TabIndex = 17;
            this.Borrar.Text = "C";
            this.Borrar.UseVisualStyleBackColor = true;
            // 
            // Igual
            // 
            this.Igual.Location = new System.Drawing.Point(303, 204);
            this.Igual.Name = "Igual";
            this.Igual.Size = new System.Drawing.Size(50, 80);
            this.Igual.TabIndex = 18;
            this.Igual.Text = "=";
            this.Igual.UseVisualStyleBackColor = true;
            // 
            // Retroceder
            // 
            this.Retroceder.Location = new System.Drawing.Point(79, 77);
            this.Retroceder.Name = "Retroceder";
            this.Retroceder.Size = new System.Drawing.Size(35, 35);
            this.Retroceder.TabIndex = 19;
            this.Retroceder.Text = "←";
            this.Retroceder.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 332);
            this.Controls.Add(this.Retroceder);
            this.Controls.Add(this.Igual);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplicacion);
            this.Controls.Add(this.Resta);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.Punto);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.Pantalla);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TextBox Pantalla;
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
        private System.Windows.Forms.Button Resta;
        private System.Windows.Forms.Button Multiplicacion;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button Igual;
        private System.Windows.Forms.Button Retroceder;
    }
}

