using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace AdapterPattern
{
    public class Adapter : IVentasService
    {
        IJsonService _jsonService;
        public Adapter(IJsonService jsonService)
        {
            _jsonService = jsonService;
        }
        public List<Sucursal> ObtenerSucursales()
        {
            string response = _jsonService.GetSucursales();
            JArray array = JArray.Parse(response);

            return array.ToObject<List<Sucursal>>();
        }
    }
}
