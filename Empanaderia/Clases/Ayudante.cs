using System;
using System.Collections.Generic;
using System.Text;

namespace Empanaderia.Clases
{
    class Ayudante : IEmpanaderia
    {
        public string PedirEmpanada(Empanada empanada)
        {
            return empanada.HacerMasa()+"\n"+empanada.PonerRelleno()+"\n"+empanada.HacerRepulgue();
        }
    }
}
