using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Patrones
{
    public abstract class AutoComponent
    {
		public abstract float Costo { get; }
        public abstract string Descripcion { get; }

        public virtual void ObtenerModelo (object modeloAuto)
        {
            object modelo = modeloAuto;
        }
	}
}
