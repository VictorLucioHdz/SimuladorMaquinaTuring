using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorMaquinaTuring
{
    internal class MaquinaTuring
    {
        public string Nombre { get; set; }//Especie de ID 
        public char Simbolo { get; set; }//Simbolo que puede escribir la maquina o almacenamiento
        public char Direccion { get; set; }//Para la busqueda y mover
        public int Operacion { get; set; }//tipo de operacion
        public int Posicion { get; set; }//Para la busqueda si al empezar en la primera celda o la siguiente 

    }
}
