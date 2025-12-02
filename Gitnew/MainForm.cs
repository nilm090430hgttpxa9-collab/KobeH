/*
 * Creado por SharpDevelop.
 * Usuario: MAX
 * Fecha: 28/11/2025
 * Hora: 07:33 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Gitnew
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
		
		void BtnEntrarClick(object sender, EventArgs e)
		{
			string contraCorrecta = "123";
			if(txtContra.Text == contraCorrecta)
			{
				frmPrincipal frm = new frmPrincipal();
				frm.Show();
				this.Hide();
			}
		}
	}
}
