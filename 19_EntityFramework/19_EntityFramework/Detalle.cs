using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_EntityFramework
{
    public partial class Detalle : Form
    {
        public Detalle()
        {
            InitializeComponent();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            //destruir de la memoria el Form
            this.Dispose();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validacion de los datos escritos en las cajas de texto
                if( Codigo.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Codigo no puede ir vacio.");
                    return; //no continuar (Early Returns)
                }
                if( Nombre.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Nombre no puede ir vacio.");
                    return;
                }
                if( Double.Parse(Costo.Text) < 0)
                {
                    MessageBox.Show("Costo no puede ser negativo ni tampoco puede ir vacio.");
                    return;
                }
                if (Double.Parse(PrecioVenta.Text) <= 0)
                {
                    MessageBox.Show("Precio de Venta no puede ser <= CERO ni tampoco puede ir vacio.");
                    return;
                }
                if (Existencias.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Exitencias no pueden ir vacias.");
                    return;
                }
                //si llego hasta aqui es porque las validaciones fueron superadas exitosamente
                //Definir que este Form ha realizado una operacion OK (Aceptar)
                this.DialogResult = DialogResult.OK;
                //Cerrar el Formulario sin destruirlo (Ocultar)
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Revise que los datos digitados estan bien.");
            }
        }
    }
}
