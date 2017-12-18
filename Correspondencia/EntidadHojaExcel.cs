using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Correspondencia
{
    class EntidadHojaExcel
    {
        public string nro_recepcion { get; set; }
        public string fecha_recepcion { get; set; }
        public string remitente { get; set; }
        public string asunto { get; set; }
        public string proveido { get; set; }
        public string destinatario { get; set; }
        public string prioridad { get; set; }
        public string fecha_recepcion_destinatario { get; set; }
        public string fecha_respuesta { get; set; }
        public string nro_cite_respuesta { get; set; }
        public string concluido { get; set; }
    }
}
