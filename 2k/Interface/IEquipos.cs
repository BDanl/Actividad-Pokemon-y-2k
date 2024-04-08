public interface IEquipos {
    public void ingresar_nombre();
    public void seleccionar_jugadores(List<Jugador> jugadores);
    public void listar_jugadores();
    public void total_rendimiento();
    public string GetNombre();
    public List<Jugador> GetJugadores();
    public void SetJugadores(List<Jugador> jugadores);
    public int GetRendimiento();
    public void SetRendimiento(int rendimiento);
}
