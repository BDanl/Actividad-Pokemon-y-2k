using System;

public class Equipo : IEquipos
{
    private string nombre;
    private List<Jugador> jugadores;
    private int rendimiento;

    // Constructor sin parámetros
    public Equipo()
    {
    }

    // Constructor con parámetros
    public Equipo(string nombre, int rendimiento)
    {
        this.nombre = nombre;
        this.rendimiento = rendimiento;
    }

    // Getter para el nombre del equipo
    public string GetNombre()
    {
        return nombre;
    }


    // Getter para la lista de jugadores
    public List<Jugador> GetJugadores()
    {
        return jugadores;
    }

    // Setter para la lista de jugadores
    public void SetJugadores(List<Jugador> jugadores)
    {
        this.jugadores = jugadores;
    }

    // Getter para el rendimiento del equipo
    public int GetRendimiento()
    {
        return rendimiento;
    }

    // Setter para el rendimiento del equipo
    public void SetRendimiento(int rendimiento)
    {
        this.rendimiento = rendimiento;
    }

    //Metodo para elegir jugador
    public void ingresar_nombre(){
        Console.WriteLine("Por favor, ingresa el nombre del Equipo: ");
        this.nombre = Console.ReadLine();
    }
    public void eleccion_jugadores(List<Jugador> jugadores)
    {
        List<Jugador> jugadores_eleccion = new List<Jugador>(); 
        Console.WriteLine($"TURNO DEL EQUIPO {this.nombre} PARA ESCOGER: ");
        int cont = 0;
        int capturar_jugador;
        foreach (var jugador in jugadores)
        {           
            if (jugador.GetDisponibilidad()){
                 Console.WriteLine($"{cont}. Nombre: {jugador.GetNombre()}, Rendimiento: {jugador.GetRendimiento()}");
                cont ++;           
            }              
        }   
             
        
        Console.WriteLine("Se escogio el jugador: ");  
        Random rnd = new Random(); 
        int eleccion = rnd.Next(0,cont);
        capturar_jugador = eleccion;
        Console.WriteLine($"Nombre: {jugadores[capturar_jugador].GetNombre()}, Rendimiento: {jugadores[capturar_jugador].GetRendimiento()}");

        cont = 0;

        jugadores_eleccion.Add(jugadores[capturar_jugador]);

        jugadores.RemoveAt(capturar_jugador);

        this.jugadores = jugadores_eleccion;

        Console.WriteLine("\n");
    }   
    public void listar_jugadores(List<Jugador> jugadores)
    {
        
    }
}
    