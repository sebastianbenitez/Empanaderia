using System;
using System.Collections.Generic;
using System.Text;

namespace Empanaderia.Clases
{
    class EmpanadaVerdura : Empanada
    {
        public override string HacerRepulgue()
        {
            return base.HacerRepulgue() + " Verdura";
        }
        public override string PonerRelleno()
        {
            return base.PonerRelleno() + " Verdura";
        }
    }
}
