using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;

namespace capaUsuarioForm
{
    public partial class ABMvivienda : Form
    {
        private Casa casaCargada;
        private Dpto dptoCargado;
        private Administradora ad;
        public ABMvivienda()
        {
            InitializeComponent();
            ad = new Administradora();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            FcargarCasa fc = new FcargarCasa();
            fc.ShowDialog();
            
            casaCargada = fc.Cas;
            //Agrego casa a la list
            if (casaCargada != null)
            {
                ad.agregarCasa(casaCargada);
            }
        }

        private void butAgregarDpto_Click(object sender, EventArgs e)
        {
            FcargarDpto fd = new FcargarDpto();
            fd.ShowDialog();
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            FeliminarCasa fec = new FeliminarCasa(casaCargada);
            fec.ShowDialog();
        }

        private void ABMvivienda_Load(object sender, EventArgs e)
        {

        }
    }
}
