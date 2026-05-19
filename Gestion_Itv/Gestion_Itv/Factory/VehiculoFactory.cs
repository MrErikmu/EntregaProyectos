using Gestion_Itv.Models;

namespace Gestion_Itv.Factory;

public static class VehiculoFactory
{
    public static IEnumerable<Vehiculo> Seed()
    {
        var list = new List<Vehiculo>();
        list.AddRange(new List<Vehiculo>
            {
                new Vehiculo { DNI = "47382910Z", Marca = "Toyota Corolla", Matricula = "1234BBB", TipoMotor = TipoMotor.Diesel },
                new Vehiculo { DNI = "12345678Z", Marca = "Seat Ibiza", Matricula = "5678CCC", TipoMotor = TipoMotor.Gasolina },
                new Vehiculo { DNI = "87654321X", Marca = "Volkswagen Golf", Matricula = "9012DDD", TipoMotor = TipoMotor.Hibrido },
                new Vehiculo { DNI = "53829104Y", Marca = "Peugeot 3008", Matricula = "3456FFF", TipoMotor = TipoMotor.Electrico },
                new Vehiculo { DNI = "20485731S", Marca = "Renault Megane", Matricula = "7890GGG", TipoMotor = TipoMotor.Diesel },
                new Vehiculo { DNI = "90123456G", Marca = "Ford Focus", Matricula = "1122HHH", TipoMotor = TipoMotor.Diesel },
                new Vehiculo { DNI = "33445566E", Marca = "Citroën C4", Matricula = "3344JJJ", TipoMotor = TipoMotor.Gasolina },
                new Vehiculo { DNI = "71234567H", Marca = "Opel Astra", Matricula = "5566KKK", TipoMotor = TipoMotor.Diesel },
                new Vehiculo { DNI = "00112233M", Marca = "BMW Serie 3", Matricula = "7788LLL", TipoMotor = TipoMotor.Gasolina },
                new Vehiculo { DNI = "44556677V", Marca = "Audi A3", Matricula = "9900MMM", TipoMotor = TipoMotor.Diesel }
            }
        );
        return list;
    }
}