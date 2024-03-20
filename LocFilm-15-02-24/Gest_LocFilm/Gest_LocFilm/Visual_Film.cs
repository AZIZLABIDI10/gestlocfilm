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
    public partial class Visual_Film : Form
    {
        public Visual_Film()
        {
            InitializeComponent();
        }

        private void Visual_Film_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DbLocFilmDataSet.Film' table. You can move, or remove it, as needed.
            this.FilmTableAdapter.Fill(this.DbLocFilmDataSet.Film);

            this.reportViewer1.RefreshReport();
        }

        private void Cmd_Fin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
