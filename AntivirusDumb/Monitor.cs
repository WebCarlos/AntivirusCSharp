using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntivirusForm
{
    public partial class Monitor : Form
    {

        
        public Monitor()
        {
            InitializeComponent();            
        }
        public void actualizar(string []aux)
        {
            CheckForIllegalCrossThreadCalls = false;
            gridEventos.Rows.Add(aux);
            CheckForIllegalCrossThreadCalls = true;

            
        }
    }

    public class EventosAux
    {
        public String Fecha;
        public String Ruta;
        public String Evento;
    }
}
