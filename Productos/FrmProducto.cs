using Productos.daoo;
using Productos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productos
{
    public partial class FrmProducto : Form
    {
        ProductoDao dao = new ProductoDao();
        public FrmProducto()
        {
            InitializeComponent();
            LlenarGrid();
        }
        public void LlenarGrid()
        {
            this.dgvRegistros.DataSource = dao.VerCarrito();
            this.dgvRegistros.Refresh();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            prod.Nombre = tbNombre.Text.ToUpper();
            prod.Codigo = tbCodigo.Text.ToUpper();
            prod.Precio = double.Parse(tbPrecio.Text);
            prod.IVA = chkIVA.Checked;
            dao.Agregar(prod);
            LlenarGrid();
        }
    }
}
