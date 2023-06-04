using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public abstract class Personal
    {
		


		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private int horas;

		public int Horas
		{
			get { return horas; }
			set { horas = value; }
		}
		private float sueldo;

		public float Sueldo
		{
			get { return sueldo; }
			set { sueldo = value; }
		}

		

		private string tipo;

		public string Tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}


	}
}
