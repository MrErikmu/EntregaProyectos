using System.Text.RegularExpressions;
using CSharpFunctionalExtensions;
using Gestion_Itv.Error;
using Gestion_Itv.Models;
using Gestion_Itv.Validator.Common;

namespace Gestion_Itv.Validator;

public class VehiculoValidator: IValidator<Vehiculo>
{
    public Result<Vehiculo, DomainError> Validar(Vehiculo vh)
    {
        var errores = new List<string>();
        if (vh.FechaMatriculacion > DateTime.Today)
            errores.Add($"La Fecha de matriculacion no puede ser superior a {DateTime.Today}");
        if(vh.FechaInspeccion<DateTime.Today||vh.FechaInspeccion>DateTime.Today.AddDays(30))
           errores.Add($"La Fecha de Inspeccion debe estar comprendida entre {DateTime.Today} y 30 dias despues");
        if(!IsokDNI(vh.DNI))
            errores.Add("El DNI introducido no es valido");
        if(!IsokMatricula(vh.DNI))
            errores.Add("La matricula introducida no es valida");
        if (vh.TipoMotor!= TipoMotor.Diesel||vh.TipoMotor!= TipoMotor.Gasolina||vh.TipoMotor!= TipoMotor.Electrico||vh.TipoMotor!= TipoMotor.Hibrido)
            errores.Add("Tipo de motor introducido incorrecto");
        if (errores.Any())
        return Result.Failure<Vehiculo, DomainError>(VehiculoError.ValidationError);
        return 
    }

    /// <summary>
    /// Funcion Auxiliar para validar el DNI Español
    /// </summary>
    /// <returns>Verdadero o Falso</returns>
    public static bool IsokDNI(string dni)
    {
        if (string.IsNullOrWhiteSpace(dni)) return false;
        dni = dni.Trim().ToUpper().Replace(" ", "").Replace("-", "");
        if (!Regex.IsMatch(dni, @"^[0-9]{8}[A-Z]$")) return false;
        var numero = dni.Substring(0, 8);
        var letra = dni[8];
        const string letrasok = "TRWAGMYFPDXBNJZSQVHLCKE";
        if (!int.TryParse(numero, out var dniNumero)) return false;
        var resto = dniNumero % 23;
        var letraCalculada = letrasok[resto];
        return letra == letraCalculada;
    }
    /// <summary>
    /// Valida la matricula de vehiculo con el uso de expresion regular.
    /// </summary>
    /// <param name="matricula"></param>
    /// <returns></returns>
    public static bool IsokMatricula(string matricula)
    {
        matricula= matricula.Trim().ToUpper().Replace(" ", "").Replace("-", "");
        if (!Regex.IsMatch(matricula, @"^\d{4}[BCDFGHJKLMNPRSTVWXYZ]{3}$")) return false;
        return true;
    }
}