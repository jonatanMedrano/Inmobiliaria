using System;
using System.Windows.Forms;
using capaNegocio;

namespace capaUsuarioForm
{
    public partial class FcargarCasa : Form
    {
        private Casa casa;

        public FcargarCasa()
        {
            InitializeComponent();
        }

        private void FcargarPropiedad_Load(object sender, EventArgs e)
        {

        }

        //Boton agregar
        private void button1_Click(object sender, EventArgs e)
        {
            string calle = this.textBoxCalle.Text;
            int nro = int.Parse(this.textBoxNumero.Text);
            string localidad = this.textBoxLocalidad.Text;
            string partido = this.textBoxPartido.Text;
            string provincia = this.textBoxProvincia.Text;
            int m2 = int.Parse(this.textBoxTotalM2.Text);
            int m2Cu = int.Parse(this.textBoxM2Cubiertos.Text);

            casa = new Casa(calle,nro,localidad,partido,provincia,m2Cu,m2);

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //es el cancelar
        private void butModificar_Click(object sender, EventArgs e)
        {
            casa = null;
            this.Close();
        }

        private void textBoxCalle_TextChanged(object sender, EventArgs e)
        {

        }

        public Casa Cas
        {
            get { return this.casa; }
        }
    }
}
