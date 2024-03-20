namespace Gest_LocFilm
{
    partial class GestLocF
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
            this.Txt_Pren = new System.Windows.Forms.TextBox();
            this.adherentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbLocFilmDataSet = new Gest_LocFilm.DbLocFilmDataSet();
            this.Txt_Nom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nbrCopie = new System.Windows.Forms.MaskedTextBox();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Ploc = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Titre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Lbl_CodFilm = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Cbo_Pram = new System.Windows.Forms.ComboBox();
            this.paramBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Cmd_Fin = new System.Windows.Forms.Button();
            this.Cmd_Sup = new System.Windows.Forms.Button();
            this.Cmd_Modif = new System.Windows.Forms.Button();
            this.Cmd_Add = new System.Windows.Forms.Button();
            this.cmd_New = new System.Windows.Forms.Button();
            this.DGV_Film = new System.Windows.Forms.DataGridView();
            this.codeFilmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titreFilmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.natFilmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbCopieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puLocFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmTableAdapter = new Gest_LocFilm.DbLocFilmDataSetTableAdapters.FilmTableAdapter();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_MontLoc = new System.Windows.Forms.TextBox();
            this.Txt_NatFilm = new System.Windows.Forms.TextBox();
            this.adherentTableAdapter = new Gest_LocFilm.DbLocFilmDataSetTableAdapters.AdherentTableAdapter();
            this.Cbo_CodAd = new System.Windows.Forms.ComboBox();
            this.paramTableAdapter = new Gest_LocFilm.DbLocFilmDataSetTableAdapters.ParamTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_NbCopL = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_CodLoc = new System.Windows.Forms.Label();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.locationTableAdapter = new Gest_LocFilm.DbLocFilmDataSetTableAdapters.LocationTableAdapter();
            this.label12 = new System.Windows.Forms.Label();
            this.Lbl_NbCopieLoc = new System.Windows.Forms.Label();
            this.filmNRetADBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.filmNRetADBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmNRetADTableAdapter = new Gest_LocFilm.DbLocFilmDataSetTableAdapters.FilmNRetADTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLocFilmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Film)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmNRetADBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmNRetADBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 46);
            this.label1.TabIndex = 20;
            this.label1.Text = "MAJ LOCATION FILM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Pren
            // 
            this.Txt_Pren.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "Prenom", true));
            this.Txt_Pren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Pren.Location = new System.Drawing.Point(388, 117);
            this.Txt_Pren.Name = "Txt_Pren";
            this.Txt_Pren.Size = new System.Drawing.Size(179, 26);
            this.Txt_Pren.TabIndex = 26;
            // 
            // adherentBindingSource
            // 
            this.adherentBindingSource.DataMember = "Adherent";
            this.adherentBindingSource.DataSource = this.dbLocFilmDataSet;
            // 
            // dbLocFilmDataSet
            // 
            this.dbLocFilmDataSet.DataSetName = "DbLocFilmDataSet";
            this.dbLocFilmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Txt_Nom
            // 
            this.Txt_Nom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "Nom", true));
            this.Txt_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nom.Location = new System.Drawing.Point(110, 117);
            this.Txt_Nom.Name = "Txt_Nom";
            this.Txt_Nom.Size = new System.Drawing.Size(175, 26);
            this.Txt_Nom.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(303, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 27);
            this.label4.TabIndex = 23;
            this.label4.Text = "Prénom :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 27);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nom : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 27);
            this.label2.TabIndex = 21;
            this.label2.Text = "Code Adhérent :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_nbrCopie
            // 
            this.txt_nbrCopie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource, "NbCopie", true));
            this.txt_nbrCopie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nbrCopie.Location = new System.Drawing.Point(307, 192);
            this.txt_nbrCopie.Mask = "99";
            this.txt_nbrCopie.Name = "txt_nbrCopie";
            this.txt_nbrCopie.Size = new System.Drawing.Size(56, 24);
            this.txt_nbrCopie.TabIndex = 52;
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "Film";
            this.filmBindingSource.DataSource = this.dbLocFilmDataSet;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(206, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 27);
            this.label7.TabIndex = 51;
            this.label7.Text = "Nbre Copie :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_Ploc
            // 
            this.Txt_Ploc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource, "PuLocF", true));
            this.Txt_Ploc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Ploc.Location = new System.Drawing.Point(110, 193);
            this.Txt_Ploc.Mask = "99.999";
            this.Txt_Ploc.Name = "Txt_Ploc";
            this.Txt_Ploc.Size = new System.Drawing.Size(92, 24);
            this.Txt_Ploc.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 27);
            this.label5.TabIndex = 49;
            this.label5.Text = "P.U. Loc :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_Titre
            // 
            this.Txt_Titre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource, "TitreFilm", true));
            this.Txt_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Titre.Location = new System.Drawing.Point(291, 155);
            this.Txt_Titre.Name = "Txt_Titre";
            this.Txt_Titre.Size = new System.Drawing.Size(185, 26);
            this.Txt_Titre.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(482, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 27);
            this.label6.TabIndex = 47;
            this.label6.Text = "Nature  :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(205, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 27);
            this.label8.TabIndex = 46;
            this.label8.Text = "Titre :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_CodFilm
            // 
            this.Lbl_CodFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lbl_CodFilm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_CodFilm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource, "CodeFilm", true));
            this.Lbl_CodFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodFilm.Location = new System.Drawing.Point(118, 154);
            this.Lbl_CodFilm.Name = "Lbl_CodFilm";
            this.Lbl_CodFilm.Size = new System.Drawing.Size(80, 27);
            this.Lbl_CodFilm.TabIndex = 45;
            this.Lbl_CodFilm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 27);
            this.label10.TabIndex = 44;
            this.label10.Text = "Code Film :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cbo_Pram
            // 
            this.Cbo_Pram.DataSource = this.paramBindingSource;
            this.Cbo_Pram.DisplayMember = "CodL";
            this.Cbo_Pram.FormattingEnabled = true;
            this.Cbo_Pram.Location = new System.Drawing.Point(444, 358);
            this.Cbo_Pram.Name = "Cbo_Pram";
            this.Cbo_Pram.Size = new System.Drawing.Size(68, 21);
            this.Cbo_Pram.TabIndex = 63;
            // 
            // paramBindingSource
            // 
            this.paramBindingSource.DataMember = "Param";
            this.paramBindingSource.DataSource = this.dbLocFilmDataSet;
            // 
            // Cmd_Fin
            // 
            this.Cmd_Fin.Location = new System.Drawing.Point(560, 352);
            this.Cmd_Fin.Name = "Cmd_Fin";
            this.Cmd_Fin.Size = new System.Drawing.Size(92, 30);
            this.Cmd_Fin.TabIndex = 62;
            this.Cmd_Fin.Text = "Quitter";
            this.Cmd_Fin.UseVisualStyleBackColor = true;
            this.Cmd_Fin.Click += new System.EventHandler(this.Cmd_Fin_Click);
            // 
            // Cmd_Sup
            // 
            this.Cmd_Sup.Location = new System.Drawing.Point(320, 352);
            this.Cmd_Sup.Name = "Cmd_Sup";
            this.Cmd_Sup.Size = new System.Drawing.Size(89, 30);
            this.Cmd_Sup.TabIndex = 57;
            this.Cmd_Sup.Text = "Suprimer";
            this.Cmd_Sup.UseVisualStyleBackColor = true;
            this.Cmd_Sup.Click += new System.EventHandler(this.Cmd_Sup_Click);
            // 
            // Cmd_Modif
            // 
            this.Cmd_Modif.Location = new System.Drawing.Point(225, 352);
            this.Cmd_Modif.Name = "Cmd_Modif";
            this.Cmd_Modif.Size = new System.Drawing.Size(89, 30);
            this.Cmd_Modif.TabIndex = 56;
            this.Cmd_Modif.Text = "Modifier";
            this.Cmd_Modif.UseVisualStyleBackColor = true;
            this.Cmd_Modif.Click += new System.EventHandler(this.Cmd_Modif_Click);
            // 
            // Cmd_Add
            // 
            this.Cmd_Add.Location = new System.Drawing.Point(130, 352);
            this.Cmd_Add.Name = "Cmd_Add";
            this.Cmd_Add.Size = new System.Drawing.Size(89, 30);
            this.Cmd_Add.TabIndex = 55;
            this.Cmd_Add.Text = "Enregistrer";
            this.Cmd_Add.UseVisualStyleBackColor = true;
            this.Cmd_Add.Click += new System.EventHandler(this.Cmd_Add_Click);
            // 
            // cmd_New
            // 
            this.cmd_New.Location = new System.Drawing.Point(35, 352);
            this.cmd_New.Name = "cmd_New";
            this.cmd_New.Size = new System.Drawing.Size(89, 30);
            this.cmd_New.TabIndex = 54;
            this.cmd_New.Text = "Nouveau";
            this.cmd_New.UseVisualStyleBackColor = true;
            this.cmd_New.Click += new System.EventHandler(this.cmd_New_Click);
            // 
            // DGV_Film
            // 
            this.DGV_Film.AutoGenerateColumns = false;
            this.DGV_Film.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Film.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeFilmDataGridViewTextBoxColumn,
            this.titreFilmDataGridViewTextBoxColumn,
            this.natFilmDataGridViewTextBoxColumn,
            this.nbCopieDataGridViewTextBoxColumn,
            this.puLocFDataGridViewTextBoxColumn});
            this.DGV_Film.DataSource = this.filmBindingSource;
            this.DGV_Film.Location = new System.Drawing.Point(66, 236);
            this.DGV_Film.Name = "DGV_Film";
            this.DGV_Film.Size = new System.Drawing.Size(575, 110);
            this.DGV_Film.TabIndex = 64;
            this.DGV_Film.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Film_CellDoubleClick);
            // 
            // codeFilmDataGridViewTextBoxColumn
            // 
            this.codeFilmDataGridViewTextBoxColumn.DataPropertyName = "CodeFilm";
            this.codeFilmDataGridViewTextBoxColumn.HeaderText = "CodeFilm";
            this.codeFilmDataGridViewTextBoxColumn.Name = "codeFilmDataGridViewTextBoxColumn";
            this.codeFilmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titreFilmDataGridViewTextBoxColumn
            // 
            this.titreFilmDataGridViewTextBoxColumn.DataPropertyName = "TitreFilm";
            this.titreFilmDataGridViewTextBoxColumn.HeaderText = "TitreFilm";
            this.titreFilmDataGridViewTextBoxColumn.Name = "titreFilmDataGridViewTextBoxColumn";
            // 
            // natFilmDataGridViewTextBoxColumn
            // 
            this.natFilmDataGridViewTextBoxColumn.DataPropertyName = "NatFilm";
            this.natFilmDataGridViewTextBoxColumn.HeaderText = "NatFilm";
            this.natFilmDataGridViewTextBoxColumn.Name = "natFilmDataGridViewTextBoxColumn";
            // 
            // nbCopieDataGridViewTextBoxColumn
            // 
            this.nbCopieDataGridViewTextBoxColumn.DataPropertyName = "NbCopie";
            this.nbCopieDataGridViewTextBoxColumn.HeaderText = "NbCopie";
            this.nbCopieDataGridViewTextBoxColumn.Name = "nbCopieDataGridViewTextBoxColumn";
            // 
            // puLocFDataGridViewTextBoxColumn
            // 
            this.puLocFDataGridViewTextBoxColumn.DataPropertyName = "PuLocF";
            this.puLocFDataGridViewTextBoxColumn.HeaderText = "PuLocF";
            this.puLocFDataGridViewTextBoxColumn.Name = "puLocFDataGridViewTextBoxColumn";
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(571, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 27);
            this.label11.TabIndex = 65;
            this.label11.Text = "Mont Tot :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_MontLoc
            // 
            this.Txt_MontLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_MontLoc.Location = new System.Drawing.Point(656, 192);
            this.Txt_MontLoc.Name = "Txt_MontLoc";
            this.Txt_MontLoc.Size = new System.Drawing.Size(71, 26);
            this.Txt_MontLoc.TabIndex = 66;
            // 
            // Txt_NatFilm
            // 
            this.Txt_NatFilm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource, "NatFilm", true));
            this.Txt_NatFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NatFilm.Location = new System.Drawing.Point(560, 153);
            this.Txt_NatFilm.Name = "Txt_NatFilm";
            this.Txt_NatFilm.Size = new System.Drawing.Size(142, 26);
            this.Txt_NatFilm.TabIndex = 67;
            // 
            // adherentTableAdapter
            // 
            this.adherentTableAdapter.ClearBeforeFill = true;
            // 
            // Cbo_CodAd
            // 
            this.Cbo_CodAd.DataSource = this.adherentBindingSource;
            this.Cbo_CodAd.DisplayMember = "CodeAD";
            this.Cbo_CodAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_CodAd.FormattingEnabled = true;
            this.Cbo_CodAd.Location = new System.Drawing.Point(356, 78);
            this.Cbo_CodAd.Name = "Cbo_CodAd";
            this.Cbo_CodAd.Size = new System.Drawing.Size(100, 28);
            this.Cbo_CodAd.TabIndex = 68;
            this.Cbo_CodAd.SelectedIndexChanged += new System.EventHandler(this.Cbo_CodAd_SelectedIndexChanged);
            // 
            // paramTableAdapter
            // 
            this.paramTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(369, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 27);
            this.label9.TabIndex = 69;
            this.label9.Text = "NB Copie Loués :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_NbCopL
            // 
            this.Txt_NbCopL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NbCopL.Location = new System.Drawing.Point(497, 193);
            this.Txt_NbCopL.Mask = "99";
            this.Txt_NbCopL.Name = "Txt_NbCopL";
            this.Txt_NbCopL.Size = new System.Drawing.Size(61, 26);
            this.Txt_NbCopL.TabIndex = 70;
            this.Txt_NbCopL.TextChanged += new System.EventHandler(this.Txt_NbCopL_TextChanged);
            // 
            // Lbl_CodLoc
            // 
            this.Lbl_CodLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lbl_CodLoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_CodLoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locationBindingSource, "CodeLoc", true));
            this.Lbl_CodLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodLoc.Location = new System.Drawing.Point(135, 79);
            this.Lbl_CodLoc.Name = "Lbl_CodLoc";
            this.Lbl_CodLoc.Size = new System.Drawing.Size(80, 27);
            this.Lbl_CodLoc.TabIndex = 72;
            this.Lbl_CodLoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataMember = "Location";
            this.locationBindingSource.DataSource = this.dbLocFilmDataSet;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 27);
            this.label13.TabIndex = 71;
            this.label13.Text = "Code Location : ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(470, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 27);
            this.label12.TabIndex = 73;
            this.label12.Text = "Nbre Copie En Location : ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_NbCopieLoc
            // 
            this.Lbl_NbCopieLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lbl_NbCopieLoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_NbCopieLoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmNRetADBindingSource1, "SommeDeNombrefilmLouer", true));
            this.Lbl_NbCopieLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NbCopieLoc.Location = new System.Drawing.Point(647, 78);
            this.Lbl_NbCopieLoc.Name = "Lbl_NbCopieLoc";
            this.Lbl_NbCopieLoc.Size = new System.Drawing.Size(80, 27);
            this.Lbl_NbCopieLoc.TabIndex = 74;
            this.Lbl_NbCopieLoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // filmNRetADBindingSource1
            // 
            this.filmNRetADBindingSource1.DataMember = "FilmNRetAD";
            this.filmNRetADBindingSource1.DataSource = this.dbLocFilmDataSet;
            // 
            // filmNRetADTableAdapter
            // 
            this.filmNRetADTableAdapter.ClearBeforeFill = true;
            // 
            // GestLocF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 396);
            this.Controls.Add(this.Lbl_NbCopieLoc);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Lbl_CodLoc);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Txt_NbCopL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Cbo_CodAd);
            this.Controls.Add(this.Txt_NatFilm);
            this.Controls.Add(this.Txt_MontLoc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DGV_Film);
            this.Controls.Add(this.Cbo_Pram);
            this.Controls.Add(this.Cmd_Fin);
            this.Controls.Add(this.Cmd_Sup);
            this.Controls.Add(this.Cmd_Modif);
            this.Controls.Add(this.Cmd_Add);
            this.Controls.Add(this.cmd_New);
            this.Controls.Add(this.txt_nbrCopie);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_Ploc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_Titre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Lbl_CodFilm);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Txt_Pren);
            this.Controls.Add(this.Txt_Nom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GestLocF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestLocF";
            this.Load += new System.EventHandler(this.GestLocF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLocFilmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Film)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmNRetADBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmNRetADBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Pren;
        private System.Windows.Forms.TextBox Txt_Nom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_nbrCopie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox Txt_Ploc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Titre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Lbl_CodFilm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Cbo_Pram;
        private System.Windows.Forms.Button Cmd_Fin;
        private System.Windows.Forms.Button Cmd_Sup;
        private System.Windows.Forms.Button Cmd_Modif;
        private System.Windows.Forms.Button Cmd_Add;
        private System.Windows.Forms.Button cmd_New;
        private System.Windows.Forms.DataGridView DGV_Film;
        private DbLocFilmDataSet dbLocFilmDataSet;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private DbLocFilmDataSetTableAdapters.FilmTableAdapter filmTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeFilmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titreFilmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn natFilmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbCopieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puLocFDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Txt_MontLoc;
        private System.Windows.Forms.TextBox Txt_NatFilm;
        private System.Windows.Forms.BindingSource adherentBindingSource;
        private DbLocFilmDataSetTableAdapters.AdherentTableAdapter adherentTableAdapter;
        private System.Windows.Forms.ComboBox Cbo_CodAd;
        private System.Windows.Forms.BindingSource paramBindingSource;
        private DbLocFilmDataSetTableAdapters.ParamTableAdapter paramTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox Txt_NbCopL;
        private System.Windows.Forms.Label Lbl_CodLoc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private DbLocFilmDataSetTableAdapters.LocationTableAdapter locationTableAdapter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Lbl_NbCopieLoc;
        private System.Windows.Forms.BindingSource filmNRetADBindingSource;
        private DbLocFilmDataSetTableAdapters.FilmNRetADTableAdapter filmNRetADTableAdapter;
        private System.Windows.Forms.BindingSource filmNRetADBindingSource1;
    }
}