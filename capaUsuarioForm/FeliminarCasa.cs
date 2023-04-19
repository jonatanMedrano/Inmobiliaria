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
    public partial class FeliminarCasa : Form
    {
        private Administradora ad;
        private Casa casaCargada;
        public FeliminarCasa(Casa c)
        {
            InitializeComponent();
            ad = new Administradora();
            ad.agregarCasa(c);
            this.mostrar(c);

            casaCargada = new Casa(c.Calle, c.Nro, c.Localidad, c.Partido, c.Provincia, c.M2Cubiertos, c.M2Terreno);
        }

        public void mostrar(Casa c)
        {
            // this.label1.Text = c.Calle;
            //this.label2.Text = c.Nro.ToString();
            //this.label3.Text = c.Localidad;
            this.listBoxCasas.DataSource = null;
            this.listBoxCasas.DataSource = ad.Casas;
            this.listBoxCasas.ClearSelected();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FeliminarCasa_Load(object sender, EventArgs e)
        {

        }


        private void checkedListBoxCasas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewCasas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
