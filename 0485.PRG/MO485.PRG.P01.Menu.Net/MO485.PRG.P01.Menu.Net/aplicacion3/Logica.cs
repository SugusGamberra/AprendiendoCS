using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MO485.PRG.P01.Menu.Net.aplicacion3
{
    public class Logica
    {
        public static void inicio()
        {
            int opcion = 0;

            do
            {
                String menu = configuraMenu();

                opcion = InterfazUsuario.getValorEntero(menu);

                switch (opcion)
                {
                    case 1:
                        sumar();
                        break;
                    case 2:
                        restar();
                        break;
                    case 3:
                        multiplicar();
                        break;
                    case 4:
                        dividir();
                        break;
                    case 5:
                        modulo();
                        break;
                    case 0:
                        break;
                    default:
                        InterfazUsuario.muestraMensaje("Opción no disponible");
                        break;
                }
            } while (opcion != 0);

        }

        private static String configuraMenu()
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

        private static void sumar()
        {
            InterfazUsuario.muestraMensaje("-- SUMA --");
            double valor1 = InterfazUsuario.getValorDouble("Valor 1:");
            double valor2 = InterfazUsuario.getValorDouble("Valor 2:");
            double resultado = valor1 + valor2;

            InterfazUsuario.muestraMensaje("Resultado: " + resultado);
        }

        private static void restar()
        {
            InterfazUsuario.muestraMensaje("-- RESTA --");
            double valor1 = InterfazUsuario.getValorDouble("Valor 1:");
            double valor2 = InterfazUsuario.getValorDouble("Valor 2:");
            double resultado = valor1 - valor2;

            InterfazUsuario.muestraMensaje("Resultado: " + resultado);
        }

        private static void multiplicar()
        {
            InterfazUsuario.muestraMensaje("-- MULTIPLICACIÓN --");
            double valor1 = InterfazUsuario.getValorDouble("Valor 1:");
            double valor2 = InterfazUsuario.getValorDouble("Valor 2:");
            double resultado = valor1 * valor2;

            InterfazUsuario.muestraMensaje("Resultado: " + resultado);
        }

        private static void dividir()
        {
            InterfazUsuario.muestraMensaje("-- DIVISIÓN --");
            double valor1 = InterfazUsuario.getValorDouble("Valor 1:");
            double valor2 = InterfazUsuario.getValorDouble("Valor 2:");
            double resultado = valor1 / valor2;

            InterfazUsuario.muestraMensaje("Resultado: " + resultado);
        }

        private static void modulo()
        {
            InterfazUsuario.muestraMensaje("-- RESTO --");
            double valor1 = InterfazUsuario.getValorDouble("Valor 1:");
            double valor2 = InterfazUsuario.getValorDouble("Valor 2:");
            double resultado = valor1 % valor2;

            InterfazUsuario.muestraMensaje("Resultado: " + resultado);
        }
    }
}
