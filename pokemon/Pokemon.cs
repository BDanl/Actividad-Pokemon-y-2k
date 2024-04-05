using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon
{
    public class Pokemon
    {
        private string nombre;
        private string tipo;
        private int statSalud;
        private int[] statAtk = new int[3];
        private int[] statDef = new int[2];

        public Pokemon(string nombre, string tipo, int statSalud)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.statSalud = statSalud;
          
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int StatSalud { get => statSalud; set => statSalud = value; }
        public int[] StatAtk { get => statAtk; set => statAtk = value; }
        public int[] StatDef { get => statDef; set => statDef = value; }
    }
}
