/*
 * Creado por SharpDevelop.
 * Usuario: manue
 * Fecha: 21/11/2025
 * Hora: 02:41 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TR22
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 
	public partial class MainForm : Form
	{
		 int glo = 0;
		 double n = 0.0, d=0;

		
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


		
		void BtncarrarClick(object sender, EventArgs e)
		{
					Close();			
		}
	void BtnreagistrarClick(object sender, EventArgs e)
		{
		glo++;
			double a, b, c;
			a = Double.Parse(txtparcial1.Text);
			b = Double.Parse(txtparcial2.Text);
			c = Double.Parse(txtparcial3.Text);
			for (int i = 1; i <= glo; i++) {
				d= (a+b+c)/3;
			}
				string asignatura = sboasignatura.Text;
				int parcial1 = Convert.ToInt32(txtparcial1.Text);
				int parcial2 = Convert.ToInt32(txtparcial2.Text);
				int parcial3 = Convert.ToInt32(txtparcial3.Text);
				double promedio = ( parcial1 + parcial2 + parcial3 ) / 3 ;
				string paso;
				
				if(promedio >= 6)
					paso = "aprobado";
				else paso = "reprobado";
				
				
				ListViewItem fila = new ListViewItem(asignatura);
				fila.SubItems.Add(parcial1.ToString());
				fila.SubItems.Add(parcial2.ToString());
				fila.SubItems.Add(parcial3.ToString());
				fila.SubItems.Add(promedio.ToString());
				fila.SubItems.Add(paso);
				lvVenta.Items.Add(fila);
				n+=d;
			this.lblpromedio.Text=(n/glo).ToString();

					
			
		}
		
		
		
		}
	}


	
	
	
	
	



