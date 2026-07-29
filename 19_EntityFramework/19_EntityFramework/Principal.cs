namespace _19_EntityFramework
{
    public partial class Principal : Form
    {
        //Metodo para cargar los registros desde la base de datos hacia Grid1
        public void CargarDatos()
        {
            try
            {
                //crear un objeto que tenga acceso al conexto de la BD
                Data.GerardoContext contexto = new Data.GerardoContext();

                //apuntar el contenido de Grid1 hacia el contenido del objeto
                //que representa a la tabla Productos
                Grid1.DataSource = contexto.Productos.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Principal()
        {
            InitializeComponent();
        }

        private void Grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.CargarDatos();

            try
            {
                //Personalizar Grid1
                //ocultar el selector de filas
                Grid1.RowHeadersVisible = false;
                //Evitar que seleccionen multiples filas
                Grid1.MultiSelect = false;
                //Sombrear toda la fila
                Grid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
