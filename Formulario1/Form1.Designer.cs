namespace Formulario1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cajaTexto = new System.Windows.Forms.TextBox();
            this.cajaTexto2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cajaNota1 = new System.Windows.Forms.TextBox();
            this.cajaNota2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cajaNota3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pulsame";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // cajaTexto
            // 
            this.cajaTexto.Location = new System.Drawing.Point(65, 95);
            this.cajaTexto.Name = "cajaTexto";
            this.cajaTexto.Size = new System.Drawing.Size(147, 20);
            this.cajaTexto.TabIndex = 2;
            // 
            // cajaTexto2
            // 
            this.cajaTexto2.Location = new System.Drawing.Point(65, 121);
            this.cajaTexto2.Name = "cajaTexto2";
            this.cajaTexto2.Size = new System.Drawing.Size(147, 20);
            this.cajaTexto2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellidos:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 72);
            this.button2.TabIndex = 5;
            this.button2.Text = "Datos de la persona";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nota 1:";
            // 
            // cajaNota1
            // 
            this.cajaNota1.Location = new System.Drawing.Point(266, 9);
            this.cajaNota1.Name = "cajaNota1";
            this.cajaNota1.Size = new System.Drawing.Size(100, 20);
            this.cajaNota1.TabIndex = 7;
            // 
            // cajaNota2
            // 
            this.cajaNota2.Location = new System.Drawing.Point(266, 35);
            this.cajaNota2.Name = "cajaNota2";
            this.cajaNota2.Size = new System.Drawing.Size(100, 20);
            this.cajaNota2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nota 2:";
            // 
            // cajaNota3
            // 
            this.cajaNota3.Location = new System.Drawing.Point(266, 61);
            this.cajaNota3.Name = "cajaNota3";
            this.cajaNota3.Size = new System.Drawing.Size(100, 20);
            this.cajaNota3.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nota 3:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(221, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Sumar notas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 417);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cajaNota3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cajaNota2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cajaNota1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cajaTexto2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cajaTexto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cajaTexto;
        private System.Windows.Forms.TextBox cajaTexto2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cajaNota1;
        private System.Windows.Forms.TextBox cajaNota2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cajaNota3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
    }
}

