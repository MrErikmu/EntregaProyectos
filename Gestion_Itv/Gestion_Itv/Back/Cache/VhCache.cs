using Gestion_Itv.Cache;
using Serilog;

namespace Gestion_Itv.Back.Cache;

/// <summary>
/// Cache sencilla de capacidad definida por constructor que elimina el elemento que menos se ha utilizado.
/// Se basa en el algoritmo LRU(least recently used), donde cada acceso mueve el elemento al final de la lista
/// El primer elemento es el menos usado ergo el mas susceptible a ser eliminado
/// </summary>
public class VhCache<TKey, TValue> : ILruCache<TKey, TValue> 
    where TKey: notnull
    {
        private readonly int _tammax;
        private readonly Dictionary<TKey, TValue> _datos = new();
        private readonly ILogger _logger = Log.ForContext<VhCache<TKey, TValue>>();
        private readonly LinkedList<TKey> _orden = new();

        public VhCache(int tammax)
        {
            if (tammax <= 0)
            {
                throw new ArgumentException("La Capacidad debe ser mayor que 0 ");
            }

            _tammax = tammax;
        }
        /// <inheritdoc cref="ILruCache{TKey,TValue}.Add" />
        public void Add(TKey key, TValue value)
        {
            _logger.Debug("Añadiendo clave: {Key}", key);

            if (_datos.TryGetValue(key, out var existingValue)) {
                _logger.Debug("[LRU-ADD] Clave {Key} ya existe. Actualizando valor: {Old} -> {New}",
                    key, existingValue, value);
                _datos[key] = value;
                Refrescar(key);
                return;
            }
            _logger.Debug("Clave {Key} es nueva. Capacidad actual: {Used}/{Total}",
                key, _datos.Count, _tammax);

            if (_datos.Count >= _tammax) {
                var oldestKey = _orden.First!.Value;
                var oldestValue = _datos[oldestKey];
                _logger.Debug("[LRU-EVICT] Cache llena. Desalojando elemento más antiguo: {Key} = {Value}",
                    oldestKey, oldestValue);
                _orden.RemoveFirst();
                _datos.Remove(oldestKey);
            }
        }
        /// <inheritdoc cref="ILruCache{TKey,TValue}.Get"/>
       
        public TValue? Get(TKey key) {
            _logger.Debug("Buscando clave: {Key}", key);

            if (!_datos.TryGetValue(key, out var value)) {
                _logger.Debug("Clave {Key} no encontrada", key);
                return default;
            }
            _logger.Debug("Clave {Key} encontrada con valor: {Value}. ",
                key, value);
            Refrescar(key);
            return value;
        }
        /// <inheritdoc cref="ILruCache{TKey,TValue}.Remove"/>
        public bool Remove(TKey key)
        {
            _logger.Debug("Eliminando clave: {Key}", key);

            if (!_datos.Remove(key)) {
                _logger.Debug(" Clave {Key} no encontrada", key);
                return false;
            }

            _orden.Remove(key);
            _logger.Debug(" Clave {Key} eliminada correctamente", key);
            return true;
        }
        /// <inheritdoc cref="ILruCache{TKey,TValue}.DisplayStatus"/>
        public void DisplayStatus()
        {
            _logger.Information("[LRU-STATUS] Capacidad: {Used}/{Total}", _datos.Count, _tammax);
            _logger.Information("[LRU-STATUS] Uso (Menos reciente -> Más reciente): {Order}",
                string.Join(" -> ", _orden));
        }

        /// <summary>
        /// Funcion para mover la clave a la ultima posicion de la lista
        /// </summary>
        /// <param name="key">Clave que hace referencia al ultimo elemento utilizado(id)</param>
        public void Refrescar(TKey key)
        {
            _logger.Verbose("[LRU-REFRESH] Moviendo clave {Key} al final de la lista", key);
            _orden.Remove(key);
            _orden.AddLast(key);
        }
    }