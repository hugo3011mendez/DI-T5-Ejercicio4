using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            }

            get
            {
                return errores;
            }
        }


        public DibujoAhorcado()
        {
            InitializeComponent();
        }
    }
}
