using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Correspondencia
{
    public partial class FrmOperaciones : Form
    {
        int id;

        public FrmOperaciones()
        {
            InitializeComponent();
            id = -1;
        }

        public FrmOperaciones(int id_mod)
        {
            InitializeComponent();
            id = id_mod;
        }

        private void FrmOperaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'correspondenciaDataSet.corr_jefatura' Puede moverla o quitarla según sea necesario.
            // this.corr_jefaturaTableAdapter.Fill(this.correspondenciaDataSet.corr_jefatura);
            if (id > 0)
            {
                this.corr_jefaturaTableAdapter.BuscarPorID(this.correspondenciaDataSet.corr_jefatura, id);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (id < 0)
            {
                try { 
                    string nro_recepcion = txtNroRecepcion.Text;
                    string fecha_recepcion = dtpFechaRecepcion.Value.ToShortDateString();
                    string remitente = txtRemitente.Text;
                    string asunto = txtAsunto.Text;
                    string proveido = txtProveido.Text;
                    string destinatario = txtDestinatario.Text;
                    string prioridad = cmbPrioridad.Text;
                    string fecha_recepcion_destinatario = dtpFechaRecepcionDestinatario.Value.ToShortDateString();
                    string fecha_respuesta = dtpFechaRespuesta.Value.ToShortDateString();
                    string nro_cite_respuesta = txtNroCiteRespuesta.Text;
                    string concluido = cmbConcluido.Text;
                    this.corr_jefaturaTableAdapter.Insertar(nro_recepcion, fecha_recepcion, remitente, asunto, proveido, destinatario, prioridad, fecha_recepcion_destinatario, fecha_respuesta, nro_cite_respuesta, concluido);
                    MessageBox.Show("Datos guardados correctamente", "Insertado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    string nro_recepcion = txtNroRecepcion.Text;
                    string fecha_recepcion = dtpFechaRecepcion.Value.ToShortDateString();
                    string remitente = txtRemitente.Text;
                    string asunto = txtAsunto.Text;
                    string proveido = txtProveido.Text;
                    string destinatario = txtDestinatario.Text;
                    string prioridad = cmbPrioridad.Text;
                    string fecha_recepcion_destinatario = dtpFechaRecepcionDestinatario.Value.ToShortDateString();
                    string fecha_respuesta = dtpFechaRespuesta.Value.ToShortDateString();
                    string nro_cite_respuesta = txtNroCiteRespuesta.Text;
                    string concluido = cmbConcluido.Text;
                    this.corr_jefaturaTableAdapter.Modificar(nro_recepcion, fecha_recepcion, remitente, asunto, proveido, destinatario, prioridad, fecha_recepcion_destinatario, fecha_respuesta, nro_cite_respuesta, concluido, id);
                    MessageBox.Show("Datos guardados correctamente", "Modificado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
