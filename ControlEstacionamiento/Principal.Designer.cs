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
            this.bEntrada = new System.Windows.Forms.Label();
            this.bSalida = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPropia = new System.Windows.Forms.Label();
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
            this.txt_CantidadEntradas.BackColor = System.Drawing.Color.Transparent;
            this.txt_CantidadEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CantidadEntradas.Location = new System.Drawing.Point(22, 9);
            this.txt_CantidadEntradas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_CantidadEntradas.Name = "txt_CantidadEntradas";
            this.txt_CantidadEntradas.Size = new System.Drawing.Size(23, 25);
            this.txt_CantidadEntradas.TabIndex = 0;
            this.txt_CantidadEntradas.Text = "0";
            // 
            // bt_Abrir1
            // 
            this.bt_Abrir1.Location = new System.Drawing.Point(58, 282);
            this.bt_Abrir1.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Abrir1.Name = "bt_Abrir1";
            this.bt_Abrir1.Size = new System.Drawing.Size(68, 24);
            this.bt_Abrir1.TabIndex = 1;
            this.bt_Abrir1.Text = "Abrir";
            this.bt_Abrir1.UseVisualStyleBackColor = true;
            this.bt_Abrir1.Click += new System.EventHandler(this.bt_Abrir1_Click);
            // 
            // bt_Abrir2
            // 
            this.bt_Abrir2.Location = new System.Drawing.Point(246, 282);
            this.bt_Abrir2.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Abrir2.Name = "bt_Abrir2";
            this.bt_Abrir2.Size = new System.Drawing.Size(68, 24);
            this.bt_Abrir2.TabIndex = 2;
            this.bt_Abrir2.Text = "Abrir";
            this.bt_Abrir2.UseVisualStyleBackColor = true;
            this.bt_Abrir2.Click += new System.EventHandler(this.bt_Abrir2_Click);
            // 
            // bt_Cerrar1
            // 
            this.bt_Cerrar1.Location = new System.Drawing.Point(58, 329);
            this.bt_Cerrar1.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Cerrar1.Name = "bt_Cerrar1";
            this.bt_Cerrar1.Size = new System.Drawing.Size(68, 24);
            this.bt_Cerrar1.TabIndex = 3;
            this.bt_Cerrar1.Text = "Cerrar";
            this.bt_Cerrar1.UseVisualStyleBackColor = true;
            this.bt_Cerrar1.Click += new System.EventHandler(this.bt_Cerrar1_Click);
            // 
            // bt_Cerrar2
            // 
            this.bt_Cerrar2.Location = new System.Drawing.Point(246, 329);
            this.bt_Cerrar2.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Cerrar2.Name = "bt_Cerrar2";
            this.bt_Cerrar2.Size = new System.Drawing.Size(68, 24);
            this.bt_Cerrar2.TabIndex = 4;
            this.bt_Cerrar2.Text = "Cerrar";
            this.bt_Cerrar2.UseVisualStyleBackColor = true;
            this.bt_Cerrar2.Click += new System.EventHandler(this.bt_Cerrar2_Click);
            // 
            // tx_Lugares
            // 
            this.tx_Lugares.AutoSize = true;
            this.tx_Lugares.BackColor = System.Drawing.Color.Transparent;
            this.tx_Lugares.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_Lugares.Location = new System.Drawing.Point(22, 76);
            this.tx_Lugares.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tx_Lugares.Name = "tx_Lugares";
            this.tx_Lugares.Size = new System.Drawing.Size(23, 25);
            this.tx_Lugares.TabIndex = 5;
            this.tx_Lugares.Text = "0";
            // 
            // bEntrada
            // 
            this.bEntrada.AutoSize = true;
            this.bEntrada.BackColor = System.Drawing.Color.Transparent;
            this.bEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEntrada.Location = new System.Drawing.Point(44, 256);
            this.bEntrada.Name = "bEntrada";
            this.bEntrada.Size = new System.Drawing.Size(108, 15);
            this.bEntrada.TabIndex = 6;
            this.bEntrada.Text = "Barrera entrada";
            // 
            // bSalida
            // 
            this.bSalida.AutoSize = true;
            this.bSalida.BackColor = System.Drawing.Color.Transparent;
            this.bSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalida.Location = new System.Drawing.Point(228, 256);
            this.bSalida.Name = "bSalida";
            this.bSalida.Size = new System.Drawing.Size(98, 15);
            this.bSalida.TabIndex = 7;
            this.bSalida.Text = "Barrera salida";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(179, 215);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(13, 16);
            this.lblHora.TabIndex = 8;
            this.lblHora.Text = "-";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblPropia
            // 
            this.lblPropia.AutoSize = true;
            this.lblPropia.BackColor = System.Drawing.Color.Transparent;
            this.lblPropia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropia.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPropia.Location = new System.Drawing.Point(23, 384);
            this.lblPropia.Name = "lblPropia";
            this.lblPropia.Size = new System.Drawing.Size(120, 19);
            this.lblPropia.TabIndex = 9;
            this.lblPropia.Text = "PROPIA S.R.L";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControlEstacionamiento.Properties.Resources.carretera1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(374, 412);
            this.Controls.Add(this.lblPropia);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.bSalida);
            this.Controls.Add(this.bEntrada);
            this.Controls.Add(this.tx_Lugares);
            this.Controls.Add(this.bt_Cerrar2);
            this.Controls.Add(this.bt_Cerrar1);
            this.Controls.Add(this.bt_Abrir2);
            this.Controls.Add(this.bt_Abrir1);
            this.Controls.Add(this.txt_CantidadEntradas);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label bEntrada;
        private System.Windows.Forms.Label bSalida;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPropia;
    }
}