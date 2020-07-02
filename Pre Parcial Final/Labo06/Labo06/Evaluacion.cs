namespace ProxyLabo06
{
    public class Evaluacion
    {
        protected int porcentaje;
        protected string nombre;

        public Evaluacion(int porcentaje, string nombre)
        {
            this.nombre = nombre;
            this.porcentaje = porcentaje;
        }
        
        public int Porcentaje => porcentaje;

        public string Nombre => nombre;


    }
}