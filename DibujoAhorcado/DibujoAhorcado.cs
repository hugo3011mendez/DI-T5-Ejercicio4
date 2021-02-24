using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace DibujoAhorcado
{
    public partial class DibujoAhorcado : UserControl
    {
        int errores;
        [Category("Errores")]
        [Description("Indica el número de errores cometidos")]
        public int Errores
        {
            set
            {
                errores = value;

                Ahorcado?.Invoke(this, EventArgs.Empty); // Lanzo el evento cambiaError cuando cambia el valor de la propiedad errores
            }

            get
            {
                return errores;
            }
        }


        [Category("Errores")]
        [Description("Se lanza cuando cambia el valor de los errores")]
        public event EventHandler CambiaError;

        [Category("Errores")]
        [Description("Se lanza cuando se completa el ahorcado")]
        public event EventHandler Ahorcado;



        public DibujoAhorcado()
        {
            if (Thread.CurrentThread.CurrentUICulture == CultureInfo.GetCultureInfo("en"))
            {
                Console.WriteLine(Properties.Recursos.Modulo);
            }

            InitializeComponent();
        }


        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            Graphics g = pe.Graphics;
            int grosor = 7; // Variable que controla el grosor del lápiz


            //Esta propiedad provoca mejoras en la apariencia o en la eficiencia a la hora de dibujar
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;


            Pen lapiz = new Pen(Color.Black, grosor);

            // Dibujo la base del ahorcado
            g.DrawLine(lapiz, this.Width, this.Height, 0, this.Height);
            g.DrawLine(lapiz, 0, this.Height, 0, 0);
            g.DrawLine(lapiz, 0, 0, this.Width / 2, 0);

            // Cambio el grosor del lápiz para dibujar el apoyo y la cuerda con el muñeco
            grosor = 5;
            lapiz = new Pen(Color.Black, grosor);
            g.DrawLine(lapiz, 0, this.Height / 5, this.Width / 5, 0);


            switch (errores)
            {
                case 1: // Dibujo la cuerda
                    g.DrawLine(lapiz, this.Width / 2, 0, this.Width / 2, this.Height / 5);
                    break;


                case 2: // Añado la cabeza
                    g.DrawEllipse(lapiz, this.Width / 2.35f, this.Height / 5, this.Width / 6.5f, this.Width / 6.5f);
                    goto case 1;


                case 3: // Añado el torso
                    g.DrawLine(lapiz, this.Width / 2f, this.Height / 5 + this.Width / 6.5f, this.Width / 2f, (this.Height / 5 + this.Width / 6.5f) * 2);
                    goto case 2;

                case 4: // Añado brazo derecho
                    g.DrawLine(lapiz, this.Width / 2f, (this.Height / 5 + this.Width / 6.5f) * 1.25f, this.Width / 1.45f, (this.Height / 5 + this.Width / 6.5f) * 1.25f);
                    goto case 3;

                case 5: // Añado brazo izquierdo
                    g.DrawLine(lapiz, this.Width / 2f, (this.Height / 5 + this.Width / 6.5f) * 1.25f, this.Width / 3.5f, (this.Height / 5 + this.Width / 6.5f) * 1.25f);
                    goto case 4;

                case 6: // Añado pierna izquierda
                    g.DrawLine(lapiz, this.Width / 2f, (this.Height / 5 + this.Width / 6.5f) * 2, this.Width / 3f, ((this.Height / 5 + this.Width / 6.5f) * 2) * 1.25f);
                    goto case 5;

                case 7: // Añado pierna derecha
                    g.DrawLine(lapiz, this.Width / 2f, (this.Height / 5 + this.Width / 6.5f) * 2, this.Width / 1.45f, ((this.Height / 5 + this.Width / 6.5f) * 2) * 1.25f);

                    Ahorcado?.Invoke(this, EventArgs.Empty); // Lanzo el evento Ahorcado cuando llega al final
                    goto case 6;
            }
        }
    }
}
