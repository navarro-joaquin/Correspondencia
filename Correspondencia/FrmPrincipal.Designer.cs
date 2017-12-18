namespace Correspondencia
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCorrespondencia = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corr_jefaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.correspondenciaDataSet = new Correspondencia.correspondenciaDataSet();
            this.corr_jefaturaTableAdapter = new Correspondencia.correspondenciaDataSetTableAdapters.corr_jefaturaTableAdapter();
            this.tableAdapterManager = new Correspondencia.correspondenciaDataSetTableAdapters.TableAdapterManager();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnVerModificar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbConcluido = new System.Windows.Forms.ComboBox();
            this.lblConcluido = new System.Windows.Forms.Label();
            this.txtNroCiteRespuesta = new System.Windows.Forms.TextBox();
            this.lblNroCiteRespuesta = new System.Windows.Forms.Label();
            this.chkFechaRespuesta = new System.Windows.Forms.CheckBox();
            this.chkRecepcionDestinatario = new System.Windows.Forms.CheckBox();
            this.dtpFechaRespuesta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaRespuesta = new System.Windows.Forms.Label();
            this.dtpFechaRecepcionDestinatario = new System.Windows.Forms.DateTimePicker();
            this.lblFechaRecepciónDestinatario = new System.Windows.Forms.Label();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.txtProveido = new System.Windows.Forms.TextBox();
            this.lblProveido = new System.Windows.Forms.Label();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.txtRemitente = new System.Windows.Forms.TextBox();
            this.lblRemitente = new System.Windows.Forms.Label();
            this.dtpFechaRecepcion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaRecepcion = new System.Windows.Forms.Label();
            this.txtNroRecepcion = new System.Windows.Forms.TextBox();
            this.lblNroRecepcion = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrespondencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corr_jefaturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correspondenciaDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCorrespondencia);
            this.groupBox1.Location = new System.Drawing.Point(12, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Correspondencia";
            // 
            // dgvCorrespondencia
            // 
            this.dgvCorrespondencia.AllowUserToAddRows = false;
            this.dgvCorrespondencia.AllowUserToDeleteRows = false;
            this.dgvCorrespondencia.AutoGenerateColumns = false;
            this.dgvCorrespondencia.BackgroundColor = System.Drawing.Color.White;
            this.dgvCorrespondencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorrespondencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgvCorrespondencia.DataSource = this.corr_jefaturaBindingSource;
            this.dgvCorrespondencia.Location = new System.Drawing.Point(6, 21);
            this.dgvCorrespondencia.Name = "dgvCorrespondencia";
            this.dgvCorrespondencia.ReadOnly = true;
            this.dgvCorrespondencia.Size = new System.Drawing.Size(861, 301);
            this.dgvCorrespondencia.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nro_recepcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nro de recepción";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fecha_recepcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha de recepción";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "remitente";
            this.dataGridViewTextBoxColumn4.HeaderText = "Remitente";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "asunto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Asunto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "proveido";
            this.dataGridViewTextBoxColumn6.HeaderText = "Proveído";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "destinatario";
            this.dataGridViewTextBoxColumn7.HeaderText = "Destinatario(s)";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "prioridad";
            this.dataGridViewTextBoxColumn8.HeaderText = "Prioridad";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "fecha_recepcion_destinatario";
            this.dataGridViewTextBoxColumn9.HeaderText = "Fecha de recepción destinatario";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "fecha_respuesta";
            this.dataGridViewTextBoxColumn10.HeaderText = "Fecha de respuesta";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "nro_cite_respuesta";
            this.dataGridViewTextBoxColumn11.HeaderText = "Nro CITE respuesta";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "concluido";
            this.dataGridViewTextBoxColumn12.HeaderText = "¿Concluido?";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
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
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 528);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(94, 41);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnVerModificar
            // 
            this.btnVerModificar.Location = new System.Drawing.Point(790, 528);
            this.btnVerModificar.Name = "btnVerModificar";
            this.btnVerModificar.Size = new System.Drawing.Size(103, 41);
            this.btnVerModificar.TabIndex = 2;
            this.btnVerModificar.Text = "&Ver/Modificar";
            this.btnVerModificar.UseVisualStyleBackColor = true;
            this.btnVerModificar.Click += new System.EventHandler(this.btnVerModificar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.cmbConcluido);
            this.groupBox2.Controls.Add(this.lblConcluido);
            this.groupBox2.Controls.Add(this.txtNroCiteRespuesta);
            this.groupBox2.Controls.Add(this.lblNroCiteRespuesta);
            this.groupBox2.Controls.Add(this.chkFechaRespuesta);
            this.groupBox2.Controls.Add(this.chkRecepcionDestinatario);
            this.groupBox2.Controls.Add(this.dtpFechaRespuesta);
            this.groupBox2.Controls.Add(this.lblFechaRespuesta);
            this.groupBox2.Controls.Add(this.dtpFechaRecepcionDestinatario);
            this.groupBox2.Controls.Add(this.lblFechaRecepciónDestinatario);
            this.groupBox2.Controls.Add(this.cmbPrioridad);
            this.groupBox2.Controls.Add(this.lblPrioridad);
            this.groupBox2.Controls.Add(this.txtDestinatario);
            this.groupBox2.Controls.Add(this.lblDestinatario);
            this.groupBox2.Controls.Add(this.txtProveido);
            this.groupBox2.Controls.Add(this.lblProveido);
            this.groupBox2.Controls.Add(this.txtAsunto);
            this.groupBox2.Controls.Add(this.lblAsunto);
            this.groupBox2.Controls.Add(this.txtRemitente);
            this.groupBox2.Controls.Add(this.lblRemitente);
            this.groupBox2.Controls.Add(this.dtpFechaRecepcion);
            this.groupBox2.Controls.Add(this.lblFechaRecepcion);
            this.groupBox2.Controls.Add(this.txtNroRecepcion);
            this.groupBox2.Controls.Add(this.lblNroRecepcion);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(881, 176);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(616, 134);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(251, 23);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbConcluido
            // 
            this.cmbConcluido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConcluido.FormattingEnabled = true;
            this.cmbConcluido.Items.AddRange(new object[] {
            "",
            "Sí",
            "No"});
            this.cmbConcluido.Location = new System.Drawing.Point(493, 133);
            this.cmbConcluido.Name = "cmbConcluido";
            this.cmbConcluido.Size = new System.Drawing.Size(69, 24);
            this.cmbConcluido.TabIndex = 23;
            // 
            // lblConcluido
            // 
            this.lblConcluido.AutoSize = true;
            this.lblConcluido.Location = new System.Drawing.Point(405, 141);
            this.lblConcluido.Name = "lblConcluido";
            this.lblConcluido.Size = new System.Drawing.Size(82, 16);
            this.lblConcluido.TabIndex = 22;
            this.lblConcluido.Text = "¿Concluido?";
            // 
            // txtNroCiteRespuesta
            // 
            this.txtNroCiteRespuesta.Location = new System.Drawing.Point(174, 130);
            this.txtNroCiteRespuesta.Name = "txtNroCiteRespuesta";
            this.txtNroCiteRespuesta.Size = new System.Drawing.Size(100, 22);
            this.txtNroCiteRespuesta.TabIndex = 21;
            // 
            // lblNroCiteRespuesta
            // 
            this.lblNroCiteRespuesta.AutoSize = true;
            this.lblNroCiteRespuesta.Location = new System.Drawing.Point(8, 136);
            this.lblNroCiteRespuesta.Name = "lblNroCiteRespuesta";
            this.lblNroCiteRespuesta.Size = new System.Drawing.Size(160, 16);
            this.lblNroCiteRespuesta.TabIndex = 20;
            this.lblNroCiteRespuesta.Text = "Nro de Cite de respuesta:";
            // 
            // chkFechaRespuesta
            // 
            this.chkFechaRespuesta.AutoSize = true;
            this.chkFechaRespuesta.Location = new System.Drawing.Point(852, 104);
            this.chkFechaRespuesta.Name = "chkFechaRespuesta";
            this.chkFechaRespuesta.Size = new System.Drawing.Size(15, 14);
            this.chkFechaRespuesta.TabIndex = 19;
            this.chkFechaRespuesta.UseVisualStyleBackColor = true;
            // 
            // chkRecepcionDestinatario
            // 
            this.chkRecepcionDestinatario.AutoSize = true;
            this.chkRecepcionDestinatario.Location = new System.Drawing.Point(852, 63);
            this.chkRecepcionDestinatario.Name = "chkRecepcionDestinatario";
            this.chkRecepcionDestinatario.Size = new System.Drawing.Size(15, 14);
            this.chkRecepcionDestinatario.TabIndex = 18;
            this.chkRecepcionDestinatario.UseVisualStyleBackColor = true;
            // 
            // dtpFechaRespuesta
            // 
            this.dtpFechaRespuesta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRespuesta.Location = new System.Drawing.Point(751, 100);
            this.dtpFechaRespuesta.Name = "dtpFechaRespuesta";
            this.dtpFechaRespuesta.Size = new System.Drawing.Size(91, 22);
            this.dtpFechaRespuesta.TabIndex = 17;
            // 
            // lblFechaRespuesta
            // 
            this.lblFechaRespuesta.AutoSize = true;
            this.lblFechaRespuesta.Location = new System.Drawing.Point(613, 105);
            this.lblFechaRespuesta.Name = "lblFechaRespuesta";
            this.lblFechaRespuesta.Size = new System.Drawing.Size(131, 16);
            this.lblFechaRespuesta.TabIndex = 16;
            this.lblFechaRespuesta.Text = "Fecha de respuesta:";
            // 
            // dtpFechaRecepcionDestinatario
            // 
            this.dtpFechaRecepcionDestinatario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRecepcionDestinatario.Location = new System.Drawing.Point(751, 59);
            this.dtpFechaRecepcionDestinatario.Name = "dtpFechaRecepcionDestinatario";
            this.dtpFechaRecepcionDestinatario.Size = new System.Drawing.Size(91, 22);
            this.dtpFechaRecepcionDestinatario.TabIndex = 15;
            // 
            // lblFechaRecepciónDestinatario
            // 
            this.lblFechaRecepciónDestinatario.Location = new System.Drawing.Point(620, 53);
            this.lblFechaRecepciónDestinatario.Name = "lblFechaRecepciónDestinatario";
            this.lblFechaRecepciónDestinatario.Size = new System.Drawing.Size(128, 35);
            this.lblFechaRecepciónDestinatario.TabIndex = 14;
            this.lblFechaRecepciónDestinatario.Text = "Fecha de recepción destinatario:";
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Items.AddRange(new object[] {
            "",
            "Urgente",
            "Normal",
            "Baja"});
            this.cmbPrioridad.Location = new System.Drawing.Point(493, 103);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(108, 24);
            this.cmbPrioridad.TabIndex = 13;
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Location = new System.Drawing.Point(421, 112);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(66, 16);
            this.lblPrioridad.TabIndex = 12;
            this.lblPrioridad.Text = "Prioridad:";
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Location = new System.Drawing.Point(111, 102);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(284, 22);
            this.txtDestinatario.TabIndex = 11;
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Location = new System.Drawing.Point(7, 108);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(98, 16);
            this.lblDestinatario.TabIndex = 10;
            this.lblDestinatario.Text = "Destinatario(s):";
            // 
            // txtProveido
            // 
            this.txtProveido.Location = new System.Drawing.Point(89, 75);
            this.txtProveido.Name = "txtProveido";
            this.txtProveido.Size = new System.Drawing.Size(512, 22);
            this.txtProveido.TabIndex = 9;
            // 
            // lblProveido
            // 
            this.lblProveido.AutoSize = true;
            this.lblProveido.Location = new System.Drawing.Point(8, 81);
            this.lblProveido.Name = "lblProveido";
            this.lblProveido.Size = new System.Drawing.Size(66, 16);
            this.lblProveido.TabIndex = 8;
            this.lblProveido.Text = "Proveído:";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(89, 47);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(512, 22);
            this.txtAsunto.TabIndex = 7;
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Location = new System.Drawing.Point(8, 53);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(52, 16);
            this.lblAsunto.TabIndex = 6;
            this.lblAsunto.Text = "Asunto:";
            // 
            // txtRemitente
            // 
            this.txtRemitente.Location = new System.Drawing.Point(571, 19);
            this.txtRemitente.MaxLength = 200;
            this.txtRemitente.Name = "txtRemitente";
            this.txtRemitente.Size = new System.Drawing.Size(296, 22);
            this.txtRemitente.TabIndex = 5;
            // 
            // lblRemitente
            // 
            this.lblRemitente.AutoSize = true;
            this.lblRemitente.Location = new System.Drawing.Point(490, 25);
            this.lblRemitente.Name = "lblRemitente";
            this.lblRemitente.Size = new System.Drawing.Size(72, 16);
            this.lblRemitente.TabIndex = 4;
            this.lblRemitente.Text = "Remitente:";
            // 
            // dtpFechaRecepcion
            // 
            this.dtpFechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRecepcion.Location = new System.Drawing.Point(383, 19);
            this.dtpFechaRecepcion.Name = "dtpFechaRecepcion";
            this.dtpFechaRecepcion.Size = new System.Drawing.Size(90, 22);
            this.dtpFechaRecepcion.TabIndex = 3;
            // 
            // lblFechaRecepcion
            // 
            this.lblFechaRecepcion.AutoSize = true;
            this.lblFechaRecepcion.Location = new System.Drawing.Point(245, 24);
            this.lblFechaRecepcion.Name = "lblFechaRecepcion";
            this.lblFechaRecepcion.Size = new System.Drawing.Size(131, 16);
            this.lblFechaRecepcion.TabIndex = 2;
            this.lblFechaRecepcion.Text = "Fecha de recepción:";
            // 
            // txtNroRecepcion
            // 
            this.txtNroRecepcion.Location = new System.Drawing.Point(129, 17);
            this.txtNroRecepcion.MaxLength = 10;
            this.txtNroRecepcion.Name = "txtNroRecepcion";
            this.txtNroRecepcion.Size = new System.Drawing.Size(100, 22);
            this.txtNroRecepcion.TabIndex = 1;
            // 
            // lblNroRecepcion
            // 
            this.lblNroRecepcion.AutoSize = true;
            this.lblNroRecepcion.Location = new System.Drawing.Point(7, 25);
            this.lblNroRecepcion.Name = "lblNroRecepcion";
            this.lblNroRecepcion.Size = new System.Drawing.Size(115, 16);
            this.lblNroRecepcion.TabIndex = 0;
            this.lblNroRecepcion.Text = "Nro de recepción:";
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(510, 528);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(103, 41);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.Text = "Importar desde &Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(650, 528);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(103, 40);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FrmPrincipal
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 581);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnVerModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrespondencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corr_jefaturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correspondenciaDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private correspondenciaDataSet correspondenciaDataSet;
        private System.Windows.Forms.BindingSource corr_jefaturaBindingSource;
        private correspondenciaDataSetTableAdapters.corr_jefaturaTableAdapter corr_jefaturaTableAdapter;
        private correspondenciaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvCorrespondencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnVerModificar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbConcluido;
        private System.Windows.Forms.Label lblConcluido;
        private System.Windows.Forms.TextBox txtNroCiteRespuesta;
        private System.Windows.Forms.Label lblNroCiteRespuesta;
        private System.Windows.Forms.CheckBox chkFechaRespuesta;
        private System.Windows.Forms.CheckBox chkRecepcionDestinatario;
        private System.Windows.Forms.DateTimePicker dtpFechaRespuesta;
        private System.Windows.Forms.Label lblFechaRespuesta;
        private System.Windows.Forms.DateTimePicker dtpFechaRecepcionDestinatario;
        private System.Windows.Forms.Label lblFechaRecepciónDestinatario;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.TextBox txtProveido;
        private System.Windows.Forms.Label lblProveido;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.TextBox txtRemitente;
        private System.Windows.Forms.Label lblRemitente;
        private System.Windows.Forms.DateTimePicker dtpFechaRecepcion;
        private System.Windows.Forms.Label lblFechaRecepcion;
        private System.Windows.Forms.TextBox txtNroRecepcion;
        private System.Windows.Forms.Label lblNroRecepcion;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnImprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

