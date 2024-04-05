using GestionVentas.BSS;
using GestionVentas.MODELOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVentas.VISTA.GestionVentasVISTA
{
    public partial class DatosVentaVista : Form
    {
        public DatosVentaVista(int id)
        {
            idx = id;
            InitializeComponent();
        }
        int idx = 0;
        DetalleVenta c = new DetalleVenta();
        DetalleVentaBSS bss = new DetalleVentaBSS();
        private void DatosVentaVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.DetalleVentaDatosBSS(idx);

        }
    }
}
