using System;

public class Jugador : IJugador
{
    private string nombre;
    private int rendimiento;

    // Método para calcular el rendimiento
    private int CalcularRendimiento()
    {
        Random rnd = new Random(); 
        return rnd.Next(1, 11);
    }

    // Métodos getters y setters
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int Rendimiento
    {
        get { return rendimiento; }
        set { rendimiento = value; }
    }

    // Constructores
    public Jugador()
    {
    }
    public Jugador(string nombre)
    {
        Nombre = nombre;
        Rendimiento = CalcularRendimiento();
    }  
}
