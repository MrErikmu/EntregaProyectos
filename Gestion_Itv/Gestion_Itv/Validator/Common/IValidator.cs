using CSharpFunctionalExtensions;
using Gestion_Itv.Error;

namespace Gestion_Itv.Validator.Common;
/// <summary>
/// Valida los datos previo a almacenar en el repositorio 
/// </summary>
/// <typeparam name="T">Tipo de entidad a validar </typeparam>
public interface IValidator<T>
{
    Result<T, DomainError> Validar(T entidad);
}