using Aplicacion.Interfaces;
using Dominio;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Presentacion
{
    public partial class GimnasioForm : Form
    {
        private readonly ControlReservas _formularioPrincipal;
        private readonly IServiceProvider _serviceProvider;
        private int idGimnasio = 0;
        public GimnasioForm(IServiceProvider serviceProvider, ControlReservas formularioPrincipal)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            ListarGimnasios();
            _formularioPrincipal = formularioPrincipal;
        }

        private void ListarGimnasios()
        {
            try
            {
                var gimnasios = _serviceProvider.GetService<IServicioGimnasio>().ObtenerGimnasios();

                dgvGimnasios.DataSource = gimnasios;
            }
            catch
            {
                MessageBox.Show("Ha sucedido un error");
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            _formularioPrincipal.AbrirFormHijo(new MenuPrincipalForm(_serviceProvider));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtDireccion.Text) || String.IsNullOrEmpty(txtTelefono.Text))
                {
                    MessageBox.Show("Complete todos los campos para continuar");

                    return;
                }

                Gimnasio gimnasio = new Gimnasio
                {
                    Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text
                };

                _serviceProvider.GetService<IServicioGimnasio>().AgregarGimnasio(gimnasio);

                MessageBox.Show("Gimnasio creado con éxito");

                txtNombre.Text = "";
                txtDireccion.Text = "";
                txtTelefono.Text = "";

                ListarGimnasios();
            }
            catch
            {
                MessageBox.Show("Ha sucedido un error");
            }
        }

        private void dgvGimnasios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    if (dgvGimnasios.Columns[e.ColumnIndex].Name == "Eliminar")
                    {
                        int id = Convert.ToInt32(dgvGimnasios.Rows[e.RowIndex].Cells["Id"].Value);

                        _serviceProvider.GetService<IServicioGimnasio>().EliminarGimnasio(id);

                        MessageBox.Show("Gimnasio eliminado con éxito");
                        ListarGimnasios();
                    }
                    else if (dgvGimnasios.Columns[e.ColumnIndex].Name == "Editar")
                    {
                        idGimnasio = Convert.ToInt32(dgvGimnasios.Rows[e.RowIndex].Cells["Id"].Value);
                        txtNombre.Text = Convert.ToString(dgvGimnasios.Rows[e.RowIndex].Cells["Nombre"].Value);
                        txtDireccion.Text = Convert.ToString(dgvGimnasios.Rows[e.RowIndex].Cells["Direccion"].Value);
                        txtTelefono.Text = Convert.ToString(dgvGimnasios.Rows[e.RowIndex].Cells["Telefono"].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha sucedido un error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (idGimnasio == 0)
                {
                    MessageBox.Show("Eliga un registro primero para actualizar!");

                    return;
                }

                if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtDireccion.Text) || String.IsNullOrEmpty(txtTelefono.Text))
                {
                    MessageBox.Show("Complete todos los campos para continuar");

                    return;
                }

                Gimnasio gimnasio = new Gimnasio
                {
                    Id = idGimnasio,
                    Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text
                };

                _serviceProvider.GetService<IServicioGimnasio>().ActualizarGimnasio(gimnasio);

                MessageBox.Show("Gimnasio actualizado con éxito");

                txtNombre.Text = "";
                txtDireccion.Text = "";
                txtTelefono.Text = "";
                idGimnasio = 0;

                ListarGimnasios();
            }
            catch
            {
                MessageBox.Show("Ha sucedido un error");
            }
        }
    }
}
