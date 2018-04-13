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
    public partial class FrmPrincipal : Form
    {
        int opcion = -1;

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

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'correspondenciaDataSet.corr_jefatura' Puede moverla o quitarla según sea necesario.
            this.corr_jefaturaTableAdapter.Fill(this.correspondenciaDataSet.corr_jefatura);
        }

        private void actualizar_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.corr_jefaturaTableAdapter.Fill(this.correspondenciaDataSet.corr_jefatura);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmOperaciones agregar = new FrmOperaciones();
            agregar.FormClosed += new FormClosedEventHandler(actualizar_FormClosed);
            agregar.Text = "Nuevo";
            agregar.ShowDialog();
        }

        private void btnVerModificar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvCorrespondencia.CurrentRow.Cells[0].Value);
            FrmOperaciones modificar = new FrmOperaciones(id);
            modificar.FormClosed += new FormClosedEventHandler(actualizar_FormClosed);
            modificar.Text = "Ver/Modificar";
            modificar.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            nro_recepcion = txtNroRecepcion.Text;
            fecha_recepcion = dtpFechaRecepcion.Value.ToShortDateString();
            remitente = txtRemitente.Text;
            asunto = txtAsunto.Text;
            proveido = txtProveido.Text;
            destinatario = txtDestinatario.Text;
            prioridad = cmbPrioridad.Text;
            fecha_recepcion_destinatario = dtpFechaRecepcionDestinatario.Value.ToShortDateString();
            fecha_respuesta = dtpFechaRespuesta.Value.ToShortDateString();
            nro_cite_respuesta = txtNroCiteRespuesta.Text;
            concluido = cmbConcluido.Text;
            if (chkRecepcion.Checked && chkRecepcionDestinatario.Checked && !chkRespuesta.Checked)
            {
                this.corr_jefaturaTableAdapter.BuscarCaso1(this.correspondenciaDataSet.corr_jefatura, nro_recepcion, fecha_recepcion, remitente, asunto, proveido, destinatario, prioridad, fecha_recepcion_destinatario, nro_cite_respuesta, concluido);
                opcion = 1;
            }
            else
            {
                if (chkRecepcion.Checked && !chkRecepcionDestinatario.Checked && chkRespuesta.Checked)
                {
                    this.corr_jefaturaTableAdapter.BuscarCaso2(this.correspondenciaDataSet.corr_jefatura, nro_recepcion, fecha_recepcion, remitente, asunto, proveido, destinatario, prioridad, fecha_respuesta, nro_cite_respuesta, concluido);
                    opcion = 2;
                }
                else
                {
                    if (chkRecepcion.Checked && !chkRecepcionDestinatario.Checked && !chkRespuesta.Checked)
                    {
                        this.corr_jefaturaTableAdapter.BuscarCaso3(this.correspondenciaDataSet.corr_jefatura, nro_recepcion, fecha_recepcion, remitente, asunto, proveido, destinatario, prioridad, nro_cite_respuesta, concluido);
                        opcion = 3;
                    }
                    else
                    {
                        if (!chkRecepcion.Checked && chkRecepcionDestinatario.Checked && chkRespuesta.Checked)
                        {
                            this.corr_jefaturaTableAdapter.BuscarCaso4(this.correspondenciaDataSet.corr_jefatura, nro_recepcion, remitente, asunto, proveido, destinatario, prioridad, fecha_recepcion_destinatario, fecha_respuesta, nro_cite_respuesta, concluido);
                            opcion = 4;
                        }
                        else
                        {
                            if (!chkRecepcion.Checked && chkRecepcionDestinatario.Checked && !chkRespuesta.Checked)
                            {
                                this.corr_jefaturaTableAdapter.BuscarCaso5(this.correspondenciaDataSet.corr_jefatura, nro_recepcion, remitente, asunto, proveido, destinatario, prioridad, fecha_recepcion_destinatario, nro_cite_respuesta, concluido);
                                opcion = 5;
                            }
                            else
                            {
                                if (!chkRecepcion.Checked && !chkRecepcionDestinatario.Checked && chkRespuesta.Checked)
                                {
                                    this.corr_jefaturaTableAdapter.BuscarCaso6(this.correspondenciaDataSet.corr_jefatura, nro_recepcion, remitente, asunto, proveido, destinatario, prioridad, fecha_respuesta, nro_cite_respuesta, concluido);
                                    opcion = 6;
                                }
                                else
                                {
                                    if (!chkRecepcion.Checked && !chkRecepcionDestinatario.Checked && !chkRespuesta.Checked)
                                    {
                                        this.corr_jefaturaTableAdapter.BuscarCaso7(this.correspondenciaDataSet.corr_jefatura, nro_recepcion, remitente, asunto, proveido, destinatario, prioridad, nro_cite_respuesta, concluido);
                                        opcion = 7;
                                    }
                                    else
                                    {
                                        this.corr_jefaturaTableAdapter.BuscarCaso0(this.correspondenciaDataSet.corr_jefatura, nro_recepcion, fecha_recepcion, remitente, asunto, proveido, destinatario, prioridad, fecha_recepcion_destinatario, fecha_respuesta, nro_cite_respuesta, concluido);
                                        opcion = 0;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivos de Excel (*xls;*xlsx;*xlsm)|*xls;*xlsx;*xlsm";

            dialog.Title = "Seleccione el archivo Excel a importar";

            dialog.FileName = string.Empty;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string ruta_al_archivo = dialog.FileName;
                string version = ruta_al_archivo.Substring(ruta_al_archivo.Length - 1);
                leerDatosExcel(ruta_al_archivo, version);
            }
        }

        private void leerDatosExcel(string ruta_al_archivo, string version)
        {
            var excel = new Excel();
            var resultado = excel.ToEntidadHojaExcelList(ruta_al_archivo);

            int nuevos = 0;
            int duplicados = 0;

            foreach(EntidadHojaExcel hoja in resultado)
            {
                string nro_recepcion = hoja.nro_recepcion;
                string fecha_recepcion = "";
                if (!(hoja.fecha_recepcion.Equals("")))
                {
                    fecha_recepcion = hoja.fecha_recepcion.Substring(0, 10);
                } 
                string remitente = hoja.remitente;
                string asunto = hoja.asunto;
                string proveido = hoja.proveido;
                string destinatario = hoja.destinatario;
                string prioridad = hoja.prioridad;
                string fecha_recepcion_destinatario = "";
                string fecha_respuesta = "";
                if (!(hoja.fecha_recepcion_destinatario.Equals("")))
                {
                    fecha_recepcion_destinatario = hoja.fecha_recepcion_destinatario.Substring(0, 10);
                }
                if (!(hoja.fecha_respuesta.Equals("")))
                {
                    fecha_respuesta = hoja.fecha_respuesta.Substring(0, 10);
                }
                string nro_cite_respuesta = hoja.nro_cite_respuesta;
                string concluido = hoja.concluido;
                int duplicado = Convert.ToInt32(this.corr_jefaturaTableAdapter.BuscarDuplicados(nro_recepcion, fecha_recepcion, remitente, asunto, proveido, destinatario, prioridad, fecha_recepcion_destinatario, fecha_respuesta, nro_cite_respuesta, concluido));
                try
                {
                    if (duplicado <= 0)
                    {
                        this.corr_jefaturaTableAdapter.Insertar(nro_recepcion, fecha_recepcion, remitente, asunto, proveido, destinatario, prioridad, fecha_recepcion_destinatario, fecha_respuesta, nro_cite_respuesta, concluido);
                        //MessageBox.Show("Fila importada correctamente", "Importando desde Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        nuevos++;
                    }
                    else
                    {
                        //MessageBox.Show("Datos duplicados encontrados\nNo serán importados a la base de datos", "Importando desde Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        duplicados++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            MessageBox.Show("Se encontraron " + nuevos + " registros nuevos y " + duplicados + " registros duplicados", "Importando desde Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.corr_jefaturaTableAdapter.Fill(this.correspondenciaDataSet.corr_jefatura);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FrmImprimir imprimir = new FrmImprimir(opcion, nro_recepcion, fecha_recepcion, remitente, asunto, proveido, destinatario, prioridad, fecha_recepcion_destinatario, fecha_respuesta, nro_cite_respuesta, concluido);
            imprimir.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Está seguro que desea eliminar el valor seleccionado?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.OK)
            {
                try
                {
                    int id = Convert.ToInt32(dgvCorrespondencia.CurrentRow.Cells[0].Value);
                    this.corr_jefaturaTableAdapter.Eliminar(id);
                    MessageBox.Show("Datos eliminados con éxito", "Eliminado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.corr_jefaturaTableAdapter.Fill(this.correspondenciaDataSet.corr_jefatura);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            this.corr_jefaturaTableAdapter.Fill(this.correspondenciaDataSet.corr_jefatura);
            opcion = -1;
        }
    }
}
