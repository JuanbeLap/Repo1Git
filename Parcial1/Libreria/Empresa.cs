using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Empresa
    {
		public Empresa() 
		{
			listaAux = new List<Auxi> {};
			listaMod = new List<Modelo> { };
			
		}	

		private List<Auxi> listaaux;

		public List<Auxi> listaAux
		{
			get { return listaaux; }
			set { listaaux = value; }
		}
		private List<Modelo> listamod;

		public List<Modelo> listaMod
		{
			get { return listamod; }
			set { listamod = value; }
		}
		




	}
}
