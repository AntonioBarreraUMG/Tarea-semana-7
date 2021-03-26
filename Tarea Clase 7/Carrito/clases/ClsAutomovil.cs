using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrito.clases 
{
    class ClsAutomovil
    {
        Random ran = new Random();
        public string marca { get; }
        public int vel_max { get; }
        private int velocidadActual { get; set; }

        private bool encendido = false;
        public string color { get; set; }


        public string Acelerar()
        {
            velocidadActual = velocidadActual + 10;
            if (velocidadActual > vel_max)
            {
                return "lo lamento, llegaste a la velocidad maxima";
            }
            else
            {
                return $"vas a {velocidadActual} km por hora";
            }
        }
        public bool EstaEncendido()
        {
            return encendido;
        }
        public ClsAutomovil(string marcaCarro, int velocidadMx)
        {
            this.marca = marcaCarro;
            this.vel_max = velocidadMx;
        }
        public string EncenderMotor()
        {
            if (encendido)
            {
                return "el carro ya esta encendido ";
            }
            else
            {
                encendido = true;
                velocidadActual = 0;
                return "Listo!! carro encendido"; ;
            }

        }
       
        
        //---------------------------TAREA------------------------
        public string Frenar()
        {
            if (velocidadActual > 0)
            {
                velocidadActual = 0;
                return "El carro se ha detenido";
            }
            else
            {
                return "¡Aún no hemos empezado a movernos!";
            }
        }
        public string ApagarMotor()
        {
            if (encendido)
            {
                encendido = false;
                return "El carro se ha apagado";
            }
            else
            {
                return "El carro ya se encontraba apagado";
            }

        }
        public int Radio()
        {
            int pista = ran.Next(1,5);
            return pista;
        }
    }
}
