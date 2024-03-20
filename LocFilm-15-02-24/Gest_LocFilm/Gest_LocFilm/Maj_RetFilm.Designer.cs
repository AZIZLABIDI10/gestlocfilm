namespace Gest_LocFilm
{
    partial class Maj_RetFilm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Cbo_Loc = new System.Windows.Forms.ComboBox();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbLocFilmDataSet = new Gest_LocFilm.DbLocFilmDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Lbl_CodFilm = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LBL_CodAd = new System.Windows.Forms.Label();
            this.Lbl_nom = new System.Windows.Forms.Label();
            this.adherentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Lbl_Pren = new System.Windows.Forms.Label();
            this.Lbl_Tire = new System.Windows.Forms.Label();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Lbl_NatFilm = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Lbl_DatLoc = new System.Windows.Forms.Label();
            this.Lbl_DatRet = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Lbl_date = new System.Windows.Forms.Label();
            this.Cmd_Fin = new System.Windows.Forms.Button();
            this.Cmd_Last = new System.Windows.Forms.Button();
            this.Cmd_Prec = new System.Windows.Forms.Button();
            this.Cmd_Suiv = new System.Windows.Forms.Button();
            this.Cmd_First = new System.Windows.Forms.Button();
            this.Cmd_Add = new System.Windows.Forms.Button();
            this.locationTableAdapter = new Gest_LocFilm.DbLocFilmDataSetTableAdapters.LocationTableAdapter();
            this.adherentTableAdapter = new Gest_LocFilm.DbLocFilmDataSetTableAdapters.AdherentTableAdapter();
            this.filmTableAdapter = new Gest_LocFilm.DbLocFilmDataSetTableAdapters.FilmTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLocFilmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 46);
            this.label1.TabIndex = 21;
            this.label1.Text = "MAJ RETOUR  FILM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cbo_Loc
            // 
            this.Cbo_Loc.DataSource = this.locationBindingSource;
            this.Cbo_Loc.DisplayMember = "CodeLoc";
            this.Cbo_Loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Loc.FormattingEnabled = true;
            this.Cbo_Loc.Location = new System.Drawing.Point(126, 90);
            this.Cbo_Loc.Name = "Cbo_Loc";
            this.Cbo_Loc.Size = new System.Drawing.Size(100, 28);
            this.Cbo_Loc.TabIndex = 70;
            this.Cbo_Loc.SelectedIndexChanged += new System.EventHandler(this.Cbo_Loc_SelectedIndexChanged);
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataMember = "Location";
            this.locationBindingSource.DataSource = this.dbLocFilmDataSet;
            // 
            // dbLocFilmDataSet
            // 
            this.dbLocFilmDataSet.DataSetName = "DbLocFilmDataSet";
            this.dbLocFilmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 27);
            this.label2.TabIndex = 69;
            this.label2.Text = "Code Location :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(447, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 27);
            this.label6.TabIndex = 79;
            this.label6.Text = "Nature  :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(191, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 27);
            this.label8.TabIndex = 78;
            this.label8.Text = "Titre :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_CodFilm
            // 
            this.Lbl_CodFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lbl_CodFilm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_CodFilm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locationBindingSource, "CodeFilm", true));
            this.Lbl_CodFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodFilm.Location = new System.Drawing.Point(105, 173);
            this.Lbl_CodFilm.Name = "Lbl_CodFilm";
            this.Lbl_CodFilm.Size = new System.Drawing.Size(80, 27);
            this.Lbl_CodFilm.TabIndex = 77;
            this.Lbl_CodFilm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 27);
            this.label10.TabIndex = 76;
            this.label10.Text = "Code Film :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(251, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 27);
            this.label4.TabIndex = 73;
            this.label4.Text = "Prénom :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 27);
            this.label3.TabIndex = 72;
            this.label3.Text = "Nom : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(245, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 27);
            this.label5.TabIndex = 71;
            this.label5.Text = "Code Adhérent :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBL_CodAd
            // 
            this.LBL_CodAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LBL_CodAd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBL_CodAd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locationBindingSource, "CodeAD", true));
            this.LBL_CodAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CodAd.Location = new System.Drawing.Point(350, 91);
            this.LBL_CodAd.Name = "LBL_CodAd";
            this.LBL_CodAd.Size = new System.Drawing.Size(80, 27);
            this.LBL_CodAd.TabIndex = 82;
            this.LBL_CodAd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_nom
            // 
            this.Lbl_nom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lbl_nom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_nom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "Nom", true));
            this.Lbl_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nom.Location = new System.Drawing.Point(129, 133);
            this.Lbl_nom.Name = "Lbl_nom";
            this.Lbl_nom.Size = new System.Drawing.Size(116, 27);
            this.Lbl_nom.TabIndex = 83;
            this.Lbl_nom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // adherentBindingSource
            // 
            this.adherentBindingSource.DataMember = "Adherent";
            this.adherentBindingSource.DataSource = this.dbLocFilmDataSet;
            // 
            // Lbl_Pren
            // 
            this.Lbl_Pren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lbl_Pren.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Pren.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "Prenom", true));
            this.Lbl_Pren.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Pren.Location = new System.Drawing.Point(337, 133);
            this.Lbl_Pren.Name = "Lbl_Pren";
            this.Lbl_Pren.Size = new System.Drawing.Size(195, 27);
            this.Lbl_Pren.TabIndex = 84;
            this.Lbl_Pren.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Tire
            // 
            this.Lbl_Tire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lbl_Tire.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Tire.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource, "TitreFilm", true));
            this.Lbl_Tire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tire.Location = new System.Drawing.Point(251, 173);
            this.Lbl_Tire.Name = "Lbl_Tire";
            this.Lbl_Tire.Size = new System.Drawing.Size(190, 27);
            this.Lbl_Tire.TabIndex = 85;
            this.Lbl_Tire.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "Film";
            this.filmBindingSource.DataSource = this.dbLocFilmDataSet;
            // 
            // Lbl_NatFilm
            // 
            this.Lbl_NatFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lbl_NatFilm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_NatFilm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource, "NatFilm", true));
            this.Lbl_NatFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NatFilm.Location = new System.Drawing.Point(525, 170);
            this.Lbl_NatFilm.Name = "Lbl_NatFilm";
            this.Lbl_NatFilm.Size = new System.Drawing.Size(122, 32);
            this.Lbl_NatFilm.TabIndex = 86;
            this.Lbl_NatFilm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 217);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 27);
            this.label14.TabIndex = 87;
            this.label14.Text = "Date Location :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_DatLoc
            // 
            this.Lbl_DatLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lbl_DatLoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_DatLoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locationBindingSource, "DateLoc", true));
            this.Lbl_DatLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DatLoc.Location = new System.Drawing.Point(126, 217);
            this.Lbl_DatLoc.Name = "Lbl_DatLoc";
            this.Lbl_DatLoc.Size = new System.Drawing.Size(80, 27);
            this.Lbl_DatLoc.TabIndex = 88;
            this.Lbl_DatLoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_DatRet
            // 
            this.Lbl_DatRet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lbl_DatRet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_DatRet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locationBindingSource, "DateRet", true));
            this.Lbl_DatRet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DatRet.Location = new System.Drawing.Point(343, 217);
            this.Lbl_DatRet.Name = "Lbl_DatRet";
            this.Lbl_DatRet.Size = new System.Drawing.Size(98, 27);
            this.Lbl_DatRet.TabIndex = 90;
            this.Lbl_DatRet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(227, 217);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 27);
            this.label17.TabIndex = 89;
            this.label17.Text = "Date Retour :";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_date
            // 
            this.Lbl_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lbl_date.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_date.Location = new System.Drawing.Point(521, 78);
            this.Lbl_date.Name = "Lbl_date";
            this.Lbl_date.Size = new System.Drawing.Size(113, 27);
            this.Lbl_date.TabIndex = 91;
            this.Lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cmd_Fin
            // 
            this.Cmd_Fin.Location = new System.Drawing.Point(560, 287);
            this.Cmd_Fin.Name = "Cmd_Fin";
            this.Cmd_Fin.Size = new System.Drawing.Size(69, 47);
            this.Cmd_Fin.TabIndex = 100;
            this.Cmd_Fin.Text = "Quitter";
            this.Cmd_Fin.UseVisualStyleBackColor = true;
            this.Cmd_Fin.Click += new System.EventHandler(this.Cmd_Fin_Click);
            // 
            // Cmd_Last
            // 
            this.Cmd_Last.Location = new System.Drawing.Point(296, 304);
            this.Cmd_Last.Name = "Cmd_Last";
            this.Cmd_Last.Size = new System.Drawing.Size(89, 30);
            this.Cmd_Last.TabIndex = 99;
            this.Cmd_Last.Text = "Dernier";
            this.Cmd_Last.UseVisualStyleBackColor = true;
            this.Cmd_Last.Click += new System.EventHandler(this.Cmd_Last_Click);
            // 
            // Cmd_Prec
            // 
            this.Cmd_Prec.Location = new System.Drawing.Point(201, 304);
            this.Cmd_Prec.Name = "Cmd_Prec";
            this.Cmd_Prec.Size = new System.Drawing.Size(89, 30);
            this.Cmd_Prec.TabIndex = 98;
            this.Cmd_Prec.Text = "Précédent";
            this.Cmd_Prec.UseVisualStyleBackColor = true;
            this.Cmd_Prec.Click += new System.EventHandler(this.Cmd_Prec_Click);
            // 
            // Cmd_Suiv
            // 
            this.Cmd_Suiv.Location = new System.Drawing.Point(106, 304);
            this.Cmd_Suiv.Name = "Cmd_Suiv";
            this.Cmd_Suiv.Size = new System.Drawing.Size(89, 30);
            this.Cmd_Suiv.TabIndex = 97;
            this.Cmd_Suiv.Text = "Suivant";
            this.Cmd_Suiv.UseVisualStyleBackColor = true;
            this.Cmd_Suiv.Click += new System.EventHandler(this.Cmd_Suiv_Click);
            // 
            // Cmd_First
            // 
            this.Cmd_First.Location = new System.Drawing.Point(11, 304);
            this.Cmd_First.Name = "Cmd_First";
            this.Cmd_First.Size = new System.Drawing.Size(89, 30);
            this.Cmd_First.TabIndex = 96;
            this.Cmd_First.Text = "Début";
            this.Cmd_First.UseVisualStyleBackColor = true;
            this.Cmd_First.Click += new System.EventHandler(this.Cmd_First_Click);
            // 
            // Cmd_Add
            // 
            this.Cmd_Add.Location = new System.Drawing.Point(11, 257);
            this.Cmd_Add.Name = "Cmd_Add";
            this.Cmd_Add.Size = new System.Drawing.Size(89, 30);
            this.Cmd_Add.TabIndex = 93;
            this.Cmd_Add.Text = "Enregistrer";
            this.Cmd_Add.UseVisualStyleBackColor = true;
            this.Cmd_Add.Click += new System.EventHandler(this.Cmd_Add_Click);
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // adherentTableAdapter
            // 
            this.adherentTableAdapter.ClearBeforeFill = true;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locationBindingSource, "FilmRetourner", true));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(563, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 27);
            this.label7.TabIndex = 102;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(447, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 27);
            this.label9.TabIndex = 101;
            this.label9.Text = "Film Retouné :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Maj_RetFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Cmd_Fin);
            this.Controls.Add(this.Cmd_Last);
            this.Controls.Add(this.Cmd_Prec);
            this.Controls.Add(this.Cmd_Suiv);
            this.Controls.Add(this.Cmd_First);
            this.Controls.Add(this.Cmd_Add);
            this.Controls.Add(this.Lbl_date);
            this.Controls.Add(this.Lbl_DatRet);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Lbl_DatLoc);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Lbl_NatFilm);
            this.Controls.Add(this.Lbl_Tire);
            this.Controls.Add(this.Lbl_Pren);
            this.Controls.Add(this.Lbl_nom);
            this.Controls.Add(this.LBL_CodAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Lbl_CodFilm);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cbo_Loc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Maj_RetFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maj_RetFilm";
            this.Load += new System.EventHandler(this.Maj_RetFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLocFilmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbo_Loc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Lbl_CodFilm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBL_CodAd;
        private System.Windows.Forms.Label Lbl_nom;
        private System.Windows.Forms.Label Lbl_Pren;
        private System.Windows.Forms.Label Lbl_Tire;
        private System.Windows.Forms.Label Lbl_NatFilm;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Lbl_DatLoc;
        private System.Windows.Forms.Label Lbl_DatRet;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label Lbl_date;
        private System.Windows.Forms.Button Cmd_Fin;
        private System.Windows.Forms.Button Cmd_Last;
        private System.Windows.Forms.Button Cmd_Prec;
        private System.Windows.Forms.Button Cmd_Suiv;
        private System.Windows.Forms.Button Cmd_First;
        private System.Windows.Forms.Button Cmd_Add;
        private DbLocFilmDataSet dbLocFilmDataSet;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private DbLocFilmDataSetTableAdapters.LocationTableAdapter locationTableAdapter;
        private System.Windows.Forms.BindingSource adherentBindingSource;
        private DbLocFilmDataSetTableAdapters.AdherentTableAdapter adherentTableAdapter;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private DbLocFilmDataSetTableAdapters.FilmTableAdapter filmTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}