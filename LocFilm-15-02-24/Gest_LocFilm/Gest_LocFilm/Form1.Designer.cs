namespace Gest_LocFilm
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_CodAd = new System.Windows.Forms.Label();
            this.adherentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbLocFilmDataSet = new Gest_LocFilm.DbLocFilmDataSet();
            this.Txt_Nom = new System.Windows.Forms.TextBox();
            this.Txt_Pren = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Lbl_DateCreat = new System.Windows.Forms.Label();
            this.cmd_New = new System.Windows.Forms.Button();
            this.Cmd_Add = new System.Windows.Forms.Button();
            this.Cmd_Modif = new System.Windows.Forms.Button();
            this.Cmd_Sup = new System.Windows.Forms.Button();
            this.Cmd_First = new System.Windows.Forms.Button();
            this.Cmd_Suiv = new System.Windows.Forms.Button();
            this.Cmd_Prec = new System.Windows.Forms.Button();
            this.Cmd_Last = new System.Windows.Forms.Button();
            this.Cmd_Fin = new System.Windows.Forms.Button();
            this.adherentTableAdapter = new Gest_LocFilm.DbLocFilmDataSetTableAdapters.AdherentTableAdapter();
            this.Cbo_Pram = new System.Windows.Forms.ComboBox();
            this.paramBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paramTableAdapter = new Gest_LocFilm.DbLocFilmDataSetTableAdapters.ParamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLocFilmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAJ ADhérent";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code Adhérent :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(487, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prénom :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_CodAd
            // 
            this.Lbl_CodAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lbl_CodAd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_CodAd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "CodeAD", true));
            this.Lbl_CodAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodAd.Location = new System.Drawing.Point(148, 129);
            this.Lbl_CodAd.Name = "Lbl_CodAd";
            this.Lbl_CodAd.Size = new System.Drawing.Size(80, 27);
            this.Lbl_CodAd.TabIndex = 4;
            this.Lbl_CodAd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.Txt_Nom.Location = new System.Drawing.Point(328, 130);
            this.Txt_Nom.Name = "Txt_Nom";
            this.Txt_Nom.Size = new System.Drawing.Size(142, 26);
            this.Txt_Nom.TabIndex = 5;
            // 
            // Txt_Pren
            // 
            this.Txt_Pren.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "Prenom", true));
            this.Txt_Pren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Pren.Location = new System.Drawing.Point(572, 130);
            this.Txt_Pren.Name = "Txt_Pren";
            this.Txt_Pren.Size = new System.Drawing.Size(142, 26);
            this.Txt_Pren.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "Date Creation :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_DateCreat
            // 
            this.Lbl_DateCreat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lbl_DateCreat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_DateCreat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adherentBindingSource, "DateCreat", true));
            this.Lbl_DateCreat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DateCreat.Location = new System.Drawing.Point(146, 190);
            this.Lbl_DateCreat.Name = "Lbl_DateCreat";
            this.Lbl_DateCreat.Size = new System.Drawing.Size(95, 27);
            this.Lbl_DateCreat.TabIndex = 8;
            this.Lbl_DateCreat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmd_New
            // 
            this.cmd_New.Location = new System.Drawing.Point(32, 239);
            this.cmd_New.Name = "cmd_New";
            this.cmd_New.Size = new System.Drawing.Size(89, 30);
            this.cmd_New.TabIndex = 9;
            this.cmd_New.Text = "Nouveau";
            this.cmd_New.UseVisualStyleBackColor = true;
            this.cmd_New.Click += new System.EventHandler(this.cmd_New_Click);
            // 
            // Cmd_Add
            // 
            this.Cmd_Add.Location = new System.Drawing.Point(127, 239);
            this.Cmd_Add.Name = "Cmd_Add";
            this.Cmd_Add.Size = new System.Drawing.Size(89, 30);
            this.Cmd_Add.TabIndex = 10;
            this.Cmd_Add.Text = "Enregistrer";
            this.Cmd_Add.UseVisualStyleBackColor = true;
            this.Cmd_Add.Click += new System.EventHandler(this.Cmd_Add_Click);
            // 
            // Cmd_Modif
            // 
            this.Cmd_Modif.Location = new System.Drawing.Point(222, 239);
            this.Cmd_Modif.Name = "Cmd_Modif";
            this.Cmd_Modif.Size = new System.Drawing.Size(89, 30);
            this.Cmd_Modif.TabIndex = 11;
            this.Cmd_Modif.Text = "Modifier";
            this.Cmd_Modif.UseVisualStyleBackColor = true;
            this.Cmd_Modif.Click += new System.EventHandler(this.Cmd_Modif_Click);
            // 
            // Cmd_Sup
            // 
            this.Cmd_Sup.Location = new System.Drawing.Point(317, 239);
            this.Cmd_Sup.Name = "Cmd_Sup";
            this.Cmd_Sup.Size = new System.Drawing.Size(89, 30);
            this.Cmd_Sup.TabIndex = 12;
            this.Cmd_Sup.Text = "Suprimer";
            this.Cmd_Sup.UseVisualStyleBackColor = true;
            this.Cmd_Sup.Click += new System.EventHandler(this.Cmd_Sup_Click);
            // 
            // Cmd_First
            // 
            this.Cmd_First.Location = new System.Drawing.Point(32, 275);
            this.Cmd_First.Name = "Cmd_First";
            this.Cmd_First.Size = new System.Drawing.Size(89, 30);
            this.Cmd_First.TabIndex = 13;
            this.Cmd_First.Text = "Début";
            this.Cmd_First.UseVisualStyleBackColor = true;
            this.Cmd_First.Click += new System.EventHandler(this.Cmd_First_Click);
            // 
            // Cmd_Suiv
            // 
            this.Cmd_Suiv.Location = new System.Drawing.Point(127, 275);
            this.Cmd_Suiv.Name = "Cmd_Suiv";
            this.Cmd_Suiv.Size = new System.Drawing.Size(89, 30);
            this.Cmd_Suiv.TabIndex = 14;
            this.Cmd_Suiv.Text = "Suivant";
            this.Cmd_Suiv.UseVisualStyleBackColor = true;
            this.Cmd_Suiv.Click += new System.EventHandler(this.Cmd_Suiv_Click);
            // 
            // Cmd_Prec
            // 
            this.Cmd_Prec.Location = new System.Drawing.Point(222, 275);
            this.Cmd_Prec.Name = "Cmd_Prec";
            this.Cmd_Prec.Size = new System.Drawing.Size(89, 30);
            this.Cmd_Prec.TabIndex = 15;
            this.Cmd_Prec.Text = "Précédent";
            this.Cmd_Prec.UseVisualStyleBackColor = true;
            this.Cmd_Prec.Click += new System.EventHandler(this.Cmd_Prec_Click);
            // 
            // Cmd_Last
            // 
            this.Cmd_Last.Location = new System.Drawing.Point(317, 275);
            this.Cmd_Last.Name = "Cmd_Last";
            this.Cmd_Last.Size = new System.Drawing.Size(89, 30);
            this.Cmd_Last.TabIndex = 16;
            this.Cmd_Last.Text = "Dernier";
            this.Cmd_Last.UseVisualStyleBackColor = true;
            this.Cmd_Last.Click += new System.EventHandler(this.Cmd_Last_Click);
            // 
            // Cmd_Fin
            // 
            this.Cmd_Fin.Location = new System.Drawing.Point(581, 258);
            this.Cmd_Fin.Name = "Cmd_Fin";
            this.Cmd_Fin.Size = new System.Drawing.Size(69, 47);
            this.Cmd_Fin.TabIndex = 17;
            this.Cmd_Fin.Text = "Quitter";
            this.Cmd_Fin.UseVisualStyleBackColor = true;
            this.Cmd_Fin.Click += new System.EventHandler(this.Cmd_Fin_Click);
            // 
            // adherentTableAdapter
            // 
            this.adherentTableAdapter.ClearBeforeFill = true;
            // 
            // Cbo_Pram
            // 
            this.Cbo_Pram.DataSource = this.paramBindingSource;
            this.Cbo_Pram.DisplayMember = "CodAD";
            this.Cbo_Pram.FormattingEnabled = true;
            this.Cbo_Pram.Location = new System.Drawing.Point(590, 193);
            this.Cbo_Pram.Name = "Cbo_Pram";
            this.Cbo_Pram.Size = new System.Drawing.Size(68, 21);
            this.Cbo_Pram.TabIndex = 18;
            // 
            // paramBindingSource
            // 
            this.paramBindingSource.DataMember = "Param";
            this.paramBindingSource.DataSource = this.dbLocFilmDataSet;
            // 
            // paramTableAdapter
            // 
            this.paramTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 356);
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
            this.Controls.Add(this.Lbl_DateCreat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_Pren);
            this.Controls.Add(this.Txt_Nom);
            this.Controls.Add(this.Lbl_CodAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adherentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLocFilmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_CodAd;
        private System.Windows.Forms.TextBox Txt_Nom;
        private System.Windows.Forms.TextBox Txt_Pren;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lbl_DateCreat;
        private System.Windows.Forms.Button cmd_New;
        private System.Windows.Forms.Button Cmd_Add;
        private System.Windows.Forms.Button Cmd_Modif;
        private System.Windows.Forms.Button Cmd_Sup;
        private System.Windows.Forms.Button Cmd_First;
        private System.Windows.Forms.Button Cmd_Suiv;
        private System.Windows.Forms.Button Cmd_Prec;
        private System.Windows.Forms.Button Cmd_Last;
        private System.Windows.Forms.Button Cmd_Fin;
        private DbLocFilmDataSet dbLocFilmDataSet;
        private System.Windows.Forms.BindingSource adherentBindingSource;
        private DbLocFilmDataSetTableAdapters.AdherentTableAdapter adherentTableAdapter;
        private System.Windows.Forms.ComboBox Cbo_Pram;
        private System.Windows.Forms.BindingSource paramBindingSource;
        private DbLocFilmDataSetTableAdapters.ParamTableAdapter paramTableAdapter;
    }
}

