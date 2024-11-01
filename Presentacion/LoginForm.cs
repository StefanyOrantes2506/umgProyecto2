using Aplicacion.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Presentacion
{
    public partial class LoginForm : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public LoginForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var nombreUsuario = txtNombreUsuario.Text;
            var contrasenia = txtContrasenia.Text;

            if (_serviceProvider.GetService<IServicioUsuario>().Login(nombreUsuario, contrasenia))
            {
                MessageBox.Show("Inicio de sesión exitoso");
                this.Hide();
                Form form = new ControlReservas(_serviceProvider, this);
                form.Show();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }
    }
}
