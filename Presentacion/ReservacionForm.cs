using Aplicacion.Interfaces;
using Dominio;
using Microsoft.Extensions.DependencyInjection;

namespace Presentacion
{
    public partial class ReservacionForm : Form
    {
        private readonly ControlReservas _formularioPrincipal;
        private readonly IServiceProvider _serviceProvider;
        private int idReservacion = 0;
        private int idMiembro = 0;
        private int idClase = 0;
        private int idEntrenador = 0;
        public ReservacionForm(IServiceProvider serviceProvider, ControlReservas formularioPrincipal)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            cargarMiembros();
            cargarClases();
            cargarEntrenadores();
            ListarReservaciones();
            _formularioPrincipal = formularioPrincipal;
        }

        private void cargarMiembros()
        {
            try
            {
                var miembros = _serviceProvider.GetService<IServicioMiembro>().ObtenerMiembros();

                cmbMiembro.DataSource = miembros;
                cmbMiembro.DisplayMember = "Nombre";
                cmbMiembro.ValueMember = "Id";
                dtpFecha.Checked = false;

                cmbMiembro.SelectedIndex = -1;
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void cargarClases()
        {
            try
            {
                var clases = _serviceProvider.GetService<IServicioClase>().ObtenerClases();

                cmbClase.DataSource = clases;
                cmbClase.DisplayMember = "Nombre";
                cmbClase.ValueMember = "Id";

                cmbClase.SelectedIndex = -1;
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void cargarEntrenadores()
        {
            try
            {
                var entrenadores = _serviceProvider.GetService<IServicioEntrenador>().ObtenerEntrenadores();

                cmbEntrenador.DataSource = entrenadores;
                cmbEntrenador.DisplayMember = "Nombre";
                cmbEntrenador.ValueMember = "Id";

                cmbEntrenador.SelectedIndex = -1;
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void ListarReservaciones()
        {
            try
            {
                var reservaciones = _serviceProvider.GetService<IServicioReservacion>().ObtenerReservaciones();

                dgvReservaciones.DataSource = reservaciones;
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void cmbMiembro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMiembro.SelectedIndex != -1)
            {
                idMiembro = (int)cmbMiembro.SelectedValue;
            }
        }

        private void cmbClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClase.SelectedIndex != -1)
            {
                idClase = (int)cmbClase.SelectedValue;
            }
        }

        private void cmbEntrenador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEntrenador.SelectedIndex != -1)
            {
                idEntrenador = (int)cmbEntrenador.SelectedValue;
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
                if (!dtpFecha.Checked)
                {
                    MessageBox.Show("Complete todos los campos para continuar");

                    return;
                }

                if (idMiembro == 0)
                {
                    MessageBox.Show("Seleccione un miembro para continuar");

                    return;
                }

                if (idClase == 0)
                {
                    MessageBox.Show("Seleccione una clase para continuar");

                    return;
                }

                if (idEntrenador == 0)
                {
                    MessageBox.Show("Seleccione un entrenador para continuar");

                    return;
                }

                Reservacion reservacion = new Reservacion
                {
                    Fecha = dtpFecha.Value,
                    IdMiembro = idMiembro,
                    IdClase = idClase,
                    IdEntrenador = idEntrenador
                };

                _serviceProvider.GetService<IServicioReservacion>().AgregarReservacion(reservacion);

                MessageBox.Show("Reservación creada con éxito");

                dtpFecha.Checked = false;
                idMiembro = 0;
                idClase = 0;
                idEntrenador = 0;
                cmbMiembro.SelectedIndex = -1;
                cmbClase.SelectedIndex = -1;
                cmbEntrenador.SelectedIndex = -1;

                ListarReservaciones();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void dgvReservaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    if (dgvReservaciones.Columns[e.ColumnIndex].Name == "Eliminar")
                    {
                        int id = Convert.ToInt32(dgvReservaciones.Rows[e.RowIndex].Cells["Id"].Value);

                        _serviceProvider.GetService<IServicioReservacion>().EliminarReservacion(id);

                        MessageBox.Show("Reservación eliminada con éxito");
                        ListarReservaciones();
                    }
                    else if (dgvReservaciones.Columns[e.ColumnIndex].Name == "Editar")
                    {
                        idReservacion = Convert.ToInt32(dgvReservaciones.Rows[e.RowIndex].Cells["Id"].Value);
                        dtpFecha.Value = Convert.ToDateTime(dgvReservaciones.Rows[e.RowIndex].Cells["Fecha"].Value);
                        cmbMiembro.SelectedValue = Convert.ToInt32(dgvReservaciones.Rows[e.RowIndex].Cells["IdMiembro"].Value);
                        cmbClase.SelectedValue = Convert.ToInt32(dgvReservaciones.Rows[e.RowIndex].Cells["IdClase"].Value);
                        cmbEntrenador.SelectedValue = Convert.ToInt32(dgvReservaciones.Rows[e.RowIndex].Cells["IdEntrenador"].Value);
                        idMiembro = (int)cmbMiembro.SelectedValue;
                        idClase = (int)cmbClase.SelectedValue;
                        idEntrenador = (int)cmbEntrenador.SelectedValue;
                        dtpFecha.Checked = true;
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
                if (idReservacion == 0)
                {
                    MessageBox.Show("Eliga un registro primero para actualizar!");

                    return;
                }

                if (idMiembro == 0)
                {
                    MessageBox.Show("Seleccione un miembro para continuar");

                    return;
                }

                if (idClase == 0)
                {
                    MessageBox.Show("Seleccione una clase para continuar");

                    return;
                }

                if (idEntrenador == 0)
                {
                    MessageBox.Show("Seleccione un entrenador para continuar");

                    return;
                }

                if (!dtpFecha.Checked)
                {
                    MessageBox.Show("Complete todos los campos para continuar");

                    return;
                }

                Reservacion reservacion = new Reservacion
                {
                    Id = idReservacion,
                    Fecha = dtpFecha.Value,
                    IdMiembro = idMiembro,
                    IdClase = idClase,
                    IdEntrenador = idEntrenador
                };

                _serviceProvider.GetService<IServicioReservacion>().ActualizarReservacion(reservacion);

                MessageBox.Show("Reservación actualizada con éxito");

                dtpFecha.Checked = false;
                idMiembro = 0;
                idClase = 0;
                idEntrenador = 0;
                idReservacion = 0;
                cmbMiembro.SelectedIndex = -1;
                cmbClase.SelectedIndex = -1;
                cmbEntrenador.SelectedIndex = -1;

                ListarReservaciones();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
