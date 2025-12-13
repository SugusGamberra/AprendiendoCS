namespace MO485.PRG.P01.Menu.Net.aplicacion3 // esto es como el package en JAVA
{
    public class ProgramMain
    {
        public static void Main(string[] args) // por convencion los metodos de las clases empiezan en mayuscula
        {
            InterfazUsuario.TIPO_INTERFAZ = "C";
            Logica.inicio();
        }
    }
}