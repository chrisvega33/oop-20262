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
                //impedir la edicion de celdas en el Grid
                Grid1.ReadOnly = true;
                //impedir agregar o eliminar filas en el grid
                Grid1.AllowUserToAddRows = false;
                Grid1.AllowUserToDeleteRows = false;
                //evitar que el usuario pueda cambiar le ancho de columna
                Grid1.AllowUserToResizeColumns = false;
                //evitar que el usuario pueda cambiar la altura de fila
                Grid1.AllowUserToResizeRows = false;
                //colocar etiquetas a los titulos de ciertas columnas
                Grid1.Columns["ProductoID"].HeaderText = "ID único";
                Grid1.Columns["Nombre"].HeaderText = "Nombre del producto";
                Grid1.Columns["PrecioVenta"].HeaderText = "Precio de Venta";

                //colocar la alineacion del texto a la derecha para las columnas de dinero
                Grid1.Columns["Costo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid1.Columns["PrecioVenta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid1.Columns["Existencias"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                //colocar formato de miles a las columnas de numeros (mascara de entrada)
                Grid1.Columns["Costo"].DefaultCellStyle.Format = "###,###,##0.00";
                Grid1.Columns["PrecioVenta"].DefaultCellStyle.Format = "###,###,##0.00";
                Grid1.Columns["Existencias"].DefaultCellStyle.Format = "###,###,##0";
                //para ProductoID lo mostraremos a 8 digitos con relleno de ceros (leading zeros)
                Grid1.Columns["ProductoID"].DefaultCellStyle.Format = "00000000";

                //ejecutar el evento de cambio de tamaño del Form
                this.Principal_SizeChanged(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Principal_SizeChanged(object sender, EventArgs e)
        {
            //Evento que se dispara cuando cambiamos el tamaño del Form
            try
            {
                //si no hay columnas que no haga nada
                if (Grid1.Columns.Count == 0) return;

                //establecemos los anchos de columnas del grid
                //columnas con anchos fijos (fixed)
                Grid1.Columns["ProductoID"].Width = 85; //medias en pixels
                Grid1.Columns["Codigo"].Width = 70;
                Grid1.Columns["Costo"].Width = 100;
                Grid1.Columns["PrecioVenta"].Width = 120;
                Grid1.Columns["Existencias"].Width = 100;

                //columnas con ancho porcentual con respecto al ancho del grid
                Grid1.Columns["Nombre"].Width = Grid1.Width * 30 / 100; //30% del ancho de Grid1
                Grid1.Columns["Observaciones"].Width = Grid1.Width * 50 / 100; //50%
            }
            catch (Exception ex)
            {
            }
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            //Mandar a llamar al Form llamado Detalle
            Detalle d = new Detalle();
            d.ShowDialog(); //mostrar el Form de forma Modal (superpuesto sobre el propietario)

            //Verificar que se hizo click en el boton Aceptar en el Form de Detalle
            if( d.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Hizo click en Aceptar");
            }
        }
    }
}
