using Gestion_Itv.Models;

namespace Gestion_Itv.Factory;

public static class VehiculoFactory
{
    /// <summary>
    /// Funcion para sembrar datos de prueba de los vehiculos
    /// </summary>
    /// <returns>lista de vehiculos</returns>
    public static IEnumerable<Vehiculo> Seed()
    {
        var list = new List<Vehiculo>();
        list.AddRange(new List<Vehiculo>
            {
                new Vehiculo { DNI = "47382910Z", Marca = "Toyota ", Modelo = "Corolla",Matricula = "1234BBB", TipoMotor = TipoMotor.Diesel,FechaInspeccion = DateTime.Now.AddDays(5),FechaMatriculacion = DateTime.Today},
                new Vehiculo { DNI = "12345678Z", Marca = "Seat ", Modelo = "Ibiza",Matricula = "5678CCC", TipoMotor = TipoMotor.Gasolina,FechaInspeccion = DateTime.Now.AddDays(15),FechaMatriculacion = DateTime.Today },
                new Vehiculo { DNI = "87654321X", Marca = "Volkswagen",Modelo = "Golf", Matricula = "9012DDD", TipoMotor = TipoMotor.Hibrido,FechaInspeccion = DateTime.Now.AddDays(20),FechaMatriculacion = DateTime.Today },
                new Vehiculo { DNI = "53829104Y", Marca = "Peugeot", Modelo = "3008",Matricula = "3456FFF", TipoMotor = TipoMotor.Electrico, FechaInspeccion = DateTime.Now.AddDays(30),FechaMatriculacion = DateTime.Today },
                new Vehiculo { DNI = "20485731S", Marca = "Renault",Modelo = "Megane", Matricula = "7890GGG", TipoMotor = TipoMotor.Diesel, FechaInspeccion = DateTime.Now.AddDays(12),FechaMatriculacion = DateTime.Today },
                new Vehiculo { DNI = "90123456G", Marca = "Ford ",Modelo = "Focus", Matricula = "1122HHH", TipoMotor = TipoMotor.Diesel, FechaInspeccion = DateTime.Now.AddDays(6),FechaMatriculacion = DateTime.Today },
                new Vehiculo { DNI = "33445566E", Marca = "Citroën",Modelo = "c4", Matricula = "3344JJJ", TipoMotor = TipoMotor.Gasolina, FechaInspeccion = DateTime.Now.AddDays(7),FechaMatriculacion = DateTime.Today },
                new Vehiculo { DNI = "71234567H", Marca = "Opel",Modelo = "Astra", Matricula = "5566KKK", TipoMotor = TipoMotor.Diesel, FechaInspeccion = DateTime.Now.AddDays(9),FechaMatriculacion = DateTime.Today },
                new Vehiculo { DNI = "00112233M", Marca = "BMW ",Modelo = "Serie 3", Matricula = "7788LLL", TipoMotor = TipoMotor.Gasolina, FechaInspeccion = DateTime.Now.AddDays(11),FechaMatriculacion = DateTime.Today },
                new Vehiculo { DNI = "44556677V", Marca = "Audi",Modelo = "A3", Matricula = "9900MMM", TipoMotor = TipoMotor.Diesel, FechaInspeccion = DateTime.Now.AddDays(4),FechaMatriculacion = DateTime.Today }
            }
        );
        return list;
    }
}