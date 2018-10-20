using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEstacionamiento
{
	public delegate void Delegado(int n, Label texto, string info);
	public partial class Principal : Form
	{
		private int entradas = 0;
		Delegado a;
		Capacidad estacionamiento;

		public Principal()
		{
			estacionamiento = new Capacidad();
			a = new Delegado(CambiarTexto);
			InitializeComponent();
			serialPort1.PortName = "COM8";
			serialPort1.Open();
			
		}

		public void CambiarTexto(int n, Label texto, string info)
		{
			texto.Text = info + " " + n; 
			
			
			
		}

		private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			string devuelto = serialPort1.ReadLine();
			// 1= se abrio puerta de entrada
			if (devuelto == "1\r")
			{
				this.Invoke(a, estacionamiento.AutosHoy(),txt_CantidadEntradas, "Entraron hoy: ");
				this.Invoke(a, estacionamiento.EntradaAuto(), tx_Lugares, "Lugares libres: ");
			}

			// 0 = se abrio la puerta de salida
			if (devuelto == "0\r")
			{
				this.Invoke(a, estacionamiento.SalidaAuto(), tx_Lugares, "lugares libres: ");
			}

			return;

		}

		#region Controladores Puertas
		private void bt_Abrir1_Click(object sender, EventArgs e)
		{

		}

		private void bt_Cerrar1_Click(object sender, EventArgs e)
		{

		}

		private void bt_Abrir2_Click(object sender, EventArgs e)
		{

		}

		private void bt_Cerrar2_Click(object sender, EventArgs e)
		{

		}

		#endregion
	}
}
