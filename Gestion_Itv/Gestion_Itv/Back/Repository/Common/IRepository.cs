using System.Runtime.InteropServices.JavaScript;
using CSharpFunctionalExtensions;
using Gestion_Itv.Error;
using Gestion_Itv.Models;

namespace Gestion_Itv.Repository;

public interface IRepositoryVh
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
    /// Obtiene Vehiculo correspondiente a la id introducida
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Vehiculo GetById(int id);
    /// <summary>
    /// Crea un nuevo vehiculo en el sistema
    /// </summary>
    /// <param name="vh"></param>
    /// <returns>Result con el objeto persona o el error de dominio</returns>
    Result<Vehiculo, DomainError> CreateVh(Vehiculo vh);
    
}