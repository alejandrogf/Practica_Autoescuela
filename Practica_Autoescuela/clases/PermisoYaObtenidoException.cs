using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Autoescuela.clases
{
    class PermisoYaObtenidoException : Exception
    {


        public PermisoYaObtenidoException(string permisoactual, string permisopedido) :
            base("\n\nSu permiso actual (" + permisoactual.ToUpper() +") " +
                 "ya incluye el permiso "+permisopedido.ToUpper() + ".")
        {
        }
    }
}
