namespace WinForm_Controle_De_Estoque.Relatorios
{
    partial class frmVisualizaRelatorio
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
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_05579_1_C_1_2017DataSet = new WinForm_Controle_De_Estoque.Dados.DataSet_Dados_do_Banco();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clienteTableAdapter = new WinForm_Controle_De_Estoque.Dados.DataSet_Dados_do_BancoTableAdapters.ClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_05579_1_C_1_2017DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.db_05579_1_C_1_2017DataSet;
            // 
            // db_05579_1_C_1_2017DataSet
            // 
            this.db_05579_1_C_1_2017DataSet.DataSetName = "db_05579_1_C_1_2017DataSet";
            this.db_05579_1_C_1_2017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.clienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WinForm_Controle_De_Estoque.Relatorios.Relatorio_Cliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(750, 386);
            this.reportViewer1.TabIndex = 0;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // frmVisualizaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 386);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmVisualizaRelatorio";
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.frmVisualizaRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_05579_1_C_1_2017DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Dados.DataSet_Dados_do_Banco db_05579_1_C_1_2017DataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private Dados.DataSet_Dados_do_BancoTableAdapters.ClienteTableAdapter clienteTableAdapter;
    }
}