using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;

namespace Correspondencia
{
    public partial class FrmImprimir : Form
    {
        int opcion;

        string nro_recepcion;
        string fecha_recepcion;
        string remitente;
        string asunto;
        string proveido;
        string destinatario;
        string prioridad;
        string fecha_recepcion_destinatario;
        string fecha_respuesta;
        string nro_cite_respuesta;
        string concluido;

        public FrmImprimir(int opcion_param, string nro_recepcion_param, string fecha_recepcion_param, string remitente_param, string asunto_param, string proveido_param, string destinatario_param, string prioridad_param, string fecha_recepcion_destinatario_param, string fecha_respuesta_param, string nro_cite_respuesta_param, string concluido_param)
        {
            InitializeComponent();
            opcion = opcion_param;

            nro_recepcion = nro_recepcion_param;
            fecha_recepcion = fecha_recepcion_param;
            remitente = remitente_param;
            asunto = asunto_param;
            proveido = proveido_param;
            destinatario = destinatario_param;
            prioridad = prioridad_param;
            fecha_recepcion_destinatario = fecha_recepcion_destinatario_param;
            fecha_respuesta = fecha_respuesta_param;
            nro_cite_respuesta = nro_cite_respuesta_param;
            concluido = concluido_param;
        }

        private void FrmImprimir_Load(object sender, EventArgs e)
        {
            dsConsultas ds = new dsConsultas();
            string ConnectionString = "server=localhost;user id=root;database=correspondencia";
            MySqlConnection myConnection = new MySqlConnection();
            myConnection.ConnectionString = ConnectionString;
            myConnection.Open();
            string consulta = "";
            switch (opcion)
            {
                case 0:
                    consulta = "SELECT * FROM `corr_jefatura` WHERE (`nro_recepcion` LIKE CONCAT('%', '" + nro_recepcion + "', '%')) AND (`fecha_recepcion` LIKE CONCAT('%', '" + fecha_recepcion + "', '%')) AND (`remitente` LIKE CONCAT('%', '" + remitente + "', '%')) AND (`asunto` LIKE CONCAT('%', '" + asunto + "', '%')) AND (`proveido` LIKE CONCAT('%', '" + proveido + "', '%')) AND (`destinatario` LIKE CONCAT('%', '" + destinatario + "', '%')) AND (`prioridad` LIKE CONCAT('%', '" + prioridad + "', '%')) AND (`fecha_recepcion_destinatario` LIKE CONCAT('%', '" + fecha_recepcion_destinatario + "', '%')) AND (`fecha_respuesta` LIKE CONCAT('%', '" + fecha_respuesta + "', '%')) AND (`nro_cite_respuesta` LIKE CONCAT('%', '" + nro_cite_respuesta + "', '%')) AND (`concluido` LIKE CONCAT('%', '" + concluido + "', '%'))";
                    break;
                case 1:
                    consulta = "SELECT * FROM `corr_jefatura` WHERE (`nro_recepcion` LIKE CONCAT('%', '" + nro_recepcion + "', '%')) AND (`fecha_recepcion` LIKE CONCAT('%', '" + fecha_recepcion + "', '%')) AND (`remitente` LIKE CONCAT('%', '" + remitente + "', '%')) AND (`asunto` LIKE CONCAT('%', '" + asunto + "', '%')) AND (`proveido` LIKE CONCAT('%', '" + proveido + "', '%')) AND (`destinatario` LIKE CONCAT('%', '" + destinatario + "', '%')) AND (`prioridad` LIKE CONCAT('%', '" + prioridad + "', '%')) AND (`fecha_recepcion_destinatario` LIKE CONCAT('%', '" + fecha_recepcion_destinatario + "', '%')) AND (`nro_cite_respuesta` LIKE CONCAT('%', '" + nro_cite_respuesta + "', '%')) AND (`concluido` LIKE CONCAT('%', '" + concluido + "', '%'))";
                    break;
                case 2:
                    consulta = "SELECT * FROM `corr_jefatura` WHERE (`nro_recepcion` LIKE CONCAT('%', '" + nro_recepcion + "', '%')) AND (`fecha_recepcion` LIKE CONCAT('%', '" + fecha_recepcion + "', '%')) AND (`remitente` LIKE CONCAT('%', '" + remitente + "', '%')) AND (`asunto` LIKE CONCAT('%', '" + asunto + "', '%')) AND (`proveido` LIKE CONCAT('%', '" + proveido + "', '%')) AND (`destinatario` LIKE CONCAT('%', '" + destinatario + "', '%')) AND (`prioridad` LIKE CONCAT('%', '" + prioridad + "', '%')) AND (`fecha_respuesta` LIKE CONCAT('%', '" + fecha_respuesta + "', '%')) AND (`nro_cite_respuesta` LIKE CONCAT('%', '" + nro_cite_respuesta + "', '%')) AND (`concluido` LIKE CONCAT('%', '" + concluido + "', '%'))";
                    break;
                case 3:
                    consulta = "SELECT * FROM `corr_jefatura` WHERE (`nro_recepcion` LIKE CONCAT('%', '" + nro_recepcion + "', '%')) AND (`fecha_recepcion` LIKE CONCAT('%', '" + fecha_recepcion + "', '%')) AND (`remitente` LIKE CONCAT('%', '" + remitente + "', '%')) AND (`asunto` LIKE CONCAT('%', '" + asunto + "', '%')) AND (`proveido` LIKE CONCAT('%', '" + proveido + "', '%')) AND (`destinatario` LIKE CONCAT('%', '" + destinatario + "', '%')) AND (`prioridad` LIKE CONCAT('%', '" + prioridad + "', '%')) AND (`nro_cite_respuesta` LIKE CONCAT('%', '" + nro_cite_respuesta + "', '%')) AND (`concluido` LIKE CONCAT('%', '" + concluido + "', '%'))";
                    break;
                case 4:
                    consulta = "SELECT * FROM `corr_jefatura` WHERE (`nro_recepcion` LIKE CONCAT('%', '" + nro_recepcion + "', '%')) AND (`remitente` LIKE CONCAT('%', '" + remitente + "', '%')) AND (`asunto` LIKE CONCAT('%', '" + asunto + "', '%')) AND (`proveido` LIKE CONCAT('%', '" + proveido + "', '%')) AND (`destinatario` LIKE CONCAT('%', '" + destinatario + "', '%')) AND (`prioridad` LIKE CONCAT('%', '" + prioridad + "', '%')) AND (`fecha_recepcion_destinatario` LIKE CONCAT('%', '" + fecha_recepcion_destinatario + "', '%')) AND (`fecha_respuesta` LIKE CONCAT('%', '" + fecha_respuesta + "', '%')) AND (`nro_cite_respuesta` LIKE CONCAT('%', '" + nro_cite_respuesta + "', '%')) AND (`concluido` LIKE CONCAT('%', '" + concluido + "', '%'))";
                    break;
                case 5:
                    consulta = "SELECT * FROM `corr_jefatura` WHERE (`nro_recepcion` LIKE CONCAT('%', '" + nro_recepcion + "', '%')) AND (`remitente` LIKE CONCAT('%', '" + remitente + "', '%')) AND (`asunto` LIKE CONCAT('%', '" + asunto + "', '%')) AND (`proveido` LIKE CONCAT('%', '" + proveido + "', '%')) AND (`destinatario` LIKE CONCAT('%', '" + destinatario + "', '%')) AND (`prioridad` LIKE CONCAT('%', '" + prioridad + "', '%')) AND (`fecha_recepcion_destinatario` LIKE CONCAT('%', '" + fecha_recepcion_destinatario + "', '%')) AND (`nro_cite_respuesta` LIKE CONCAT('%', '" + nro_cite_respuesta + "', '%')) AND (`concluido` LIKE CONCAT('%', '" + concluido + "', '%'))";
                    break;
                case 6:
                    consulta = "SELECT * FROM `corr_jefatura` WHERE (`nro_recepcion` LIKE CONCAT('%', '" + nro_recepcion + "', '%')) AND (`remitente` LIKE CONCAT('%', '" + remitente + "', '%')) AND (`asunto` LIKE CONCAT('%', '" + asunto + "', '%')) AND (`proveido` LIKE CONCAT('%', '" + proveido + "', '%')) AND (`destinatario` LIKE CONCAT('%', '" + destinatario + "', '%')) AND (`prioridad` LIKE CONCAT('%', '" + prioridad + "', '%')) AND (`fecha_respuesta` LIKE CONCAT('%', '" + fecha_respuesta + "', '%')) AND (`nro_cite_respuesta` LIKE CONCAT('%', '" + nro_cite_respuesta + "', '%')) AND (`concluido` LIKE CONCAT('%', '" + concluido + "', '%'))";
                    break;
                case 7:
                    consulta = "SELECT * FROM `corr_jefatura` WHERE (`nro_recepcion` LIKE CONCAT('%', '" + nro_recepcion + "', '%')) AND (`remitente` LIKE CONCAT('%', '" + remitente + "', '%')) AND (`asunto` LIKE CONCAT('%', '" + asunto + "', '%')) AND (`proveido` LIKE CONCAT('%', '" + proveido + "', '%')) AND (`destinatario` LIKE CONCAT('%', '" + destinatario + "', '%')) AND (`prioridad` LIKE CONCAT('%', '" + prioridad + "', '%')) AND (`nro_cite_respuesta` LIKE CONCAT('%', '" + nro_cite_respuesta + "', '%')) AND (`concluido` LIKE CONCAT('%', '" + concluido + "', '%'))";
                    break;
                default:
                    consulta = "select * from corr_jefatura";
                    break;
            }
            MySqlCommand myCommand = new MySqlCommand();
            MySqlDataAdapter myAdapter = new MySqlDataAdapter(consulta, ConnectionString);
            myAdapter.Fill(ds, ds.Tables[0].TableName);

            ReportDataSource rds = new ReportDataSource("Consulta", ds.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();

            myConnection.Close();
            this.reportViewer1.RefreshReport();
        }
    }
}
