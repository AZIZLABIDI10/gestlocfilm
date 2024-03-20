namespace Gest_LocFilm
{
    partial class Etat_Adhérent
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
            this.AdherentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AdherentTableAdapter = new Gest_LocFilm.DbLocFilmDataSetTableAdapters.AdherentTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmd_Fin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DbLocFilmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdherentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.AdherentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gest_LocFilm.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(751, 341);
            this.reportViewer1.TabIndex = 0;
            // 
            // DbLocFilmDataSet
            // 
            this.DbLocFilmDataSet.DataSetName = "DbLocFilmDataSet";
            this.DbLocFilmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AdherentBindingSource
            // 
            this.AdherentBindingSource.DataMember = "Adherent";
            this.AdherentBindingSource.DataSource = this.DbLocFilmDataSet;
            // 
            // AdherentTableAdapter
            // 
            this.AdherentTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prévisualisation Etat Des Adhérents";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cmd_Fin
            // 
            this.Cmd_Fin.Location = new System.Drawing.Point(712, 410);
            this.Cmd_Fin.Name = "Cmd_Fin";
            this.Cmd_Fin.Size = new System.Drawing.Size(69, 23);
            this.Cmd_Fin.TabIndex = 18;
            this.Cmd_Fin.Text = "Quitter";
            this.Cmd_Fin.UseVisualStyleBackColor = true;
            this.Cmd_Fin.Click += new System.EventHandler(this.Cmd_Fin_Click);
            // 
            // Etat_Adhérent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 445);
            this.Controls.Add(this.Cmd_Fin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Etat_Adhérent";
            this.Text = "Etat_Adhérent";
            this.Load += new System.EventHandler(this.Etat_Adhérent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DbLocFilmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdherentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AdherentBindingSource;
        private DbLocFilmDataSet DbLocFilmDataSet;
        private DbLocFilmDataSetTableAdapters.AdherentTableAdapter AdherentTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cmd_Fin;
    }
}