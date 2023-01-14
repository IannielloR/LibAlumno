using LibAlumno.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibAlumno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNombreVacio_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno alumno = new Alumno("", "Gonzalez", 42123456);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnNombreLargo_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno alumno = new Alumno("fjdslkjfkldsjoijeosjoifdkjsolijelfkdjioekjslidjfkelifjilsie", "Gonzales", 42123456);
                MessageBox.Show($"Nombre: {alumno.Nombre}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btenAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno alumno = new Alumno("Jose","Gonzalez",42123456); 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
