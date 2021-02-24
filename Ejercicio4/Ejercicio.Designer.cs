namespace Ejercicio4
{
    partial class Ejercicio
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
            this.dibujoAhorcado1 = new DibujoAhorcado.DibujoAhorcado();
            this.SuspendLayout();
            // 
            // dibujoAhorcado1
            // 
            this.dibujoAhorcado1.Errores = 0;
            this.dibujoAhorcado1.Location = new System.Drawing.Point(75, 45);
            this.dibujoAhorcado1.Name = "dibujoAhorcado1";
            this.dibujoAhorcado1.Size = new System.Drawing.Size(171, 170);
            this.dibujoAhorcado1.TabIndex = 0;
            // 
            // Ejercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dibujoAhorcado1);
            this.Name = "Ejercicio";
            this.Text = "Ejercicio";
            this.ResumeLayout(false);

        }

        #endregion

        private DibujoAhorcado.DibujoAhorcado dibujoAhorcado1;
    }
}

