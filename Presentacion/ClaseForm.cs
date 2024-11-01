using Aplicacion.Interfaces;
using Dominio;
using Microsoft.Extensions.DependencyInjection;

namespace Presentacion
{
    public partial class ClaseForm : Form
    {
        private readonly ControlReservas _formularioPrincipal;
        private readonly IServiceProvider _serviceProvider;
        private int idClase = 0;
        private int idEntrenador = 0;
        private int idGimnasio = 0;
        public ClaseForm(IServiceProvider serviceProvider, ControlReservas formularioPrincipal)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            cargarEntrenadores();
            cargarGimnasios();
            ListarClases();
            _formularioPrincipal = formularioPrincipal;
        }

        private void cargarEntrenadores()
        {
            try
            {
                var entrenadores = _serviceProvider.GetService<IServicioEntrenador>().ObtenerEntrenadores();

                cmbEntrenador.DataSource = entrenadores;
                cmbEntrenador.DisplayMember = "Nombre";
                cmbEntrenador.ValueMember = "Id";
                dtpHorario.Checked = false;

                cmbEntrenador.SelectedIndex = -1;
            }
            catch
            {
                MessageBox.Show("Ha sucedido un error");
            }
        }

        private void cargarGimnasios()
        {
            try
            {
                var gimnasios = _serviceProvider.GetService<IServicioGimnasio>().ObtenerGimnasios();

                cmbGimnasio.DataSource = gimnasios;
                cmbGimnasio.DisplayMember = "Nombre";
                cmbGimnasio.ValueMember = "Id";

                cmbGimnasio.SelectedIndex = -1;
            }
            catch
            {
                MessageBox.Show("Ha sucedido un error");
            }
        }

        private void ListarClases()
        {
            try
            {
                var clases = _serviceProvider.GetService<IServicioClase>().ObtenerClases();

                dgvClases.DataSource = clases;
            }
            catch
            {
                MessageBox.Show("Ha sucedido un error");
            }
        }

        private void cmbEntrenador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbEntrenador.SelectedIndex != -1) {
                idEntrenador = (int)cmbEntrenador.SelectedValue;
            }
        }

        private void cmbGimnasio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbGimnasio.SelectedIndex != -1)
            {
               idGimnasio = (int)cmbGimnasio.SelectedValue;
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
                if (String.IsNullOrEmpty(txtNombre.Text) || !dtpHorario.Checked)
                {
                    MessageBox.Show("Complete todos los campos para continuar");

                    return;
                }

                if (idEntrenador == 0)
                {
                    MessageBox.Show("Seleccione un entrenador para continuar");

                    return;
                }

                if (idGimnasio == 0)
                {
                    MessageBox.Show("Seleccione un gimnasio para continuar");

                    return;
                }

                Clase clase = new Clase
                {
                    Nombre = txtNombre.Text,
                    Horario = dtpHorario.Value,
                    IdEntrenador = idEntrenador,
                    IdGimnasio = idGimnasio
                };

                _serviceProvider.GetService<IServicioClase>().AgregarClase(clase);

                MessageBox.Show("Clase creada con éxito");

                txtNombre.Text = "";
                dtpHorario.Checked = false;
                idEntrenador = 0;
                idGimnasio = 0;
                cmbEntrenador.SelectedIndex = -1;
                cmbGimnasio.SelectedIndex = -1;

                ListarClases();
            }
            catch
            {
                MessageBox.Show("Ha sucedido un error");
            }
        }

        private void dgvClases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    if (dgvClases.Columns[e.ColumnIndex].Name == "Eliminar")
                    {
                        int id = Convert.ToInt32(dgvClases.Rows[e.RowIndex].Cells["Id"].Value);

                        _serviceProvider.GetService<IServicioClase>().EliminarClase(id);

                        MessageBox.Show("Clase eliminada con éxito");
                        ListarClases();
                    }
                    else if (dgvClases.Columns[e.ColumnIndex].Name == "Editar")
                    {
                        idClase = Convert.ToInt32(dgvClases.Rows[e.RowIndex].Cells["Id"].Value);
                        txtNombre.Text = Convert.ToString(dgvClases.Rows[e.RowIndex].Cells["Nombre"].Value);
                        dtpHorario.Value = Convert.ToDateTime(dgvClases.Rows[e.RowIndex].Cells["Horario"].Value);
                        cmbGimnasio.SelectedValue = Convert.ToInt32(dgvClases.Rows[e.RowIndex].Cells["IdGimnasio"].Value);
                        cmbEntrenador.SelectedValue = Convert.ToInt32(dgvClases.Rows[e.RowIndex].Cells["IdEntrenador"].Value);
                        idGimnasio = (int)cmbGimnasio.SelectedValue;
                        idEntrenador = (int)cmbEntrenador.SelectedValue;
                        dtpHorario.Checked = true;
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
                if (idClase == 0)
                {
                    MessageBox.Show("Eliga un registro primero para actualizar!");

                    return;
                }

                if (idEntrenador == 0)
                {
                    MessageBox.Show("Seleccione un entrenador para continuar");

                    return;
                }

                if (idGimnasio == 0)
                {
                    MessageBox.Show("Seleccione un gimnasio para continuar");

                    return;
                }

                if (String.IsNullOrEmpty(txtNombre.Text) || !dtpHorario.Checked)
                {
                    MessageBox.Show("Complete todos los campos para continuar");

                    return;
                }

                Clase clase = new Clase
                {
                    Id = idClase,
                    Nombre = txtNombre.Text,
                    Horario = dtpHorario.Value,
                    IdEntrenador = idEntrenador,
                    IdGimnasio = idGimnasio
                };

                _serviceProvider.GetService<IServicioClase>().ActualizarClase(clase);

                MessageBox.Show("Clase actualizada con éxito");

                txtNombre.Text = "";
                dtpHorario.Checked = false;
                idEntrenador = 0;
                idGimnasio = 0;
                idClase = 0;
                cmbEntrenador.SelectedIndex = -1;
                cmbGimnasio.SelectedIndex = -1;

                ListarClases();
            }
            catch
            {
                MessageBox.Show("Ha sucedido un error");
            }
        }
    }
}
