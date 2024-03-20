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
    public partial class GestLocF : Form
    {
        public GestLocF()
        {
            InitializeComponent();
        }

        private void GestLocF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbLocFilmDataSet1.FilmNRetAD' table. You can move, or remove it, as needed.
            this.filmNRetADTableAdapter.Fill(this.dbLocFilmDataSet.FilmNRetAD);
            // TODO: This line of code loads data into the 'dbLocFilmDataSet.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.dbLocFilmDataSet.Location);
            Cbo_Pram.Visible = false;
            // TODO: This line of code loads data into the 'dbLocFilmDataSet.Param' table. You can move, or remove it, as needed.
            this.paramTableAdapter.Fill(this.dbLocFilmDataSet.Param);
            // TODO: This line of code loads data into the 'dbLocFilmDataSet.Adherent' table. You can move, or remove it, as needed.
            this.adherentTableAdapter.Fill(this.dbLocFilmDataSet.Adherent);
            // TODO: This line of code loads data into the 'dbLocFilmDataSet.Film' table. You can move, or remove it, as needed.
            this.filmTableAdapter.Fill(this.dbLocFilmDataSet.Film);
          
        }

        private void cmd_New_Click(object sender, EventArgs e)
        {
            this.paramTableAdapter.Fill(this.dbLocFilmDataSet.Param);
            Txt_Titre.Text = "";
            Txt_Ploc.Text = "";
            txt_nbrCopie.Text = "";
            Lbl_CodFilm.Text = "";
            Cbo_CodAd.Text = "";
            Txt_Nom.Text = "";
            Txt_Pren.Text = "";
            Txt_NatFilm.Text ="";
            Lbl_CodLoc.Text  = "LOC-" + Convert.ToString(Cbo_Pram.Text);
        }

        private void Cmd_Fin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGV_Film_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow   SelectedRow = DGV_Film.Rows [e.RowIndex ];
            Lbl_CodFilm.Text =Convert.ToString ( SelectedRow.Cells[0].Value) ;
        }

        private void efface()
        {
            this.paramTableAdapter.Fill(this.dbLocFilmDataSet.Param);
            Txt_Titre.Text = "";
            Txt_Ploc.Text = "";
            txt_nbrCopie.Text = "";
            Lbl_CodFilm.Text = "";
            Cbo_CodAd.Text = "";
            Txt_Nom.Text = "";
            Txt_Pren.Text = "";
            Txt_NatFilm.Text = "";
            Lbl_NbCopieLoc.Text = "";
            Lbl_CodLoc.Text = "LOC-" + Convert.ToString(Cbo_Pram.Text);
            Txt_NbCopL.Text = "";
        }

        private void Txt_NbCopL_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txt_nbrCopie.Text) < Convert.ToInt16(Txt_NbCopL.Text))
            {
                MessageBox.Show("Attention le Nombre de Copie Disponible Inférieur aux Nombre de Copie à Louer ", "Erreur");
                Txt_NbCopL.Text = txt_nbrCopie.Text;
            }
            Txt_MontLoc.Text = "";
             Txt_MontLoc.Text = Convert.ToString(Convert.ToDouble(Txt_Ploc.Text) * Convert.ToInt16(Txt_NbCopL.Text));

        }

        private void Cmd_Add_Click(object sender, EventArgs e)
        {
            DateTime Maintenant = DateTime.Now;
            DateTime Result = Maintenant.AddDays(2);// En Suppose que La durée de Location Est de 2 Jours Seulement 
            // La fonction addDay(X) ajoute a la date actuelle x jours dans notre cas c'est 2 jours

            DialogResult resultat = MessageBox.Show("Voulez Vous Enregistrer La Location Du  Film (O/N) : ", "Confirmation", MessageBoxButtons.YesNo);
            if (resultat == DialogResult.Yes)
            {
                this.locationTableAdapter.InsertQueryLoc(Lbl_CodLoc.Text, Cbo_CodAd.Text, Lbl_CodFilm.Text, Convert.ToDecimal(Txt_MontLoc.Text), DateTime.Now, Result, Convert.ToInt16(Txt_NbCopL.Text));
                MessageBox.Show("Opération D'enregistrement Effectuée avec Sucée !");
                this.locationTableAdapter.Fill(this.dbLocFilmDataSet.Location);
                this.paramTableAdapter.UpdateQueryLoc (Convert.ToUInt16(Cbo_Pram.Text) + 1);

            }
            else
            {
                MessageBox.Show("Opération D'enregistrement Non Efféctuée !");
            }
        }

        private void Cbo_CodAd_SelectedIndexChanged(object sender, EventArgs e)
        {

             Convert.ToString(this.filmNRetADTableAdapter.FillByFilmNR  (dbLocFilmDataSet.FilmNRetAD, Cbo_CodAd.Text));
        }

        private void Cmd_Sup_Click(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show("Voulez Vous Suprimer La Location Du  Film (O/N) : ", "Confirmation", MessageBoxButtons.YesNo);
            if (resultat == DialogResult.Yes)
            {
                this.locationTableAdapter.DeleteQueryLoc(Lbl_CodLoc.Text);
                MessageBox.Show("Opération De suppression Effectuée avec Sucée !");
                this.locationTableAdapter.Fill(this.dbLocFilmDataSet.Location);
                this.paramTableAdapter.UpdateQueryLoc(Convert.ToUInt16(Cbo_Pram.Text) + 1);

            }
            else
            {
                MessageBox.Show("Opération De suppression  Non Efféctuée !");
            }
        }

        private void Cmd_Modif_Click(object sender, EventArgs e)
        {
            DateTime Maintenant = DateTime.Now;
            DateTime Result = Maintenant.AddDays(2);
            DialogResult resultat = MessageBox.Show("Voulez Vous MAJ La Location Du  Film (O/N) : ", "Confirmation", MessageBoxButtons.YesNo);
            if (resultat == DialogResult.Yes)
            {
                this.locationTableAdapter.DeleteQueryLoc(Lbl_CodLoc.Text);
                this.locationTableAdapter.InsertQueryLoc(Lbl_CodLoc.Text, Cbo_CodAd.Text, Lbl_CodFilm.Text, Convert.ToDecimal(Txt_MontLoc.Text), DateTime.Now, Result, Convert.ToInt16(Txt_NbCopL.Text));
                MessageBox.Show("Opération De MAJ Effectuée avec Sucée !");
                this.locationTableAdapter.Fill(this.dbLocFilmDataSet.Location);
                this.paramTableAdapter.UpdateQueryLoc(Convert.ToUInt16(Cbo_Pram.Text) + 1);

            }
            else
            {
                MessageBox.Show("Opération De MAJ  Non Efféctuée !");
            }
        }

        

   
        
    }
}
