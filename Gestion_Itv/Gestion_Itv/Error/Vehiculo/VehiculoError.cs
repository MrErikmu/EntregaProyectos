namespace Gestion_Itv.Error;
/// <summary>
/// Errores especificos para el dominio Vehiculo
/// </summary>
/// <param name="Mensaje"></param>
public abstract record VehiculoError(string Mensaje) : DomainError(Mensaje)
{
    public sealed record NotFound(string Id)
        : VehiculoError($"No existe un Vehiculo con id: {Id}");
   
    public sealed record ValidationError(IEnumerable<string>Errors)
        :VehiculoError($"Se han detectado los siguietes errores de validacion{Environment.NewLine}.{string.Join($"{Environment.NewLine}• ", Errors)}");
    
    public sealed record DniWithTooManyVh(string Dni)
        : VehiculoError($"El DNI: {Dni} ya tiene el maximo de 3 vehiculos asociados");

    public sealed record DbError(string info)
        : VehiculoError($"Error en la base de datos: {info}");

    public sealed record StorageError(string details)
        : VehiculoError($"Error de almacenamiento {details}");


}
