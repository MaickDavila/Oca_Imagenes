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
    public partial class Padre : Form
    {
        
        public Padre()
        {
            InitializeComponent();
        }
        

        private void btnllamar_hijo_Click(object sender, EventArgs e)
        {
            Hijo hijo = new Hijo();
            AddOwnedForm(hijo);
            hijo.Show();
        }

        private void Imagen_Seleccionada_Load(object sender, EventArgs e)
        {
             
        }
        public void RecogerDatos_del_Hijo(string texto)
        {
            txt_texto.Text = texto;
        }
    }
}
