using System.Runtime.InteropServices.JavaScript;
using CSharpFunctionalExtensions;
using Gestion_Itv.Error;
using Gestion_Itv.Models;

namespace Gestion_Itv.Repository;
/// <summary>
/// Concretizacion de las operaciones CRUD
/// </summary>
public interface IVehiculoRepository: ICrudRepo<int , Vehiculo>
{
    /// <summary>
    /// Muestra todos los vehiculos del sistema con paginacion
    /// </summary>
    /// <param name="pagina"></param>
    /// <param name="tamPagina"></param>
    /// <param name="mostrarDelete"></param>
    /// <returns></returns>
    IEnumerable<Vehiculo> GetAll(int pagina= 1, int tamPagina = 5, bool mostrarDelete = true);
    
    /// <summary>
    /// Obtiene Vehiculo correspondiente a la matricula introducida
    /// </summary>
    /// <param name="matricula">Matricula del vehiculo</param>
    /// <returns>El objeto Vehiculo con esa matricula</returns>
    Vehiculo GetByMatricula(string matricula);
    /// <summary>
    /// Crea un nuevo vehiculo en el sistema
    /// </summary>
    /// <param name="vh"></param>
    /// <returns>Result con el objeto persona o el error de dominio</returns>
    Result<Vehiculo, DomainError> CreateVh(Vehiculo vh);
    Vehiculo Delete(bool islogical);
}