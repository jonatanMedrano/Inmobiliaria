
namespace capaUsuarioForm
{
    partial class ABMvivienda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.butAgregar = new System.Windows.Forms.Button();
            this.butModificar = new System.Windows.Forms.Button();
            this.butEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butAgregarDpto = new System.Windows.Forms.Button();
            this.butModifiDpto = new System.Windows.Forms.Button();
            this.butElimiDpto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butAgregar
            // 
            this.butAgregar.Location = new System.Drawing.Point(123, 114);
            this.butAgregar.Name = "butAgregar";
            this.butAgregar.Size = new System.Drawing.Size(75, 23);
            this.butAgregar.TabIndex = 0;
            this.butAgregar.Text = "Agregar";
            this.butAgregar.UseVisualStyleBackColor = true;
            this.butAgregar.Click += new System.EventHandler(this.butAgregar_Click);
            // 
            // butModificar
            // 
            this.butModificar.Location = new System.Drawing.Point(123, 163);
            this.butModificar.Name = "butModificar";
            this.butModificar.Size = new System.Drawing.Size(75, 23);
            this.butModificar.TabIndex = 1;
            this.butModificar.Text = "Modificar";
            this.butModificar.UseVisualStyleBackColor = true;
            this.butModificar.Click += new System.EventHandler(this.button2_Click);
            // 
            // butEliminar
            // 
            this.butEliminar.Location = new System.Drawing.Point(123, 215);
            this.butEliminar.Name = "butEliminar";
            this.butEliminar.Size = new System.Drawing.Size(75, 23);
            this.butEliminar.TabIndex = 2;
            this.butEliminar.Text = "Eliminar";
            this.butEliminar.UseVisualStyleBackColor = true;
            this.butEliminar.Click += new System.EventHandler(this.butEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "CASA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "DEPARTAMENTO";
            // 
            // butAgregarDpto
            // 
            this.butAgregarDpto.Location = new System.Drawing.Point(364, 114);
            this.butAgregarDpto.Name = "butAgregarDpto";
            this.butAgregarDpto.Size = new System.Drawing.Size(75, 23);
            this.butAgregarDpto.TabIndex = 5;
            this.butAgregarDpto.Text = "Agregar";
            this.butAgregarDpto.UseVisualStyleBackColor = true;
            this.butAgregarDpto.Click += new System.EventHandler(this.butAgregarDpto_Click);
            // 
            // butModifiDpto
            // 
            this.butModifiDpto.Location = new System.Drawing.Point(364, 163);
            this.butModifiDpto.Name = "butModifiDpto";
            this.butModifiDpto.Size = new System.Drawing.Size(75, 23);
            this.butModifiDpto.TabIndex = 6;
            this.butModifiDpto.Text = "Modificar";
            this.butModifiDpto.UseVisualStyleBackColor = true;
            // 
            // butElimiDpto
            // 
            this.butElimiDpto.Location = new System.Drawing.Point(364, 214);
            this.butElimiDpto.Name = "butElimiDpto";
            this.butElimiDpto.Size = new System.Drawing.Size(75, 23);
            this.butElimiDpto.TabIndex = 7;
            this.butElimiDpto.Text = "Eliminar";
            this.butElimiDpto.UseVisualStyleBackColor = true;
            // 
            // ABMvivienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 363);
            this.Controls.Add(this.butElimiDpto);
            this.Controls.Add(this.butModifiDpto);
            this.Controls.Add(this.butAgregarDpto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butEliminar);
            this.Controls.Add(this.butModificar);
            this.Controls.Add(this.butAgregar);
            this.Name = "ABMvivienda";
            this.Text = "ABMvivienda";
            this.Load += new System.EventHandler(this.ABMvivienda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAgregar;
        private System.Windows.Forms.Button butModificar;
        private System.Windows.Forms.Button butEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butAgregarDpto;
        private System.Windows.Forms.Button butModifiDpto;
        private System.Windows.Forms.Button butElimiDpto;
    }
}