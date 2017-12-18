namespace Correspondencia
{
    partial class FrmOperaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblNroRecepcion;
            System.Windows.Forms.Label lblFechaRecepcion;
            System.Windows.Forms.Label lblRemitente;
            System.Windows.Forms.Label lblAsunto;
            System.Windows.Forms.Label lblProveido;
            System.Windows.Forms.Label lblDestinatario;
            System.Windows.Forms.Label lblPrioridad;
            System.Windows.Forms.Label lblFechaRecepcionDestinatario;
            System.Windows.Forms.Label lblFechaRespuesta;
            System.Windows.Forms.Label lblNroCiteRespuesta;
            System.Windows.Forms.Label lblConcluido;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNroRecepcion = new System.Windows.Forms.TextBox();
            this.corr_jefaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.correspondenciaDataSet = new Correspondencia.correspondenciaDataSet();
            this.dtpFechaRecepcion = new System.Windows.Forms.DateTimePicker();
            this.txtRemitente = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.txtProveido = new System.Windows.Forms.TextBox();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.dtpFechaRecepcionDestinatario = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaRespuesta = new System.Windows.Forms.DateTimePicker();
            this.txtNroCiteRespuesta = new System.Windows.Forms.TextBox();
            this.cmbConcluido = new System.Windows.Forms.ComboBox();
            this.corr_jefaturaTableAdapter = new Correspondencia.correspondenciaDataSetTableAdapters.corr_jefaturaTableAdapter();
            this.tableAdapterManager = new Correspondencia.correspondenciaDataSetTableAdapters.TableAdapterManager();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            lblNroRecepcion = new System.Windows.Forms.Label();
            lblFechaRecepcion = new System.Windows.Forms.Label();
            lblRemitente = new System.Windows.Forms.Label();
            lblAsunto = new System.Windows.Forms.Label();
            lblProveido = new System.Windows.Forms.Label();
            lblDestinatario = new System.Windows.Forms.Label();
            lblPrioridad = new System.Windows.Forms.Label();
            lblFechaRecepcionDestinatario = new System.Windows.Forms.Label();
            lblFechaRespuesta = new System.Windows.Forms.Label();
            lblNroCiteRespuesta = new System.Windows.Forms.Label();
            lblConcluido = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.corr_jefaturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correspondenciaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNroRecepcion
            // 
            lblNroRecepcion.AutoSize = true;
            lblNroRecepcion.Location = new System.Drawing.Point(22, 24);
            lblNroRecepcion.Name = "lblNroRecepcion";
            lblNroRecepcion.Size = new System.Drawing.Size(118, 16);
            lblNroRecepcion.TabIndex = 0;
            lblNroRecepcion.Text = "Nro. de recepción:";
            // 
            // lblFechaRecepcion
            // 
            lblFechaRecepcion.AutoSize = true;
            lblFechaRecepcion.Location = new System.Drawing.Point(354, 24);
            lblFechaRecepcion.Name = "lblFechaRecepcion";
            lblFechaRecepcion.Size = new System.Drawing.Size(131, 16);
            lblFechaRecepcion.TabIndex = 2;
            lblFechaRecepcion.Text = "Fecha de recepción:";
            // 
            // lblRemitente
            // 
            lblRemitente.AutoSize = true;
            lblRemitente.Location = new System.Drawing.Point(22, 59);
            lblRemitente.Name = "lblRemitente";
            lblRemitente.Size = new System.Drawing.Size(72, 16);
            lblRemitente.TabIndex = 4;
            lblRemitente.Text = "Remitente:";
            // 
            // lblAsunto
            // 
            lblAsunto.AutoSize = true;
            lblAsunto.Location = new System.Drawing.Point(115, 90);
            lblAsunto.Name = "lblAsunto";
            lblAsunto.Size = new System.Drawing.Size(52, 16);
            lblAsunto.TabIndex = 6;
            lblAsunto.Text = "Asunto:";
            // 
            // lblProveido
            // 
            lblProveido.AutoSize = true;
            lblProveido.Location = new System.Drawing.Point(419, 90);
            lblProveido.Name = "lblProveido";
            lblProveido.Size = new System.Drawing.Size(66, 16);
            lblProveido.TabIndex = 8;
            lblProveido.Text = "Proveído:";
            // 
            // lblDestinatario
            // 
            lblDestinatario.AutoSize = true;
            lblDestinatario.Location = new System.Drawing.Point(22, 261);
            lblDestinatario.Name = "lblDestinatario";
            lblDestinatario.Size = new System.Drawing.Size(98, 16);
            lblDestinatario.TabIndex = 10;
            lblDestinatario.Text = "Destinatario(s):";
            // 
            // lblPrioridad
            // 
            lblPrioridad.AutoSize = true;
            lblPrioridad.Location = new System.Drawing.Point(22, 294);
            lblPrioridad.Name = "lblPrioridad";
            lblPrioridad.Size = new System.Drawing.Size(66, 16);
            lblPrioridad.TabIndex = 12;
            lblPrioridad.Text = "Prioridad:";
            // 
            // lblFechaRecepcionDestinatario
            // 
            lblFechaRecepcionDestinatario.Location = new System.Drawing.Point(22, 325);
            lblFechaRecepcionDestinatario.Name = "lblFechaRecepcionDestinatario";
            lblFechaRecepcionDestinatario.Size = new System.Drawing.Size(131, 34);
            lblFechaRecepcionDestinatario.TabIndex = 14;
            lblFechaRecepcionDestinatario.Text = "Fecha de recepción destinatario:";
            // 
            // lblFechaRespuesta
            // 
            lblFechaRespuesta.AutoSize = true;
            lblFechaRespuesta.Location = new System.Drawing.Point(337, 336);
            lblFechaRespuesta.Name = "lblFechaRespuesta";
            lblFechaRespuesta.Size = new System.Drawing.Size(131, 16);
            lblFechaRespuesta.TabIndex = 16;
            lblFechaRespuesta.Text = "Fecha de respuesta:";
            // 
            // lblNroCiteRespuesta
            // 
            lblNroCiteRespuesta.Location = new System.Drawing.Point(23, 367);
            lblNroCiteRespuesta.Name = "lblNroCiteRespuesta";
            lblNroCiteRespuesta.Size = new System.Drawing.Size(117, 38);
            lblNroCiteRespuesta.TabIndex = 18;
            lblNroCiteRespuesta.Text = "Nro. de Cite de respuesta:";
            // 
            // lblConcluido
            // 
            lblConcluido.AutoSize = true;
            lblConcluido.Location = new System.Drawing.Point(337, 380);
            lblConcluido.Name = "lblConcluido";
            lblConcluido.Size = new System.Drawing.Size(82, 16);
            lblConcluido.TabIndex = 20;
            lblConcluido.Text = "¿Concluido?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(lblNroRecepcion);
            this.groupBox1.Controls.Add(this.txtNroRecepcion);
            this.groupBox1.Controls.Add(lblFechaRecepcion);
            this.groupBox1.Controls.Add(this.dtpFechaRecepcion);
            this.groupBox1.Controls.Add(lblRemitente);
            this.groupBox1.Controls.Add(this.txtRemitente);
            this.groupBox1.Controls.Add(lblAsunto);
            this.groupBox1.Controls.Add(this.txtAsunto);
            this.groupBox1.Controls.Add(lblProveido);
            this.groupBox1.Controls.Add(this.txtProveido);
            this.groupBox1.Controls.Add(lblDestinatario);
            this.groupBox1.Controls.Add(this.txtDestinatario);
            this.groupBox1.Controls.Add(lblPrioridad);
            this.groupBox1.Controls.Add(this.cmbPrioridad);
            this.groupBox1.Controls.Add(lblFechaRecepcionDestinatario);
            this.groupBox1.Controls.Add(this.dtpFechaRecepcionDestinatario);
            this.groupBox1.Controls.Add(lblFechaRespuesta);
            this.groupBox1.Controls.Add(this.dtpFechaRespuesta);
            this.groupBox1.Controls.Add(lblNroCiteRespuesta);
            this.groupBox1.Controls.Add(this.txtNroCiteRespuesta);
            this.groupBox1.Controls.Add(lblConcluido);
            this.groupBox1.Controls.Add(this.cmbConcluido);
            this.groupBox1.Location = new System.Drawing.Point(13, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 421);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // txtNroRecepcion
            // 
            this.txtNroRecepcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corr_jefaturaBindingSource, "nro_recepcion", true));
            this.txtNroRecepcion.Location = new System.Drawing.Point(146, 18);
            this.txtNroRecepcion.MaxLength = 10;
            this.txtNroRecepcion.Name = "txtNroRecepcion";
            this.txtNroRecepcion.Size = new System.Drawing.Size(117, 22);
            this.txtNroRecepcion.TabIndex = 1;
            // 
            // corr_jefaturaBindingSource
            // 
            this.corr_jefaturaBindingSource.DataMember = "corr_jefatura";
            this.corr_jefaturaBindingSource.DataSource = this.correspondenciaDataSet;
            // 
            // correspondenciaDataSet
            // 
            this.correspondenciaDataSet.DataSetName = "correspondenciaDataSet";
            this.correspondenciaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpFechaRecepcion
            // 
            this.dtpFechaRecepcion.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.corr_jefaturaBindingSource, "fecha_recepcion", true));
            this.dtpFechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRecepcion.Location = new System.Drawing.Point(491, 16);
            this.dtpFechaRecepcion.Name = "dtpFechaRecepcion";
            this.dtpFechaRecepcion.Size = new System.Drawing.Size(117, 22);
            this.dtpFechaRecepcion.TabIndex = 3;
            // 
            // txtRemitente
            // 
            this.txtRemitente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corr_jefaturaBindingSource, "remitente", true));
            this.txtRemitente.Location = new System.Drawing.Point(146, 53);
            this.txtRemitente.MaxLength = 200;
            this.txtRemitente.Name = "txtRemitente";
            this.txtRemitente.Size = new System.Drawing.Size(339, 22);
            this.txtRemitente.TabIndex = 5;
            // 
            // txtAsunto
            // 
            this.txtAsunto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corr_jefaturaBindingSource, "asunto", true));
            this.txtAsunto.Location = new System.Drawing.Point(25, 121);
            this.txtAsunto.MaxLength = 1000;
            this.txtAsunto.Multiline = true;
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAsunto.Size = new System.Drawing.Size(229, 119);
            this.txtAsunto.TabIndex = 7;
            // 
            // txtProveido
            // 
            this.txtProveido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corr_jefaturaBindingSource, "proveido", true));
            this.txtProveido.Location = new System.Drawing.Point(295, 121);
            this.txtProveido.MaxLength = 2000;
            this.txtProveido.Multiline = true;
            this.txtProveido.Name = "txtProveido";
            this.txtProveido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProveido.Size = new System.Drawing.Size(313, 119);
            this.txtProveido.TabIndex = 9;
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corr_jefaturaBindingSource, "destinatario", true));
            this.txtDestinatario.Location = new System.Drawing.Point(146, 255);
            this.txtDestinatario.MaxLength = 1000;
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(339, 22);
            this.txtDestinatario.TabIndex = 11;
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corr_jefaturaBindingSource, "prioridad", true));
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Items.AddRange(new object[] {
            "Urgente",
            "Normal",
            "Baja"});
            this.cmbPrioridad.Location = new System.Drawing.Point(146, 286);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(108, 24);
            this.cmbPrioridad.TabIndex = 13;
            // 
            // dtpFechaRecepcionDestinatario
            // 
            this.dtpFechaRecepcionDestinatario.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.corr_jefaturaBindingSource, "fecha_recepcion_destinatario", true));
            this.dtpFechaRecepcionDestinatario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRecepcionDestinatario.Location = new System.Drawing.Point(159, 330);
            this.dtpFechaRecepcionDestinatario.Name = "dtpFechaRecepcionDestinatario";
            this.dtpFechaRecepcionDestinatario.Size = new System.Drawing.Size(117, 22);
            this.dtpFechaRecepcionDestinatario.TabIndex = 15;
            // 
            // dtpFechaRespuesta
            // 
            this.dtpFechaRespuesta.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.corr_jefaturaBindingSource, "fecha_respuesta", true));
            this.dtpFechaRespuesta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRespuesta.Location = new System.Drawing.Point(491, 331);
            this.dtpFechaRespuesta.Name = "dtpFechaRespuesta";
            this.dtpFechaRespuesta.Size = new System.Drawing.Size(117, 22);
            this.dtpFechaRespuesta.TabIndex = 17;
            // 
            // txtNroCiteRespuesta
            // 
            this.txtNroCiteRespuesta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corr_jefaturaBindingSource, "nro_cite_respuesta", true));
            this.txtNroCiteRespuesta.Location = new System.Drawing.Point(159, 374);
            this.txtNroCiteRespuesta.MaxLength = 10;
            this.txtNroCiteRespuesta.Name = "txtNroCiteRespuesta";
            this.txtNroCiteRespuesta.Size = new System.Drawing.Size(117, 22);
            this.txtNroCiteRespuesta.TabIndex = 19;
            // 
            // cmbConcluido
            // 
            this.cmbConcluido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.corr_jefaturaBindingSource, "concluido", true));
            this.cmbConcluido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConcluido.FormattingEnabled = true;
            this.cmbConcluido.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.cmbConcluido.Location = new System.Drawing.Point(491, 377);
            this.cmbConcluido.Name = "cmbConcluido";
            this.cmbConcluido.Size = new System.Drawing.Size(117, 24);
            this.cmbConcluido.TabIndex = 21;
            // 
            // corr_jefaturaTableAdapter
            // 
            this.corr_jefaturaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.corr_jefaturaTableAdapter = this.corr_jefaturaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Correspondencia.correspondenciaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(159, 431);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 36);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(382, 431);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(88, 36);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 482);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOperaciones";
            this.Text = "FrmOperaciones";
            this.Load += new System.EventHandler(this.FrmOperaciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.corr_jefaturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correspondenciaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private correspondenciaDataSet correspondenciaDataSet;
        private System.Windows.Forms.BindingSource corr_jefaturaBindingSource;
        private correspondenciaDataSetTableAdapters.corr_jefaturaTableAdapter corr_jefaturaTableAdapter;
        private correspondenciaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtNroRecepcion;
        private System.Windows.Forms.DateTimePicker dtpFechaRecepcion;
        private System.Windows.Forms.TextBox txtRemitente;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.TextBox txtProveido;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.DateTimePicker dtpFechaRecepcionDestinatario;
        private System.Windows.Forms.DateTimePicker dtpFechaRespuesta;
        private System.Windows.Forms.TextBox txtNroCiteRespuesta;
        private System.Windows.Forms.ComboBox cmbConcluido;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
    }
}