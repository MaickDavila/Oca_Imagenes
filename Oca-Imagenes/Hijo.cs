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
    public partial class Hijo : Form
    {
        public Hijo()
        {
            InitializeComponent();
        }


        private void Hijo_Load(object sender, EventArgs e)
        {

        }

        private void btn_enviar_a_padre_Click(object sender, EventArgs e)
        {
            Padre padre = Owner as Padre;
            padre.RecogerDatos_del_Hijo(txt_texto.Text);
        }
    }
}
