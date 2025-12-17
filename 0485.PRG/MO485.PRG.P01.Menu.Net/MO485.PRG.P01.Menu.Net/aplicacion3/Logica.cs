using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MO485.PRG.P01.Menu.Net.aplicacion3
{
    public class Logica
    {
        public static void Inicio()
        {
            int opcion = 0;

            do
            {
                String menu = ConfiguraMenu();

                opcion = InterfazUsuario.GetValorEntero(menu);

                switch (opcion)
                {
                    case 1:
                        Sumar();
                        break;
                    case 2:
                        Restar();
                        break;
                    case 3:
                        Multiplicar();
                        break;
                    case 4:
                        Dividir();
                        break;
                    case 5:
                        Modulo();
                        break;
                    case 0:
                        break;
                    default:
                        InterfazUsuario.MuestraMensaje("Opción no disponible");
                        break;
                }
            } while (opcion != 0);

        }

        private static String ConfiguraMenu()
        {
            String menu = "\n";
            menu = menu + "-- MENÚ CALCULADORA --";
            menu = menu + "\n";
            menu = menu + "1. Sumar";
            menu = menu + "\n";
            menu = menu + "2. Restar";
            menu = menu + "\n";
            menu = menu + "3. Multiplicar";
            menu = menu + "\n";
            menu = menu + "4. Dividir";
            menu = menu + "\n";
            menu = menu + "5. Módulo (obtener resto)";
            menu = menu + "\n";
            menu = menu + "0. Salir";
            menu = menu + "\n";

            return menu;
        }

        private static void Sumar()
        {
            InterfazUsuario.MuestraMensaje("-- SUMA --");
            double valor1 = InterfazUsuario.GetValorDouble("Valor 1:");
            double valor2 = InterfazUsuario.GetValorDouble("Valor 2:");
            double resultado = valor1 + valor2;

            InterfazUsuario.MuestraMensaje("Resultado: " + resultado);
        }

        private static void Restar()
        {
            InterfazUsuario.MuestraMensaje("-- RESTA --");
            double valor1 = InterfazUsuario.GetValorDouble("Valor 1:");
            double valor2 = InterfazUsuario.GetValorDouble("Valor 2:");
            double resultado = valor1 - valor2;

            InterfazUsuario.MuestraMensaje("Resultado: " + resultado);
        }

        private static void Multiplicar()
        {
            InterfazUsuario.MuestraMensaje("-- MULTIPLICACIÓN --");
            double valor1 = InterfazUsuario.GetValorDouble("Valor 1:");
            double valor2 = InterfazUsuario.GetValorDouble("Valor 2:");
            double resultado = valor1 * valor2;

            InterfazUsuario.MuestraMensaje("Resultado: " + resultado);
        }

        private static void Dividir()
        {
            InterfazUsuario.MuestraMensaje("-- DIVISIÓN --");
            double valor1 = InterfazUsuario.GetValorDouble("Valor 1:");
            double valor2 = InterfazUsuario.GetValorDouble("Valor 2:");
            double resultado = valor1 / valor2;

            InterfazUsuario.MuestraMensaje("Resultado: " + resultado);
        }

        private static void Modulo()
        {
            InterfazUsuario.MuestraMensaje("-- RESTO --");
            double valor1 = InterfazUsuario.GetValorDouble("Valor 1:");
            double valor2 = InterfazUsuario.GetValorDouble("Valor 2:");
            double resultado = valor1 % valor2;

            InterfazUsuario.MuestraMensaje("Resultado: " + resultado);
        }
    }
}
