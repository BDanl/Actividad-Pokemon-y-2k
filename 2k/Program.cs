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

 // Agregar 10 jugadores a la lista
for (int i = 1; i <= 10; i++)
{
    jugadores.Add(new Jugador($"Jugador {i}"));
}

// Mostrar los nombres y rendimientos de los jugadores
Console.WriteLine("Lista de Jugadores:");
foreach (var jugador in jugadores)
{
    Console.WriteLine($"Nombre: {jugador.Nombre}, Rendimiento: {jugador.Rendimiento}");
}

