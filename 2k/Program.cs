Console.WriteLine("2K24");
Console.WriteLine("JUEGO NUEVO\n");

/* Presentamos a los equipos */
Console.WriteLine("PRIMER EQUIPO");
Equipo equipo1 = new Equipo();
equipo1.ingresar_nombre();
Console.WriteLine("\n");

Console.WriteLine("SEGUNDO EQUIPO");
Equipo equipo2 = new Equipo();
equipo2.ingresar_nombre();
Console.WriteLine("\n");

Console.WriteLine("Equipo 1: " + equipo1.GetNombre());
Console.WriteLine("Equipo 2: " +equipo2.GetNombre() + "\n");

/* Se crean los 10 jugadores */
List<Jugador> jugadores = new List<Jugador>();


// Agregar los jugadores
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

// Mostrar los nombres y rendimientos de los jugadores
Console.WriteLine("Lista de Jugadores:");
foreach (var jugador in jugadores)
{
    Console.WriteLine($"Nombre: {jugador.GetNombre()}, Rendimiento: {jugador.GetRendimiento()}");
}
Console.WriteLine("\n");

// Se elige que equipo escoge primero
Random rnd = new Random(); 
int eleccion = rnd.Next(1,3);

Equipo equipo_empieza = null;
Equipo equipo_siguiente = null;

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
        equipo_empieza.eleccion_jugadores(jugadores); 
        equipo_siguiente.eleccion_jugadores(jugadores); 
    }  
