public interface IEquipos {
    public void ingresar_nombre();
    public void seleccionar_jugadores(List<IJugador> jugadores);
    public void listar_jugadores();
    public void total_rendimiento();
    public string GetNombre();
    public List<IJugador> GetJugadores();
    public void SetJugadores(List<IJugador> jugadores);
    public int GetRendimiento();
    public void SetRendimiento(int rendimiento);
}
