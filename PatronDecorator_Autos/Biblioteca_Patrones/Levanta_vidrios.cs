using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Patrones
{
    public class Levanta_vidrios : Decorator
    {
        public Levanta_vidrios(AutoComponent Modelo) : base(Modelo)
        {
        }   
        public override float Costo => _ComponentModelo.Costo + 1;
        public override string Descripcion => string.Format($"{_ComponentModelo.Descripcion}, con levanta vidrios electrico!");
    }
}
