//Ruben Bernal Ramos
//CSI1

using Ejercicio2_Condicionales_Prog.servicios;

namespace Ejercicio2_Condicionales_Prog.controladores
{
    /// <summary>
    /// Clase principal de nuestra aplicación
    /// rbr - 231023
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal de nuestra aplicación
        /// rbr - 231023
        /// </summary>
        /// <param name="args"></param>
        static public void Main(string[] args) 
        {
            //Declaro las variables
            int numero1, numero2;

            //Instancio la interfaz y la implementación
            solicitarInterfaz si = new solicitarImplementacion();

            numero1 = si.solicitudNumero();
            numero2 = (int)Math.Sqrt(numero1);

            //Controlo si el número se puede expresar como el cuadrado de otro número entero
            if(numero2*numero2==numero1)
            {
                Console.WriteLine("El número " + numero1 + " tiene raiz cuadrada perfecta");
            }
            else
            {
                Console.WriteLine("El número " + numero1 + " no tiene raiz cuadrada perfecta");
            }
        }
    }
}