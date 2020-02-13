using System;
using System.Collections.Generic;

namespace AdapterPattern
{
    public class AdapterClient : IVentasPrinter
    {
        private IVentasService _ventasService;
        public AdapterClient(IVentasService ventasService)
        {
            _ventasService = ventasService;
        }

        public void PrintSales()
        {
            List<Sucursal> ventas = _ventasService.ObtenerSucursales();
            foreach(Sucursal sucursal in ventas)
            {
                Console.WriteLine(string.Format("{0} - {1} Total : {2}", sucursal.Id, sucursal.Name, sucursal.Total));
            }

        }
    }
}
