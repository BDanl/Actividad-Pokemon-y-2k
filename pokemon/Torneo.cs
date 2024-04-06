
namespace pokemon
{
    public class Torneo
    {
        
        public static void Main(string[] args)
        {
            Metodos actions = new();
            //pokemon 1
            Console.WriteLine("Pokemon 1 name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Pokemon 1 type: ");
            string type = Console.ReadLine();

            Console.WriteLine("Pokemon 1 HP: ");
            int hp = int.Parse(Console.ReadLine());

            Pokemon pokemon1 = new(name, type, hp);
            
            for (int i = 0; i < 3; i++)
            {

                pokemon1.StatAtk[i] = actions.GstatAtk();
            }

            for (int i = 0; i < 2; i++)
            {

                pokemon1.StatDef[i] = actions.GstatDef();
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

                pokemon2.StatAtk[i] = actions.GstatAtk();
            }

            for (int i = 0; i < 2; i++)
            {

                pokemon2.StatDef[i] = actions.GstatDef();
            }

            //Combate
            for (int i = 0; i < 3; i++)
            {
                int atk1p1 = actions.Attack(pokemon1.StatAtk);
                int def1p2 = actions.Defense(pokemon2.StatDef);
                if (atk1p1 > def1p2)
                {
                    pokemon2.StatSalud = pokemon2.StatSalud - (atk1p1 - def1p2);
                }
                else
                {
                    pokemon1.StatSalud = pokemon1.StatSalud - (def1p2 - atk1p1);
                }

                int atk1p2 = actions.Attack(pokemon2.StatAtk);
                int def1p1 = actions.Defense(pokemon1.StatDef);
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
    }
}
