﻿namespace Correspondencia
{
    partial class FrmImprimir
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BusquedaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsConsultas = new Correspondencia.dsConsultas();
            ((System.ComponentModel.ISupportInitialize)(this.BusquedaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BusquedaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Correspondencia.Reporte.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(895, 415);
            this.reportViewer1.TabIndex = 0;
            // 
            // BusquedaBindingSource
            // 
            this.BusquedaBindingSource.DataMember = "Busqueda";
            this.BusquedaBindingSource.DataSource = this.dsConsultas;
            // 
            // dsConsultas
            // 
            this.dsConsultas.DataSetName = "dsConsultas";
            this.dsConsultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmImprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 415);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmImprimir";
            this.Text = "FrmImprimir";
            this.Load += new System.EventHandler(this.FrmImprimir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BusquedaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConsultas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BusquedaBindingSource;
        private dsConsultas dsConsultas;
    }
}