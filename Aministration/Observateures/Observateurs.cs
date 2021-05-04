using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aministration.Observateures
{
    
    public partial class Observateurs : Form
    {
        HumidityCalculatorEntities db = new HumidityCalculatorEntities();
        public Observateurs()
        {
            InitializeComponent();
        }

        private void Observateurs_Load(object sender, EventArgs e)
        {
            var obser = (from o in db.Observateurs
                         select new
                         {
                             ID = o.ObservateurId,
                             NomPrenom = o.NomPrenomObservateur,
                         });
            dataGridViewObs.DataSource = obser.ToList();
            var Bas = (from b in db.Bassins
                       select new
                       {
                           ID = b.BassinId,
                           NomBassin = b.NomBassin,
                       });
            dataGridViewBas.DataSource = Bas.ToList();
            var sta =( from s in db.Stations
                        select new
                        {
                            ID = s.StationId,
                            NomStation = s.NomStation,
                        });
            dataGridViewStat.DataSource = sta.ToList();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBoxCodeObs.Text);
        }

        private void dataGridViewObs_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxCodeObs.Text = dataGridViewObs.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxNomObs.Text = dataGridViewObs.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dataGridViewStat_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxNomStat.Text = dataGridViewStat.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxCodeStat.Text = dataGridViewStat.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dataGridView3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxNomBas.Text = dataGridViewBas.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxCodeBas.Text = dataGridViewBas.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
