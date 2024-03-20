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
    public partial class VisuFilmLouer : Form
    {
        public VisuFilmLouer()
        {
            InitializeComponent();
        }

        private void VisuFilmLouer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DbLocFilmDataSet.Location' table. You can move, or remove it, as needed.
            this.LocationTableAdapter.Fill(this.DbLocFilmDataSet.Location);

            this.reportViewer1.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cmd_Fin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
