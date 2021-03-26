using Carrito.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Carrito
{
    public partial class Form1 : Form
    {
        SoundPlayer audio = new SoundPlayer();
        ClsAutomovil carrito;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            carrito = new ClsAutomovil("Meches",150);
            carrito.color = "blanco";
        }

        private void buttonAcelerar_Click(object sender, EventArgs e)
        {
            if (carrito.EstaEncendido())
            {
                labelVelocidad.Text = carrito.Acelerar();
            }
            else
            {
                MessageBox.Show($"lo lamento el carro{carrito.marca} esta apagado");
            }
        }
        
        private void buttonEncender_Click(object sender, EventArgs e)
        {
            string respuesta = carrito.EncenderMotor();
            labeldatos.Text = respuesta;

            audio.SoundLocation = "C:/Users/jeant/Desktop/Tarea Clase 7/Carrito/Audios/Arranca.wav";
            audio.Play();

        }


        //--------------------------TAREA------------------------------
        private void buttonFrenar_Click(object sender, EventArgs e)
        {
            audio.SoundLocation = "C:/Users/jeant/Desktop/Tarea Clase 7/Carrito/Audios/Frena.wav";
            audio.Play();

            if (carrito.EstaEncendido())
            {
                labelVelocidad.Text = carrito.Frenar();
            }
            else
            {
                labelVelocidad.Text = "";
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            string respuesta = carrito.ApagarMotor();
            labeldatos.Text = respuesta;
        }

        private void buttonRadio_Click(object sender, EventArgs e)
        {
            int pista = carrito.Radio();
            audio.SoundLocation = $"C:/Users/jeant/Desktop/Tarea Clase 7/Carrito/Audios/pista{Convert.ToString(pista)}.wav";
            audio.Play();

            labelRadio.Text = $"Se está reproduciendo la pista número {pista}";
        }
    }
}
