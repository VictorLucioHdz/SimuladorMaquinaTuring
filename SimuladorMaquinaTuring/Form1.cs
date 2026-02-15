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
    //E PAAA WACHA MI IDEA VAMOS A CREAR UNA LISTA EN LA CUAL VAMOS IR METIENDO OBJETOS DE TIPO MAQUINA TURING LA CUAL 
    //VA TENER PROPIEDADES QUE NECESITEMOS EN LOS DIFERENTES PROCESOS Y ASI CREAR LA LISTA DESPUES CONFORME EL BOTON DE 
    //AGREGAR DE CADA OPERACION VA TENER DEFINIDO UN NUMETO DE TIPO DE OPERACION Y UN NOMBRE PARA LLEVAR LA CUENTA DE CUANTAS MAQUINAS VAN
    //AL FINAL IRA UN BOTON QUE DIJA EJECUTAR EL CUAL VA A RECORRER LA LISTA DE OPERACIONES Y LA ESTRUCTURA QUE TENGO PENSADO HACER ES 
    //UN SWITCH CASE EN EL CUAL DEPENDIENDO DEL NUMERO DE OPERACION QUE TENGA ES LO QUE SE VA HACER PARA NO MESCLAR TANTO EN EL SWITCH 
    //VAMOS A LLAMAR SOLO LOS METODOS DENTRO DEL SWITCH 
    //POR EJEMPLO EL METODO DE BUSQUEDA QUE ESTA AL FINAL DE ESTE CODIGO, EN EL SWITCH SOLO SE LLAMARIA A ESE METODO Y LE PASARIAMOS LA MAQUINA TURING QUE CORRESPONDA Y ASI CON CADA PROCESO
    // EL NUMERO DE LAS OPERACIONES ES 1 PA BUSQUEDA, 2 PA ESCRIBIR , 
    //YA JALA 2 3, SI PONES LA MAQUINA DE BUSCAR EN VARIAS DIRECCIONES JALA LA MAARCA TAMBIEN Y LA DE ESCRIBIR PERO HYA UN PROBLEMA 
    //AL MOMENTO DE EJECUTAR Y BUSCAS UNA Z y LA CELDA EN LA QUE ESTA ES Z SE DETIENE HAY Q VALIDAR SI ES EMPEZANDO O APARTIR DE 
    //LA PRIMERA CELDA OTRA LAS OCURRENCIAS AUN NOSE COMO IMPLEMENTARLO
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
        List<MaquinaTuring> Operaciones = new List<MaquinaTuring>();
        int Cabezal = 1;// siempre en el 1 por que el 0 va ser blanco
        int MTnumero =0; //variable para saber que maquina turing se esta usando (busqueda, escritura, etc)


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
        private  void btnBusqueda_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbBusqueda.Text))
                
            {
                MessageBox.Show("Selecciona un símbolo a buscar.");
                return;
            }
            if (radDerecha.Checked || radIzq.Checked )
            {
                MaquinaTuring MT = new MaquinaTuring();
                MTnumero++;
                MT.Simbolo = char.Parse(cmbBusqueda.Text);//Obtenemos el simbolo a buscar del combo box
                MT.Nombre = "MT" + MTnumero.ToString(); //Le damos un nombre a la maquina turing (esto es opcional, pero puede servir para identificarla en caso de que queramos hacer varias maquinas turing)
                MT.Operacion = 1; //Operacion 1 es para busqueda
                MT.Posicion = (int)EmpezarEn.Value; //Obtenemos la posicion de inicio de la busqueda del numeric up down
                if (radDerecha.Checked)
                {
                    MT.Direccion = 'D';
                    listaOpe.Items.Add('D' + MT.Simbolo.ToString());
                    Operaciones.Add(MT);
                }
                else if (radIzq.Checked)
                {
                    MT.Direccion = 'I';
                    listaOpe.Items.Add('I' + MT.Simbolo.ToString());
                    Operaciones.Add(MT);
                }
                else
                {
                    MessageBox.Show("Selecciona una dirección para la búsqueda.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Selecciona una dirección para la búsqueda y el simbolo a buscar");
                return;
            }

        }
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbBusqueda.Text))

            {
                MessageBox.Show("Selecciona un símbolo a buscar.");
                return;
            }
            MaquinaTuring MT = new MaquinaTuring();
            MTnumero++;
            MT.Simbolo = char.Parse(cmbEscribir.Text);//Obtenemos el simbolo a escribir del combo box
            MT.Nombre = "MT" + MTnumero.ToString(); //Le damos un nombre a la maquina turing
            MT.Operacion = 2; //Operacion 2 es para escribir
            Operaciones.Add(MT);
            listaOpe.Items.Add( MT.Simbolo.ToString());

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
                        if(Cabezal == Cinta.Count - 1)
                        {
                            Cinta.Add('B');
                        }
                            
                        
                        

                        // 2. Modificar la vista
                        // dgvCinta.Rows[0].Cells[Cabezal].Value = charReemplazar;
                        
                        // 3. Actualizar etiqueta de lectura
                        lblLeyendo.Text = charReemplazar.ToString();

                        // Efecto visual de éxito 
                        dgvCinta.Rows[0].Cells[Cabezal].Style.BackColor = Color.LightGreen;
                        await Task.Delay(300);
                        CargaCinta();
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

        private void x_Load(object sender, EventArgs e)
        {

        }

        private void btnEscribirN_Click(object sender, EventArgs e)
        {
           
        }
        private async void Buscar(MaquinaTuring MT)
        {
            
            char simboloAEncontrar = MT.Simbolo;
            int Contador = 1;

            string Direccion = MT.Direccion.ToString();
            MessageBox.Show(MT.Nombre + MT.Simbolo.ToString() + MT.Direccion.ToString());
            bool encontrado = false;



            while (Cabezal >= 0 &&Cabezal < Cinta.Count) //Ciclo de busqueda hacía la derecha
            {
                IndicarCabezal(); //Actualizar lo que se está leyendo 
                lblLeyendo.Text = Leer().ToString();

                if (Contador >= MT.Posicion)//Si es apartir de la primera celda
                {

                    if (Cinta[Cabezal] == simboloAEncontrar) //Verificamos si el simbolo encontrado en el cabezal es el que buscamos
                    {
                        // En caso de que lo sea cambiamos la variable encontrado a true 
                        encontrado = true;
                        dgvCinta.Rows[0].Cells[Cabezal].Style.BackColor = Color.Green; // ponemos el fondo en color verde para saber que lo hemos encontrado
                        await Task.Delay(1000); //usamos el async para que se vea el verde 1 segundo
                        IndicarCabezal(); // Regresar al color rojo del encavezado
                        break; // Salimos del ciclo
                    }
                }
                await Task.Delay(500); //Aqui ya usamos lo del async que pusimos al inicio del evento, esto unicamente hace que de un salto
                                       // a otro tenga una espera de medio segundo (es unicamente estetico, lo podemos quitar si da algun problema)
                Contador++;
                //preguntamos la direccion
                
                    if (Direccion == "D")
                    {
                        if (Cabezal < Cinta.Count)
                        {
                            Cabezal++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else //esto es unicamente por si no se encuentra se sale directamente del ciclo 
                    {
                        if (Cabezal > 0)
                        {
                            Cabezal--;
                        }
                        else
                        {
                            break;
                        }
                    }
                
            }

            if (!encontrado)
            {
                MessageBox.Show($"El símbolo '{simboloAEncontrar}' no se encontró en el resto de la cinta.");
            }


            
        }
           
        private void radIzq_CheckedChanged(object sender, EventArgs e)
        {
            radDerecha.Checked = false;
        }

        private void radDerecha_CheckedChanged(object sender, EventArgs e)
        {
            radIzq.Checked = false;
        }

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            MaquinaTuring MT = new MaquinaTuring();
            MTnumero++;
            MT.Nombre = "MT" + MTnumero.ToString();
            MT.Simbolo = '#';
            Cinta.RemoveAt(Cabezal);
            Cinta.Insert(Cabezal, '#');
            
        }
        private void Escribir(MaquinaTuring MT)
        {
            char simboloAEscribir = MT.Simbolo;
            Cinta.RemoveAt(Cabezal);
            Cinta.Insert(Cabezal, simboloAEscribir);
            CargaCinta();
            IndicarCabezal();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            foreach(MaquinaTuring MT in Operaciones)
            {
                switch (MT.Operacion)
                {
                    case 1: //Busqueda
                        Buscar(MT);
                        break;
                    case 2: //Escritura
                        Escribir(MT);
                        break;
                    case 3: //Mover
                        // Llamar al método de marcar con el símbolo especificado en MT.Simbolo
                        break;
                    default:
                        MessageBox.Show($"Operación desconocida para {MT.Nombre}");
                        break;
                }
            }
        }

        private void grbBusquedaEscritura_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            MaquinaTuring MT = new MaquinaTuring();
            MT.Nombre = "MT" + MTnumero.ToString();
            MT.Operacion = 3; //Operacion 3 es para mover
            if (radMoverD.Checked)
            {
                MT.Direccion = 'D';
            }
            if (radMoverIzq.Checked)
            {
                MT.Direccion = 'I';
            }

        }

        private void radMoverD_CheckedChanged(object sender, EventArgs e)
        {
            radMoverIzq.Checked = false;
            radMoverD.Checked = true;
        }

        private void radMoverIzq_CheckedChanged(object sender, EventArgs e)
        {
            radMoverD.Checked = false;
            radMoverIzq.Checked = true;
        }
    }
}

