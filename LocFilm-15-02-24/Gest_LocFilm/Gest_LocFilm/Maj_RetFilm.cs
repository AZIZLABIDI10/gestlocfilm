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
    public partial class Maj_RetFilm : Form
    {
        public Maj_RetFilm()
        {
            InitializeComponent();
        }

        private void Maj_RetFilm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbLocFilmDataSet.Film' table. You can move, or remove it, as needed.
            this.filmTableAdapter.Fill(this.dbLocFilmDataSet.Film);
            // TODO: This line of code loads data into the 'dbLocFilmDataSet.Adherent' table. You can move, or remove it, as needed.
            this.adherentTableAdapter.Fill(this.dbLocFilmDataSet.Adherent);
            // TODO: This line of code loads data into the 'dbLocFilmDataSet.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.dbLocFilmDataSet.Location);

            Lbl_date.Text = Convert.ToString( DateTime.Now);
        }

        private void Cbo_Loc_SelectedIndexChanged(object sender, EventArgs e)
        {
             this.adherentTableAdapter.FillByRechercheAD(dbLocFilmDataSet.Adherent, LBL_CodAd.Text);
             this.filmTableAdapter.FillByRechFilm(dbLocFilmDataSet.Film, Lbl_CodFilm.Text);
        }

        private void Cmd_Add_Click(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show("Voulez Vous Enregistrer La Réception Du  Film (O/N) : ", "Confirmation", MessageBoxButtons.YesNo);
            if (resultat == DialogResult.Yes)
            {
                this.locationTableAdapter.UpdateQueryRetFilm(Cbo_Loc.Text);
                MessageBox.Show("Opération D'enregistrement Réception Film avec Sucée !");
                this.locationTableAdapter.Fill(this.dbLocFilmDataSet.Location);
               

            }
            else
            {
                MessageBox.Show("Opération De Réception Non Efféctuée !");
            }
         
        }

        private void Cmd_First_Click(object sender, EventArgs e)
        {
            this.filmTableAdapter.Fill(this.dbLocFilmDataSet.Film);
            this.locationBindingSource.MoveFirst();
            
        }

        private void Cmd_Suiv_Click(object sender, EventArgs e)
        {
            this.locationBindingSource.MoveNext();
        }

        private void Cmd_Prec_Click(object sender, EventArgs e)
        {
            this.locationBindingSource.MovePrevious();
        }

        private void Cmd_Last_Click(object sender, EventArgs e)
        {
            this.adherentBindingSource.MoveLast();
        }

        private void Cmd_Fin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
