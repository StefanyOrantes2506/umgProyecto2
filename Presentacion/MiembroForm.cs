using Aplicacion.Interfaces;
using Dominio;
using Microsoft.Extensions.DependencyInjection;

namespace Presentacion
{
    public partial class MiembroForm : Form
    {
        private readonly ControlReservas _formularioPrincipal;
        private readonly IServiceProvider _serviceProvider;
        private int idMiembro = 0;
        private int idMembresia = 0;
        public MiembroForm(IServiceProvider serviceProvider, ControlReservas formularioPrincipal)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            cargarMembresias();
            ListarMiembros();
            _formularioPrincipal = formularioPrincipal;
        }

        private void cargarMembresias()
        {
            try
            {
                var membresias = _serviceProvider.GetService<IServicioMembresia>().ObtenerMembresias();

                cmbTipoMembresia.DataSource = membresias;
                cmbTipoMembresia.DisplayMember = "Nombre";
                cmbTipoMembresia.ValueMember = "Id";

                cmbTipoMembresia.SelectedIndex = -1;
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void ListarMiembros()
        {
            try
            {
                var miembros = _serviceProvider.GetService<IServicioMiembro>().ObtenerMiembros();

                dgvMiembros.DataSource = miembros;
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void cmbTipoMembresia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTipoMembresia.SelectedIndex != -1)
            {
                idMembresia = (int)cmbTipoMembresia.SelectedValue;
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
                if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellido.Text) || String.IsNullOrEmpty(txtEdad.Text))
                {
                    MessageBox.Show("Complete todos los campos para continuar");

                    return;
                }

                if (idMembresia == 0)
                {
                    MessageBox.Show("Seleccione un tipo de membresía para continuar");

                    return;
                }

                Miembro miembro = new Miembro
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Edad = Convert.ToInt32(txtEdad.Text),
                    IdMembresia = idMembresia
                };

                _serviceProvider.GetService<IServicioMiembro>().AgregarMiembro(miembro);

                MessageBox.Show("Miembro creado con éxito");

                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEdad.Text = "";
                idMembresia = 0;
                cmbTipoMembresia.SelectedIndex = -1;

                ListarMiembros();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void dgvMiembros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    if (dgvMiembros.Columns[e.ColumnIndex].Name == "Eliminar")
                    {
                        int id = Convert.ToInt32(dgvMiembros.Rows[e.RowIndex].Cells["Id"].Value);

                        _serviceProvider.GetService<IServicioMiembro>().EliminarMiembro(id);

                        MessageBox.Show("Miembro eliminado con éxito");
                        ListarMiembros();
                    }
                    else if (dgvMiembros.Columns[e.ColumnIndex].Name == "Editar")
                    {
                        idMiembro = Convert.ToInt32(dgvMiembros.Rows[e.RowIndex].Cells["Id"].Value);
                        txtNombre.Text = Convert.ToString(dgvMiembros.Rows[e.RowIndex].Cells["Nombre"].Value);
                        txtApellido.Text = Convert.ToString(dgvMiembros.Rows[e.RowIndex].Cells["Apellido"].Value);
                        txtEdad.Text = Convert.ToString(dgvMiembros.Rows[e.RowIndex].Cells["Edad"].Value);
                        cmbTipoMembresia.SelectedValue = Convert.ToInt32(dgvMiembros.Rows[e.RowIndex].Cells["IdMembresia"].Value);
                        idMembresia = (int)cmbTipoMembresia.SelectedValue;
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
                if (idMiembro == 0)
                {
                    MessageBox.Show("Eliga un registro primero para actualizar!");

                    return;
                }

                if (idMembresia == 0)
                {
                    MessageBox.Show("Seleccione un tipo de membresía para continuar");

                    return;
                }

                if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellido.Text) || String.IsNullOrEmpty(txtEdad.Text))
                {
                    MessageBox.Show("Complete todos los campos para continuar");

                    return;
                }

                Miembro miembro = new Miembro
                {
                    Id = idMiembro,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Edad = Convert.ToInt32(txtEdad.Text),
                    IdMembresia = idMembresia
                };

                _serviceProvider.GetService<IServicioMiembro>().ActualizarMiembro(miembro);

                MessageBox.Show("Miembro actualizado con éxito");

                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEdad.Text = "";
                idMembresia = 0;
                idMiembro = 0;
                cmbTipoMembresia.SelectedIndex = -1;

                ListarMiembros();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
