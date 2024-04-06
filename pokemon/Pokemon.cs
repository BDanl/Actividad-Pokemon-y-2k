using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon
{
    interface IAcciones
    {
         public int Attack(int[] atk);
         public int Defense(int[] def);
         public int GstatAtk();
         public int GstatDef();

    }

    public class Metodos: IAcciones
    {
        public int Attack(int[] atk)
        {
            Random random = new();

            double[] numAtk = [1, 0, 0.5];
            int rAtk = random.Next(0, numAtk.Length);

            int result = random.Next(0, atk.Length);
            result = (int)(atk[result] * numAtk[rAtk]);
            return result;

        }
        public int Defense(int[] def)
        {
            Random random = new();

            double[] numDef = [1, 0.5];
            int rDef = random.Next(0, numDef.Length);

            int result2 = random.Next(0, def.Length);
            result2 = (int)(def[result2] * numDef[rDef]);
            return result2;
        }
        public int GstatAtk()
        {
            Random random = new();
            int atkNumber = random.Next(0, 40);
            return atkNumber;
        }
        public int GstatDef()
        {
            Random random = new();
            int defNumber = random.Next(10, 35);
            return defNumber;
        }
    }
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
