namespace Gest_LocFilm
{
    partial class VisuFilmLouer
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DbLocFilmDataSet = new Gest_LocFilm.DbLocFilmDataSet();
            this.LocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LocationTableAdapter = new Gest_LocFilm.DbLocFilmDataSetTableAdapters.LocationTableAdapter();
            this.Cmd_Fin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DbLocFilmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.LocationBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gest_LocFilm.LocationFilm.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 84);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(874, 313);
            this.reportViewer1.TabIndex = 0;
            // 
            // DbLocFilmDataSet
            // 
            this.DbLocFilmDataSet.DataSetName = "DbLocFilmDataSet";
            this.DbLocFilmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LocationBindingSource
            // 
            this.LocationBindingSource.DataMember = "Location";
            this.LocationBindingSource.DataSource = this.DbLocFilmDataSet;
            // 
            // LocationTableAdapter
            // 
            this.LocationTableAdapter.ClearBeforeFill = true;
            // 
            // Cmd_Fin
            // 
            this.Cmd_Fin.Location = new System.Drawing.Point(613, 413);
            this.Cmd_Fin.Name = "Cmd_Fin";
            this.Cmd_Fin.Size = new System.Drawing.Size(69, 23);
            this.Cmd_Fin.TabIndex = 22;
            this.Cmd_Fin.Text = "Quitter";
            this.Cmd_Fin.UseVisualStyleBackColor = true;
            this.Cmd_Fin.Click += new System.EventHandler(this.Cmd_Fin_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(874, 46);
            this.label1.TabIndex = 21;
            this.label1.Text = "Prévisualisation Etat Des Films Loués";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // VisuFilmLouer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 448);
            this.Controls.Add(this.Cmd_Fin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "VisuFilmLouer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisuFilmLouer";
            this.Load += new System.EventHandler(this.VisuFilmLouer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DbLocFilmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LocationBindingSource;
        private DbLocFilmDataSet DbLocFilmDataSet;
        private DbLocFilmDataSetTableAdapters.LocationTableAdapter LocationTableAdapter;
        private System.Windows.Forms.Button Cmd_Fin;
        private System.Windows.Forms.Label label1;
    }
}