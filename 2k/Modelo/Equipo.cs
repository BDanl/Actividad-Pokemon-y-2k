using System;

public class Equipo : IEquipos
{
    private string nombre;
    private List<Jugador> jugadores;
    private int rendimiento;

    // Constructor sin parámetros
    public Equipo()
    {
        this.jugadores = new List<Jugador>();
    }

    // Constructor con parámetros
    public Equipo(string nombre, int rendimiento)
    {
        this.nombre = nombre;
        this.rendimiento = rendimiento;
        this.jugadores = new List<Jugador>();
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
    public void seleccionar_jugadores(List<Jugador> jugadores)
    {
        Console.WriteLine($"TURNO DEL EQUIPO {this.nombre} PARA ESCOGER: ");
        int cont = 0;
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
        Console.WriteLine($"Nombre: {jugadores[eleccion].GetNombre()}, Rendimiento: {jugadores[eleccion].GetRendimiento()}");

        cont = 0;

        this.jugadores.Add(jugadores[eleccion]);

        jugadores.RemoveAt(eleccion);

        Console.WriteLine("\n");
    }   
    public void listar_jugadores()
    {
        Console.WriteLine($"Jugadores del quipo: {this.nombre}");
        foreach (var jugador in this.jugadores)
        {      
             Console.WriteLine($"Nombre: {jugador.GetNombre()}, Rendimiento: {jugador.GetRendimiento()}");
                      
        }              
    } 

    public void total_rendimiento()
    {
        rendimiento = 0;
        Console.WriteLine($"Total rendimiento del equipo {this.nombre}: ");
        foreach (var jugador in this.jugadores)
        {      
            rendimiento += jugador.GetRendimiento();        
        } 
        Console.WriteLine(rendimiento);
    }

}

    