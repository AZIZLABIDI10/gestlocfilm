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
    public partial class VisuFilNRet : Form
    {
        public VisuFilNRet()
        {
            InitializeComponent();
        }

        private void VisuFilNRet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DbLocFilmDataSet.Req_FilmNonRet' table. You can move, or remove it, as needed.
            this.Req_FilmNonRetTableAdapter.Fill(this.DbLocFilmDataSet.Req_FilmNonRet);

            this.reportViewer1.RefreshReport();
        }

        private void Cmd_Fin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
