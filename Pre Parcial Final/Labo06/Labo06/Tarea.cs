using System;

namespace ProxyLabo06
{
    public class Tarea : Evaluacion
    {
        private DateTime fechaEntrega;

        public Tarea(int porcentaje, string nombre, DateTime fechaEntrega) : base(porcentaje, nombre)
        {
            this.fechaEntrega = fechaEntrega;
        }

        public DateTime FechaEntrega => fechaEntrega;
        
    }
}