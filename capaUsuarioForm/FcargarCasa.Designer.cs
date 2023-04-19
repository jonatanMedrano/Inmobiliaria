
namespace capaUsuarioForm
{
    partial class FcargarCasa
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botAgregar = new System.Windows.Forms.Button();
            this.butCancelar = new System.Windows.Forms.Button();
            this.textBoxCalle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxLocalidad = new System.Windows.Forms.TextBox();
            this.textBoxPartido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxProvincia = new System.Windows.Forms.TextBox();
            this.textBoxTotalM2 = new System.Windows.Forms.TextBox();
            this.textBoxM2Cubiertos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botAgregar
            // 
            this.botAgregar.Location = new System.Drawing.Point(52, 269);
            this.botAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.botAgregar.Name = "botAgregar";
            this.botAgregar.Size = new System.Drawing.Size(88, 27);
            this.botAgregar.TabIndex = 0;
            this.botAgregar.Text = "Agregar";
            this.botAgregar.UseVisualStyleBackColor = true;
            this.botAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(224, 269);
            this.butCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(88, 27);
            this.butCancelar.TabIndex = 1;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseCompatibleTextRendering = true;
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butModificar_Click);
            // 
            // textBoxCalle
            // 
            this.textBoxCalle.Location = new System.Drawing.Point(93, 54);
            this.textBoxCalle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCalle.Name = "textBoxCalle";
            this.textBoxCalle.Size = new System.Drawing.Size(116, 23);
            this.textBoxCalle.TabIndex = 3;
            this.textBoxCalle.TextChanged += new System.EventHandler(this.textBoxCalle_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "DIRECCION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(93, 84);
            this.textBoxNumero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(116, 23);
            this.textBoxNumero.TabIndex = 5;
            // 
            // textBoxLocalidad
            // 
            this.textBoxLocalidad.Location = new System.Drawing.Point(93, 114);
            this.textBoxLocalidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxLocalidad.Name = "textBoxLocalidad";
            this.textBoxLocalidad.Size = new System.Drawing.Size(116, 23);
            this.textBoxLocalidad.TabIndex = 6;
            // 
            // textBoxPartido
            // 
            this.textBoxPartido.Location = new System.Drawing.Point(93, 144);
            this.textBoxPartido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPartido.Name = "textBoxPartido";
            this.textBoxPartido.Size = new System.Drawing.Size(116, 23);
            this.textBoxPartido.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Calle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Numero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Localidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Partido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 173);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Provincia";
            // 
            // textBoxProvincia
            // 
            this.textBoxProvincia.Location = new System.Drawing.Point(93, 173);
            this.textBoxProvincia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxProvincia.Name = "textBoxProvincia";
            this.textBoxProvincia.Size = new System.Drawing.Size(116, 23);
            this.textBoxProvincia.TabIndex = 17;
            // 
            // textBoxTotalM2
            // 
            this.textBoxTotalM2.Location = new System.Drawing.Point(93, 203);
            this.textBoxTotalM2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTotalM2.Name = "textBoxTotalM2";
            this.textBoxTotalM2.Size = new System.Drawing.Size(65, 23);
            this.textBoxTotalM2.TabIndex = 18;
            // 
            // textBoxM2Cubiertos
            // 
            this.textBoxM2Cubiertos.Location = new System.Drawing.Point(265, 203);
            this.textBoxM2Cubiertos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxM2Cubiertos.Name = "textBoxM2Cubiertos";
            this.textBoxM2Cubiertos.Size = new System.Drawing.Size(78, 23);
            this.textBoxM2Cubiertos.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 210);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Total M2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(177, 210);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "M2 Cubiertos";
            // 
            // FcargarCasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 331);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxM2Cubiertos);
            this.Controls.Add(this.textBoxTotalM2);
            this.Controls.Add(this.textBoxProvincia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPartido);
            this.Controls.Add(this.textBoxLocalidad);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCalle);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.botAgregar);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FcargarCasa";
            this.Text = "Agregar Casa";
            this.Load += new System.EventHandler(this.FcargarPropiedad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botAgregar;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.TextBox textBoxCalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxLocalidad;
        private System.Windows.Forms.TextBox textBoxPartido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxProvincia;
        private System.Windows.Forms.TextBox textBoxTotalM2;
        private System.Windows.Forms.TextBox textBoxM2Cubiertos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

