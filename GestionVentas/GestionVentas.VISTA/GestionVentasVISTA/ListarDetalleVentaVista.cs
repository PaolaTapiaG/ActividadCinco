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
    public partial class ListarDetalleVentaVista : Form
    {
        public ListarDetalleVentaVista()
        {
            InitializeComponent();
            this.textBox3.TextChanged += new EventHandler(textBox3_TextChanged);
            this.textBox4.TextChanged += new EventHandler(textBox4_TextChanged);
        }

        DetalleVentaBSS bss = new DetalleVentaBSS();
        VentaBSS bssvent = new VentaBSS();
        ProductoBSS bssprod = new ProductoBSS();
        public static int IdVentaSeleccionada = 0;
        public static int IdProductoSeleccionada = 0;

        private void ListarDetalleVentaVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarDetalleVentaBss();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int IdDetalleVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DatosVentaVista fr = new DatosVentaVista(IdDetalleVentaSeleccionada);
            fr.ShowDialog();
            bss.DetalleVentaDatosBSS(IdDetalleVentaSeleccionada);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SeleccionarVentaVista fr = new SeleccionarVentaVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Venta v = bssvent.ObtenerVentaIdBss(IdVentaSeleccionada);
                textBox1.Text = v.Total.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SeleccionarProductoVista fr = new SeleccionarProductoVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto p = bssprod.ObtenerProductoIdBss(IdProductoSeleccionada);
                textBox2.Text = p.NombreProducto;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVenta d = new DetalleVenta();
            d.IdVenta = IdVentaSeleccionada;
            d.IdProducto = IdProductoSeleccionada;
            d.Cantidad = Convert.ToInt32(textBox3.Text);
            d.PrecioVenta = Convert.ToDecimal(textBox4.Text);
            d.Total = Convert.ToDecimal(textBox5.Text);

            bss.InsertarDetalleVentaBss(d);
            MessageBox.Show("Se guardo correctamente el detalle de la venta");
            dataGridView1.DataSource = bss.ListarDetalleVentaBss();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int IdDetalleVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleVenta editarDetalleVenta = bss.ObtenerDetalleVentaIdBss(IdDetalleVentaSeleccionada);

            
            int cantidad;
            if (int.TryParse(textBox3.Text, out cantidad))
            {
                editarDetalleVenta.Cantidad = cantidad;
            }
            else
            {
                MessageBox.Show("La cantidad ingresada no es válida.");
                return; 
            }

            decimal precioVenta;
            if (decimal.TryParse(textBox4.Text, out precioVenta))
            {
                editarDetalleVenta.PrecioVenta = precioVenta;
            }
            else
            {
                MessageBox.Show("El precio de venta ingresado no es válido.");
                return; 
            }

        
            decimal total;
            if (decimal.TryParse(textBox5.Text, out total))
            {
                editarDetalleVenta.Total = total;
            }
            else
            {
                MessageBox.Show("El total ingresado no es válido.");
                return; 
            }

            bss.EditarDetalleVentaBss(editarDetalleVenta);
            MessageBox.Show("Datos Actualizados");

            dataGridView1.DataSource = bss.ListarDetalleVentaBss();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdDetalleVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro que lo desea eliminar?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarDetalleVentaBss(IdDetalleVentaSeleccionada);
                dataGridView1.DataSource = bss.ListarDetalleVentaBss();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            MultiplicarValores();
        }
        private void MultiplicarValores()
        {
            if (double.TryParse(textBox3.Text, out double valor1) &&
                double.TryParse(textBox4.Text, out double valor2))
            {
                textBox5.Text = (valor1 * valor2).ToString();
            }
            else
            {
                textBox5.Text = "Error";
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            MultiplicarValores();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
