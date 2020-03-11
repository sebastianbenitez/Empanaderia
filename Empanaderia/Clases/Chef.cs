using System;
using System.Collections.Generic;
using System.Text;

namespace Empanaderia.Clases
{
    class Chef : IEmpanaderia
    {
        public string PedirEmpanada(Empanada empanada)
        {
            var Ayudante = new Ayudante();
            return Ayudante.PedirEmpanada(empanada);
        }
    }
}
