/*
 * Created by SharpDevelop.
 * User: CC2_PC27
 * Date: 01/12/2025
 * Time: 05:50 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace german_proyecto
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.formCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.formDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.formEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.archivoToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(284, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.formCToolStripMenuItem,
									this.formDToolStripMenuItem,
									this.formEToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Text = "Archivo";
			// 
			// formCToolStripMenuItem
			// 
			this.formCToolStripMenuItem.Name = "formCToolStripMenuItem";
			this.formCToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.formCToolStripMenuItem.Text = "formc";
			this.formCToolStripMenuItem.Click += new System.EventHandler(this.FormCToolStripMenuItemClick);
			// 
			// formDToolStripMenuItem
			// 
			this.formDToolStripMenuItem.Name = "formDToolStripMenuItem";
			this.formDToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.formDToolStripMenuItem.Text = "formd";
			this.formDToolStripMenuItem.Click += new System.EventHandler(this.FormDToolStripMenuItemClick);
			// 
			// formEToolStripMenuItem
			// 
			this.formEToolStripMenuItem.Name = "formEToolStripMenuItem";
			this.formEToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.formEToolStripMenuItem.Text = "forme";
			this.formEToolStripMenuItem.Click += new System.EventHandler(this.FormEToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "german proyecto";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem formEToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem formDToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem formCToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
