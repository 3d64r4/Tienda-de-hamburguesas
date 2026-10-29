
using System;
using System.Windows.Forms;

namespace Tienda_de_hamburguesas
{
    public partial class Tortas : Form
    {
        //  matriz de obsequios
        string[,] obsequios =
        {
            { "1", "Paquete Avengers" },
            { "2", "Paquete Barbie" },
            { "3", "Paquete Sorpresa" }
        };

        // productos de la tienda
        string[,] productos =
        {
            { "Paquete kids",     "55" },
            { "Jalapeño",         "25" },
            { "Italiana",         "30" },
            { "Jamón",            "25" },
            { "Refresco chico",   "12" },
            { "Refresco mediano", "15" },
            { "Refresco grande",  "18" },
            { "Galletas",         "13" },
            { "Pay de queso",     "22" },
            { "Nieve",            "15" }
        };

        public Tortas()
        {
            InitializeComponent();
        }

        private void Tortas_Load(object sender, EventArgs e)
        {
            // Ventana maximizada y sin poder minimizar
            this.WindowState = FormWindowState.Maximized;
            this.MinimizeBox = false;

            // Textbox deshabilitados
            textSubtotal.Enabled = false;
            textIva.Enabled = false;
            textTotal.Enabled = false;
            textObsequio.Enabled = false;

            // Deshabilitados hasta elegir Paquete kids
            textCodigo.Enabled = false;
            btnBuscar.Enabled = false;
        }

        //habilitando el obsequio solo si es Paquete kids
        private void listTorta_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool esKids = listTorta.SelectedItem != null &&
                          listTorta.SelectedItem.ToString() == "Paquete kids";

            textCodigo.Enabled = esKids;
            btnBuscar.Enabled = esKids;

            if (!esKids)
            {
                textCodigo.Clear();
                textObsequio.Clear();
            }
        }

        // Botón Buscar: busca el código en la matriz de obsequios
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = textCodigo.Text.Trim();

            for (int i = 0; i < obsequios.GetLength(0); i++)
            {
                if (obsequios[i, 0] == codigo)
                {
                    textObsequio.Text = obsequios[i, 1];
                    return;
                }
            }

            MessageBox.Show("Revise el codigo del obsequio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textCodigo.Clear();
            textObsequio.Clear();
            textCodigo.Focus();
        }

        // Buscando el precio
        private decimal BuscarPrecio(string producto)
        {
            for (int i = 0; i < productos.GetLength(0); i++)
            {
                if (productos[i, 0] == producto)
                    return decimal.Parse(productos[i, 1]);
            }
            return 0;
        }

        // calculando el total
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            // Validar que se seleccionó algo en las tres listas
            if (listTorta.SelectedIndex == -1 ||
                listRefresco.SelectedIndex == -1 ||
                listPostre.SelectedIndex == -1)
            {
                MessageBox.Show("Debe de capturar todos los campos",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string torta = listTorta.SelectedItem.ToString();
            string refresco = listRefresco.SelectedItem.ToString();
            string postre = listPostre.SelectedItem.ToString();

            // Si es Paquete kids, debe tener un obsequio válido
            if (torta == "Paquete kids" && textObsequio.Text == "")
            {
                MessageBox.Show("No se encuentra el codigo del obsequio",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // En la lista dice "Chico", en la matriz "Refresco chico"
            if (refresco != "Ninguno")
                refresco = "Refresco " + refresco.ToLower();

            decimal subtotal = BuscarPrecio(torta) + BuscarPrecio(refresco) + BuscarPrecio(postre);
            decimal iva = subtotal * 0.16m;
            decimal total = subtotal + iva;

            textSubtotal.Text = subtotal.ToString("0.##");
            textIva.Text = iva.ToString("0.##");
            textTotal.Text = total.ToString("0.##");
        }
    }
}