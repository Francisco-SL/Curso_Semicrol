﻿namespace Formulario1
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.EtiquetaColor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.AprobadoSuspenso = new System.Windows.Forms.Label();
            this.EsInformatico = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(200, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GroupBox de colores";
            // 
            // radioButton3
            // 
            this.radioButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton3.Location = new System.Drawing.Point(10, 76);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(187, 30);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Rojo";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.MostrarColor_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton2.Location = new System.Drawing.Point(10, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(187, 30);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Verde";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.MostrarColor_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton1.Location = new System.Drawing.Point(10, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(187, 30);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Azul";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.MostrarColor_CheckedChanged);
            // 
            // EtiquetaColor
            // 
            this.EtiquetaColor.AutoSize = true;
            this.EtiquetaColor.Location = new System.Drawing.Point(12, 127);
            this.EtiquetaColor.Name = "EtiquetaColor";
            this.EtiquetaColor.Size = new System.Drawing.Size(0, 13);
            this.EtiquetaColor.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Boton Seleccionado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Location = new System.Drawing.Point(9, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox2.Size = new System.Drawing.Size(200, 79);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "A/S";
            // 
            // radioButton5
            // 
            this.radioButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton5.Location = new System.Drawing.Point(10, 46);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(187, 30);
            this.radioButton5.TabIndex = 3;
            this.radioButton5.Text = "Suspenso";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.AprobadoSuspenso_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton4.Location = new System.Drawing.Point(10, 16);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(187, 30);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.Text = "Apobado";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.AprobadoSuspenso_CheckedChanged);
            // 
            // AprobadoSuspenso
            // 
            this.AprobadoSuspenso.AutoSize = true;
            this.AprobadoSuspenso.Location = new System.Drawing.Point(9, 225);
            this.AprobadoSuspenso.Name = "AprobadoSuspenso";
            this.AprobadoSuspenso.Size = new System.Drawing.Size(0, 13);
            this.AprobadoSuspenso.TabIndex = 4;
            // 
            // EsInformatico
            // 
            this.EsInformatico.AutoSize = true;
            this.EsInformatico.Location = new System.Drawing.Point(12, 253);
            this.EsInformatico.Name = "EsInformatico";
            this.EsInformatico.Size = new System.Drawing.Size(92, 17);
            this.EsInformatico.TabIndex = 5;
            this.EsInformatico.Text = "Es informatico";
            this.EsInformatico.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Boton informatico";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 427);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.EsInformatico);
            this.Controls.Add(this.AprobadoSuspenso);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EtiquetaColor);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label EtiquetaColor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label AprobadoSuspenso;
        private System.Windows.Forms.CheckBox EsInformatico;
        private System.Windows.Forms.Button button2;
    }
}