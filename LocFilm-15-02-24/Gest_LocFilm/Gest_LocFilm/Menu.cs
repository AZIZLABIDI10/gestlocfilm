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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void finTraitementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mAJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form MajAd = new Form1();
            MajAd.Show();
        }

        private void mAJToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form MajLoc = new GestionFilm();
            MajLoc.Show();


        }

        private void mAJLOCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form LocFilm = new GestLocF();
            LocFilm.Show();
        }

        private void gestRetourFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form GestRetFilm = new Maj_RetFilm();
            GestRetFilm.Show();
        }

        private void etatAdhérentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PrevAD = new Etat_Adhérent();
            PrevAD.Show();
        }

        private void etatFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form VisFilm = new Visual_Film();
            VisFilm.Show();
        }

        private void etatTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form VisFilmL = new VisuFilmLouer();
            VisFilmL.Show();

        }

        private void etatFilmRetounerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form VisFLNret = new VisuFilNRet();
            VisFLNret.Show();
        }
    }
}
