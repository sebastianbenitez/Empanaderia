using System;
using System.Collections.Generic;
using System.Text;

namespace Empanaderia.Clases
{
    class EmpanadaCarne : Empanada
    {
        public override string HacerRepulgue()
        {
            return base.HacerRepulgue() + " Carne";
        }
        public override string PonerRelleno()
        {
            return base.PonerRelleno() + " Carne";
        }
    }
}
