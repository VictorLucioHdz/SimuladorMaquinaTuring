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
            dgvCinta.Columns.Clear();
            dgvCinta.Rows.Clear();
            dgvCinta.ColumnCount = 0;
            dgvCinta.RowCount = 1;


            for (int i = 0; i < Cinta.Count; i++)
            {
                dgvCinta.Columns.Add("c" + i, "");
                dgvCinta.Columns[i].Width = 40;

                dgvCinta.Rows[0].Cells[i].Value = Cinta[i].ToString();
                dgvCinta.Rows[0].Cells[i].Style.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void IndicarCabezal()
        {
            if (Cinta.Count == 0)
            { return; }
            foreach (DataGridViewCell cell in dgvCinta.Rows[0].Cells)
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



        private void dgvCinta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //usar el async hace que se vaya viendo el recorrido del cabezal de poco en poco (es mas estetico que nada)
        private async void btnBusqueda_Click(object sender, EventArgs e)
        {
            string buscar = cboLetraBusqueda.Text; //gardamos el simbolo que vayamos a buscar 

            if (string.IsNullOrEmpty(buscar)) //Validacion de que la variable no esté vacía
            {
                MessageBox.Show("Favor de seleccionar o ingresar un simbolo para buscar");
                return;
            }
            char simboloAEncontrar = buscar[0];
            bool encontrado = false;

            grbMover.Enabled = false;  // Bloqueamos controles para que no muevan nada mientras busca

            while (Cabezal < Cinta.Count) //Ciclo de busqueda hacía la derecha
            {
                IndicarCabezal(); //Actualizar lo que se está leyendo 
                lblLeyendo.Text = Leer().ToString();


                if (Cinta[Cabezal] == simboloAEncontrar) //Verificamos si el simbolo encontrado en el cabezal es el que buscamos
                {
                    // En caso de que lo sea cambiamos la variable encontrado a true 
                    encontrado = true;
                    dgvCinta.Rows[0].Cells[Cabezal].Style.BackColor = Color.Green; // ponemos el fondo en color verde para saber que lo hemos encontrado
                    await Task.Delay(1000); //usamos el async para que se vea el verde 1 segundo
                    IndicarCabezal(); // Regresar al color rojo del encavezado
                    break; // Salimos del ciclo
                }

                await Task.Delay(500); //Aqui ya usamos lo del async que pusimos al inicio del evento, esto unicamente hace que de un salto
                                       // a otro tenga una espera de medio segundo (es unicamente estetico, lo podemos quitar si da algun problema)

                //movemos cabezal a la otra poscicion 
                if (Cabezal < Cinta.Count - 1)
                {
                    Cabezal++;
                }

                else //esto es unicamente por si no se encuentra se sale directamente del ciclo 
                {

                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show($"El símbolo '{simboloAEncontrar}' no se encontró en el resto de la cinta.");
            }

            // Activamos otra vez los controles
            grbMover.Enabled = true;


        }


        private async void btnBuscarYRemplazar_Click(object sender, EventArgs e)
        {


            string strBuscar = cboBuscar.Text;
            string strReemplazar = cboRemplazar.Text;
            string strOcurrencia = txtOcurrencia.Text;

            if (string.IsNullOrEmpty(strBuscar) || string.IsNullOrEmpty(strReemplazar))
            {
                MessageBox.Show("Debes llenar los campos de 'Buscar' y 'Reemplazar por'.");
                return;
            }

            // Validar que la ocurrencia sea un número válido. 
            // Si lo dejan vacío, asumimos que buscan la 1ra ocurrencia.
            int ocurrenciaObjetivo = 1;
            if (!string.IsNullOrEmpty(strOcurrencia))
            {
                if (!int.TryParse(strOcurrencia, out ocurrenciaObjetivo) || ocurrenciaObjetivo < 1)
                {
                    MessageBox.Show("La ocurrencia debe ser un número mayor a 0.");
                    return;
                }
            }

            char charBuscar = strBuscar[0];
            char charReemplazar = strReemplazar[0];

            char[] Alfabeto = { 'x', 'y', 'z', 'B' };
            if (!Alfabeto.Contains(charReemplazar))
            {
                MessageBox.Show("El carácter de reemplazo no es válido en el alfabeto.");
                return;
            }

            grbBusqueda.Enabled = false;

            int contadorEncontrados = 0;
            bool reemplazoRealizado = false;


            while (Cabezal < Cinta.Count)
            {
                IndicarCabezal();
                lblLeyendo.Text = Leer().ToString();

                await Task.Delay(500);

                if (Cinta[Cabezal] == charBuscar)
                {
                    contadorEncontrados++;

                    if (contadorEncontrados == ocurrenciaObjetivo)
                    {

                        // 1. Modificar la lista de datos 
                        Cinta[Cabezal] = charReemplazar;

                        // 2. Modificar la vista
                        dgvCinta.Rows[0].Cells[Cabezal].Value = charReemplazar;

                        // 3. Actualizar etiqueta de lectura
                        lblLeyendo.Text = charReemplazar.ToString();

                        // Efecto visual de éxito 
                        dgvCinta.Rows[0].Cells[Cabezal].Style.BackColor = Color.LightGreen;
                        await Task.Delay(300);
                        IndicarCabezal();

                        MessageBox.Show($"Se reemplazó '{charBuscar}' por '{charReemplazar}' exitosamente.");
                        reemplazoRealizado = true;
                        break;
                    }
                }


                if (Cabezal < Cinta.Count - 1)
                {
                    Cabezal++;
                }
                else
                {
                    break;
                }
            }

            if (!reemplazoRealizado)
            {
                MessageBox.Show($"No se encontró la ocurrencia #{ocurrenciaObjetivo} del símbolo '{charBuscar}'.");
            }

            grbBusqueda.Enabled = true;
        }
    }
}
