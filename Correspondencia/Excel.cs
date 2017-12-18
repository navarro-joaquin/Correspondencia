using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToExcel;

namespace Correspondencia
{
    class Excel
    {
        private string no_null(string texto)
        {
            if (texto == null)
            {
                return "";
            }
            else
            {
                return texto;
            }
        }

        public List<EntidadHojaExcel> ToEntidadHojaExcelList(string pathDelFicheroExcel)
        {
            var book = new ExcelQueryFactory(pathDelFicheroExcel);
            var resultado = (from row in book.Worksheet("BDD")
                             let item = new EntidadHojaExcel
                             {
                                 nro_recepcion = no_null(row["Nro de recepción"].Cast<string>()),
                                 fecha_recepcion = no_null(row["Fecha de recepción"].Cast<string>()),
                                 remitente = no_null(row["Remitente"].Cast<string>()),
                                 asunto = no_null(row["Asunto"].Cast<string>()),
                                 proveido = no_null(row["Proveído"].Cast<string>()),
                                 destinatario = no_null(row["Destinatario(s)"].Cast<string>()),
                                 prioridad = no_null(row["Prioridad"].Cast<string>()),
                                 fecha_recepcion_destinatario = no_null(row["Fecha recepción destinatario"].Cast<string>()),
                                 fecha_respuesta = no_null(row["Fecha de respuesta"].Cast<string>()),
                                 nro_cite_respuesta = no_null(row["Nro Cite Respuesta"].Cast<string>()),
                                 concluido = no_null(row["¿Concluido?"].Cast<string>())
                             }
                             select item).ToList();
            book.Dispose();
            return resultado;
        }
    }
}
