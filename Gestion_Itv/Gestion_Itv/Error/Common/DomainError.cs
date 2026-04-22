namespace Gestion_Itv.Error;
/// <summary>
/// Clase abstracta para creación de errores
/// </summary>
/// <param name="mensaje"></param>
public abstract record DomainError(string mensaje);