using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Autoescuela.clases
{
    public class EdadIncorrectaException : Exception
    {
        public EdadIncorrectaException(int edad) 
            : base("\n\nSu edad (" + edad+") debe estar comprendida entre 18 y 65 años.")
        {
        }
    }
}
