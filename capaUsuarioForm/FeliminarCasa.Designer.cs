
namespace capaUsuarioForm
{
    partial class FeliminarCasa
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
            this.listBoxCasas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxCasas
            // 
            this.listBoxCasas.FormattingEnabled = true;
            this.listBoxCasas.ItemHeight = 15;
            this.listBoxCasas.Location = new System.Drawing.Point(101, 67);
            this.listBoxCasas.Name = "listBoxCasas";
            this.listBoxCasas.Size = new System.Drawing.Size(489, 94);
            this.listBoxCasas.TabIndex = 7;
            this.listBoxCasas.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // FeliminarCasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxCasas);
            this.Name = "FeliminarCasa";
            this.Text = "Eliminar Casa";
            this.Load += new System.EventHandler(this.FeliminarCasa_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxCasas;
    }
}