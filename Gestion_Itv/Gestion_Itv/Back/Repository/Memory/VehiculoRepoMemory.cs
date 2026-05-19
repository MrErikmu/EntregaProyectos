using CSharpFunctionalExtensions;
using Gestion_Itv.Error;
using Gestion_Itv.Models;
using Gestion_Itv.Repository;
using Serilog;

namespace Gestion_Itv.Back.Repository.Memory;

public class VehiculoRepoMemory: IVehiculoRepository
{
    public IEnumerable<Vehiculo> GetAll()
    {
    private readonly ILogger _logger = Log.ForContext<VehiculoRepoMemory>();
    private int _idCounter = 0;
    private readonly Dictionary<string, Vehiculo> _porMatricula = new();
    private readonly Dictionary<string, int> _dniId = new();
    /// <summary>
    /// Diccionario que vincula DNI a Diccionario de Vehiculos-Matricula
    /// para cumplir el requisito de solo 3 vehiculos por DNI. 
    /// </summary>
    private readonly Dictionary<string, Dictionary<string, Vehiculo>> _porDNIregristrados = new();

    public PersonasMemoryRepository() : this(AppConfig.DropData, AppConfig.SeedData) { }

    }

    public Vehiculo? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Vehiculo? Create(Vehiculo entity)
    {
        throw new NotImplementedException();
    }

    public Vehiculo? Delete(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Vehiculo> GetAll(int pagina = 1, int tamPagina = 5, bool mostrarDelete = true)
    {
        throw new NotImplementedException();
    }

    public Vehiculo GetByMatricula(string matricula)
    {
        throw new NotImplementedException();
    }

    public Result<Vehiculo, DomainError> CreateVh(Vehiculo vh)
    {
        throw new NotImplementedException();
    }

    public Vehiculo Delete(bool islogical)
    {
        throw new NotImplementedException();
    }
}