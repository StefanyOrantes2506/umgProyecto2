using Aplicacion.Interfaces;
using Dominio;
using Microsoft.Extensions.DependencyInjection;

namespace Presentacion
{
    public partial class MembresiaForn : Form
    {
        private readonly ControlReservas _formularioPrincipal;
        private readonly IServiceProvider _serviceProvider;
        private int idMembresia = 0;
        public MembresiaForn(IServiceProvider serviceProvider, ControlReservas formularioPrincipal)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            ListarMembresias();
            _formularioPrincipal = formularioPrincipal;
        }

        private void ListarMembresias()
        {
            try
            {
                var membresias = _serviceProvider.GetService<IServicioMembresia>().ObtenerMembresias();

                dgvMembresias.DataSource = membresias;
            }
            catch
            {
                MessageBox.Show("Ha sucedido un error");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Complete todos los campos para continuar");

                    return;
                }

                Membresia membresia = new Membresia
                {
                    Nombre = txtNombre.Text
                };

                _serviceProvider.GetService<IServicioMembresia>().AgregarMembresia(membresia);

                MessageBox.Show("Membresia creada con éxito");

                txtNombre.Text = "";

                ListarMembresias();
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

        private void dgvMembresias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    if (dgvMembresias.Columns[e.ColumnIndex].Name == "Eliminar")
                    {
                        int id = Convert.ToInt32(dgvMembresias.Rows[e.RowIndex].Cells["Id"].Value);

                        _serviceProvider.GetService<IServicioMembresia>().EliminarMembresia(id);

                        MessageBox.Show("Membresia eliminada con éxito");
                        ListarMembresias();
                    }
                    else if (dgvMembresias.Columns[e.ColumnIndex].Name == "Editar")
                    {
                        idMembresia = Convert.ToInt32(dgvMembresias.Rows[e.RowIndex].Cells["Id"].Value);
                        txtNombre.Text = Convert.ToString(dgvMembresias.Rows[e.RowIndex].Cells["Nombre"].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha sucedido un error");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idMembresia == 0)
                {
                    MessageBox.Show("Eliga un registro primero para actualizar!");

                    return;
                }

                if (String.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Complete todos los campos para continuar");

                    return;
                }

                Membresia membresia = new Membresia
                {
                    Id = idMembresia,
                    Nombre = txtNombre.Text
                };

                _serviceProvider.GetService<IServicioMembresia>().ActualizarMembresia(membresia);

                MessageBox.Show("Membresia actualizada con éxito");

                txtNombre.Text = "";
                idMembresia = 0;

                ListarMembresias();
            }
            catch
            {
                MessageBox.Show("Ha sucedido un error");
            }
        }
    }
}
