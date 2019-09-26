using Logica;
using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        private readonly Aplicacion app = new Aplicacion();
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarData()
        {
            var fila = new DataGridViewRow();
            fila.CreateCells(dgv);

            for (var i = 0; i < app.GetArrayCount(); i++)
            {
                fila.Cells[0].Value = app.GetProducto(i).codigo;
                fila.Cells[1].Value = app.GetProducto(i).nombre;
                fila.Cells[2].Value = app.GetProducto(i).detalle;
                fila.Cells[3].Value = app.GetProducto(i).costo;
                fila.Cells[4].Value = app.GetProducto(i).precio;
                fila.Cells[5].Value = app.GetProducto(i).fechaCrea.Date.ToString();
                fila.Cells[6].Value = app.GetProducto(i).fechaVec.Date.ToString();
                fila.Cells[7].Value = app.GetProducto(i).categoria;
                if (app.GetProducto(i).estado)
                {
                    fila.Cells[8].Value = "Activo";
                }
                else
                {
                    fila.Cells[8].Value = "Inactivo";
                }
            }

            dgv.Rows.Add(fila);
        }

        private void LimpiarTextos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            rtxtDetalle.Text = "";
            txtCosto.Text = "";
            txtCategoria.Text = "";
            chkEstado.Checked = true;
        }
        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            try
            {
                app.CrearProducto(txtCodigo.Text, txtNombre.Text, rtxtDetalle.Text, txtCosto.Text, txtPrecio.Text, dtpVence.Value.Date, txtCategoria.Text, chkEstado.Checked);
                LimpiarTextos();
                MostrarData();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Aparecio el siguiente error\n " + exception);
                throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            app.EliminarProducto(dgv.CurrentRow.Index);
            dgv.Rows.Remove(dgv.CurrentRow);
        }
    }
}
