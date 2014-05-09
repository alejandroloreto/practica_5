/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 02/05/2014
 * Time: 10:04 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Practica_5
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.Nombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Codigo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Rusia = new System.Windows.Forms.CheckBox();
			this.Japon = new System.Windows.Forms.CheckBox();
			this.Alemania = new System.Windows.Forms.CheckBox();
			this.RU = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.Mau = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.continente = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.Calendario = new System.Windows.Forms.MonthCalendar();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(45, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre:";
			// 
			// Nombre
			// 
			this.Nombre.Location = new System.Drawing.Point(45, 53);
			this.Nombre.Name = "Nombre";
			this.Nombre.Size = new System.Drawing.Size(100, 20);
			this.Nombre.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(163, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Codigo:";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// Codigo
			// 
			this.Codigo.Location = new System.Drawing.Point(163, 53);
			this.Codigo.Name = "Codigo";
			this.Codigo.Size = new System.Drawing.Size(100, 20);
			this.Codigo.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(45, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(274, 22);
			this.label3.TabIndex = 4;
			this.label3.Text = "1. ¿Cantidand de estados de la republica -mexicana?";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(50, 185);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(263, 30);
			this.label4.TabIndex = 6;
			this.label4.Text = "2. ¿Paises que formaron los aliados durante la segunda guerra mundial?";
			// 
			// Rusia
			// 
			this.Rusia.Location = new System.Drawing.Point(56, 218);
			this.Rusia.Name = "Rusia";
			this.Rusia.Size = new System.Drawing.Size(104, 24);
			this.Rusia.TabIndex = 7;
			this.Rusia.Text = "Rusia";
			this.Rusia.UseVisualStyleBackColor = true;
			// 
			// Japon
			// 
			this.Japon.Location = new System.Drawing.Point(56, 248);
			this.Japon.Name = "Japon";
			this.Japon.Size = new System.Drawing.Size(104, 24);
			this.Japon.TabIndex = 8;
			this.Japon.Text = "Japon";
			this.Japon.UseVisualStyleBackColor = true;
			// 
			// Alemania
			// 
			this.Alemania.Location = new System.Drawing.Point(56, 278);
			this.Alemania.Name = "Alemania";
			this.Alemania.Size = new System.Drawing.Size(104, 24);
			this.Alemania.TabIndex = 9;
			this.Alemania.Text = "Alemania";
			this.Alemania.UseVisualStyleBackColor = true;
			// 
			// RU
			// 
			this.RU.Location = new System.Drawing.Point(56, 308);
			this.RU.Name = "RU";
			this.RU.Size = new System.Drawing.Size(104, 24);
			this.RU.TabIndex = 10;
			this.RU.Text = "Reino Unido";
			this.RU.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(50, 343);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(294, 23);
			this.label5.TabIndex = 11;
			this.label5.Text = "3. ¿ Dicatador de italia durante la segunda guerra mundial?";
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(50, 381);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 24);
			this.radioButton1.TabIndex = 12;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Hittler";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(50, 411);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 24);
			this.radioButton2.TabIndex = 13;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Berlusconi";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// Mau
			// 
			this.Mau.Location = new System.Drawing.Point(50, 441);
			this.Mau.Name = "Mau";
			this.Mau.Size = new System.Drawing.Size(104, 24);
			this.Mau.TabIndex = 14;
			this.Mau.TabStop = true;
			this.Mau.Text = "Mausolini";
			this.Mau.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(390, 41);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(239, 23);
			this.label6.TabIndex = 15;
			this.label6.Text = "4. ¿En que continente se encuentra Tuvalu?";
			// 
			// continente
			// 
			this.continente.FormattingEnabled = true;
			this.continente.Items.AddRange(new object[] {
									"America",
									"Europa",
									"Africa",
									"Oceanico",
									"Asia"});
			this.continente.Location = new System.Drawing.Point(390, 67);
			this.continente.Name = "continente";
			this.continente.Size = new System.Drawing.Size(121, 21);
			this.continente.TabIndex = 16;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(390, 130);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(215, 23);
			this.label7.TabIndex = 17;
			this.label7.Text = "5. ¿Fecha del grito de dolores?";
			// 
			// Calendario
			// 
			this.Calendario.Location = new System.Drawing.Point(381, 170);
			this.Calendario.Name = "Calendario";
			this.Calendario.TabIndex = 18;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(56, 133);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(65, 20);
			this.numericUpDown1.TabIndex = 19;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(469, 465);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 20;
			this.button1.Text = "Terminar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(683, 619);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.Calendario);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.continente);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.Mau);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.RU);
			this.Controls.Add(this.Alemania);
			this.Controls.Add(this.Japon);
			this.Controls.Add(this.Rusia);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Codigo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Nombre);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Practica_5";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.MonthCalendar Calendario;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox continente;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RadioButton Mau;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox RU;
		private System.Windows.Forms.CheckBox Alemania;
		private System.Windows.Forms.CheckBox Japon;
		private System.Windows.Forms.CheckBox Rusia;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Codigo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Nombre;
		private System.Windows.Forms.Label label1;
	}
}
