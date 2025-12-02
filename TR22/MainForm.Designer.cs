/*
 * Creado por SharpDevelop.
 * Usuario: manue
 * Fecha: 21/11/2025
 * Hora: 02:41 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace TR22
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
			this.sboasignatura = new System.Windows.Forms.ComboBox();
			this.lblasignatura = new System.Windows.Forms.Label();
			this.txtparcial3 = new System.Windows.Forms.TextBox();
			this.txtparcial2 = new System.Windows.Forms.TextBox();
			this.txtparcial1 = new System.Windows.Forms.TextBox();
			this.lblparcial3 = new System.Windows.Forms.Label();
			this.lblparcial2 = new System.Windows.Forms.Label();
			this.lblparcial1 = new System.Windows.Forms.Label();
			this.lvVenta = new System.Windows.Forms.ListView();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.btncarrar = new System.Windows.Forms.Button();
			this.btnreagistrar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblpromedio = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// sboasignatura
			// 
			this.sboasignatura.FormattingEnabled = true;
			this.sboasignatura.Items.AddRange(new object[] {
									"español",
									"matematicas ",
									"ciencias ",
									"formacion ",
									"ingles",
									"humanidades ",
									"formacion socio emocional",
									"club"});
			this.sboasignatura.Location = new System.Drawing.Point(67, 68);
			this.sboasignatura.Name = "sboasignatura";
			this.sboasignatura.Size = new System.Drawing.Size(246, 28);
			this.sboasignatura.TabIndex = 51;
			// 
			// lblasignatura
			// 
			this.lblasignatura.Location = new System.Drawing.Point(67, 25);
			this.lblasignatura.Name = "lblasignatura";
			this.lblasignatura.Size = new System.Drawing.Size(246, 23);
			this.lblasignatura.TabIndex = 50;
			this.lblasignatura.Text = "ASIGNATURA O SUBMODULO";
			// 
			// txtparcial3
			// 
			this.txtparcial3.Location = new System.Drawing.Point(765, 55);
			this.txtparcial3.Name = "txtparcial3";
			this.txtparcial3.Size = new System.Drawing.Size(100, 26);
			this.txtparcial3.TabIndex = 45;
			// 
			// txtparcial2
			// 
			this.txtparcial2.Location = new System.Drawing.Point(611, 55);
			this.txtparcial2.Name = "txtparcial2";
			this.txtparcial2.Size = new System.Drawing.Size(100, 26);
			this.txtparcial2.TabIndex = 44;
			// 
			// txtparcial1
			// 
			this.txtparcial1.Location = new System.Drawing.Point(473, 55);
			this.txtparcial1.Name = "txtparcial1";
			this.txtparcial1.Size = new System.Drawing.Size(100, 26);
			this.txtparcial1.TabIndex = 43;
			// 
			// lblparcial3
			// 
			this.lblparcial3.Location = new System.Drawing.Point(765, 7);
			this.lblparcial3.Name = "lblparcial3";
			this.lblparcial3.Size = new System.Drawing.Size(100, 23);
			this.lblparcial3.TabIndex = 42;
			this.lblparcial3.Text = "PARCIAL 3";
			// 
			// lblparcial2
			// 
			this.lblparcial2.Location = new System.Drawing.Point(611, 7);
			this.lblparcial2.Name = "lblparcial2";
			this.lblparcial2.Size = new System.Drawing.Size(100, 23);
			this.lblparcial2.TabIndex = 41;
			this.lblparcial2.Text = "PARCIAL 2";
			// 
			// lblparcial1
			// 
			this.lblparcial1.Location = new System.Drawing.Point(473, 7);
			this.lblparcial1.Name = "lblparcial1";
			this.lblparcial1.Size = new System.Drawing.Size(100, 23);
			this.lblparcial1.TabIndex = 40;
			this.lblparcial1.Text = "PARCIAL 1";
			// 
			// lvVenta
			// 
			this.lvVenta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4,
									this.columnHeader5,
									this.columnHeader6,
									this.columnHeader7});
			this.lvVenta.Location = new System.Drawing.Point(12, 215);
			this.lvVenta.Name = "lvVenta";
			this.lvVenta.Size = new System.Drawing.Size(1148, 288);
			this.lvVenta.TabIndex = 38;
			this.lvVenta.UseCompatibleStateImageBehavior = false;
			this.lvVenta.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "ASIGNATURA O SUBMODULO";
			this.columnHeader2.Width = 247;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "PARCIAL 1";
			this.columnHeader3.Width = 97;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "PARCIAL 2";
			this.columnHeader4.Width = 129;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "PARCIAL 3";
			this.columnHeader5.Width = 104;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "PROMEDIO";
			this.columnHeader6.Width = 103;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "PASO O NO PASO";
			this.columnHeader7.Width = 167;
			// 
			// btncarrar
			// 
			this.btncarrar.Location = new System.Drawing.Point(456, 170);
			this.btncarrar.Name = "btncarrar";
			this.btncarrar.Size = new System.Drawing.Size(90, 36);
			this.btncarrar.TabIndex = 37;
			this.btncarrar.Text = "CERRAR";
			this.btncarrar.UseVisualStyleBackColor = true;
			// 
			// btnreagistrar
			// 
			this.btnreagistrar.Location = new System.Drawing.Point(321, 173);
			this.btnreagistrar.Name = "btnreagistrar";
			this.btnreagistrar.Size = new System.Drawing.Size(117, 33);
			this.btnreagistrar.TabIndex = 35;
			this.btnreagistrar.Text = "REAGISTAR";
			this.btnreagistrar.UseVisualStyleBackColor = true;
			this.btnreagistrar.Click += new System.EventHandler(this.BtnreagistrarClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(245, 523);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 40);
			this.label1.TabIndex = 54;
			this.label1.Text = "PROMEDIO GENARL";
			// 
			// lblpromedio
			// 
			this.lblpromedio.Location = new System.Drawing.Point(364, 541);
			this.lblpromedio.Name = "lblpromedio";
			this.lblpromedio.Size = new System.Drawing.Size(100, 23);
			this.lblpromedio.TabIndex = 55;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1172, 573);
			this.Controls.Add(this.lblpromedio);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.sboasignatura);
			this.Controls.Add(this.lblasignatura);
			this.Controls.Add(this.txtparcial3);
			this.Controls.Add(this.txtparcial2);
			this.Controls.Add(this.txtparcial1);
			this.Controls.Add(this.lblparcial3);
			this.Controls.Add(this.lblparcial2);
			this.Controls.Add(this.lblparcial1);
			this.Controls.Add(this.lvVenta);
			this.Controls.Add(this.btncarrar);
			this.Controls.Add(this.btnreagistrar);
			this.Name = "MainForm";
			this.Text = "TR22";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblpromedio;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.Button btnreagistrar;
		private System.Windows.Forms.Button btncarrar;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ListView lvVenta;
		private System.Windows.Forms.Label lblparcial1;
		private System.Windows.Forms.Label lblparcial2;
		private System.Windows.Forms.Label lblparcial3;
		private System.Windows.Forms.TextBox txtparcial1;
		private System.Windows.Forms.TextBox txtparcial2;
		private System.Windows.Forms.TextBox txtparcial3;
		private System.Windows.Forms.Label lblasignatura;
		private System.Windows.Forms.ComboBox sboasignatura;
		
		
	}
}
