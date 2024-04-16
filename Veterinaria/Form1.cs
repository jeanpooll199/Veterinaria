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

namespace Veterinaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar datos de entrada (ver ejemplo anterior)

            // Obtener ruta de la carpeta "Mis documentos"
            string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Crear nombre del archivo
            string fileName = "mascotas.txt";
            string filePath = Path.Combine(documentsFolder, fileName);

            // Formatear datos en una cadena de texto
           
            string datos = "RAZA:  "+ txtRaza.Text + "            " + "NOMBRE:  " +txtNombre.Text + "            " + "EDAD:   "+txtEdad.Text + "        " + "COLOR PELAJE:  "+ txtColor.Text;

            try
            {
                File.WriteAllText(filePath, datos);
                MessageBox.Show("Datos guardados correctamente en " + filePath);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error: No se pudo guardar el archivo. " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
