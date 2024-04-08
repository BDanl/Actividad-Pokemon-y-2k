using System;

public class Jugador : IJugador
{
    private string nombre;
    private int rendimiento;
    private bool disponible;

    // Método para calcular el rendimiento
    public int CalcularRendimiento()
    {
        Random rnd = new Random(); 
        return rnd.Next(1, 11);
    }

   // Getter para el nombre del jugador
    public string GetNombre()
    {
        return nombre;
    }

    // Getter para el reendimiento del jugador
    public int GetRendimiento()
    {
        return rendimiento;
    }

    // Setter para el nombre del jugador
    public void SetNombre(string nombre){
        this.nombre = nombre;
    }

// Getter para la disponibilidad del jugador
    public bool GetDisponibilidad()
    {
        return disponible;
    }

    // Setter para el nombre del jugador
    public void SetDisponibilidad(bool disponible){
        this.disponible = disponible;
    }

    // Constructores    
    public Jugador(string nombre)
    {
        this.nombre = nombre;
        rendimiento = CalcularRendimiento();
        disponible = true;
    }  
}
