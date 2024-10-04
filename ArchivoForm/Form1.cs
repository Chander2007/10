using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.models;

namespace WindowsFormsApp1
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
         // Configurar columnas del DataGridView
         dgvRegister.Columns.Add("FullName", "Nombre");
         dgvRegister.Columns.Add("Age", "Edad");
         dgvRegister.Columns.Add("Notes", "Notas");
         dgvRegister.Columns.Add("Gender", "Género");
      }

      private void btnAdd_Click(object sender, EventArgs e)
      {
         // Obtener datos 
         string nombre = tbFullName.Text;
         DateTime fechaNacimiento = dateTimePickerBirthdate.Value;

         // Crear una instancia de la clase Persona
         Persona persona = new Persona(nombre, fechaNacimiento);
         int edad = persona.CalcularEdad();

         int nota = int.Parse(tbNotes.Text); 
         char genero = char.Parse(tbGender.Text);

         // Escribir datos en el archivo binario
         using (FileStream mArchivoEscritor = new FileStream("datos.dat", FileMode.Append, FileAccess.Write))
         using (BinaryWriter escritor = new BinaryWriter(mArchivoEscritor))
         {
            escritor.Write(nombre.Length);
            escritor.Write(nombre.ToCharArray());
            escritor.Write(edad);
            escritor.Write(nota);
            escritor.Write(genero);
         }

         // Agregar al DataGridView
         dgvRegister.Rows.Add(nombre, edad, nota, genero);

         // Limpiar
         tbFullName.Clear();
         dateTimePickerBirthdate.Value = DateTime.Now; // Restablecer al valor actual
         tbNotes.Clear();
         tbGender.Clear();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         // Leer datos del archivo binario al cargar el formulario
         if (File.Exists("datos.dat"))
         {
            using (FileStream mArchivoLector = new FileStream("datos.dat", FileMode.Open, FileAccess.Read))
            using (BinaryReader lector = new BinaryReader(mArchivoLector))
            {
               while (mArchivoLector.Position != mArchivoLector.Length)
               {
                  int length = lector.ReadInt32();
                  char[] nombreArray = lector.ReadChars(length);
                  string nombre = new string(nombreArray);
                  int edad = lector.ReadInt32();
                  int nota = lector.ReadInt32();
                  char genero = lector.ReadChar();

                  dgvRegister.Rows.Add(nombre, edad, nota, genero);
               }
            }
         }
      }
   }
}
