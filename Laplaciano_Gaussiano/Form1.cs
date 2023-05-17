using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laplaciano_Gaussiano
{
    public partial class Form1 : Form
    {

        Bitmap img_1;
        bool Exist_Img = false;
        Bitmap img_res;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SFD_img.Filter = "Images|*.png;*.bmp;*.jpg";
        }

        //Abrir 
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OFD_img.ShowDialog() == DialogResult.OK)
            {
                img_1 = (Bitmap)Bitmap.FromFile(OFD_img.FileName);
                PB_img.Image = img_1;
                Exist_Img = true;
            }

        }

        //Guardar
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SFD_img.ShowDialog() == DialogResult.OK)
            {
                img_res.Save(SFD_img.FileName, ImageFormat.Png);
            }
        }

        //filtro Gaussiano
        private void gaussianoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Exist_Img)
            {
                Bitmap img_gauss = gaussiano(img_1);
                PB_result.Image = img_gauss;
                img_res = img_gauss;
            }
        }

        private void laplacianoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Exist_Img)
            {
                Bitmap img_laplaciana = laplaciano(img_1);
                PB_result.Image = img_laplaciana;
                img_res = img_laplaciana;
            }
        }

        private void laplacianoGaussianoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Exist_Img)
            {
                Bitmap img_gauss = gaussiano(img_1);
                Bitmap img_laplaciana_gauss = laplaciano(img_gauss);
                Bitmap img_laplaciana= laplaciano(img_laplaciana_gauss);
                // Mostrar la imagen resultante
                PB_result.Image = img_laplaciana_gauss;
                pictureBox1.Image = img_laplaciana;
                img_res = img_laplaciana_gauss;
            }
        }

        private Bitmap gaussiano(Bitmap img)
        {
            Bitmap img_gauss = img;
            //definir el tamaño de la matriz kernel
            int tamKernel = 5;

            double[,] Kernel = new double[tamKernel, tamKernel];

            //definir la desviacion estandar
            double desv = 1.4;

            //llenar la matriz kernel con sus valores
            for (int i = 0; i < tamKernel; i++)
            {
                for (int j = 0; j < tamKernel; j++)
                {
                    //formula para calcular los valores de la matriz kernel
                    Kernel[i, j] = 1 / (2 * Math.PI * Math.Pow(desv, 2)) *
                                    Math.Exp(-(Math.Pow(i - tamKernel / 2, 2) + Math.Pow(j - tamKernel / 2, 2)) /
                                    (2 * Math.Pow(desv, 2)));
                }
            }

            for (int x = tamKernel / 2; x < img.Width - tamKernel / 2; x++)
            {
                for (int y = tamKernel / 2; y < img.Height - tamKernel / 2; y++)
                {
                    double r = 0, g = 0, b = 0;

                    for (int i = 0; i < tamKernel; i++)
                    {
                        for (int j = 0; j < tamKernel; j++)
                        {
                            Color pixelColor = img.GetPixel(x + i - tamKernel / 2, y + j - tamKernel / 2);
                            r += pixelColor.R * Kernel[i, j];
                            g += pixelColor.G * Kernel[i, j];
                            b += pixelColor.B * Kernel[i, j];
                        }
                    }

                    // definir el nuevo valor del pixel en la imagen filtrada
                    Color newColor = Color.FromArgb((int)r, (int)g, (int)b);
                    img_gauss.SetPixel(x, y, newColor);
                }
            }

            // mostrar la imagen filtrada
            return img_gauss;
        }
        private Bitmap laplaciano(Bitmap img)
        {
            // Crear una nueva imagen del mismo tamaño para almacenar el resultado
            Bitmap resultImage = new Bitmap(img.Width, img.Height);

            //Definir la matriz del filtro Laplaciano
            int[,] laplacianFilter = new int[,]
            {
                { -1, -1, -1 },
                { -1,  8, -1 },
                { -1, -1, -1 }
            };
            //int[,] laplacianFilter = new int[,]
            //{
            //{ 0, 1, 0 },
            //{ 1, -4, 1 },
            //{ 0, 1, 0 }
            //};


            // Aplicar el filtro a cada píxel de la imagen en escala de grises
            for (int x = 1; x < img.Width - 1; x++)
            {
                for (int y = 1; y < img.Height - 1; y++)
                {
                    // Calcular el valor del nuevo píxel aplicando el filtro Laplaciano
                    int newValue = 0;
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            Color pixelColor = img.GetPixel(x + i, y + j);
                            int grayValue = pixelColor.R; // La imagen está en escala de grises, todos los canales tienen el mismo valor
                            newValue += grayValue * laplacianFilter[i + 1, j + 1];
                        }
                    }

                    // Asegurarse de que el valor del nuevo píxel esté en el rango [0, 255]
                    if (newValue > 255) newValue = 255;
                    if (newValue < 0) newValue = 0;

                    newValue = 255 - newValue;


                    // Establecer el nuevo valor del píxel en la imagen resultante
                    Color newColor = Color.FromArgb(newValue, newValue, newValue);
                    resultImage.SetPixel(x, y, newColor);
                }
            }

            // Mostrar la imagen resultante
            return resultImage;
        }
    }
}
