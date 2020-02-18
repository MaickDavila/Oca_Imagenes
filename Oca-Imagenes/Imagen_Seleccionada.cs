using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oca_Imagenes
{
    public partial class Imagen_Seleccionada : Form
    {
        string Ruta, Nombre;
        public Imagen_Seleccionada()
        {
            InitializeComponent();
        }
        public Imagen_Seleccionada(string ruta, string nombre)
        {
            InitializeComponent();
            Ruta = ruta;
            Nombre = nombre;
        }

        private void Imagen_Seleccionada_Load(object sender, EventArgs e)
        {
            Image image = Image.FromFile(Ruta + "/" + Nombre);
            imagen.Image = image;
        }
    }
}
