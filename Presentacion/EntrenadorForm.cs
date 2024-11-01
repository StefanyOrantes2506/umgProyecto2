using Aplicacion.Interfaces;
using Dominio;
using Microsoft.Extensions.DependencyInjection;

namespace Presentacion
{
    public partial class EntrenadorForm : Form
    {
        private readonly ControlReservas _formularioPrincipal;
        private readonly IServiceProvider _serviceProvider;
        private int idEntrenador = 0;
        public EntrenadorForm(IServiceProvider serviceProvider, ControlReservas formularioPrincipal)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            ListarEntrenadores();
            _formularioPrincipal = formularioPrincipal;
        }

        private void ListarEntrenadores()
        {
            try
            {
                var entrenadores = _serviceProvider.GetService<IServicioEntrenador>().ObtenerEntrenadores();

                dgvEntrenadores.DataSource = entrenadores;
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
                if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellido.Text) || String.IsNullOrEmpty(txtEdad.Text))
                {
                    MessageBox.Show("Complete todos los campos para continuar");

                    return;
                }

                Entrenador entrenador = new Entrenador
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Edad = Convert.ToInt32(txtEdad.Text)
                };

                _serviceProvider.GetService<IServicioEntrenador>().AgregarEntrenador(entrenador);

                MessageBox.Show("Entrenador creado con éxito");

                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEdad.Text = "";

                ListarEntrenadores();
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

        private void dgvEntrenadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    if (dgvEntrenadores.Columns[e.ColumnIndex].Name == "Eliminar")
                    {
                        int id = Convert.ToInt32(dgvEntrenadores.Rows[e.RowIndex].Cells["Id"].Value);

                        _serviceProvider.GetService<IServicioEntrenador>().EliminarEntrenador(id);

                        MessageBox.Show("Entrenador eliminado con éxito");
                        ListarEntrenadores();
                    }
                    else if (dgvEntrenadores.Columns[e.ColumnIndex].Name == "Editar")
                    {
                        idEntrenador = Convert.ToInt32(dgvEntrenadores.Rows[e.RowIndex].Cells["Id"].Value);
                        txtNombre.Text = Convert.ToString(dgvEntrenadores.Rows[e.RowIndex].Cells["Nombre"].Value);
                        txtApellido.Text = Convert.ToString(dgvEntrenadores.Rows[e.RowIndex].Cells["Apellido"].Value);
                        txtEdad.Text = Convert.ToString(dgvEntrenadores.Rows[e.RowIndex].Cells["Edad"].Value);
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
                if (idEntrenador == 0)
                {
                    MessageBox.Show("Eliga un registro primero para actualizar!");

                    return;
                }

                if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellido.Text) || String.IsNullOrEmpty(txtEdad.Text))
                {
                    MessageBox.Show("Complete todos los campos para continuar");

                    return;
                }

                Entrenador entrenador = new Entrenador
                {
                    Id = idEntrenador,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Edad = Convert.ToInt32(txtEdad.Text)
                };

                _serviceProvider.GetService<IServicioEntrenador>().ActualizarEntrenador(entrenador);

                MessageBox.Show("Entrenador actualizado con éxito");

                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEdad.Text = "";
                idEntrenador = 0;

                ListarEntrenadores();
            }
            catch
            {
                MessageBox.Show("Ha sucedido un error");
            }
        }
    }
}
