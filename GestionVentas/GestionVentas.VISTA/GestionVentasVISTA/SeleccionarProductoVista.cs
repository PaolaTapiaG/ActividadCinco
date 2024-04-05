using GestionVentas.BSS;
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
    public partial class SeleccionarProductoVista : Form
    {
        public SeleccionarProductoVista()
        {
            InitializeComponent();
        }
        ProductoBSS bss = new ProductoBSS();
        private void SeleccionarProductoVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProductoBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarDetalleVentaVista.IdProductoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
