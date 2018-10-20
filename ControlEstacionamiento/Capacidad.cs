using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEstacionamiento
{
	class Capacidad
	{
		public static int cantidadMax = 50;
		public static int cantidadAutos = 0;
		private int entradas = 0;
		private int salidas = 0;

		public Capacidad() {

		}
		public int AutosHoy(){
			return entradas;
		}

		public int EntradaAuto() {
			entradas++;
			cantidadAutos++;
			
			return Disponibilidad();
		}

		public int SalidaAuto() {
			if (cantidadAutos > 0) {
				cantidadAutos--;
				
			}
			return Disponibilidad();
		}
		public static int Disponibilidad() {
			int devolver = cantidadMax - cantidadAutos;
			return devolver;
		
		}
		

	}
}
