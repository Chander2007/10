using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.models
{
   internal class Persona
   {
         public string Nombre { get; set; }
         public DateTime FechaNacimiento { get; set; }

         public Persona(string nombre, DateTime fechaNacimiento)
         {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
         }

         public int CalcularEdad()
         {
            int edad = DateTime.Now.Year - FechaNacimiento.Year;
            if (DateTime.Now < FechaNacimiento.AddYears(edad)) edad--;
            return edad;
         }
      }

   }

