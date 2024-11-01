using Aplicacion.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Presentacion
{
    public partial class ReportesReservacionesForm : Form
    {
        private readonly ControlReservas _formularioPrincipal;
        private readonly IServiceProvider _serviceProvider;
        private string tipoReporte = "";
        private int idMiembro = 0;
        private int idClase = 0;
        private int idEntrenador = 0;
        public ReportesReservacionesForm(IServiceProvider serviceProvider, ControlReservas formularioPrincipal)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _formularioPrincipal = formularioPrincipal;
        }

        private void cmbTipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoReporte.SelectedIndex == 0)
                {
                    tipoReporte = "";
                    var miembros = _serviceProvider.GetService<IServicioMiembro>().ObtenerMiembros();

                    cmbReporte.DataSource = miembros;
                    cmbReporte.DisplayMember = "Nombre";
                    cmbReporte.ValueMember = "Id";

                    cmbReporte.SelectedIndex = -1;
                }
                else if (cmbTipoReporte.SelectedIndex == 1)
                {
                    tipoReporte = "";
                    var clases = _serviceProvider.GetService<IServicioClase>().ObtenerClases();

                    cmbReporte.DataSource = clases;
                    cmbReporte.DisplayMember = "Nombre";
                    cmbReporte.ValueMember = "Id";

                    cmbReporte.SelectedIndex = -1;
                }
                else if (cmbTipoReporte.SelectedIndex == 2)
                {
                    tipoReporte = "";
                    var entrenadores = _serviceProvider.GetService<IServicioEntrenador>().ObtenerEntrenadores();

                    cmbReporte.DataSource = entrenadores;
                    cmbReporte.DisplayMember = "Nombre";
                    cmbReporte.ValueMember = "Id";

                    cmbReporte.SelectedIndex = -1;
                }
                tipoReporte = cmbTipoReporte.Text;
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void cmbReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tipoReporte))
            {
                if (cmbTipoReporte.SelectedIndex == 0)
                {
                    idMiembro = (int)cmbReporte.SelectedValue;
                }
                else if (cmbTipoReporte.SelectedIndex == 1)
                {
                    idClase = (int)cmbReporte.SelectedValue;
                }
                else if (cmbTipoReporte.SelectedIndex == 2)
                {
                    idEntrenador = (int)cmbReporte.SelectedValue;
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoReporte.SelectedIndex == -1)
                {
                    MessageBox.Show("Elija un tipo de registro por el cual quiere filtrar!");

                    return;
                }

                if (cmbReporte.SelectedIndex == -1)
                {
                    MessageBox.Show("Elija un registro!");
                    return;
                }

                if (tipoReporte.Equals("Miembros") && idMiembro != 0)
                {
                    var reservaciones = _serviceProvider.GetService<IServicioReservacion>().ObtenerReservacionesPorMiembro(idMiembro);

                    dgvReportes.DataSource = null;
                    dgvReportes.DataSource = reservaciones;

                    idMiembro = 0;
                }
                else if (tipoReporte.Equals("Clases") && idClase != 0)
                {
                    var reservaciones = _serviceProvider.GetService<IServicioReservacion>().ObtenerReservacionesPorClase(idClase);

                    dgvReportes.DataSource = null;
                    dgvReportes.DataSource = reservaciones;

                    idClase = 0;
                }
                else if (tipoReporte.Equals("Entrenadores") && idEntrenador != 0)
                {
                    var reservaciones = _serviceProvider.GetService<IServicioReservacion>().ObtenerReservacionesPorEntrenador(idEntrenador);

                    dgvReportes.DataSource = null;
                    dgvReportes.DataSource = reservaciones;

                    idEntrenador = 0;
                }
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
    }
}
