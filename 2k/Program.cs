Console.WriteLine("2K24");
Console.WriteLine("JUEGO NUEVO\n");

Cancha partido = new Cancha();

partido.crear_equipos();
partido.crear_jugadores();
partido.mostrar_jugadores();
partido.seleccionar_jugadores();
partido.listar_jugadores();
partido.totalizar_rendimiento();