using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibAlumno.Models.Bases
{
    public class Persona
    {
        public Persona(string nombre, string apellido, int DNI) 
        {
            this.Nombre= nombre;
            this.Apellido = apellido;
            this.DNI = DNI;
        }
        public string Nombre { get; set
            {
                if (Nombre.Trim().Length < 1)
                {
                    throw new ArgumentException("Debe ingresar un nombre.");
                }
                else if (Nombre.Trim().Length > 50)
                {

                    throw new ArgumentException("El nombre debe tener entre 1 y 50 caracteres.");

                }

            }
        }
        public string Apellido { get; set;}
        public int DNI { get; set;}
    }
}
