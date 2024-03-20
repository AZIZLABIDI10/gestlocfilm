namespace Gest_LocFilm
{
    partial class VisuFilNRet
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
            this.Req_FilmNonRetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DbLocFilmDataSet = new Gest_LocFilm.DbLocFilmDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Req_FilmNonRetTableAdapter = new Gest_LocFilm.DbLocFilmDataSetTableAdapters.Req_FilmNonRetTableAdapter();
            this.Cmd_Fin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Req_FilmNonRetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbLocFilmDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Req_FilmNonRetBindingSource
            // 
            this.Req_FilmNonRetBindingSource.DataMember = "Req_FilmNonRet";
            this.Req_FilmNonRetBindingSource.DataSource = this.DbLocFilmDataSet;
            // 
            // DbLocFilmDataSet
            // 
            this.DbLocFilmDataSet.DataSetName = "DbLocFilmDataSet";
            this.DbLocFilmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Req_FilmNonRetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gest_LocFilm.FilmNonRet.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 85);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(847, 289);
            this.reportViewer1.TabIndex = 0;
            // 
            // Req_FilmNonRetTableAdapter
            // 
            this.Req_FilmNonRetTableAdapter.ClearBeforeFill = true;
            // 
            // Cmd_Fin
            // 
            this.Cmd_Fin.Location = new System.Drawing.Point(783, 380);
            this.Cmd_Fin.Name = "Cmd_Fin";
            this.Cmd_Fin.Size = new System.Drawing.Size(66, 23);
            this.Cmd_Fin.TabIndex = 24;
            this.Cmd_Fin.Text = "Quitter";
            this.Cmd_Fin.UseVisualStyleBackColor = true;
            this.Cmd_Fin.Click += new System.EventHandler(this.Cmd_Fin_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(846, 46);
            this.label1.TabIndex = 23;
            this.label1.Text = "Prévisualisation des Film Loués et Non Retounés";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VisuFilNRet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 412);
            this.Controls.Add(this.Cmd_Fin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "VisuFilNRet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisuFilNRet";
            this.Load += new System.EventHandler(this.VisuFilNRet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Req_FilmNonRetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbLocFilmDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Req_FilmNonRetBindingSource;
        private DbLocFilmDataSet DbLocFilmDataSet;
        private DbLocFilmDataSetTableAdapters.Req_FilmNonRetTableAdapter Req_FilmNonRetTableAdapter;
        private System.Windows.Forms.Button Cmd_Fin;
        private System.Windows.Forms.Label label1;
    }
}