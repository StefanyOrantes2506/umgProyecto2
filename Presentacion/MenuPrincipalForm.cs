namespace Presentacion
{
    public partial class MenuPrincipalForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public MenuPrincipalForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }
    }
}
