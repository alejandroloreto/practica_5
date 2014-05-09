/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 02/05/2014
 * Time: 10:04 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Practica_5
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			int aciertos=0;
			
			if(this.numericUpDown1.Text=="31"){
				aciertos++;
			}
			
			if(this.RU.Checked){
			      aciertos++;
                } 
			if(this.Japon.Checked){
				aciertos++;
				}
		
			 
			if(this.Mau.Checked){
				aciertos++;
			}
			
			if(this.continente.Text=="Oceanico"){
				aciertos++;
			}
			
			DateTime fecha= Calendario.SelectionStart;
			
			if(fecha.ToShortDateString()=="16/09/1810"){
				aciertos++;
			}
			
			MessageBox.Show("Codigo: " + Codigo.Text + "\n Nombre: " + Nombre.Text +"\n Aciertos: " + aciertos);
		}
	}
}
