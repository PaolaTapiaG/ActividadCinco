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
    public partial class ListarVentasVista : Form
    {
        public ListarVentasVista()
        {
            InitializeComponent();
        }
        VentaBSS bss = new VentaBSS();
        private void ListarVentasVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarVentaBss();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Venta u = new Venta();

          
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
               
                if (decimal.TryParse(textBox1.Text, out decimal total))
                {
                    u.Total = total;
                }
                else
                {
                    MessageBox.Show("El total ingresado no es válido.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese el total de la venta.");
                return;
            }

            u.Fecha = dateTimePicker1.Value;

           
            try
            {
                bss.InsertarVentaBss(u);
                MessageBox.Show("La venta se guardó correctamente.");
                dataGridView1.DataSource = bss.ListarVentaBss();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la venta: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int IdVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Venta editarVenta = bss.ObtenerVentaIdBss(IdVentaSeleccionada);

            
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
             
                if (decimal.TryParse(textBox1.Text, out decimal total))
                {
                    editarVenta.Total = total;
                }
                else
                {
                    MessageBox.Show("El valor ingresado en Total no es válido.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese el valor en Total.");
                return;
            }

            editarVenta.Fecha = dateTimePicker1.Value;
            try
            {
                bss.EditarVentaBss(editarVenta);
                MessageBox.Show("Datos Actualizados");
                dataGridView1.DataSource = bss.ListarVentaBss();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos de la venta: " + ex.Message);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar a esta venta?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarVentaBss(IdVentaSeleccionada);
                dataGridView1.DataSource = bss.ListarVentaBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListarDetalleVentaVista formulario = new ListarDetalleVentaVista();
            formulario.ShowDialog();
        }
    }
}
