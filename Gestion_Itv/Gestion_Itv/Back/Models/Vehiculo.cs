namespace Gestion_Itv.Models;

public record Vehiculo
{
    public string Matricula;
    public string DNI;
    public string Marca;
    public string Modelo;
    public TipoMotor TipoMotor;
    public DateTime FechaMatriculacion;
    public DateTime FechaInspeccion;
}