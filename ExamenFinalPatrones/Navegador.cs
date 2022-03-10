using ExamenFinalPatrones.Strategies;

namespace ExamenFinalPatrones
{
    internal class Navegador
    {
        public string TipoDeRuta { private get; set; }

        //Los tipos de datos de origen, destino y retorno se obviaron por la falta de reelevancia para el ejercicio
        public object? generar_ruta(object origen, object destino)
        {
            TrazadorDeRuta trazador = null;

            switch (TipoDeRuta)
            {
                case "P":
                    trazador = new TrazadorDeRutaAPie();
                    break;
                case "AT":
                    trazador = new TrazadorDeRutaAtraccionesTuristicas();
                    break;
                case "A":
                    trazador = new TrazadorDeRutaAutomovil();
                    break;
                case "C":
                    trazador = new TrazadorDeRutaCiclista();
                    break;
                case "TP":
                    trazador = new TrazadorDeRutaTransportePublico();
                    break;
                default:
                    break;
            }

            return trazador?.trazar_ruta(origen, destino);
        }
    }
}
