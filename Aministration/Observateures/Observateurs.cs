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
            var obser =( from o in db.Observateurs
                        select new
                        {
                            NomPrenom = o.NomPrenomObservateur,
                        });
           dataGridViewObs.DataSource = obser.ToList();
            var Bas =( from b in db.Bassins
                        select new
                        {
                            NomBassin = b.NomBassin,
                        });
            dataGridView3.DataSource = Bas.ToList();
            var sta =( from s in db.Stations
                        select new
                        {
                            NomStation = s.NomStation,
                        });
            dataGridViewStat.DataSource = sta.ToList();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
