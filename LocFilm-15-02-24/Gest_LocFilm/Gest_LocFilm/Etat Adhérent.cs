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
    public partial class Etat_Adhérent : Form
    {
        public Etat_Adhérent()
        {
            InitializeComponent();
        }

        private void Etat_Adhérent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DbLocFilmDataSet.Adherent' table. You can move, or remove it, as needed.
            this.AdherentTableAdapter.Fill(this.DbLocFilmDataSet.Adherent);

            this.reportViewer1.RefreshReport();
        }

        private void Cmd_Fin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
