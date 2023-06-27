using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Patrones
{
    public abstract class Decorator : AutoComponent
    {
        protected AutoComponent _ComponentModelo;

        public Decorator(AutoComponent Modelo)
        {
            _ComponentModelo = Modelo;
        }

        
    }
}
