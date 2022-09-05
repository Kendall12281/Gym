namespace ExamenGym.Layeres.UI.Reporte
{
    partial class frmRepRutinasPorCliente
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
            this.examen2021CIIIDataSetReporte = new ExamenGym.Examen2021CIIIDataSetReporte();
            this.pASeleccionarRutinasPorClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pA_SeleccionarRutinasPorClientesTableAdapter = new ExamenGym.Examen2021CIIIDataSetReporteTableAdapters.PA_SeleccionarRutinasPorClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.examen2021CIIIDataSetReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASeleccionarRutinasPorClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetReporte";
            reportDataSource1.Value = this.pASeleccionarRutinasPorClientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ExamenGym.Layeres.UI.Reporte.Reportes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(771, 575);
            this.reportViewer1.TabIndex = 0;
            // 
            // examen2021CIIIDataSetReporte
            // 
            this.examen2021CIIIDataSetReporte.DataSetName = "Examen2021CIIIDataSetReporte";
            this.examen2021CIIIDataSetReporte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pASeleccionarRutinasPorClientesBindingSource
            // 
            this.pASeleccionarRutinasPorClientesBindingSource.DataMember = "PA_SeleccionarRutinasPorClientes";
            this.pASeleccionarRutinasPorClientesBindingSource.DataSource = this.examen2021CIIIDataSetReporte;
            // 
            // pA_SeleccionarRutinasPorClientesTableAdapter
            // 
            this.pA_SeleccionarRutinasPorClientesTableAdapter.ClearBeforeFill = true;
            // 
            // frmRepRutinasPorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 575);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRepRutinasPorCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examen Gym - Reporte de Rutinas por Cliente";
            this.Load += new System.EventHandler(this.frmRepRutinasPorCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examen2021CIIIDataSetReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASeleccionarRutinasPorClientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Examen2021CIIIDataSetReporte examen2021CIIIDataSetReporte;
        private System.Windows.Forms.BindingSource pASeleccionarRutinasPorClientesBindingSource;
        private Examen2021CIIIDataSetReporteTableAdapters.PA_SeleccionarRutinasPorClientesTableAdapter pA_SeleccionarRutinasPorClientesTableAdapter;
    }
}