public class Cancha{
    private IEquipos equipo1 = null;
    private IEquipos equipo2 = null;
    private List<Jugador> jugadores = new List<Jugador>();

    // Presentamos a los equipos
    public void crear_equipos(){
        Console.WriteLine("PRIMER EQUIPO");
        equipo1 = new Equipo();
        equipo1.ingresar_nombre();
        Console.WriteLine("\n");

        Console.WriteLine("SEGUNDO EQUIPO");
        equipo2 = new Equipo();
        equipo2.ingresar_nombre();
        Console.WriteLine("\n");

        Console.WriteLine("Equipo 1: " + equipo1.GetNombre());
        Console.WriteLine("Equipo 2: " +equipo2.GetNombre() + "\n");
    }

    // Agregar los jugadores
    public void crear_jugadores(){    
        jugadores.Add(new Jugador("Andres ALberto"));
        jugadores.Add(new Jugador("Leandro Aristizabal"));
        jugadores.Add(new Jugador("Bovea Cifuentes"));
        jugadores.Add(new Jugador("David Giraldo"));
        jugadores.Add(new Jugador("Lebron James"));
        jugadores.Add(new Jugador("Daniel Henao"));
        jugadores.Add(new Jugador("Killyn Maquiavelo"));
        jugadores.Add(new Jugador("Sofia Vergara"));
        jugadores.Add(new Jugador("Pipe Bueno"));
        jugadores.Add(new Jugador("Luis Miguel"));
        }

    // Mostrar los nombres y rendimientos de los jugadores
    public void mostrar_jugadores(){
        Console.WriteLine("Lista de Jugadores:");
        foreach (var jugador in jugadores)
        {
            Console.WriteLine($"Nombre: {jugador.GetNombre()}, Rendimiento: {jugador.GetRendimiento()}");
        }
        Console.WriteLine("\n");
    }


    // Se elige que equipo escoge primero
    public void seleccionar_jugadores(){
        Random rnd = new Random(); 
        int eleccion = rnd.Next(1,3);

        IEquipos equipo_empieza = null;
        IEquipos equipo_siguiente = null;

        switch (eleccion){
            case 1: 
                equipo_empieza = equipo1;
                equipo_siguiente = equipo2;
            break;

            case 2: 
                equipo_empieza = equipo2;      
                equipo_siguiente = equipo1;  
            break;
        }

        Console.WriteLine($"Empieza el equipo {equipo_empieza.GetNombre()}");
            for(int i = 0; i < 3; i ++){        
                equipo_empieza.seleccionar_jugadores(jugadores); 
                equipo_siguiente.seleccionar_jugadores(jugadores); 
        }  
    }
    // Se crea la lista de jugadores
    public void listar_jugadores(){
        equipo1.listar_jugadores();
        equipo2.listar_jugadores();
    }

    //Calcular el total del rendimiento por equipo
    public void totalizar_rendimiento(){
        equipo1.total_rendimiento();
        equipo2.total_rendimiento();
        IEquipos equipo_ganador = equipo1;
        if (equipo1.GetRendimiento() == equipo2.GetRendimiento()){
            Console.WriteLine($"Hay un empate entre los dos equipos, pierde el profe Duque");
        }else if(equipo2.GetRendimiento() > equipo1.GetRendimiento()){
            equipo_ganador = equipo2;
        }
        Console.WriteLine($"El equipo {equipo_ganador.GetNombre()} es el ganador");
    }

}


