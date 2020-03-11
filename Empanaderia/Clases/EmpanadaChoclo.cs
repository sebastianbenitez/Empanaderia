using System;
using System.Collections.Generic;
using System.Text;

namespace Empanaderia.Clases
{
    class EmpanadaChoclo : Empanada
    {
        public override string HacerRepulgue()
        {
            return base.HacerRepulgue() + " Choclo";
        }
        public override string PonerRelleno()
        {
            return base.PonerRelleno() + " Choclo";
        }
    }
}
