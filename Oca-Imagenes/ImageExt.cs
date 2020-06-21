using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Oca_Imagenes
{
    public static class ImageExt
    {
        public static Image Resize(this Image img,int dstWidth, int dstHeight)
        {
            var bmp = new Bitmap(dstWidth, dstHeight);
            using (var graphics = Graphics.FromImage(bmp))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    var destRect = new Rectangle(0, 0, dstWidth, dstHeight);
                    graphics.DrawImage(img, destRect);
                    //graphics.DrawImage(img, destRect, srcX, srcY, srcWidth, srcHeight, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return bmp;
        }

        public static Image ResizeProportional(this Image img, int width, int height, bool enlarge = false)
        {
            double ratio = Math.Max(img.Width / (double)width, img.Height / (double)height);
            if (ratio < 1 && !enlarge) return img;
            return img.Resize(int.Parse(Math.Round(img.Width / ratio).ToString()), int.Parse(Math.Round(img.Height / ratio).ToString()));
        }

        private static List<string> Errores = new List<string>();
        public static string KeyValidString = "";
        public static bool ConKey = true;



        public static void RemoveBackground(string ruta_image, List<string> key)
        {
            try
            {
                //402 - sin creditos
                using (var client = new HttpClient())
                using (var formData = new MultipartFormDataContent())
                {
                    formData.Headers.Add("X-Api-Key", KeyValidString);
                    formData.Add(new ByteArrayContent(File.ReadAllBytes(ruta_image)), "image_file", "file.jpg");
                    formData.Add(new StringContent("auto"), "size");
                    var response = client.PostAsync("https://api.remove.bg/v1.0/removebg", formData).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        FileStream fileStream = new FileStream(ruta_image, FileMode.Create, FileAccess.Write, FileShare.None);
                        response.Content.CopyToAsync(fileStream).ContinueWith((copyTask) => { fileStream.Close(); });
                    }
                    else
                    {                        
                        if (response.StatusCode.ToString() == "PaymentRequired")
                        {
                            LLenarErrores(KeyValidString);
                            ListarErrores();
                            getApiValid(key);
                        }
                        Console.WriteLine("Error: " + response.Content.ReadAsStringAsync().Result);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error=>", e);                 
            }
        }
        public static string getApiValid(List<string> keys)
        {
            string salida = "";
            try
            {
                bool hay = false;
                foreach (var key in keys)
                {
                    var resp = Errores.FindIndex(item => item == key);
                    if (resp == -1)
                    {
                        KeyValidString = key;
                        hay = true;
                        break;
                    }
                }
                ConKey = hay;
            }
            catch (Exception)
            {
                salida = "";
                throw;
            }
            return salida;
        }
        public static void ListarErrores()
        {
            try
            {
                Errores.Clear();
                StreamReader leer = File.OpenText("Errores.txt");
                string cadena = leer.ReadLine();
                while (cadena != null)
                {
                    Errores.Add(cadena);
                    cadena = leer.ReadLine();
                }
                leer.Close();
               
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void LLenarErrores(string key)
        {
            try
            {                
                StreamWriter escribir = File.AppendText("Errores.txt");
                escribir.WriteLine(key);
                escribir.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
