using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Autoescuela.clases
{
    public class Usuario
    {
        public string Nombre { get; set; }
        //public int Edad { get; set; }
        public string PermisoActual { get; set; }
        //public string PermisoPedido { get; set; }

        //Construyo la property a mano para que el error se controle automaticamente al incluirlo
        //en el set.
        private int _edad;
        public int Edad
        {
            set
            {
                if (value < 18 | value > 65)
                {
                    throw new EdadIncorrectaException(value);
                }
                else
                {
                    _edad = value;
                }
            }
            get 
            { return _edad; }
        }


        private string _permisopedido;
        public string PermisoPedido
        {
            set
            {
                //Comparo los caracteres del permiso pedido y el actual, la funcion me indica la 
                //diferencia (posicion) que tienen y así puedo saber si es mayor, menor o igual.
                //En este caso solo debe permitir continuar si permiso pedido es 1 mayor que el actual
                var result = string.Compare(value, PermisoActual, StringComparison.Ordinal);

                if (result>1)
                {
                    throw new PermisoIncorrectoException(PermisoActual, value);
                }else if (result<0)
                {
                    throw new PermisoYaObtenidoException(PermisoActual, value);
                }
                else
                {
                    _permisopedido = value;
                }
            }

            get 
            { return _permisopedido; }
        }

    }


}
