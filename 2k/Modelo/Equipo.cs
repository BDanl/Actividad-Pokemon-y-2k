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
    public Equipo(string nombre, List<Jugador> jugadores, int rendimiento)
    {
        this.nombre = nombre;
        this.jugadores = jugadores;
        this.rendimiento = rendimiento;
    }

    // Getter para el nombre del equipo
    public string GetNombre()
    {
        return nombre;
    }

    // Setter para el nombre del equipo
    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
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
    public void eleccion_jugadores(List<Jugador> jugadores){}
    public void listar_jugadores(List<Jugador> jugadores){}

   

}