using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorMaquinaTuring
{
    public partial class x : Form
    {
        public x()
        {
            InitializeComponent();
            dgvCinta.ColumnCount = 0;
            dgvCinta.RowCount = 1;

        }
        //DECLARACIONES PUBLICAS PARA TODA LA CLASE FORM
        List<char> Cinta = new List<char>();
        int Cabezal = 1;// siempre en el 1 por que el 0 va ser blanco


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            //AL DARLE GUARDAR SE DEBE BLOQUEAR EL TXT DE LA CINTA Y EL BOTON DE GUARDAR

            //Validar que la cadena solo sea nuestro alfabeto 
            string strCadena = txtCadena.Text;
            char[] Alfabeto = { 'x', 'y', 'z', 'B' };
            foreach (char c in strCadena)
            {
                if (!Alfabeto.Contains(c))
                {
                    MessageBox.Show("La cadena contiene caracteres no válidos. Por favor, ingrese una cadena válida.");
                    return;
                }
            }
            //Activar los controles 
            grbBusqueda.Enabled = true;
            grbBusquedaEscritura.Enabled = true;
            grbEscribir.Enabled = true;
            grbLectura.Enabled = true;
            grbMover.Enabled = true;
            grbCaptura.Enabled = false;

            //Sacar las letras de la cadena y meterlos a la lista pa 
            Cinta.Add('B'); // Aqui se agrega un blanco al princiò
            foreach (char c in strCadena)
            {
                Cinta.Add(c);
            }
            //AL FINAL AÑADIR UN BLANCO
            Cinta.Add('B');
            CargaCinta();
            IndicarCabezal();
            lblLeyendo.Text = Leer().ToString();

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CargaCinta()
        {
            //Este jale es pa limpiar el data 
            dgvCinta.Columns.Clear();
            dgvCinta.Rows.Clear();
            dgvCinta.ColumnCount = 0;
            dgvCinta.RowCount = 1;

            //y aqui recorre la lista hasta el final y le da un tamaño pa q no sea tan grande los cuadritos 
            for (int i = 0; i < Cinta.Count; i++)
            {
                dgvCinta.Columns.Add("c" + i, "");
                dgvCinta.Columns[i].Width = 40;

                dgvCinta.Rows[0].Cells[i].Value = Cinta[i].ToString();
                dgvCinta.Rows[0].Cells[i].Style.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }
        }
        //Pone en rojo el cabezal
        private void IndicarCabezal()
        {
            if (Cinta.Count == 0) 
            { return; }
            foreach(DataGridViewCell cell in dgvCinta.Rows[0].Cells)
            {
                cell.Style.BackColor = Color.White;
            }
            dgvCinta.Rows[0].Cells[Cabezal].Style.BackColor = Color.Red;
        }

        //hacemos metodos de movimiento para que en otros procesos nomas llamemos el metodo de mover cabezal
        //puede ahorrar codigo
        private void MoverCabezalIzquierda()
        {
            if (Cabezal > 0)
            {
                Cabezal--;
                IndicarCabezal();
                lblLeyendo.Text = Leer().ToString();
            }
        }
        private void MoverCabezalDerecha()
        {
            if (Cabezal < Cinta.Count - 1)
            {
                Cabezal++;
                IndicarCabezal();
                lblLeyendo.Text = Leer().ToString();
            }
        }
        //Leer la letra que esta en el cabezal
        private char Leer()
        {
            return Cinta[Cabezal];
            
        }
        
        private void btnCabezalIzquirda_Click(object sender, EventArgs e)
        {
            MoverCabezalIzquierda();
        }

        private void btnCabezalDerecha_Click(object sender, EventArgs e)
        {
            MoverCabezalDerecha();
        }
    }
}
