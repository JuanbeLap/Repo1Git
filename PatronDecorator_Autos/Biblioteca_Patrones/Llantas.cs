using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Patrones
{
    public class Llantas : Decorator
    {
        public Llantas(AutoComponent Modelo) : base(Modelo)
        {
        }   

        public override float Costo => _ComponentModelo.Costo + 2;
        public override string Descripcion => $"{_ComponentModelo.Descripcion} Llantas de aleación ready";
    }
}
