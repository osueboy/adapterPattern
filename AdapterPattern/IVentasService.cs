using System.Collections.Generic;

namespace AdapterPattern
{
    public interface IVentasService
    {

        List<Sucursal> ObtenerSucursales();
    }
}
