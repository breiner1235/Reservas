using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas
{
    internal class Vuelo
    {
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaSalida { get; set; }

        public int AsientosDisponibles;
        public string PreferenciaAsiento { get; set; }

        public Vuelo(string origen, string destino, DateTime fechaSalida, string preferenciaAsiento)
        {
            Origen = origen;
            Destino = destino;
            FechaSalida = fechaSalida;
            PreferenciaAsiento = preferenciaAsiento;


        }
        public void ReservarAsiento()
        {

            if (AsientosDisponibles > 0)
            {
                AsientosDisponibles -= 1;
                return;
            }
            else
            {
                throw new InvalidOperationException("No hay asientos disponibles para reservar.");
            }
        }

        public override string ToString()
        {
            return $"Origen: {Origen}\n\n Destino: {Destino}\n\n Fecha de salida: {FechaSalida.ToString("dd/MM/yyyy")}";


        }
    }
}
