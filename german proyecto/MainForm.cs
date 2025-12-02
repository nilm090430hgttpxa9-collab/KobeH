/*
 * Created by SharpDevelop.
 * User: CC2_PC27
 * Date: 01/12/2025
 * Time: 05:50 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using german_proyecto;

namespace german_proyecto
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
		
		void FormCToolStripMenuItemClick(object sender, EventArgs e)
		{
			formc c = new formc();
			c.MdiParent=this;
			c.Show();
		}
		
		void FormDToolStripMenuItemClick(object sender, EventArgs e)
		{
			formd d = new formd();
			d.MdiParent=this;
			d.Show();
		}
		
		void FormEToolStripMenuItemClick(object sender, EventArgs e)
		{
			forme frme = new forme();
			frme.MdiParent=this;
			frme.Show();			
		}
	}
}
