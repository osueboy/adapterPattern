using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdapterPattern
{
    public class JsonService : IJsonService
    {
        public string GetSucursales()
        {
            List<Sucursal> sucursales = new List<Sucursal>();
            sucursales.Add(new Sucursal() { Id = 1, Name = "Sucursal1", Total = 50000 });
            sucursales.Add(new Sucursal() { Id = 2, Name = "Sucursal2", Total = 100000 });
            sucursales.Add(new Sucursal() { Id = 3, Name = "Sucursal3", Total = 200000 });          
            string json = JsonConvert.SerializeObject(sucursales);
            return json;
        }
    }
}
