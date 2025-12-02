/*
 * Creado por SharpDevelop.
 * Usuario: cesar
 * Fecha: 28/11/2025
 * Hora: 06:22 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TRABAJO_3._
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		 int[] numeros = new int[10];
        Random rnd = new Random();
		
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
		
		void BtnGenerarClick(object sender, EventArgs e)
		{
			  listBox1.Items.Clear();

            for (int i = 0; i < 10; i++)
            {
                numeros[i] = rnd.Next(0, 11); // genera números del 1 al 9
                listBox1.Items.Add(numeros[i]);
            }
    	}
		
		void BtnOrdenarClick(object sender, EventArgs e)
		{
			 listBox1.Items.Clear();

            Array.Sort(numeros);

            foreach (int n in numeros)
            {
                listBox1.Items.Add(n);
            }
		}
	}
}
