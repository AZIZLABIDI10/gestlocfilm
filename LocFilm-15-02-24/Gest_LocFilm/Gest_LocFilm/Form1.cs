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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbLocFilmDataSet.Param' table. You can move, or remove it, as needed.
            this.paramTableAdapter.Fill(this.dbLocFilmDataSet.Param);
            // TODO: This line of code loads data into the 'dbLocFilmDataSet.Adherent' table. You can move, or remove it, as needed.
             this.adherentTableAdapter.Fill(this.dbLocFilmDataSet.Adherent);
            Cbo_Pram.Visible = false;
            Lbl_DateCreat.Text  =Convert.ToString( DateTime.Now);

        }

        private void cmd_New_Click(object sender, EventArgs e)
        {
            this.paramTableAdapter.Fill(this.dbLocFilmDataSet.Param);
            Lbl_CodAd.Text = "AD-"+ Cbo_Pram.Text;
            Txt_Nom.Text = "";
            Txt_Pren.Text = "";
        }

        private void Cmd_Add_Click(object sender, EventArgs e)
        {
            
            DialogResult resultat = MessageBox.Show ("Voulez Vous Enregistrer Le Nouveau Adhérent (O/N) : ","Confirmation", MessageBoxButtons.YesNo);
            if (resultat == DialogResult.Yes)
            {
                this.adherentTableAdapter.InsertQueryAD(Lbl_CodAd.Text, Txt_Nom.Text, Txt_Pren.Text, DateTime.Now);
                MessageBox.Show("Opération D'enregistrement Effectuée avec Sucée !");
                this.paramTableAdapter.UpdateQueryCodAd(Convert.ToUInt16(Cbo_Pram.Text) + 1);
            }
            else
            {
                MessageBox.Show("Opération D'enregistrement Non Efféctuée !");
            }

        }

        private void Cmd_Sup_Click(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show("Voulez Vous Supprimer cet  (O/N) : ", "Confirmation", MessageBoxButtons.YesNo);
            if (resultat == DialogResult.Yes)
            {
                this.adherentTableAdapter.DeleteQueryAd(Lbl_CodAd.Text);
                MessageBox.Show("Opération De Suppréssion Effectuée avec Sucée !");
                this.adherentTableAdapter.Fill(this.dbLocFilmDataSet.Adherent);
            }
            else
            {
                MessageBox.Show("Opération De Suppréssion Non Efféctuée !");
            }
        }

        private void Cmd_First_Click(object sender, EventArgs e)
        {
            this.adherentTableAdapter.Fill(this.dbLocFilmDataSet.Adherent);
            this.adherentBindingSource.MoveFirst();
        }

        private void Cmd_Suiv_Click(object sender, EventArgs e)
        {
            this.adherentBindingSource.MoveNext();
        }

        private void Cmd_Prec_Click(object sender, EventArgs e)
        {
            this.adherentBindingSource.MovePrevious();
        }

        private void Cmd_Last_Click(object sender, EventArgs e)
        {
            this.adherentBindingSource.MoveLast();
        }

        private void Cmd_Modif_Click(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show("Voulez Vous Modifier  cet  (O/N) : ", "Confirmation", MessageBoxButtons.YesNo);
            if (resultat == DialogResult.Yes)
            {
                this.adherentTableAdapter.DeleteQueryAd(Lbl_CodAd.Text);
                this.adherentTableAdapter.InsertQueryAD(Lbl_CodAd.Text, Txt_Nom.Text, Txt_Pren.Text, DateTime.Now);
                MessageBox.Show("Opération De Modification Effectuée avec Sucée !");
                this.adherentTableAdapter.Fill(this.dbLocFilmDataSet.Adherent);
            }
            else
            {
                MessageBox.Show("Opération De Modification Non Efféctuée !");
            }
        }

        private void Cmd_Fin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
