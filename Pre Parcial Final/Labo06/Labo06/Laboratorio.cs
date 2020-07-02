namespace ProxyLabo06
{
    public class Laboratorio : Evaluacion
    {
        private string tipo;

        public Laboratorio(int porcentaje, string nombre, string tipo) : base(porcentaje, nombre)
        {
            this.tipo = tipo;
        }
    }
}