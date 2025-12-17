using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MO485.PRG.P01.Menu.Net.aplicacion3
{
    public class InterfazUsuario
    {
        public static string TIPO_INTERFAZ = "C";

        public static void MuestraMensaje(string mensaje)
        {
            if (TIPO_INTERFAZ == "C")
            {
                Console.WriteLine(mensaje);
            }
            else if (TIPO_INTERFAZ == "D")
            {
                // JOptionPane.showMessageDialog(null, mensaje, "Calculadora", JOptionPane.INFORMATION_MESSAGE);
            }

        }

        public static int GetValorEntero(String mensaje)
        {
            int valor = 0;

            if (TIPO_INTERFAZ == "C")
            {
                MuestraMensaje(mensaje);
                // esto es como el scanner en JAVA
                string valorDevuelto = Console.ReadLine();
                valor = int.Parse(valorDevuelto);
            }
            else if (TIPO_INTERFAZ == "D")
            {
            
                //String valorDevuelto = JOptionPane.showInputDialog(null, mensaje, "Calculadora", JOptionPane.QUESTION_MESSAGE);
                //valor = Integer.parseInt(valorDevuelto);
            }

            return valor;
        }
        public static double GetValorDouble(String mensaje)
        {
            double valor = 0;

            if (TIPO_INTERFAZ == "C")
            {
                MuestraMensaje(mensaje);
                string valorDevuelto = Console.ReadLine();
                valor = double.Parse(valorDevuelto);
            }
            else if (TIPO_INTERFAZ == "D")
            {
                //String valorDevuelto = JOptionPane.showInputDialog(null, mensaje, "Calculadora", JOptionPane.QUESTION_MESSAGE);
                //valor = Double.parseDouble(valorDevuelto);
            }

            return valor;
        }
    }
}
