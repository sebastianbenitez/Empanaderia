using System;
using System.Collections.Generic;
using System.Text;

namespace Empanaderia.Clases
{
    class Empanada
    {
        public string HacerMasa()
        {
            return "Hacer masa";
        }
        public virtual string PonerRelleno()
        {
            return "Poner relleno";
        }
        public virtual string HacerRepulgue()
        {
            return "Hacer repulgue";
        }
    }
}
