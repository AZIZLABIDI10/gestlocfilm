using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gest_LocFilm
{
    public partial class GestionFilm : Form
    {
        public GestionFilm()
        {
            InitializeComponent();
        }

        private void GestionFilm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbLocFilmDataSet2.NatFilm' table. You can move, or remove it, as needed.
            this.natFilmTableAdapter.Fill(this.dbLocFilmDataSet2.NatFilm);
             
            // TODO: This line of code loads data into the 'dbLocFilmDataSet.Film' table. You can move, or remove it, as needed.
            this.filmTableAdapter.Fill(this.dbLocFilmDataSet.Film);
            // TODO: This line of code loads data into the 'dbLocFilmDataSet.Param' table. You can move, or remove it, as needed.
            this.paramTableAdapter.Fill(this.dbLocFilmDataSet.Param);
            Cbo_Pram.Visible = false;
            Cbo_NatF_TabF.Visible = false;
            Lbl_CodAd.Text = "FM-" + Cbo_Pram.Text;
            Txt_Titre.Text = "";
            Txt_Ploc.Text = "";
            txt_nbrCopie.Text = "";

        }

        private void cmd_New_Click(object sender, EventArgs e)
        {
            Cbo_NatF_TabF.Visible = false;
            this.paramTableAdapter.Fill(this.dbLocFilmDataSet.Param);
            this.filmTableAdapter.Fill(this.dbLocFilmDataSet.Film);
            Lbl_CodAd.Text = "FM-" + Cbo_Pram.Text;
            Txt_Titre.Text  = "";
            Txt_Ploc.Text = "";
            txt_nbrCopie.Text = "";
           
        }

        private void Cmd_Add_Click(object sender, EventArgs e)
        {
            
            DialogResult resultat = MessageBox.Show("Voulez Vous Enregistrer Le Nouveau Film (O/N) : ", "Confirmation", MessageBoxButtons.YesNo);
            if (resultat == DialogResult.Yes)
            {
                this.filmTableAdapter.InsertQueryFilm(Lbl_CodAd.Text, Txt_Titre.Text, Cbo_NatFilm.Text, Convert.ToInt16(txt_nbrCopie.Text), Convert.ToDateTime(Txt_DatTime.Text), Convert.ToDecimal (Txt_Ploc.Text));
                MessageBox.Show("Opération D'enregistrement Effectuée avec Sucée !");
                this.filmTableAdapter.Fill(this.dbLocFilmDataSet.Film);
                this.paramTableAdapter.UpdateQueryFilm (Convert.ToUInt16(Cbo_Pram.Text) + 1);
                
            }
            else
            {
                MessageBox.Show("Opération D'enregistrement Non Efféctuée !");
            }
        }

        private void Cmd_First_Click(object sender, EventArgs e)
        {
            Cbo_NatF_TabF.Visible = true;
            this.filmTableAdapter.Fill(this.dbLocFilmDataSet.Film);
            this.filmBindingSource.MoveFirst();
        }

        private void Cmd_Suiv_Click(object sender, EventArgs e)
        {
            Cbo_NatF_TabF.Visible = true;
            this.filmBindingSource.MoveNext();
        }

        private void Cmd_Prec_Click(object sender, EventArgs e)
        {
            Cbo_NatF_TabF.Visible = true;
            this.filmBindingSource.MovePrevious();
        }

        private void Cmd_Last_Click(object sender, EventArgs e)
        {
            Cbo_NatF_TabF.Visible = true;
            this.filmBindingSource.MoveLast();
        }

        private void Cmd_Fin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cmd_Modif_Click(object sender, EventArgs e)
        {
            Cbo_NatF_TabF.Visible = true;
            DialogResult resultat = MessageBox.Show("Voulez Vous Modifier Le Nouveau Adhérent (O/N) : ", "Confirmation", MessageBoxButtons.YesNo);
            if (resultat == DialogResult.Yes)
            {
                this.filmTableAdapter.DeleteQueryFilm(Lbl_CodAd.Text);
                this.filmTableAdapter.InsertQueryFilm(Lbl_CodAd.Text, Txt_Titre.Text, Cbo_NatFilm.Text, Convert.ToInt16(txt_nbrCopie.Text), Convert.ToDateTime(Txt_DatTime.Text), Convert.ToDecimal(Txt_Ploc.Text));
                MessageBox.Show("Opération De Modification Effectuée avec Sucée !");
                
                this.paramTableAdapter.UpdateQueryFilm(Convert.ToUInt16(Cbo_Pram.Text) + 1);
                this.filmTableAdapter.Fill(this.dbLocFilmDataSet.Film);

            }
            else
            {
                MessageBox.Show("Opération De Modification Non Efféctuée !");
            }
        }

        private void Cmd_Sup_Click(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show("Voulez Vous Supprimer ce Film  (O/N) : ", "Confirmation", MessageBoxButtons.YesNo);
            if (resultat == DialogResult.Yes)
            {
                this.filmTableAdapter.DeleteQueryFilm(Lbl_CodAd.Text);
                MessageBox.Show("Opération De Suppréssion Effectuée avec Sucée !");
                this.filmTableAdapter.Fill(this.dbLocFilmDataSet.Film);
            }
            else
            {
                MessageBox.Show("Opération De Suppréssion Non Efféctuée !");
            }
        }

        
      
    }
}
