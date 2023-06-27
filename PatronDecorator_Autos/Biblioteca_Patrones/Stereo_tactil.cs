using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Patrones
{
    public class Stereo_tactil : Decorator
    {
        public Stereo_tactil(AutoComponent Modelo) : base(Modelo)
        {
        }
        public override float Costo => _ComponentModelo.Costo + 2.5f;
        public override string Descripcion => string.Format($"{_ComponentModelo.Descripcion}, con stereo tactil y bluetooth!!!");
    }
}
