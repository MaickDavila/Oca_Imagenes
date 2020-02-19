using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oca_Imagenes
{
    public partial class Form1 : Form
    {
        string Ruta_Entrada, Ruta_Salida;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_r_salida_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    Ruta_Salida = "";
                    txt_r_salida.Text = folder.SelectedPath;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            track_bar_calidad.Value = 50;
            ActivarHilo();
        }

        private void btn_r_entrada_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                if (folder.ShowDialog() == DialogResult.OK)
                {                    
                    Ruta_Entrada = "";
                    tabla_imagenes.Rows.Clear();
                    txt_r_entrada.Text = folder.SelectedPath;
                    RecorrerFolderEntrada();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                
            }
        }
        
         
        void RecorrerFolderEntrada()
        {
            try
            {
                string full_ruta_name = "";
                Ruta_Entrada = txt_r_entrada.Text;
                List<string> imagenes = new List<string>();
                List<string> pesos = new List<string>();
                List<string> dim = new List<string>();

                DirectoryInfo carpeta = new DirectoryInfo(Ruta_Entrada);
                foreach (var item in carpeta.GetFiles())
                {                    
                    string extension = item.Extension.Trim().ToLower();
                    if (extension == ".png" || extension == ".jpg")
                    {
                        string name = item.Name;
                        Image img = Image.FromFile(Ruta_Entrada + "/" + name);
                        string dimensiones = img.Width + "-" + img.Height;

                        float peso = (item.Length / 1024f);
                        string peso_string = peso + " kb";
                        if (peso > 1024f) peso_string = peso + " mb";
                        if (peso > 1024f)
                        {
                            peso = (item.Length / 1024f) / 1024f;
                            peso_string = peso + " mb";
                        }
                        full_ruta_name = Ruta_Entrada + @"\" + name;
                        imagenes.Add(name);
                        pesos.Add(peso_string);
                        dim.Add(dimensiones);
                         
                    }
                }
                Image image;
                Size size = new Size(100, 100);

                int cont = 0;
                foreach (string item in imagenes)
                {
                    image = Image.FromFile(Ruta_Entrada + $"/{item}");
                    tabla_imagenes.Rows.Add(ResizeImage(image, size), dim.ToArray()[cont], pesos.ToArray()[cont], item);
                    cont++;
                }
            }
            catch (Exception ex)
            {
                string es = ex.Message;
            }
        }
        

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        public void SoloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar.Equals('.'))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else e.Handled = true;
            }
        }

        private void tabla_imagenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indice = tabla_imagenes.CurrentRow.Index;
                string nombre = (tabla_imagenes.Rows[indice].Cells["cnombre"].Value.ToString());
                Image image = Image.FromFile(Ruta_Entrada + $"/{nombre}");
                
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnempezar_Click(object sender, EventArgs e)
        {
            
        }

        private void tabla_imagenes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int indice = 0;
                indice = tabla_imagenes.CurrentRow.Index;
                string nombre = tabla_imagenes.Rows[indice].Cells["cnombre"].Value.ToString();
                 
                string abrir = Ruta_Entrada + @"\" + nombre;

                Process.Start(abrir);
            }
            catch (Exception ex)
            {
                string es = ex.Message;
            }
        }
        
        private void btn_aplicar_cambios_Click(object sender, EventArgs e)
        {
            if (tabla_imagenes.Rows.Count > 0)
            {
                hilo.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("¡No se encontró ninguna imagen!", "Imagen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private static Image ResizeImage(Image imgToResize, Size size)
        {
            Bitmap b = null;
            try
            {
                int sourceWidth = imgToResize.Width;
                int sourceHeight = imgToResize.Height;

                float nPercent = 0;
                float nPercentW = 0;
                float nPercentH = 0;

                nPercentW = ((float)size.Width / (float)sourceWidth);
                nPercentH = ((float)size.Height / (float)sourceHeight);

                if (nPercentH < nPercentW)
                    nPercent = nPercentH;
                else
                    nPercent = nPercentW;

                int destWidth = (int)(sourceWidth * nPercent);
                int destHeight = (int)(sourceHeight * nPercent);

                b = new Bitmap(destWidth, destHeight);
                Graphics g = Graphics.FromImage((Image)b);
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
                g.Dispose();
            }
            catch (Exception ex)
            {
                string es = ex.Message;
            }

            return (Image)b;
        }
        bool Se_Aplico = false;
        private void hilo_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                
                int ancho = 0, alto = 0;
                int indice = 0;                
                bool tiene_tamanios = (txt_ancho.Text.Trim().Length != 0 || txt_alto.Text.Trim().Length != 0) ? true : false;
                Ruta_Salida = txt_r_salida.Text;
                bool existe_salida = txt_r_salida.Text.Trim().Length > 0 ? true : false;
                if (!existe_salida)
                {
                    MessageBox.Show("¡Para aplicar los cambios, especifique una ruta de salida válida!", "Imagenes", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (!tiene_tamanios)
                {
                    if (check_tamanios.Checked)
                    {
                        if (MessageBox.Show("¡No se definieron los cambios en el tamaño!\n¿Desea mantener el tamaño original de las imagenes?", "Imagenes", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                        {
                            return;
                        }
                    }
                }
                progreso.Maximum = tabla_imagenes.Rows.Count - 1;

                if (tiene_tamanios)
                {
                    ancho = int.Parse(txt_ancho.Text);
                    alto = int.Parse(txt_alto.Text);
                }
               
               

                foreach (DataGridViewRow row in tabla_imagenes.Rows)
                {
                    indice = row.Index;
                    string nombre = tabla_imagenes.Rows[indice].Cells["cnombre"].Value.ToString();
                    string tamanio_original = tabla_imagenes.Rows[indice].Cells["csize"].Value.ToString();
                    string abrir = Ruta_Entrada + @"\" + nombre;
                    Image image = Image.FromFile(abrir);
                    if (!tiene_tamanios)
                    {
                        string[] campos = tamanio_original.Split('-');
                        ancho = int.Parse(campos[0]);
                        alto = int.Parse(campos[1]);
                    }
                    if (check_dimesion.Checked)
                    {
                        if (!tiene_tamanios)
                        {
                            image = ImageExt.Resize(image, ancho, alto);
                        }
                        else
                        {
                            image = ImageExt.ResizeProportional(image, ancho, alto, true);
                        }

                    }
                    else
                    {
                        image = ImageExt.Resize(image, ancho, alto);
                    }
                    
                    abrir = Application.StartupPath + @"\Temp\" + nombre;
                    
                    using (MemoryStream stream = new MemoryStream())
                    {
                        if (File.Exists(abrir))
                        {

                            File.Delete(abrir);
                            
                        }
                        Comprimir_Guardar_Imagen(image, Ruta_Salida + @"\" + nombre);
                    }
                    hilo.ReportProgress(row.Index);
                }
                Se_Aplico = true;
               
            }
            catch (Exception ex)
            {
                string es = ex.Message;
                Se_Aplico = false;
            }
        }
         

        private void hilo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progreso.Value = e.ProgressPercentage;
            
        }

        private void hilo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Se_Aplico)
            {
                lbl_progreso.Text = "¡Completado!";
                MessageBox.Show("Los cambios se aplicaron.", "¡Completado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(Ruta_Salida);
            }
            else
            {
                MessageBox.Show("No se realizaron cambios", "¡Completado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        void ActivarHilo()
        {
            hilo.WorkerReportsProgress = true;
            hilo.WorkerSupportsCancellation = true;
            CheckForIllegalCrossThreadCalls = false;
        }
        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        private void track_bar_calidad_Scroll(object sender, EventArgs e)
        {
            lbl_calidad.Text = track_bar_calidad.Value.ToString();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            tabla_imagenes.Rows.Clear();
            txt_r_entrada.Text = "";
            txt_r_salida.Text = "";
            Ruta_Entrada = "";
            Ruta_Salida = "";
            lbl_calidad.Text = "50";
            track_bar_calidad.Value = 50;
            txt_alto.Text = "";
            txt_ancho.Text = "";
            check_dimesion.Checked = true;
            progreso.Value = 0;
            lbl_progreso.Text = "";
        }

        private void check_tamanios_CheckedChanged(object sender, EventArgs e)
        {
            if (check_tamanios.Checked)
            {
                panel_tamanios.Enabled = true;
            }
            else
            {
                panel_tamanios.Enabled = false;
            }
        }

       

        private void Comprimir_Guardar_Imagen(Image image, string r_salida)
        {
            try
            {
                // Get a bitmap. The using statement ensures objects  
                // are automatically disposed from memory after use.  
                long calidad = 0;
                calidad = long.Parse(track_bar_calidad.Value.ToString());
                using (Bitmap bmp1 = new Bitmap(image))
                {
                    ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

                    // Create an Encoder object based on the GUID  
                    // for the Quality parameter category.  
                    System.Drawing.Imaging.Encoder myEncoder =
                        System.Drawing.Imaging.Encoder.Quality;

                    // Create an EncoderParameters object.  
                    // An EncoderParameters object has an array of EncoderParameter  
                    // objects. In this case, there is only one  
                    // EncoderParameter object in the array.  
                    EncoderParameters myEncoderParameters = new EncoderParameters(1);

                    EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, calidad);
                    myEncoderParameters.Param[0] = myEncoderParameter;
                    if(check90.Checked) bmp1.RotateFlip(RotateFlipType.Rotate90FlipX);
                    bmp1.Save(r_salida, jpgEncoder, myEncoderParameters);

                    //myEncoderParameter = new EncoderParameter(myEncoder, 100L);
                    //myEncoderParameters.Param[0] = myEncoderParameter;
                    //bmp1.Save(@"C:\TestPhotoQualityHundred.jpg", jpgEncoder, myEncoderParameters);

                    //// Save the bitmap as a JPG file with zero quality level compression.  
                    //myEncoderParameter = new EncoderParameter(myEncoder, 0L);
                    //myEncoderParameters.Param[0] = myEncoderParameter;
                    //bmp1.Save(@"C:\TestPhotoQualityZero.jpg", jpgEncoder, myEncoderParameters);
                }
            }
            catch (Exception ex)
            {
                string es = ex.Message;
            }     
        }

    }
}
