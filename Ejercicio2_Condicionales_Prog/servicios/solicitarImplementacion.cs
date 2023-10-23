//Ruben Bernal Ramos
//CSI1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Condicionales_Prog.servicios
{
    /// <summary>
    /// Implementación de la interfaz solicitar
    /// rbr - 231023
    /// </summary>
    internal class solicitarImplementacion : solicitarInterfaz
    {
        /// <summary>
        /// Método que pedirá un número por consola, lo guardará y lo devolverá
        /// rbr - 231023
        /// </summary>
        /// <returns></returns>
        public int solicitudNumero()
        {
            int numero;

            Console.WriteLine("Introduce un número entero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            return numero;
        }
    }
}
