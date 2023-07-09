using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Persona:IComparable<Persona>,IDisposable,ICalculable
    {
		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}
		private int legajo;

		public int Legajo
		{
			get { return legajo; }
			set { legajo = value; }
		}
		private int edad;

		public int Edad
		{
			get { return edad; }
			set { edad = value; }
		}
		public int CompareTo(Persona per)
		{
			//return string.Compare(this.Nombre, per.Nombre);
			return this.Nombre.CompareTo(per.Nombre);
		}

		private bool disposedValue;
		private bool disposable;
		private bool disposing;
		public void Dispose()
		{
			if (!disposedValue)
			{
				if (disposing)
				{

				}
				disposedValue=true;
			}	
		}
		~Persona()
		{
			disposable=true;
		}

        int Sumar(int nro1, int nro2)
        {
            return nro1 + nro2;
        }

        int ICalculable.Sumar(int nro1, int nro2)
        {
            throw new NotImplementedException();
        }
    }
}
