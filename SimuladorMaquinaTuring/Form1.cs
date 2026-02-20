using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

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
            lblDefinicionFormal.Text = "----";

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
            char[] Alfabeto = { 'a', 'b', 'c', 'd','e','B' };
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

            ActualizarDefinicionFormal();
            DibujarDiagrama();

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
        // private void MoverCabezalDerecha()
        // {
        //     // Si el cabezal está JUSTO en el borde final, expandimos antes de mover
        //     if (Cabezal == Cinta.Count - 1)
        //     {
        //         ExpandirCintaDerecha();
        //     }
        //
        //     // Ahora sí, avanzamos sin miedo (ya hay espacio)
        //     Cabezal++;
        //     IndicarCabezal();
        //     lblLeyendo.Text = Leer().ToString();
        // }
        private void MoverCabezalDerecha()
        {// CASO CRÍTICO: Si el cabezal está en el borde derecho...
            if (Cabezal == Cinta.Count - 1)
            {
                // ...CREAMOS UNA CELDA NUEVA ANTES DE MOVERNOS
                ExpandirCinta();
            }

            // Ahora sí avanzamos, porque ya aseguramos que hay piso donde pisar
            Cabezal++;

            // Actualizamos lo visual
            IndicarCabezal();
            lblLeyendo.Text = Leer().ToString();

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
                    lblMaquinas.Text += "→" + "D" + MT.Simbolo.ToString();
                    Operaciones.Add(MT);
                }
                else if (radIzq.Checked)    
                {
                    MT.Direccion = 'I';
                    listaOpe.Items.Add('I' + MT.Simbolo.ToString());
                    lblMaquinas.Text += "→" + "I" + MT.Simbolo.ToString() ;
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

            ActualizarDefinicionFormal();
            DibujarDiagrama();

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
            lblMaquinas.Text += "→" + MT.Simbolo.ToString();
            ActualizarDefinicionFormal();
            DibujarDiagrama();

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
            //MessageBox.Show(MT.Nombre + MT.Simbolo.ToString() + MT.Direccion.ToString());
            bool encontrado = false;



            while (Cabezal >= 0 &&Cabezal < Cinta.Count) 
            {
               // if (Direccion == "D")
               // {
               //     // VERIFICAR SI NECESITAMOS EXPANDIR
               //     if (Cabezal == Cinta.Count - 1)
               //     {
               //         ExpandirCintaDerecha(); // Crea espacio nuevo para seguir buscando
               //
               //         // OJO: Si expandes infinitamente buscando algo que NO existe, 
               //         // el programa nunca se detendrá (loop infinito real).
               //         // Normalmente en simuladores se pone un límite o se deja al usuario detenerlo.
               //     }
               //
               //     Cabezal++;
               // }
                // ... resto del código ...
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
                await Task.Delay(50); //Aqui ya usamos lo del async que pusimos al inicio del evento, esto unicamente hace que de un salto
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
            MT.Operacion = 4; //Operacion 4 es para marcar
            lblMaquinas.Text += "→"+"#";
            Operaciones.Add(MT);
            listaOpe.Items.Add("#");
            ActualizarDefinicionFormal();
            DibujarDiagrama();

        }
        private void Escribir(MaquinaTuring MT)
        {
            // Lógica: Cambiar en la lista
            char simboloAEscribir = MT.Simbolo;
            Cinta[Cabezal] = simboloAEscribir;

            // Visual: Cambiar en el cuadrito (DataGridView)
            dgvCinta.Rows[0].Cells[Cabezal].Value = simboloAEscribir.ToString();

            // Actualizar etiqueta de lectura
            lblLeyendo.Text = Leer().ToString();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {


            // Recorremos todas las operaciones que guardaste
            foreach (MaquinaTuring MT in Operaciones)
            {
                switch (MT.Operacion)
                {
                    case 1: // Busqueda
                        MessageBox.Show("Estado :" + MT.Nombre + "\nBuscar : " + MT.Simbolo + " a la " + MT.Direccion);
                        Buscar(MT);
                        break;

                    case 2: // Escritura
                        MessageBox.Show("Estado :" + MT.Nombre + "\nEscribir el símbolo " + MT.Simbolo);
                        Escribir(MT);
                        break;

                    case 3: // Mover
                        if (MT.Direccion == 'D')
                        {
                            // AQUÍ ESTABA EL ERROR:
                            // Borré el bloque que agregaba Cinta.Add('B') manualmente.
                            // Ahora confiamos en que MoverCabezalDerecha() creará solo UN espacio si es necesario.

                            MessageBox.Show("Estado :" + MT.Nombre + "\nMover a la Derecha");
                            MoverCabezalDerecha();
                        }
                        else
                        {
                            MessageBox.Show("Estado :" + MT.Nombre + "\nMover a la Izquierda");
                            MoverCabezalIzquierda();
                        }
                        break;

                    case 4: // Marcar
                        MessageBox.Show("Estado :" + MT.Nombre + "\nMarcar ");
                        // Lógica de marcado (simple)
                        if (Cabezal < Cinta.Count)
                        {
                            Cinta.RemoveAt(Cabezal);
                            Cinta.Insert(Cabezal, '#');
                        }
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
                listaOpe.Items.Add("D");
                lblMaquinas.Text += "→"+"D" ;
                Operaciones.Add(MT);
                
            }
            if (radMoverIzq.Checked)
            {
                MT.Direccion = 'I';
                listaOpe.Items.Add("I");
                lblMaquinas.Text += "→" + "I";
                Operaciones.Add(MT);
            }

            ActualizarDefinicionFormal();
            DibujarDiagrama();
        }

        private void radMoverD_CheckedChanged(object sender, EventArgs e)
        {
            radMoverIzq.Checked = false;
           
        }

        private void radMoverIzq_CheckedChanged(object sender, EventArgs e)
        {
            radMoverD.Checked = false;
            
        }

        // Estados
        private void ActualizarDefinicionFormal()
        {
            //CONJUNTO DE ESTADOS (Q)
            List<int> estados = new List<int>();
            for (int i = 0; i < Operaciones.Count; i++)
            {
                estados.Add(i + 1); 
            }
            // string.Join une los números con comas: "1, 2, 3"
            string strQ = estados.Count > 0 ? string.Join(", ", estados) : "ø";

            //ESTADO FINAL (F)
            string strF = estados.Count > 0 ? estados.Last().ToString() : "ø";

            //ESTADO INICIAL (q0)
            string strQ0 = estados.Count > 0 ? "1" : "-";

            //ALFABETO DE ENTRADA (Sigma)
            string strSigma = "a,b,c,d,e,";

            //ALFABETO DE LA CINTA (usamos un HashSet para evitar duplicados)
            HashSet<char> simbolosCinta = new HashSet<char>();
            // agregamos lo que ya existe en la cinta actual
            foreach (char c in Cinta) simbolosCinta.Add(c);
            simbolosCinta.Add('B'); 
            simbolosCinta.Add('#');
            simbolosCinta.Add('x');
            simbolosCinta.Add('y');
            simbolosCinta.Add('z');
            string strGamma = string.Join(", ", simbolosCinta);
            //ACTUALIZAR EL LABEL
            lblDefinicionFormal.Text =
                $"Q = {{ {strQ} }}\n" +
                $"F = {{ {strF} }}\n" +
                $"q0 = {{ {strQ0} }}\n" +
                $"Alfabeto Σ = {{ {strSigma} }}\n" +
                $"Símbolos de cinta Γ = {{ {strGamma} }}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        private void DibujarDiagrama()
        {
        
            //CONFIGURACIÓN VISUAL 
            int radio = 25;           // Tamaño de la bolita
            int separacion = 140;     // Distancia entre estados
            int margen = 100;         // Margen extra
            int xInicial = 60;        // Dónde empieza el dibujo

            // Colores para el fondo
            Color colorFondo = Color.White;
            Color colorLineaEstado = Color.Black;     // Círculos 
            Color colorFlecha = Color.DarkBlue;       // Flechas 
            Color colorTextoLoop = Color.Red;         // Texto del bucle

            // Calculamos ancho necesario
            int totalEstados = Operaciones.Count;
            int anchoRequerido = (totalEstados * separacion) + margen;

            // Ajustar tamaño del PictureBox al contenido (para que el Panel muestre scroll)
            if (anchoRequerido < pnlScroll.Width) anchoRequerido = pnlScroll.Width;

            pbDiagrama.Width = anchoRequerido;
            pbDiagrama.Height = pnlScroll.Height - 20; // Ajuste para evitar scroll vertical

            // Crear lienzo
            Bitmap bmp = new Bitmap(pbDiagrama.Width, pbDiagrama.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias; // Líneas suaves
                g.Clear(colorFondo);

                // configurar "lapices" que se usarán
                Pen lapizEstado = new Pen(colorLineaEstado, 2);

                Pen lapizFlecha = new Pen(colorFlecha, 2);
                lapizFlecha.CustomEndCap = new AdjustableArrowCap(4, 4); // Punta de flecha

                Font fuenteEstado = new Font("Segoe UI", 12, FontStyle.Bold);
                Font fuenteTexto = new Font("Consolas", 9, FontStyle.Bold);

                Brush brochaTexto = Brushes.Black;       // Texto general
                Brush brochaFlecha = Brushes.DarkBlue;   // Texto de transiciones

                int x = xInicial;
                int y = pbDiagrama.Height / 2;

                //Dibujar bolitas
                for (int i = 0; i <= totalEstados; i++)
                {
                    //Dibujar estado (circulos)
                    Rectangle rect = new Rectangle(x - radio, y - radio, radio * 2, radio * 2);
                    g.DrawEllipse(lapizEstado, rect);

                    //Nombre de los estados (q1, q2, q3, etc)
                    string nombre = "q" + (i + 1);
                    SizeF tam = g.MeasureString(nombre, fuenteEstado);
                    g.DrawString(nombre, fuenteEstado, brochaTexto, x - (tam.Width / 2), y - (tam.Height / 2));

                    //Flechas (Si hay siguiente estado)
                    if (i < totalEstados)
                    {
                        MaquinaTuring op = Operaciones[i];
                        int xSig = x + separacion;

                        // CASO A: busqueda (Loop + flecha recta)
                        if (op.Operacion == 1)
                        {
                            string dir = op.Direccion == 'D' ? "D" : "I";

                            // Flecha curva (Loop)
                            DrawSelfLoop(g, lapizFlecha, x, y - radio, $"≠ {op.Simbolo}, {dir}", Brushes.Red);

                            // Flecha recta (Éxito)
                            g.DrawLine(lapizFlecha, x + radio, y, xSig - radio, y);
                            g.DrawString($"= {op.Simbolo}", fuenteTexto, brochaFlecha, x + radio + 5, y - 15);
                        }
                        // CASO B: movimiento, escritura o marca (Solo flecha recta)
                        else
                        {
                            string texto = "";
                            if (op.Operacion == 2) texto = $"Escribe {op.Simbolo}";
                            if (op.Operacion == 3) texto = $"Mueve {op.Direccion}";
                            if (op.Operacion == 4) texto = "Marca #";

                            g.DrawLine(lapizFlecha, x + radio, y, xSig - radio, y);
                            g.DrawString(texto, fuenteTexto, brochaFlecha, x + radio + 5, y - 15);
                        }
                    }
                    else // Estado de aceptacion (último estado)
                    {
                        // Doble círculo
                        g.DrawEllipse(lapizEstado, x - radio + 4, y - radio + 4, (radio * 2) - 8, (radio * 2) - 8);
                    }

                    x += separacion;
                }
            }

            pbDiagrama.Image = bmp;
        }
        //Metodo auxiliar para dibujar flecha de loop, recibe el Graphics, el Pen, la posicion x del estado, la posicion y del arco, el texto a mostrar y el color del texto
        private void DrawSelfLoop(Graphics g, Pen p, int x, int yTop, string texto, Brush colorTexto)
        {
            // Puntos para la curva Bezier (Arco superior)
            Point p1 = new Point(x - 5, yTop);
            Point p2 = new Point(x - 30, yTop - 45); // Control Izq
            Point p3 = new Point(x + 30, yTop - 45); // Control Der
            Point p4 = new Point(x + 5, yTop);

            g.DrawBezier(p, p1, p2, p3, p4);

            // Texto centrado arriba de la curva
            Font f = new Font("Consolas", 8, FontStyle.Bold);
            SizeF tam = g.MeasureString(texto, f);
            g.DrawString(texto, f, colorTexto, x - (tam.Width / 2), yTop - 55);

        }
        // Método auxiliar para hacer la cinta infinita
        //private void ExpandirCintaDerecha()
        //{
        //    // 1. Agregar un Blanco a la lista lógica
        //    Cinta.Add('B');
        //
        //    // 2. Agregar la columna visual al DataGridView
        //    int nuevoIndice = Cinta.Count - 1;
        //    dgvCinta.Columns.Add("c" + nuevoIndice, ""); // Agrega la columna
        //
        //    // 3. Darle el mismo estilo que las demás
        //    dgvCinta.Columns[nuevoIndice].Width = 40;
        //    dgvCinta.Rows[0].Cells[nuevoIndice].Value = "B"; // Valor visual
        //    dgvCinta.Rows[0].Cells[nuevoIndice].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //
        //    // (Opcional) Si usas el triangulito Δ visualmente:
        //    // dgvCinta.Rows[0].Cells[nuevoIndice].Value = "Δ";
        //}
        private void AgregarOperacion(int tipo, char simbolo, char direccion)
        {
            MaquinaTuring MT = new MaquinaTuring();
            MTnumero++;
            MT.Nombre = "MT" + MTnumero;
            MT.Operacion = tipo; // 2=Escribir, 3=Mover

            if (tipo == 2) // Escribir
            {
                MT.Simbolo = simbolo;
                listaOpe.Items.Add($"Escribir {simbolo}");
                lblMaquinas.Text += $" → {simbolo}";
            }
            else if (tipo == 3) // Mover
            {
                MT.Direccion = direccion;
                listaOpe.Items.Add($"Mover {direccion}");
                lblMaquinas.Text += $" → {direccion}";
            }

            Operaciones.Add(MT);
        }
        private void ExpandirCinta()
        {
            // 1. Lógica: Agrega un blanco al final de la lista
            Cinta.Add('B');

            // 2. Visual: Agrega una columna nueva al DataGridView
            string nombreColumna = "c" + (Cinta.Count - 1);
            dgvCinta.Columns.Add(nombreColumna, "");

            // 3. Configuración visual de la nueva celda
            int indiceNuevaCelda = dgvCinta.Columns.Count - 1;
            dgvCinta.Columns[indiceNuevaCelda].Width = 40;
            dgvCinta.Rows[0].Cells[indiceNuevaCelda].Value = "B";
            dgvCinta.Rows[0].Cells[indiceNuevaCelda].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }

}

