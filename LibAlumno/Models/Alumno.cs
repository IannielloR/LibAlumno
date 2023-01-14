using LibAlumno.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibAlumno.Models
{
    public class Alumno : Persona
    {
        public Alumno(string nombre, string apellido, int DNI) : base(nombre, apellido, DNI)
        {
        }
    }
}
