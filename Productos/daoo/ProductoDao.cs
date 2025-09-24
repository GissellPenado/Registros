using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Productos.Modelos;

namespace Productos.daoo
{
    public class ProductoDao
    {
        // ok
        private static int TAM = 5;
        const int TAMAÑO = 10;
        private Producto[] carrito = new Producto[TAM];
        private int pos = 0;
        public void Agregar(Producto prod)
        {
            try
            {
                carrito[pos++] = prod;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("No se puede agregar más elementos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public Producto[] VerCarrito()
        {
            return carrito;
        }
    }
}
