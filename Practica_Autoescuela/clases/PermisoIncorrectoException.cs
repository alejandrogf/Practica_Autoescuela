using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Autoescuela.clases
{
    public class PermisoIncorrectoException : Exception
    {
        public PermisoIncorrectoException(string permisoactual, string permisopedido) :
            base("\n\nSu permiso actual (" + permisoactual.ToUpper() +") " +
                 "no le permite obtener el permiso "+permisopedido.ToUpper() + ".")
        {
        }
    }
}
