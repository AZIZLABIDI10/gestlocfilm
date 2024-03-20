namespace Gest_LocFilm
{
    partial class Visual_Film
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DbLocFilmDataSet = new Gest_LocFilm.DbLocFilmDataSet();
            this.FilmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FilmTableAdapter = new Gest_LocFilm.DbLocFilmDataSetTableAdapters.FilmTableAdapter();
            this.Cmd_Fin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DbLocFilmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.FilmBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gest_LocFilm.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(31, 70);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(738, 316);
            this.reportViewer1.TabIndex = 0;
            // 
            // DbLocFilmDataSet
            // 
            this.DbLocFilmDataSet.DataSetName = "DbLocFilmDataSet";
            this.DbLocFilmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FilmBindingSource
            // 
            this.FilmBindingSource.DataMember = "Film";
            this.FilmBindingSource.DataSource = this.DbLocFilmDataSet;
            // 
            // FilmTableAdapter
            // 
            this.FilmTableAdapter.ClearBeforeFill = true;
            // 
            // Cmd_Fin
            // 
            this.Cmd_Fin.Location = new System.Drawing.Point(706, 406);
            this.Cmd_Fin.Name = "Cmd_Fin";
            this.Cmd_Fin.Size = new System.Drawing.Size(69, 23);
            this.Cmd_Fin.TabIndex = 20;
            this.Cmd_Fin.Text = "Quitter";
            this.Cmd_Fin.UseVisualStyleBackColor = true;
            this.Cmd_Fin.Click += new System.EventHandler(this.Cmd_Fin_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 46);
            this.label1.TabIndex = 19;
            this.label1.Text = "Prévisualisation Etat Des Films";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Visual_Film
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 434);
            this.Controls.Add(this.Cmd_Fin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Visual_Film";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visual_Film";
            this.Load += new System.EventHandler(this.Visual_Film_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DbLocFilmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilmBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FilmBindingSource;
        private DbLocFilmDataSet DbLocFilmDataSet;
        private DbLocFilmDataSetTableAdapters.FilmTableAdapter FilmTableAdapter;
        private System.Windows.Forms.Button Cmd_Fin;
        private System.Windows.Forms.Label label1;
    }
}