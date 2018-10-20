namespace ControlEstacionamiento
{
	partial class Principal
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
			this.components = new System.ComponentModel.Container();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.txt_CantidadEntradas = new System.Windows.Forms.Label();
			this.bt_Abrir1 = new System.Windows.Forms.Button();
			this.bt_Abrir2 = new System.Windows.Forms.Button();
			this.bt_Cerrar1 = new System.Windows.Forms.Button();
			this.bt_Cerrar2 = new System.Windows.Forms.Button();
			this.tx_Lugares = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// serialPort1
			// 
			this.serialPort1.DiscardNull = true;
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
			// 
			// txt_CantidadEntradas
			// 
			this.txt_CantidadEntradas.AutoSize = true;
			this.txt_CantidadEntradas.Location = new System.Drawing.Point(30, 20);
			this.txt_CantidadEntradas.Name = "txt_CantidadEntradas";
			this.txt_CantidadEntradas.Size = new System.Drawing.Size(16, 17);
			this.txt_CantidadEntradas.TabIndex = 0;
			this.txt_CantidadEntradas.Text = "0";
			// 
			// bt_Abrir1
			// 
			this.bt_Abrir1.Location = new System.Drawing.Point(78, 347);
			this.bt_Abrir1.Name = "bt_Abrir1";
			this.bt_Abrir1.Size = new System.Drawing.Size(90, 30);
			this.bt_Abrir1.TabIndex = 1;
			this.bt_Abrir1.Text = "Abrir";
			this.bt_Abrir1.UseVisualStyleBackColor = true;
			this.bt_Abrir1.Click += new System.EventHandler(this.bt_Abrir1_Click);
			// 
			// bt_Abrir2
			// 
			this.bt_Abrir2.Location = new System.Drawing.Point(328, 347);
			this.bt_Abrir2.Name = "bt_Abrir2";
			this.bt_Abrir2.Size = new System.Drawing.Size(90, 30);
			this.bt_Abrir2.TabIndex = 2;
			this.bt_Abrir2.Text = "Abrir";
			this.bt_Abrir2.UseVisualStyleBackColor = true;
			this.bt_Abrir2.Click += new System.EventHandler(this.bt_Abrir2_Click);
			// 
			// bt_Cerrar1
			// 
			this.bt_Cerrar1.Location = new System.Drawing.Point(78, 405);
			this.bt_Cerrar1.Name = "bt_Cerrar1";
			this.bt_Cerrar1.Size = new System.Drawing.Size(90, 30);
			this.bt_Cerrar1.TabIndex = 3;
			this.bt_Cerrar1.Text = "Cerrar";
			this.bt_Cerrar1.UseVisualStyleBackColor = true;
			this.bt_Cerrar1.Click += new System.EventHandler(this.bt_Cerrar1_Click);
			// 
			// bt_Cerrar2
			// 
			this.bt_Cerrar2.Location = new System.Drawing.Point(328, 405);
			this.bt_Cerrar2.Name = "bt_Cerrar2";
			this.bt_Cerrar2.Size = new System.Drawing.Size(90, 30);
			this.bt_Cerrar2.TabIndex = 4;
			this.bt_Cerrar2.Text = "Cerrar";
			this.bt_Cerrar2.UseVisualStyleBackColor = true;
			this.bt_Cerrar2.Click += new System.EventHandler(this.bt_Cerrar2_Click);
			// 
			// tx_Lugares
			// 
			this.tx_Lugares.AutoSize = true;
			this.tx_Lugares.Location = new System.Drawing.Point(33, 100);
			this.tx_Lugares.Name = "tx_Lugares";
			this.tx_Lugares.Size = new System.Drawing.Size(16, 17);
			this.tx_Lugares.TabIndex = 5;
			this.tx_Lugares.Text = "0";
			// 
			// Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(498, 507);
			this.Controls.Add(this.tx_Lugares);
			this.Controls.Add(this.bt_Cerrar2);
			this.Controls.Add(this.bt_Cerrar1);
			this.Controls.Add(this.bt_Abrir2);
			this.Controls.Add(this.bt_Abrir1);
			this.Controls.Add(this.txt_CantidadEntradas);
			this.MaximizeBox = false;
			this.Name = "Principal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Principal";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.Label txt_CantidadEntradas;
		private System.Windows.Forms.Button bt_Abrir1;
		private System.Windows.Forms.Button bt_Abrir2;
		private System.Windows.Forms.Button bt_Cerrar1;
		private System.Windows.Forms.Button bt_Cerrar2;
		private System.Windows.Forms.Label tx_Lugares;
	}
}