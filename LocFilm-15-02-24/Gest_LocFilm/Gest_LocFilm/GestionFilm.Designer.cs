namespace Gest_LocFilm
{
    partial class GestionFilm
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
            this.Cbo_Pram = new System.Windows.Forms.ComboBox();
            this.paramBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbLocFilmDataSet = new Gest_LocFilm.DbLocFilmDataSet();
            this.Cmd_Fin = new System.Windows.Forms.Button();
            this.Cmd_Last = new System.Windows.Forms.Button();
            this.Cmd_Prec = new System.Windows.Forms.Button();
            this.Cmd_Suiv = new System.Windows.Forms.Button();
            this.Cmd_First = new System.Windows.Forms.Button();
            this.Cmd_Sup = new System.Windows.Forms.Button();
            this.Cmd_Modif = new System.Windows.Forms.Button();
            this.Cmd_Add = new System.Windows.Forms.Button();
            this.cmd_New = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Lbl_CodAd = new System.Windows.Forms.Label();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Titre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cbo_NatFilm = new System.Windows.Forms.ComboBox();
            this.natFilmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbLocFilmDataSet2 = new Gest_LocFilm.DbLocFilmDataSet();
            this.Txt_DatTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Ploc = new System.Windows.Forms.MaskedTextBox();
            this.paramTableAdapter = new Gest_LocFilm.DbLocFilmDataSetTableAdapters.ParamTableAdapter();
            this.filmTableAdapter = new Gest_LocFilm.DbLocFilmDataSetTableAdapters.FilmTableAdapter();
            this.txt_nbrCopie = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dbLocFilmDataSet1 = new Gest_LocFilm.DbLocFilmDataSet();
            this.natFilmTableAdapter = new Gest_LocFilm.DbLocFilmDataSetTableAdapters.NatFilmTableAdapter();
            this.Cbo_NatF_TabF = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.paramBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLocFilmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.natFilmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLocFilmDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLocFilmDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cbo_Pram
            // 
            this.Cbo_Pram.DataSource = this.paramBindingSource;
            this.Cbo_Pram.DisplayMember = "CodF";
            this.Cbo_Pram.FormattingEnabled = true;
            this.Cbo_Pram.Location = new System.Drawing.Point(452, 277);
            this.Cbo_Pram.Name = "Cbo_Pram";
            this.Cbo_Pram.Size = new System.Drawing.Size(68, 21);
            this.Cbo_Pram.TabIndex = 33;
            // 
            // paramBindingSource
            // 
            this.paramBindingSource.DataMember = "Param";
            this.paramBindingSource.DataSource = this.dbLocFilmDataSet;
            // 
            // dbLocFilmDataSet
            // 
            this.dbLocFilmDataSet.DataSetName = "DbLocFilmDataSet";
            this.dbLocFilmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Cmd_Fin
            // 
            this.Cmd_Fin.Location = new System.Drawing.Point(574, 263);
            this.Cmd_Fin.Name = "Cmd_Fin";
            this.Cmd_Fin.Size = new System.Drawing.Size(69, 47);
            this.Cmd_Fin.TabIndex = 32;
            this.Cmd_Fin.Text = "Quitter";
            this.Cmd_Fin.UseVisualStyleBackColor = true;
            this.Cmd_Fin.Click += new System.EventHandler(this.Cmd_Fin_Click);
            // 
            // Cmd_Last
            // 
            this.Cmd_Last.Location = new System.Drawing.Point(310, 280);
            this.Cmd_Last.Name = "Cmd_Last";
            this.Cmd_Last.Size = new System.Drawing.Size(89, 30);
            this.Cmd_Last.TabIndex = 31;
            this.Cmd_Last.Text = "Dernier";
            this.Cmd_Last.UseVisualStyleBackColor = true;
            this.Cmd_Last.Click += new System.EventHandler(this.Cmd_Last_Click);
            // 
            // Cmd_Prec
            // 
            this.Cmd_Prec.Location = new System.Drawing.Point(215, 280);
            this.Cmd_Prec.Name = "Cmd_Prec";
            this.Cmd_Prec.Size = new System.Drawing.Size(89, 30);
            this.Cmd_Prec.TabIndex = 30;
            this.Cmd_Prec.Text = "Précédent";
            this.Cmd_Prec.UseVisualStyleBackColor = true;
            this.Cmd_Prec.Click += new System.EventHandler(this.Cmd_Prec_Click);
            // 
            // Cmd_Suiv
            // 
            this.Cmd_Suiv.Location = new System.Drawing.Point(120, 280);
            this.Cmd_Suiv.Name = "Cmd_Suiv";
            this.Cmd_Suiv.Size = new System.Drawing.Size(89, 30);
            this.Cmd_Suiv.TabIndex = 29;
            this.Cmd_Suiv.Text = "Suivant";
            this.Cmd_Suiv.UseVisualStyleBackColor = true;
            this.Cmd_Suiv.Click += new System.EventHandler(this.Cmd_Suiv_Click);
            // 
            // Cmd_First
            // 
            this.Cmd_First.Location = new System.Drawing.Point(25, 280);
            this.Cmd_First.Name = "Cmd_First";
            this.Cmd_First.Size = new System.Drawing.Size(89, 30);
            this.Cmd_First.TabIndex = 28;
            this.Cmd_First.Text = "Début";
            this.Cmd_First.UseVisualStyleBackColor = true;
            this.Cmd_First.Click += new System.EventHandler(this.Cmd_First_Click);
            // 
            // Cmd_Sup
            // 
            this.Cmd_Sup.Location = new System.Drawing.Point(310, 244);
            this.Cmd_Sup.Name = "Cmd_Sup";
            this.Cmd_Sup.Size = new System.Drawing.Size(89, 30);
            this.Cmd_Sup.TabIndex = 27;
            this.Cmd_Sup.Text = "Suprimer";
            this.Cmd_Sup.UseVisualStyleBackColor = true;
            this.Cmd_Sup.Click += new System.EventHandler(this.Cmd_Sup_Click);
            // 
            // Cmd_Modif
            // 
            this.Cmd_Modif.Location = new System.Drawing.Point(215, 244);
            this.Cmd_Modif.Name = "Cmd_Modif";
            this.Cmd_Modif.Size = new System.Drawing.Size(89, 30);
            this.Cmd_Modif.TabIndex = 26;
            this.Cmd_Modif.Text = "Modifier";
            this.Cmd_Modif.UseVisualStyleBackColor = true;
            this.Cmd_Modif.Click += new System.EventHandler(this.Cmd_Modif_Click);
            // 
            // Cmd_Add
            // 
            this.Cmd_Add.Location = new System.Drawing.Point(120, 244);
            this.Cmd_Add.Name = "Cmd_Add";
            this.Cmd_Add.Size = new System.Drawing.Size(89, 30);
            this.Cmd_Add.TabIndex = 25;
            this.Cmd_Add.Text = "Enregistrer";
            this.Cmd_Add.UseVisualStyleBackColor = true;
            this.Cmd_Add.Click += new System.EventHandler(this.Cmd_Add_Click);
            // 
            // cmd_New
            // 
            this.cmd_New.Location = new System.Drawing.Point(25, 244);
            this.cmd_New.Name = "cmd_New";
            this.cmd_New.Size = new System.Drawing.Size(89, 30);
            this.cmd_New.TabIndex = 24;
            this.cmd_New.Text = "Nouveau";
            this.cmd_New.UseVisualStyleBackColor = true;
            this.cmd_New.Click += new System.EventHandler(this.cmd_New_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 27);
            this.label6.TabIndex = 22;
            this.label6.Text = "Date Sortie  :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_CodAd
            // 
            this.Lbl_CodAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lbl_CodAd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_CodAd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource, "CodeFilm", true));
            this.Lbl_CodAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodAd.Location = new System.Drawing.Point(120, 134);
            this.Lbl_CodAd.Name = "Lbl_CodAd";
            this.Lbl_CodAd.Size = new System.Drawing.Size(80, 27);
            this.Lbl_CodAd.TabIndex = 21;
            this.Lbl_CodAd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "Film";
            this.filmBindingSource.DataSource = this.dbLocFilmDataSet;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 27);
            this.label2.TabIndex = 20;
            this.label2.Text = "Code Film :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 46);
            this.label1.TabIndex = 19;
            this.label1.Text = "MAJ Film";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Titre
            // 
            this.Txt_Titre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource, "TitreFilm", true));
            this.Txt_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Titre.Location = new System.Drawing.Point(293, 135);
            this.Txt_Titre.Name = "Txt_Titre";
            this.Txt_Titre.Size = new System.Drawing.Size(185, 26);
            this.Txt_Titre.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(499, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 27);
            this.label4.TabIndex = 35;
            this.label4.Text = "Nature  :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 27);
            this.label3.TabIndex = 34;
            this.label3.Text = "Titre :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cbo_NatFilm
            // 
            this.Cbo_NatFilm.DataSource = this.natFilmBindingSource;
            this.Cbo_NatFilm.DisplayMember = "NatFilm";
            this.Cbo_NatFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_NatFilm.FormattingEnabled = true;
            this.Cbo_NatFilm.Location = new System.Drawing.Point(585, 134);
            this.Cbo_NatFilm.Name = "Cbo_NatFilm";
            this.Cbo_NatFilm.Size = new System.Drawing.Size(134, 28);
            this.Cbo_NatFilm.TabIndex = 37;
            // 
            // natFilmBindingSource
            // 
            this.natFilmBindingSource.DataMember = "NatFilm";
            this.natFilmBindingSource.DataSource = this.dbLocFilmDataSet2;
            // 
            // dbLocFilmDataSet2
            // 
            this.dbLocFilmDataSet2.DataSetName = "DbLocFilmDataSet";
            this.dbLocFilmDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Txt_DatTime
            // 
            this.Txt_DatTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource, "DateSFilm", true));
            this.Txt_DatTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_DatTime.Location = new System.Drawing.Point(120, 199);
            this.Txt_DatTime.Name = "Txt_DatTime";
            this.Txt_DatTime.Size = new System.Drawing.Size(226, 24);
            this.Txt_DatTime.TabIndex = 38;
            this.Txt_DatTime.Value = new System.DateTime(2020, 2, 15, 10, 53, 0, 0);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(361, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 27);
            this.label5.TabIndex = 39;
            this.label5.Text = "P.U. Loc :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_Ploc
            // 
            this.Txt_Ploc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource, "PuLocF", true));
            this.Txt_Ploc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Ploc.Location = new System.Drawing.Point(447, 199);
            this.Txt_Ploc.Mask = "99.999";
            this.Txt_Ploc.Name = "Txt_Ploc";
            this.Txt_Ploc.Size = new System.Drawing.Size(92, 24);
            this.Txt_Ploc.TabIndex = 40;
            // 
            // paramTableAdapter
            // 
            this.paramTableAdapter.ClearBeforeFill = true;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // txt_nbrCopie
            // 
            this.txt_nbrCopie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource, "PuLocF", true));
            this.txt_nbrCopie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nbrCopie.Location = new System.Drawing.Point(644, 197);
            this.txt_nbrCopie.Mask = "99";
            this.txt_nbrCopie.Name = "txt_nbrCopie";
            this.txt_nbrCopie.Size = new System.Drawing.Size(56, 24);
            this.txt_nbrCopie.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(543, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 27);
            this.label7.TabIndex = 41;
            this.label7.Text = "Nbre Copie :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dbLocFilmDataSet1
            // 
            this.dbLocFilmDataSet1.DataSetName = "DbLocFilmDataSet";
            this.dbLocFilmDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // natFilmTableAdapter
            // 
            this.natFilmTableAdapter.ClearBeforeFill = true;
            // 
            // Cbo_NatF_TabF
            // 
            this.Cbo_NatF_TabF.DataSource = this.filmBindingSource;
            this.Cbo_NatF_TabF.DisplayMember = "NatFilm";
            this.Cbo_NatF_TabF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_NatF_TabF.FormattingEnabled = true;
            this.Cbo_NatF_TabF.Location = new System.Drawing.Point(585, 134);
            this.Cbo_NatF_TabF.Name = "Cbo_NatF_TabF";
            this.Cbo_NatF_TabF.Size = new System.Drawing.Size(134, 28);
            this.Cbo_NatF_TabF.TabIndex = 43;
            // 
            // GestionFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 346);
            this.Controls.Add(this.Cbo_NatF_TabF);
            this.Controls.Add(this.txt_nbrCopie);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_Ploc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_DatTime);
            this.Controls.Add(this.Cbo_NatFilm);
            this.Controls.Add(this.Txt_Titre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cbo_Pram);
            this.Controls.Add(this.Cmd_Fin);
            this.Controls.Add(this.Cmd_Last);
            this.Controls.Add(this.Cmd_Prec);
            this.Controls.Add(this.Cmd_Suiv);
            this.Controls.Add(this.Cmd_First);
            this.Controls.Add(this.Cmd_Sup);
            this.Controls.Add(this.Cmd_Modif);
            this.Controls.Add(this.Cmd_Add);
            this.Controls.Add(this.cmd_New);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Lbl_CodAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GestionFilm";
            this.Text = "GestionFilm";
            this.Load += new System.EventHandler(this.GestionFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paramBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLocFilmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.natFilmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLocFilmDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLocFilmDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cbo_Pram;
        private System.Windows.Forms.Button Cmd_Fin;
        private System.Windows.Forms.Button Cmd_Last;
        private System.Windows.Forms.Button Cmd_Prec;
        private System.Windows.Forms.Button Cmd_Suiv;
        private System.Windows.Forms.Button Cmd_First;
        private System.Windows.Forms.Button Cmd_Sup;
        private System.Windows.Forms.Button Cmd_Modif;
        private System.Windows.Forms.Button Cmd_Add;
        private System.Windows.Forms.Button cmd_New;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lbl_CodAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Titre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cbo_NatFilm;
        private System.Windows.Forms.DateTimePicker Txt_DatTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox Txt_Ploc;
        private DbLocFilmDataSet dbLocFilmDataSet;
        private System.Windows.Forms.BindingSource paramBindingSource;
        private DbLocFilmDataSetTableAdapters.ParamTableAdapter paramTableAdapter;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private DbLocFilmDataSetTableAdapters.FilmTableAdapter filmTableAdapter;
        private System.Windows.Forms.MaskedTextBox txt_nbrCopie;
        private System.Windows.Forms.Label label7;
        private DbLocFilmDataSet dbLocFilmDataSet1;
        private DbLocFilmDataSet dbLocFilmDataSet2;
        private System.Windows.Forms.BindingSource natFilmBindingSource;
        private DbLocFilmDataSetTableAdapters.NatFilmTableAdapter natFilmTableAdapter;
        private System.Windows.Forms.ComboBox Cbo_NatF_TabF;
    }
}