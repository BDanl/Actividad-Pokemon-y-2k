namespace pokemon
{
    public class Torneo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pokemon 1 name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Pokemon 1 type: ");
            string type = Console.ReadLine();

            Console.WriteLine("Pokemon 1 HP: ");
            int hp = int.Parse(Console.ReadLine());

            Pokemon pokemon1 = new(name, type, hp);
            
            for (int i = 0; i < 3; i++)
            {

                pokemon1.StatAtk[i] = GstatAtk();
            }

            for (int i = 0; i < 2; i++)
            {

                pokemon1.StatDef[i] = GstatDef();
            }

            //pokemon 2
            Console.WriteLine("Pokemon 2 name: ");
            name = Console.ReadLine();

            Console.WriteLine("Pokemon 2 type: ");
            type = Console.ReadLine();

            Console.WriteLine("Pokemon 2 HP: ");
            hp = int.Parse(Console.ReadLine());

            Pokemon pokemon2 = new(name, type, hp);

            for (int i = 0; i < 3; i++)
            {

                pokemon2.StatAtk[i] = GstatAtk();
            }

            for (int i = 0; i < 2; i++)
            {

                pokemon2.StatDef[i] = GstatDef();
            }

            //Combate
            for (int i = 0; i < 3; i++)
            {
                int atk1p1 = Attack(pokemon1.StatAtk);
                int def1p2 = Defense(pokemon2.StatDef);
                if (atk1p1 > def1p2)
                {
                    pokemon2.StatSalud = pokemon2.StatSalud - (atk1p1 - def1p2);
                }
                else
                {
                    pokemon1.StatSalud = pokemon1.StatSalud - (def1p2 - atk1p1);
                }

                int atk1p2 = Attack(pokemon2.StatAtk);
                int def1p1 = Defense(pokemon1.StatDef);
                if (atk1p2 > def1p1)
                {
                    pokemon1.StatSalud = pokemon1.StatSalud - (atk1p2 - def1p1);
                }
                else
                {
                    pokemon2.StatSalud = pokemon2.StatSalud - (def1p1 - atk1p2);
                }

            }
            if (pokemon1.StatSalud == pokemon2.StatSalud)
            {
                Console.WriteLine("Empate");
            }
            else if (pokemon1.StatSalud > pokemon2.StatSalud)
            {
                Console.WriteLine(pokemon1.Nombre + " ganó");
            }
            else
            {
                Console.WriteLine(pokemon2.Nombre + " ganó");
            }
        }

        public static int Attack(int[] atk)
        {
            Random random = new();

            double[] numAtk = [1, 0, 0.5];
            int rAtk = random.Next(0, numAtk.Length);

            int result = random.Next(0, atk.Length);
            result = (int)(atk[result] * numAtk[rAtk]);
            return result;

        }

        public static int Defense(int[] def)
        {
            Random random = new();

            double[] numDef = [1, 0.5];
            int rDef = random.Next(0, numDef.Length);

            int result2 = random.Next(0, def.Length);
            result2 = (int)(def[result2] * numDef[rDef]);
            return result2;
        }

        public static int GstatAtk()
        {
            Random random = new();
            int atkNumber = random.Next(0, 40);
            return atkNumber;
        }

        public static int GstatDef()
        {
            Random random = new();
            int defNumber = random.Next(10, 35);
            return defNumber;
        }
    }
}
