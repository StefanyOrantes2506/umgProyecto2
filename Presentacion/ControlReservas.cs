namespace Presentacion
{
    public partial class ControlReservas : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly LoginForm _loginForm;
        private bool cerradoPorBoton = false;

        public ControlReservas(IServiceProvider serviceProvider, LoginForm loginForm)
        {
            _serviceProvider = serviceProvider;
            _loginForm = loginForm;
            InitializeComponent();
            AbrirFormHijo(new MenuPrincipalForm(_serviceProvider));
            personalizarDisenio();
        }

        public void personalizarDisenio()
        {
            pnlMovimientos.Visible = false;
            pnlConsultasReportes.Visible = false;
            pnlGestionarUsr.Visible = false;
        }

        private void OcultarSubMenu()
        {
            if (pnlMovimientos.Visible == true)
                pnlMovimientos.Visible = false;
            if (pnlConsultasReportes.Visible == true)
                pnlConsultasReportes.Visible = false;
            if (pnlGestionarUsr.Visible == true)
                pnlGestionarUsr.Visible = false;
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlMovimientos);
        }

        private void btnAsistencias_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new AsistenciaForm(_serviceProvider, this));
            OcultarSubMenu();
        }

        private void btnClases_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new ClaseForm(_serviceProvider, this));
            OcultarSubMenu();
        }

        private void btnEntrenadores_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new EntrenadorForm(_serviceProvider, this));
            OcultarSubMenu();
        }

        private void btnGimnasios_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new GimnasioForm(_serviceProvider, this));
            OcultarSubMenu();
        }

        private void btnMembresias_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new MembresiaForn(_serviceProvider, this));
            OcultarSubMenu();
        }

        private void btnMiembros_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new MiembroForm(_serviceProvider, this));
            OcultarSubMenu();
        }

        private void btnReservaciones_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new ReservacionForm(_serviceProvider, this));
            OcultarSubMenu();
        }

        private Form formularioActivo = null;
        public void AbrirFormHijo(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            pnlFormHijo.Controls.Add(formularioHijo);
            pnlFormHijo.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            cerradoPorBoton = true;
            this.Close();
            _loginForm.Show();
        }

        private void btnConsultasReportes_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlConsultasReportes);
        }

        private void btnControlUsr_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlGestionarUsr);
        }

        private void btnReReservas_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new ReportesReservacionesForm(_serviceProvider, this));
            OcultarSubMenu();
        }

        private void btnReAsistencias_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new ReportesAsistenciasForm(_serviceProvider, this));
            OcultarSubMenu();
        }

        private void btnGestionarUsr_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new UsuarioForm(_serviceProvider, this));
        }

        private void ControlReservas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing && !cerradoPorBoton)
            {
                _loginForm.Close();
            }
        }
    }
}