using Aplicacion.Interfaces;
using Dominio;
using Microsoft.Extensions.DependencyInjection;

namespace Presentacion
{
    public partial class UsuarioForm : Form
    {
        private readonly ControlReservas _formularioPrincipal;
        private readonly IServiceProvider _serviceProvider;
        private int idUsuario = 0;
        public UsuarioForm(IServiceProvider serviceProvider, ControlReservas formularioPrincipal)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            ListarUsuarios();
            _formularioPrincipal = formularioPrincipal;
        }

        private void ListarUsuarios()
        {
            try
            {
                var usuarios = _serviceProvider.GetService<IServicioUsuario>().ObtenerUsuarios();

                dgvUsuarios.DataSource = usuarios;
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            _formularioPrincipal.AbrirFormHijo(new MenuPrincipalForm(_serviceProvider));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNombreUsuario.Text) || String.IsNullOrEmpty(txtContrasenia.Text))
                {
                    MessageBox.Show("Complete todos los campos para continuar");

                    return;
                }

                Usuario usuario = new Usuario
                {
                    NombreUsuario = txtNombreUsuario.Text,
                    Contrasenia = txtContrasenia.Text,
                };

                _serviceProvider.GetService<IServicioUsuario>().AgregarUsuario(usuario);

                MessageBox.Show("Usuario creado con éxito");

                txtNombreUsuario.Text = "";
                txtContrasenia.Text = "";

                ListarUsuarios();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    if (dgvUsuarios.Columns[e.ColumnIndex].Name == "Eliminar")
                    {
                        int id = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells["Id"].Value);

                        _serviceProvider.GetService<IServicioUsuario>().EliminarUsuario(id);

                        MessageBox.Show("Usuario eliminado con éxito");
                        ListarUsuarios();
                    }
                    else if (dgvUsuarios.Columns[e.ColumnIndex].Name == "Editar")
                    {
                        idUsuario = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells["Id"].Value);
                        txtNombreUsuario.Text = Convert.ToString(dgvUsuarios.Rows[e.RowIndex].Cells["NombreUsuario"].Value);
                        txtContrasenia.Text = Convert.ToString(dgvUsuarios.Rows[e.RowIndex].Cells["Contrasenia"].Value);
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
                if (idUsuario == 0)
                {
                    MessageBox.Show("Eliga un registro primero para actualizar!");

                    return;
                }

                if (String.IsNullOrEmpty(txtNombreUsuario.Text) || String.IsNullOrEmpty(txtContrasenia.Text))
                {
                    MessageBox.Show("Complete todos los campos para continuar");

                    return;
                }

                Usuario usuario = new Usuario
                {
                    Id = idUsuario,
                    NombreUsuario = txtNombreUsuario.Text,
                    Contrasenia = txtContrasenia.Text,
                };

                _serviceProvider.GetService<IServicioUsuario>().ActualizarUsuario(usuario);

                MessageBox.Show("Usuario actualizado con éxito");

                txtNombreUsuario.Text = "";
                txtContrasenia.Text = "";
                idUsuario = 0;

                ListarUsuarios();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
